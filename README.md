references:
### installation
```
dotnet new mstest -n PlaywrightTests
cd PlaywrightTests
dotnet build



```
Permission to execute the powershell is required . Run the playwright.ps1 execution policy need to be set as administrator
```
    Set-ExecutionPolicy -ExecutionPolicy RemoteSigned   
    pwsh bin/Debug/net8.0/playwright.ps1 install
    
```

#### To the run test test
``` 
    dotnet test --settings:Chromium.runsettings 
```
This command will run test with specific runsettings







#### References
https://playwright.dev/dotnet/docs/intro
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test
https://learn.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest


#### RECORDING as Test
https://playwright.dev/dotnet/docs/codegen#recording-a-test




https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test