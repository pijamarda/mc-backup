# Minecraft Server Backup program (c#)

This little program allows you to backup a Minecraft server using the following command

```
./mc-backup server_folder
```

The program expect a world/ folder inside the server_folder indicated

## Prerequisites

To execute it you need the Dotnet 8.0 runtime installed  

```
sudo apt update
sudo apt-get install -y aspnetcore-runtime-8.0
```


## Command to publish the release verion that runs on the ARM64 Oracle VM

dotnet publish -r linux-arm64

I added these two lines so the executable is self-contained

```
<PublishSingleFile>true</PublishSingleFile>
<SelfContained>true</SelfContained>
```