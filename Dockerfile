# escape=`

# Build service from sources

FROM microsoft/dotnet-framework:4.7.2-sdk-windowsservercore-ltsc2016 AS builder

LABEL Maintainer="Iqan Shaikh"

COPY /src .

RUN msbuild FileWriterService.sln /p:OutputPath=C:/output /p:Configuration=Release


# Install and run service in runtime

FROM microsoft/dotnet-framework:4.7.2-runtime-windowsservercore-ltsc2016

LABEL Maintainer="Iqan Shaikh"

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

RUN MKDIR C:\Iqan\FileWriterService

WORKDIR C:\Iqan\FileWriterService

COPY --from=builder C:/output .

RUN C:/Windows/Microsoft.NET/Framework/v4.0.30319/installutil.exe FileWriterService.exe

RUN net start Iqan.FileWriter
