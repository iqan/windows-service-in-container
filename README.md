# Windows Service in Container

## Build
docker build -t iqan/file-writer-service .

## Run
docker run -v C:\Iqan:C:\Iqan\FileWriterService -d --name file-writer-service iqan/file-writer-service