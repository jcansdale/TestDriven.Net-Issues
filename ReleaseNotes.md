# Release Notes - [TestDriven.NET](http://testdriven.net): 4.0 Beta 2

## [TDI59](https://github.com/jcansdale/TestDriven.Net-Issues/issues/59): Add support for running "Ad hoc" async methods
Async methods can be targeted directly and the "Ad hoc" runner will wait for them to complete (the async method mustn't return void).

## [TDI54](https://github.com/jcansdale/TestDriven.Net-Issues/issues/54): Label text sent to console when running multiple tests
When running all tests in a project/solution, any console/trace output will be labeled with the name of the test that output it.

## [TDI17](https://github.com/jcansdale/TestDriven.Net-Issues/issues/17): Automatically pass DTE object to "Ad hoc" test methods that take DTE as a parameter
The 'Test With > In-Proc' command will pass the current `DTE` (Visual Studio) object to "Ad hoc" test methods that take `DTE` (or `DTE2`) as a parameter.

## [TDI52](https://github.com/jcansdale/TestDriven.Net-Issues/issues/52): Add support for new VSTestHost when executing 'Test With > In-Proc'
VisualStudio [TestHost](https://github.com/Microsoft/VisualStudio-TestHost) project can be used for writing Visual Studio integration tests. As a quick way to prototype a test, the 'Test With > In-Proc' command will populate initialize the `VSTestContext` class, giving easy to the current `ServiceProvider` and `DTE` objects. Click on this issue for an example.

## [TDI29](https://github.com/jcansdale/TestDriven.Net-Issues/issues/29): Run using .NET Framework (and "quirks mode") that project.json is targeting
When running tests using the 'dotnet test' based runners, run using the exact .NET Framework version and "quirks mode" they were compiled for.

## [TDI53](https://github.com/jcansdale/TestDriven.Net-Issues/issues/53): When running project.json tests, always target tests specified by `testRunner`
When targeting a 'project.json' based project, run using the "Ad hoc" runner if a non-test method is targeted (no test attribute), otherwise only consider the `testRunner` specified in 'project.json'.

## [TDI50](https://github.com/jcansdale/TestDriven.Net-Issues/issues/50): CurrentDirectory not set for dotnet-test based test runners
The current directory wasn't being set when executing using a 'dotnet test' based test runner. It is now being set to the output directory (consistent with other TestDriven.Net runners).

## [TDI44](https://github.com/jcansdale/TestDriven.Net-Issues/issues/44): Remove `Go To Code/Test` command
This command was rarely being used and taking up valuable space on the context menu.
