## Release Notes - [TestDriven.Net](http://testdriven.net) 4.0 Beta 3 ([download](http://testdriven.net/download.aspx))

### [TDI76](https://github.com/jcansdale/TestDriven.Net-Issues/issues/76): Add support for Visual Studio 2017 RC
TestDriven.Net will be installed for Visual Studio 2017 RC (Community, Professional and Enterprise in their default locations).

### [TDI77](https://github.com/jcansdale/TestDriven.Net-Issues/issues/77): Setup prompts to download .NET 3.5 on Windows 10
Installer (setup.exe) is now built using .NET 4.0 so that is can be installed on a clean installation without .NET 2.0/3.5.

### [TDI72](https://github.com/jcansdale/TestDriven.Net-Issues/issues/72): Can you put the .csproj context menu buttons back below "build" like in VS2012?
Project context menu buttons are now placed in consistent locations.

### [TDI65](https://github.com/jcansdale/TestDriven.Net-Issues/issues/65): Update for NUnit 3.5
Update installer to include latest version of NUnit.

### [TDI71](https://github.com/jcansdale/TestDriven.Net-Issues/issues/71): Test With > NUnit not working in 4.0 Beta 2
Restore option to test using the old NUnit 2.5.10 GUI from project context menu.


## Release Notes - [TestDriven.Net](http://testdriven.net) 4.0 Beta 2 ([download](http://testdriven.net/download.aspx))

### [TDI59](https://github.com/jcansdale/TestDriven.Net-Issues/issues/59): Add support for running "Ad hoc" async methods
Async methods can be targeted directly and the "Ad hoc" runner will wait for them to complete (the async method mustn't return void).

### [TDI60](https://github.com/jcansdale/TestDriven.Net-Issues/issues/60): Develop library for testing classes that call static methods
This version of TestDriven.Net was tested using [StaticMocks](https://jcansdale.github.io/StaticMocks), a helper library for mocking static methods. If you're interested, you can find it [here](https://jcansdale.github.io/StaticMocks).

### [TDI54](https://github.com/jcansdale/TestDriven.Net-Issues/issues/54): Label text sent to console when running multiple tests
When running all tests in a project/solution, any console/trace output will be labeled with the name of the test that output it.

### [TDI63](https://github.com/jcansdale/TestDriven.Net-Issues/issues/63): Testing .NET Core project might fail with: "MyTests.exe isn't a .NET assembly"
When a "runtimes" element was defined in a .NET Core project, it was attempting to execute the native EXE shim rather than the target assembly DLL.

### [TDI17](https://github.com/jcansdale/TestDriven.Net-Issues/issues/17): Automatically pass DTE object to "Ad hoc" test methods that take DTE as a parameter
The 'Test With > In-Proc' command will pass the current `DTE` (Visual Studio) object to "Ad hoc" test methods that take `DTE` (or `DTE2`) as a parameter.

### [TDI52](https://github.com/jcansdale/TestDriven.Net-Issues/issues/52): Add support for new VSTestHost when executing 'Test With > In-Proc'
VisualStudio [TestHost](https://github.com/Microsoft/VisualStudio-TestHost) project can be used for writing Visual Studio integration tests. As a quick way to prototype a test, the 'Test With > In-Proc' command will populate initialize the `VSTestContext` class, giving easy to the current `ServiceProvider` and `DTE` objects. Click on this issue for an example.

### [TDI29](https://github.com/jcansdale/TestDriven.Net-Issues/issues/29): Run using .NET Framework (and "quirks mode") that project.json is targeting
When running tests using the 'dotnet test' based runners, run using the exact .NET Framework version and "quirks mode" they were compiled for.

### [TDI50](https://github.com/jcansdale/TestDriven.Net-Issues/issues/50): CurrentDirectory not set for dotnet-test based test runners
The current directory wasn't being set when executing using a 'dotnet test' based test runner. It is now being set to the output directory (consistent with other TestDriven.Net runners).

### [TDI53](https://github.com/jcansdale/TestDriven.Net-Issues/issues/53): When running project.json tests, always target tests specified by `testRunner`
When targeting a 'project.json' based project, run using the "Ad hoc" runner if a non-test method is targeted (no test attribute), otherwise only consider the `testRunner` specified in 'project.json'.

### [TDI44](https://github.com/jcansdale/TestDriven.Net-Issues/issues/44): Remove `Go To Code/Test` command
This command was rarely being used and taking up valuable space on the context menu.
