## Command to publish the release verion that runs on the ARM64 Oracle VM

dotnet publish -r linux-arm64

I added these two lines so the executable is self-contained

```
<PublishSingleFile>true</PublishSingleFile>
<SelfContained>true</SelfContained>
```