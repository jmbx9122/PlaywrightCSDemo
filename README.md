
#### Project initial Setup

- Open Visual Studio Code
- Install VSCode Extension like
	- C# Dev Kit
	- C# 
	- Playwright Test for VSCode
		Note: This extension will work great if you are woking with Node based instead of C#. but still it will be really helpful in quick execution with some limitation
- Open Folder Path 'PlaywrightCSDemo'
- Open Visual Code Terminal by `ctl+`' or Menu `View --> Terminal`
- Run following commands in the Terminal
```
  dotnet new mstest-playwright
  dotnet build
  pwsh .\bin\Debug\net8.0\playwright.ps1 install
```

- From Left Panel Select `Test` or `"View --> Testing"` . For first time you may not see any test . need to keep patient here :). run Following code
  
```
dotnet test
```

- All available test will start visible in `Test Explorer` panel in left of Visual Studio code.
- Now use this for running all, or selective test.

#### Running Test from Terminal
MSTest provide various options to be specified while running the test. This command provide options to run the test

- Running test without any option: This will run all test in the project
```
dotnet test
```

Create folder `runtimesettings`
Create `chromium.runsettings` inside `runtimesetting`
```
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
  <Playwright>
    <BrowserName>chromium</BrowserName>
    <LaunchOptions>
      <Headless>false</Headless>
    </LaunchOptions>
  </Playwright>
</RunSettings>
```


- Running test `chromium.runsettings` with following command
```
    dotnet test --settings: .\runtimesetting\Chromium.runsettings
```



Conclusion Task 1: So till now we have done basic setup for the using `MSTest-playwright` and verified that it is running without any issue


### Trouble Shooting 
Permission to execute the PowerShell is required . Run the playwright.ps1 execution policy need to be set as administrator

```
    Set-ExecutionPolicy -ExecutionPolicy RemoteSigned  
    pwsh bin/Debug/net8.0/playwright.ps1 install
```

  

#### To the run test test

This command will run test with specific runsettings

  

#### Example CI Pipeline Configuration

```

trigger:
  - main
  
pool:
  vmImage: 'ubuntu-latest'

steps:
- task: UseDotNet@2
  inputs:
    packageType: 'sdk'
    version: '5.x'

- script: |
    dotnet restore
    dotnet test --configuration Release

```

#### References

https://playwright.dev/dotnet/docs/intro

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test

https://learn.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest

  
  

#### RECORDING as Test

https://playwright.dev/dotnet/docs/codegen#recording-a-test

  
  
  
  

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test