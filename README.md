# Windows Service in Container

## Build
docker build -t iqan/file-writer-service .

## Run
docker run -d --name file-writer-service iqan/file-writer-windows-service

- check log file content (which will be populated every 10 seconds) `docker exec -d file-writer-service powershell cat C:\Iqan\FileWriterService`