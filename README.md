# TestDriven.Net

Download the latest [release](https://testdriven.net) or report an [issue](https://github.com/jcansdale/TestDriven.Net-Issues/issues).

[![Tweet Jamie Cansdale](https://img.shields.io/twitter/follow/jcansdale.svg?style=social "Follow Jamie Cansdale")](https://twitter.com/jcansdale)

## 4.3 Beta

### Enhancements
- [#109](https://github.com/jcansdale/TestDriven.Net-Issues/issues/98) Create a pure VSIX version of TestDriven.Net
This can be found on the Vsix Gallery [here](http://vsixgallery.com/extension/bca1b950-36b0-45ae-a30a-2c12aeec3b2a/)
- [#98](https://github.com/jcansdale/TestDriven.Net-Issues/issues/98) Allow .NET Standard ad-hoc methods to be executed using .NET Framework
- [#115](https://github.com/jcansdale/TestDriven.Net-Issues/issues/115) Honor default parameters when executing ad-hoc test methods
- [#107](https://github.com/jcansdale/TestDriven.Net-Issues/issues/107) Update to initialize TestDriven.Net asynchronously
- [#120](https://github.com/jcansdale/TestDriven.Net-Issues/issues/120) Add IgnorePortablePDBsInStackTraces in .config files
- [#108](https://github.com/jcansdale/TestDriven.Net-Issues/issues/108) Find a way to execute VS 2015 MSTest projects in VS 2017

### Fixes
- [#122](https://github.com/jcansdale/TestDriven.Net-Issues/issues/122) Can't run tests in SDK style F# projects
- [#121](https://github.com/jcansdale/TestDriven.Net-Issues/issues/121) Full paths appear in SDK style project stack traces (not short project relative paths)
- [#113](https://github.com/jcansdale/TestDriven.Net-Issues/issues/113) Windows Defender started flagging installer
- [#110](https://github.com/jcansdale/TestDriven.Net-Issues/issues/110) [STAThread] async Task hangs when executed with Test With > In-Proc (VS SDK)


## 4.2 Beta
           
- [TDI105](https://github.com/jcansdale/TestDriven.Net-Issues/issues/105): Add support for Visual Studio 2017 Preview Editions
Preview versions can be installed side by side with regular versions. Default install location is assumed.


## 4.1 RTM
            
- [TDI104](https://github.com/jcansdale/TestDriven.Net-Issues/issues/104): TestDriven.Net doesn't appear in Visual Studio 2017 / 15.3
devenv /updateconfiguration no longer updates Visual Studio's state on first launch. This exposed an issue with TestDriven.Net's installer.
	      

## 4.1 Alpha
    
- [TDI90](https://github.com/jcansdale/TestDriven.Net-Issues/issues/90): Add 'Test With &gt; In Proc (VS SDK)' for spelunking Visual Studio services and MEF exports
Target methods can define any number of service interfaces and MEF [Import/ImportMany] parameters. More information [here](https://github.com/jcansdale/TestDriven.Net-Issues/issues/90).
	      

## 4.0 RTM

- [TDI88](https://github.com/jcansdale/TestDriven.Net-Issues/issues/88): Please re-introduce "Navigate to test or code"
Add a keyboard shortcut to the 'TestDriven.NET.GoToTestOrCode' command to execute the 'Go To Code/Test' functionality (it's no longer on the code context menu).
    
- [TDI92](https://github.com/jcansdale/TestDriven.Net-Issues/issues/92): Remove support for legacy project.json/.NET Core projects
.NET Core isn't currently supported. I'll revisit this when .NET Core 2.0 is released.
  

## 4.0 Beta 3

- [TDI76](https://github.com/jcansdale/TestDriven.Net-Issues/issues/76): Add support for Visual Studio 2017 RC
TestDriven.Net will be installed for Visual Studio 2017 RC (Community, Professional and Enterprise in their default locations).

- [TDI77](https://github.com/jcansdale/TestDriven.Net-Issues/issues/77): Setup prompts to download .NET 3.5 on Windows 10
Installer (setup.exe) is now built using .NET 4.0 so that is can be installed on a clean installation without .NET 2.0/3.5. Also made NCoverExplorer default to using .NET 4.0.

- [TDI80](https://github.com/jcansdale/TestDriven.Net-Issues/issues/80): TestDriven.Net doesn't work on a 32-bit OS in Visual Studio 2015+
Fixed issue where TestDriven.Net couldn't find its home directory when running on a 32-bit version of Windows.

- [TDI83](https://github.com/jcansdale/TestDriven.Net-Issues/issues/83): Test With > NCover doesn't work when .NET 2.0/3.5 isn't installed
Allow NCover/NCoverExplorer to run when just .NET 4.x is installed.

- [TDI72](https://github.com/jcansdale/TestDriven.Net-Issues/issues/72): Can you put the .csproj context menu buttons back below "build" like in VS2012?
Project context menu buttons are now placed in consistent locations.

- [TDI65](https://github.com/jcansdale/TestDriven.Net-Issues/issues/65): Update for NUnit 3.5
Update installer to include latest version of NUnit.

- [TDI71](https://github.com/jcansdale/TestDriven.Net-Issues/issues/71): Test With > NUnit not working in 4.0 Beta 2
Restore option to test using the old NUnit 2.5.10 GUI from project context menu.


## 4.0 Beta 2

- [TDI59](https://github.com/jcansdale/TestDriven.Net-Issues/issues/59): Add support for running "Ad hoc" async methods
Async methods can be targeted directly and the "Ad hoc" runner will wait for them to complete (the async method mustn't return void).

- [TDI60](https://github.com/jcansdale/TestDriven.Net-Issues/issues/60): Develop library for testing classes that call static methods
This version of TestDriven.Net was tested using [StaticMocks](https://jcansdale.github.io/StaticMocks), a helper library for mocking static methods. If you're interested, you can find it [here](https://jcansdale.github.io/StaticMocks).

- [TDI54](https://github.com/jcansdale/TestDriven.Net-Issues/issues/54): Label text sent to console when running multiple tests
When running all tests in a project/solution, any console/trace output will be labeled with the name of the test that output it.

- [TDI63](https://github.com/jcansdale/TestDriven.Net-Issues/issues/63): Testing .NET Core project might fail with: "MyTests.exe isn't a .NET assembly"
When a "runtimes" element was defined in a .NET Core project, it was attempting to execute the native EXE shim rather than the target assembly DLL.

- [TDI17](https://github.com/jcansdale/TestDriven.Net-Issues/issues/17): Automatically pass DTE object to "Ad hoc" test methods that take DTE as a parameter
The 'Test With > In-Proc' command will pass the current `DTE` (Visual Studio) object to "Ad hoc" test methods that take `DTE` (or `DTE2`) as a parameter.

- [TDI52](https://github.com/jcansdale/TestDriven.Net-Issues/issues/52): Add support for new VSTestHost when executing 'Test With > In-Proc'
VisualStudio [TestHost](https://github.com/Microsoft/VisualStudio-TestHost) project can be used for writing Visual Studio integration tests. As a quick way to prototype a test, the 'Test With > In-Proc' command will populate initialize the `VSTestContext` class, giving easy to the current `ServiceProvider` and `DTE` objects. Click on this issue for an example.

- [TDI29](https://github.com/jcansdale/TestDriven.Net-Issues/issues/29): Run using .NET Framework (and "quirks mode") that project.json is targeting
When running tests using the 'dotnet test' based runners, run using the exact .NET Framework version and "quirks mode" they were compiled for.

- [TDI50](https://github.com/jcansdale/TestDriven.Net-Issues/issues/50): CurrentDirectory not set for dotnet-test based test runners
The current directory wasn't being set when executing using a 'dotnet test' based test runner. It is now being set to the output directory (consistent with other TestDriven.Net runners).

- [TDI53](https://github.com/jcansdale/TestDriven.Net-Issues/issues/53): When running project.json tests, always target tests specified by `testRunner`
When targeting a 'project.json' based project, run using the "Ad hoc" runner if a non-test method is targeted (no test attribute), otherwise only consider the `testRunner` specified in 'project.json'.

- [TDI44](https://github.com/jcansdale/TestDriven.Net-Issues/issues/44): Remove `Go To Code/Test` command
This command was rarely being used and taking up valuable space on the context menu.


## 4.0 Beta

- TDI#[21](https://github.com/jcansdale/TestDriven.Net-Issues/issues/21): Add 'Test With > .NET' and 'Test With > .NET Core' commands

- TDI#[40](https://github.com/jcansdale/TestDriven.Net-Issues/issues/40): Add support for .NET Framework / .xproj based projects that use `ITestRunner` interface

- TDI#[36](https://github.com/jcansdale/TestDriven.Net-Issues/issues/36): Add support for App.config when running .xproj / .NET Framework tests

- TDI#[14](https://github.com/jcansdale/TestDriven.Net-Issues/issues/14): Add support for running "Ad hoc" test methods in .NET Core Class Library projects

- TDI#[27](https://github.com/jcansdale/TestDriven.Net-Issues/issues/27): Add support for targeting .NET Framework .xproj 'Library' projects

- TDI#[23](https://github.com/jcansdale/TestDriven.Net-Issues/issues/23): TestDriven.Net tries to run tests in .NET Core projects that don't contain tests

- TDI#[18](https://github.com/jcansdale/TestDriven.Net-Issues/issues/18): .NET Core test runner should honor the NUGET_PACKAGES environment variable

- TDI#[7](https://github.com/jcansdale/TestDriven.Net-Issues/issues/7): Can't resolve some assemblies when targeting .NET Core 'Class Library' projects

- TDI#[33](https://github.com/jcansdale/TestDriven.Net-Issues/issues/33): Skip .xproj / project.json style projects that don't contain any tests

- TDI#[34](https://github.com/jcansdale/TestDriven.Net-Issues/issues/34): Can't find .xproj assembly when project name is different to folder name

- TDI#[37](https://github.com/jcansdale/TestDriven.Net-Issues/issues/37): Look for DLLs in RID directory, not just EXEs


## 4.0 Alpha

### TDI#[3](https://github.com/jcansdale/TestDriven.Net-Issues/issues/3): Add support for .NET Core testing

.NET Core assemblies can now be targeted using Visual Studio 2015 Update 3 with .NET Core 1.0

### TD#7: Add support for Visual Studio "15" preview (full and lightweight installs)

If you add or remove features using the lightweight installer, you will need to reinstall TestDriven.Net 4.

### TDI#[14](https://github.com/jcansdale/TestDriven.Net-Issues/issues/14): Add support for running "Ad hoc" test methods in .NET Core Console and Class Library projects

Any .NET Core method or property can be executed using the 'Run Test(s)' command. Any returned value or object will be expanded on the output window.

### TDI#[10](https://github.com/jcansdale/TestDriven.Net-Issues/issues/10): Add support for .NET Core debugging

.NET Core projects can be debugged using the Test With > Debugger' command.

### TDI#[6](https://github.com/jcansdale/TestDriven.Net-Issues/issues/6): Add support for running NUnit tests using .NET Core

Install the 'dotnet-test-nunit' and 'NUnit' packages from NuGet to run NUnit .NET core tests.

### TDI#[5](https://github.com/jcansdale/TestDriven.Net-Issues/issues/5): Add support for running xUnit tests using .NET Core

Install the 'dotnet-test-xunit' and 'xUnit' packages from NuGet to run xUnit .NET core tests.

### TDI#[8](https://github.com/jcansdale/TestDriven.Net-Issues/issues/8): Allow .NET Core test runner projects to test themselves

The tests for .NET Core [xUnit](https://github.com/xunit/dotnet-test-xunit) and [NUnit](https://github.com/nunit/dotnet-test-nunit) test runner projects can now be executed using TestDriven.Net (the test runner is used to run tests on itself).

### TDI#[11](https://github.com/jcansdale/TestDriven.Net-Issues/issues/11): Can't target tests in .NET Core nested types

The tests in nested types will now be executed when an outer type is targeted (xUnit and NUnit).

### TDI#[5](https://github.com/jcansdale/TestDriven.Net-Issues/issues/5): Clean up output when an xUnit test fails

Cleaned up the reporting of failed tests and changed to use relative paths in stack frames.

### Please add a feature request [here](https://github.com/jcansdale/TestDriven.Net-Issues/issues) if there is another test runner you would like to see supported.


## 3.10 RTM

### TDI#[28](https://github.com/jcansdale/TestDriven.Net-Issues/issues/28): Can't evaluate "Ad hoc" properties in NUnit test projects

Attempting to target a property in NUnit test projects would result in an exception rathere than property being evaluated.

### TDI#[22](https://github.com/jcansdale/TestDriven.Net-Issues/issues/22): 'Test With > Performance' not working on Visual Studio 2013 Premium

Symbols appeared not to be found when attempting to profile a test in Visual Studio 2013 Premium.

### NTA#[12](https://github.com/nunit/nunit3-tdnet-adapter/issues/12): Add support for running nested classes when a parent class is targeted (NUnit 3.x)

Some people like to use nested classes to arrange their tests.

### NTA#[5](https://github.com/nunit/nunit3-tdnet-adapter/issues/5): Add support for executing tests in concrete sub-classes when abstract class is targeted (NUnit 3.x)

Targeting abstract test fixtures in now supported.

### NTA#[6](https://github.com/nunit/nunit3-tdnet-adapter/issues/6): Add support for targeting generic test fixtures (NUnit 3.x)

Generix fixtures and their contained methods can now be targeted.

### NTA#[1](https://github.com/nunit/nunit3-tdnet-adapter/issues/1): Fixed - Inconclusive tests were being reported as Failed (NUnit 3.x)

For example, Assume.That(false) was being counted as a failed test rather than inconclusive/ignored.

### NTA#[2](https://github.com/nunit/nunit3-tdnet-adapter/issues/2): Update to use NUnit v3.4.1

TestDriven.Net shoud still work with all NUnit 3.x tests, but packaged version is now NUnit v3.4.1.

### NTA#[0](https://github.com/nunit/nunit3-tdnet-adapter): Move NUnit 3.x adapter for TestDriven.Net to NUnit ogarnization on GitHub

Please report any issues with the NUnit 3.x support in TestDriven.Net [here](https://github.com/nunit/nunit3-tdnet-adapter).

### TDI#[13](https://github.com/jcansdale/TestDriven.Net-Issues/issues/13): Can't execute all tests in project if properties window is open

There is a bug in Visual Studio 2015 that causes an exception to be thrown when a properties window is open and the active document is queried. I've added a workaround for this.


## 3.10 Beta 2

### NTA#[18](https://github.com/jcansdale/nunit3-tdnet-adapter/issues/18): Remove extra new line after assert fail message when running NUnit 3.x tests

When an assert fail message contains multiple lines, NUnit 3 ends it with a trailing new line. The extra new line clutters up test results, especially if there are multiple failing tests.


## 3.10 Beta

### TD#11: Add native support for all NUnit 3.x versions

Previously you needed to reference the 'NUnitTDNet' package on NuGet to run NUnit 3.x tests. You can now execute any NUnit 3.x tests without special references or setup. This installer includes NUnit 3.4.0, but can execute any NUnit 3.x tests.

### TD#1: Reinstate support for legacy NUnit 2.2 version

Useful when converting old .NET 1.x projects that reference this early NUnit framework version.

### TD#4: Uninstall fails when launched from 'Add or remove programs'

Uninstall worked properly when using'setup.exe' or from the command line. Simply run 'setup.exe' when upgrading to new version.


## 3.9 RTM

### 9547: Add support for options pane in VS 2015

General options are now available in VS 2015 under ‘Tools > Options… > TestDriven.Net’.

### 9546: Suggest using 'NUnitTDNet' NuGet package when tests reference NUnit 3.0

Give suggestions when referencing a version of 'nunit.framework' that isn’t included with installer.

### 9545: Remove NUnit 3.0 beta 2 from installer

Ready to release TestDriven.NET 3.9 RTM, but can't release it with Beta version of NUnit.


## 3.9 Beta 3

### 9543: Add support for NUnit 3.0 beta 2/3

Tests that reference ‘nunit.framework’ 3.0 beta 2/3 can be executed with this version. Future versions of NUnit 3.0 might be compatible with this release (depending on interface changes).

### 9544: Add support for ‘Test With > Performance’ in Visual Studio Enterprise 2015

This is an easy way to do performance profiling if you’re using an Enterprise version of Visual Studio.


## 3.9 Beta 2

### 9539: Applications can run slightly differently when compiled to target .NET 4.0 compared to .NET 4.5 and later

Add support for running with quirks when tests are compiled to target .NET 4.5 and later.

### 9540: Unknown .NET Framework Version: v4.6

Removed warning message when targeting .NET v4.5.2 and later.

### 9541: Ignored tests not visible on ‘Task List’ when using VS 2015

Display ignored tests on ‘Error List / Messages’ when using VS 2015.

### 9542: Can’t jump to ignored tests that take parameters

Allow double clicking on ‘Task List’ / ‘Error List’ for tests that take parameters.


## 3.9 Beta

### 9538: Test run sometimes aborts when project properties are on tab list (VS 2015 RC)

Added workaround for bug in VS 2015 RC when project properties haven’t been activated yet.

### 9536: Can’t target F# tests that take parameters

Added support for F# tests that take parameters (test must have unique name).

### 9537: F# projects don’t always build before test on VS 2015 RC

Added workaround for issue in VS 2015 RC. This should be fixed in VS 2015 RTM.


## 3.8 RTM

### 9535: Clean up security warnings during installation

TestDriven.Net’s setup and installer files are now signed with Mutant Design’s code signing key.


## 3.8 Beta 2

### 9533: Add support for ‘Test With > Coverage’ in Visual Studio 2015

Coverage wasn’t working in Visual Studio 2015.

### 9532: Warnings not visible when ‘Task List’ is activated

When ‘Lask List’ is automatically activated, the ‘Add-ins’ category will now be selected. If user navigates to ‘Lask List’, this category may need to be manually selected.

### 9534: Add support for NUnit 2.6.4

This version of NUnit will warn rather than attempt to execute tests built with future NUnit 3.x versions.


## 3.8 Beta

### 9528: Add support for Visual Studio 14 CTP

Convert TestDriven.Net from integrating with Visual Studio as an add-in to integrating as a package.

### 9531: Add support for VS 14 version of MSTest

Install test runner adapter that is compatible with the VS 14 version of MSTest.

### 9529: Ignored tests keep being added to ‘Task List’ on each test run

Fixed bug where ignored tests weren’t being deleted from ‘Task List’ before test run in Visual Studio 2012+.

### 9530: A resource leak has been shown to occur when adding test warnings to ‘Task List’

Reduce this by limiting the number of warnings that can be added to ‘Task List’ in a single test run.


## 3.7 Beta

### 9524: Non-admin user can’t test with coverage when solution contains any signed assemblies

Allow non-admin users to test with coverage on any unsigned assemblies in solution.

### 9525: Unknown .NET Framework Version: v4.5.1

Fixed warning when executing tests compiled with .NET v4.5.1.

### 9526: Build sometimes shows output window ‘Test’ instead of ‘Build’

This would happen the first time a solution was built before running any tests.

### 9527: TestDriven.Net version number not shown on ‘Add-in Manager’ or Visual Studio ‘About’ window

This was an issue in Visual Studio 2012 and 2013.


## 3.6 RTM

### 9521: Not all projects built before test when keyboard used to start test execution on VS2012/VS2013

Caused by a strange Solution Explorer / keyboard interaction. Added a workaround for this issue.

### 9522: When build before test fails, build status message is being cleared

Fixed.

### 9523: When build before test fails, remain on output window.

This allows enter key to be pressed to jump to source that caused build to fail.

### 9524: TestDriven.Net not working on Windows XP

Fixed.


## 3.5 RTM

### 9520: Options dialog shows "the control to display here could not be loaded"

Fixed options dialog issue when TestDriven.Net is installed for all users


## 3.5.2830 RTM

### No new features

No bugs reported. Ready to RTM!


## 3.5 RC 2

### 9519 - TestDriven.Net doesn’t show up when installed for all users on VS 2012 and 2013

Add-in now installed for all users, not just current user.

### 9520 - Visual Studio crashes when testing solution that contains WiX setup project

WiX project extension causes Visual Studio to quit when interacting with the WiX project model. Added workaround to avoid this.


## 3.5 RC

### 9517: Add support for Visual Studio 2013 version of MSTest

Added support for Visual Studio's built in unit test runner.

### Add support for Visual Studio 2013 version of code coverage / performance profiling

'Test With > Code Coverage' and 'Test With > Performance' can be used on Visual Studio 2013 Premium and Ultimate.


## 3.5 Beta 3

### 9516: Add support for Visual Studio 2013

Added preliminary support for VS 2013\. Needs lots of testing.

### 9515: Exclude compiler generated code from NCover coverage reports

Exclude any methods tagged with 'System.Runtime.CompilerServices.CompilerGeneratedAttribute' from coverage.


## 3.5 Beta 2

### 9513: Add support for NUnit 2.6.2

This version now includes the NUnit 2.6.2 test runner.

### 9514: Add support for Danish language

Stack traces in Danish language are now double clickable.


## 3.5 Beta 1

### 9512: ‘Test With > Performance’ not working on 2012

Fixed .NET profiler environment variables when using VS2012.

### 9511: Add support for ‘Should’ naming convention with ‘Go To Test/Code’

Jumping between 'Target.cs' and 'TargetShould.cs' test file naming convention now supported.

### 9510: Tests won’t run in MSTest when directory contains a ‘#’

Fixed issue when solution directory conatained a '#'.


## 3.4 RTM

### 9508: Add support for running all tests in current solution

There’s a new command called ‘TestDriven.NET.RunAllTestsInSolution’. Bind this to a keyboard shortcut to execute all tests in the current solution.

### 9509: Add support for MSTest when only Visual Studio 2012 is installed

There was an issue running tests in VS 2012 when VS 2012 wasn't also installed.


## 3.4 Beta 3

### 9506: Add support for NUnit 2.6.1

This version now includes the latest stable NUnit release.

### 9504: Add support for Reflector 6.8

Reflector 6.8 is the last free version of Reflector that all older versions will be upgraded to. Register the location of your ‘Reflector.exe’ using ‘Tools > Options... > TestDriven.Net > Reflector’.

### 9507: 'Test With > Coverage' doesn't work if only VS 2012 is installed

The location of the .NET tools changed in the latest WinSDK. Coverage will now work in VS 2012.

### 9505: Fix issue with German stack traces

This fixes an issue where stack traces aren’t double clickable when Visual Studio is internationalized into English but the test process is German.


## 3.4 Beta 2

### 9501: Add support for VS 2012 RTM

When installing for VS 2012, TestDriven.Net will only be installed for the current user. The HKLM add-in key no longer appears to work in the VS 2012 RTM release.


## 3.4 Beta

### 9501: Add support for VS 2012 RC

This version has been tested with Visual Studio 2012 RC

### 9500: Can’t run MSTests when VS 11 Beta is installed.

In VS 11 Beta the directory that contains MSTest public assemblies was changed. This stopped MSTest support from working in VS 2010 as well as VS 11 Beta. This has now been fixed.

### 9502: 'Test With > Silverlight' has been deprecated in this version.

If you still use this feature, you can re-enable it by editing the 'TestDriven.dll.config' file (see comments)


## 3.3 Beta 2

### 9496: Add support for NUnit 2.6 Final Release (2.6.0.12051)

NUnit 2.6 Final Release is now included in the TestDriven.Net installer.

### 9498: NUnit 2.6 GUI crashes when opening 32-bit test project

The NUnit GUI would crash when opening AnyCPU or x86 projects. This is now working.


## 3.3 Beta

### 9042: Add support for NUnit 2.6 RC

Xcopy deployable version of NUnit 2.6 RC can be found in the '\Program Files (x86)\TestDriven.NET 3\NUnit\2.6' directory.


## 3.2 Beta 2

### 7423: Add support for MSTest in VS 11 Developer Preview

The previous 3.2 Beta was defaulting to the simple MSTest support that was developed for VS 2005\. Most MSTest attributes (deployment items etc) should now be working in this version.

### 7424: Remove legacy support for MSTest in Visual Studio 2005

Removed the simple MSTest support that was originally developed for VS 2005, but was also set as the default for when a appropriate MSTest runner couldn't be found. Defaulting to this early MSTest runner would cause many MSTest attributes to be ignored and was potentially confusing.


## 3.2 Beta

### 7302: Add support for Visual Studio 11 Developer Preview

You can find the VS 11 preview version here: [http://msdn.microsoft.com/en-us/vstudio/hh127353](http://msdn.microsoft.com/en-us/vstudio/hh127353)


## 3.1 Beta

### 6978: Code coverage doesn't work when solution contains native code

'Test With > Coverage' wasn't working when target project contained native code DLLs with PDB information.

### 6979: Can't double click on stack trace when Visual Studio is localized to a different language than Windows

This is now fixed for French versions of Windows, but will need to be fixed for each individual language (if Visual Studio isn't localized for the same language). Please contact me if you're being bitten by this issue.

### 5806: Add support for Reflector 7

Reflector 7 can be registered using 'Options > TestDriven.Net > Reflector'. Once registered the 'Go To Reflector' buttons will be visible.

### 5807: Add support for NUnit 2.5.10

Xcopy deployable version of NUnit 2.5.10 test runner is now included in the 'Program Files\TestDriven.Net 3\NUnit' directory.

### 5808: Error loading settings file

No need to load 'NUnitsettings.xml' file when executed using TestDriven.Net.


## 3.0 RTM

### 3278: Add option to activate 'Output' window on test failure/output/warning

By default the 'Output' window will be activated when there's significant text output to see. This can be disabled via 'Options > TestDriven.Net > General'.

### 3276: 'View.NextError' doesn't work until 'Error List' window is activated

Ensure that 'Error List' and 'Task List' windows are ready before starting test run.

### 3280: Fixed bug that might have caused default for AnyCPU tests to change to 64-bit

When upgrading from a pre-2.23 version, the default for AnyCPU tests might have changed to 64-bit. This has been reset back to 32-bit in this version (see 'Options > TestDriven.Net > General').

### 3279: Ensure the summary status message remains visible at end of test run

The summary status message was being lost when focus was away from Visual Studio.


## 3.0 RC 6

### 3267: Add 'Go To Test/Code' command to code context menu

This command has been added to the code context menu to make it more discoverable (think of it as 'Ctrl-Tab' for test driven developers). You can assign a keyboard shortcut to 'TestDriven.NET.GoToTestOrCode'.

### 3265: Rename the 'TestDriven.NET.GoToTest' command to 'TestDriven.NET.GoToTestOrCode'

This name makes it clearer that the command can be used to navigate back and forth between your tests and code under test.

### 3269: If multiple source files are found using 'Go To Test/Code', try to match based on containing folder

This will resolve the case when there are similarly named types in multiple namespaces (assuming the test/code under test folder structure matches).

### 3274: Visual Studio sometimes hangs with 'Stop Debugging in Progress...' when using 'Test With > Debugger' (VS 2010)

This is caused by a bug in Visual Studio 2010\. I've added a workaround that seems to resolve the issue.

### 3271: Add support for 'System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute' when testing with code coverage (.NET 4.0)

This .NET 4.0 attribute can be used with both NCover and Microsoft's code coverage support.

### 3270: 'Test With > Coverage' doesn't work when 'Run in 64-bit process' option is active

When testing with code coverage / performance profiling, tests compiled for AnyCPU will be executed in a 32-bit process.

### 3275: 'Test With > NCover' could crash when testing a very large number of assemblies

If the list of assemblies with PDB information exceeds a certain limit, all assemblies will be covered (whether or not they have a PDB file).

### 3264: 'Go To Source Code' sometimes can't navigate to types (.NET Reflector)

Fixed issue where 'Go To Source Code' would sometimes fail when target source was referenced from another project.

### 3266: Add 'TestDriven.NET.GoToCref' command

This command is used by 'Go To Source Code' from inside .NET Reflector. It takes a single cref string as a parameter.


## 3.0 RC 5

### 3263: Simplify 'TestDriven.NET.GoToTests' command so that it flips between test and test target source

This command can be used to flip between your tests and the code your tests are targeting (e.g. between 'Target.cs' and 'TargetTests.cs'). Your tests filename must end with 'Tests', 'UnitTests', 'Fixture' or 'TestFixture'. The command 'TestDriven.NET.GoToTests' can be called via a keyboard shortcut.

### 3246: Only show source files that actually exist on stack trace

This stops Visual Studio trying to navigate to source that doesn't exist when using test frameworks that distribute their PDB files.

### 3254: 'Test With > NUnit' should use xcopy deployable NUnit GUI when available

The NUnit GUI can be xcopy deployed along with your solution (use the files in '\Program Files (x86)\TestDriven.NET 3\NUnit\2.5'). The 'Test With > NUnit' command (on the project context menu) will now launch the xcopy deployed NUnit GUI application.

### 3261: Ask user which version of .NET Reflector to use / where to install it

The 'Go To Reflector' command will no longer use a private copy of Reflector that TestDriven.Net downloads. This should prevent a confusing situation when updating to a new version of Reflector. TestDriven.Net will default to using the same version of Reflector as Red Gate's .NET Reflector add-in.

### 3262: Add 'Options > TestDriven.Net > Reflector' page for registering .NET Reflector

This options page can be used if you need to change the location .NET Reflector is installed at.

### 3253: Allow 'Error List' to activate when running tests and build fails

The 'Error List' was failing to activate properly when running tests using the 'Solution Explorer' or 'Repeat Test Run'.

### 3257: ConfigurationException error when running 'setup.exe'

Found a workaround for an issue that could be triggered by a corrupted 'machine.config' file.


## 3.0 RC 4

### 3240: Leave cursor on last failed test

If the 'Output' window is set to auto-hide, simply hit 'Enter' to jump to the last failed test. Otherwise hit 'Ctrl + Alt + O' to activate the 'Output' window and then 'Enter'.

### 3241: Automatically show 'Output' window if there is test output or failed tests

The 'Output' window will automatically appear when there is something significant to see. It won't appear for general test runner info messages.

### 3234: Include xcopy deployable version of NUnit 2.5.5 test runner

The files at '\Program Files (x86)\TestDriven.NET 3\NUnit\2.5' can (optionally) be stored with your solution. This will ensure that your tests are always executed using a known version of NUnit. For more information see: [http://bit.ly/bPlwRm](http://bit.ly/bPlwRm) and [http://bit.ly/rjeXn](http://bit.ly/rjeXn).

### 3244: Show hints when NCover can't be run with Typemock Isolator

Warn when Typemock Isolator 6.0.3 or admin privs is required to run with NCover. This is the case when running with NCover and Isolator on .NET 4.0.

### 3245: Don't automatically disable JustMock when Typemock Isolator is installed

Fixed issue where JustMock (and other profilers) were being disabled when Typemock Isolator was installed.

### 3250: Don't automatically use installed version of NUnit 2.5.x

Automatically using the installed version of NUnit turned out to be too brittle. This has been deprecated in favour of xcopy deployable test runners. If you need to execute your tests using a specific version of NUnit (which may include custom extensions), you can find instructions here: [http://bit.ly/bPlwRm](http://bit.ly/bPlwRm)

### 3249: Don't include .NET 1.1 version of NUnit 2.5 in package

Since TestDriven.Net 3.0 is focused on .NET 2.0 & 4.0 development, including the .NET 1.1 version of NUnit 2.5 was redundant.


## 3.0 RC 3

### 3238: Automatically show 'Output' window if there is output/errors at end of test run

The 'Output' window will be activated if it's hidden and there is new output/error information to see.

### 3239: Add double-clickable 'Error List' entries for failed tests don't have stack trace information (VS 2010)

Test failures that are due to an attribute (such as 'ExpectedException') don't contain any stack trace information. These failed tests can now be navigated to via the 'Error List' (only on VS 2010).


## 3.0 RC 2

### 3163: Run tests with .NET version they were compiled for

The test project's 'Target Framework' property will be used to decide which .NET version to execute with.

### 3227: Automatically show 'Task List' if there are only skipped tests

The 'Task List' tool window will appear if all targeted tests have been skipped.

### 3226: Tests with ExpectedException are skipped on VS 2008 (MSTest)

Fixed bug in ExpectedException support that would cause tests declared this attribute to be skipped.


## 3.0 RC

### 3218: Add support for performance profiling in Visual Studio 2005-2010 Team/Premium SKUs

Use 'Test With > Performance' to perform instrumented performance profiling on target code.

### 3213: Show ignored or otherwise excluded tests on the 'Task List' window

Any skipped tests will be displayed on the 'Task List' as double-clickable items.

### 3217: Add support for NCover in Visual Studio 2010

All versions of NCover can now be used with Visual Studio 2010 / .NET 4.0.

### 3223: Add support for MSTest's DeploymentItem attribute

Solution relative and project output relative deployment items are now supported. Files will be deployed in the test project's output directory when required.

### 3210: Add support for targeting abstract types and methods in VS 2010 version of MSTest

Targeting an abstract base class will execute concrete test classes. Targeting a test method on the base class will execute this method for all concrete classes.

### 3219: Don't require admin privs when doing coverage/profiling of unsigned assemblies

Visual Studio no longer needs to be run as administrator when performing coverage/profiling on unsigned assemblies.

### 3221: Remove redundant whitespace from output window

Output the minimum amount of whitespace to ensure that test output and exceptions are clearly separated. This change is particularly noticeable when executing all tests in a solution.

### 3203: Don't execute tests that require a custom HostType (MSTest)

Tests with the HostType attribute will be skipped and indicated in the 'Task List'.

### 3204: Add support for TestClassExtensionAttribute (MSTest)

This was tested with the RowTest Unit Test Extensibility Sample (for Visual Studio 2010), which can be found here: http://code.msdn.microsoft.com/UnitTestExtendSample

### 3205: Add support for TestCategoryBaseAttribute (MSTest)

Custom categories that extend this attribute will now be taken into account.

### 3206: Add support for ExpectedExceptionBaseAttribute (MSTest)

Custom exception filters that extend this attribute will now be taken into account.

### 3200: Include 'Description' of ignored tests in 'Task List' summary (MSTest)

The reason why a test is being ignored can be included in the description like this: [Ignore, Description("Reason for ignoring.")]

### 3212: Output warning when installed version of NCover isn't registered

Confusing "NCover couldn't create a coverage report" message was being output when NCover had expired. This version will output a more meaningful warning.

### 3201: Add support for MSTest's 'TestDeploymentDir' and 'DeploymentDirectory' properties (MSTest)

Set these properties to be the test project's output directory (which TestDriven.Net uses for deployment).

### 3209: Output window text doesn't appear when window starts auto-hidden (VS 2010)

Added workaround for this Visual Studio 2010 painting bug.

### 3214: Can't 'Go To Source Code' from Reflector when target is nested inside a 'Solution Folder'

Navigation from Reflector to code inside solution folders wasn't working. This has been fixed.


## 3.0 Beta 2

### 3172: Add support for TestCategory attribute when using MSTest

Test categories can be specified using the TestCategory attribute on VS 2010 or [TestProperty("TestCategory", "MyCategory")] on VS 2008\. Tests can be filtered using the 'TestDriven.Net > General > Categories' option.

### 3199: 'Test With' menus sometimes missing on VS 2005 / 2008 (issue in TestDriven.Net 3.0.2611 Beta 2)

Must use CommandBarControls.Add on VS 2010 and Commands.AddCommandBar on VS 2005 / 2008.

### 3189: Can't build test project after 'Test With > In-Proc' on VS 2010

Fixed issue where test assemblies were ending up locked after being executed inside the Visual Studio process.

### 3190: Move Reflector 6 Pro's 'Open in .NET Reflector' button to below 'Go To Definition'

This button has been moved so that it doesn't accidentally get pressed when attempting to run tests.

### 3184: 'Go To Source Code' and 'Toggle Breakpoint' not available when Reflector is started using 'Open in .NET Reflector'

If these commands aren't visible on Reflector's context menu, launch Reflector using 'Go To Reflector', open 'Tools > Integration Options', deactivate Visual Studio add-in, press 'OK', then reactivate the add-in.

### 3187: 'TestDriven.Reflector' failed to load when Reflector 6 Pro add-in starts

This could happen when the Reflector Pro add-in activated Reflector inside the Visual Studio process (e.g. when using commands on the '.NET Reflector' menu).

### 3188: 'Go To Source Code' crashes when Reflector launched using 'Open in .NET Reflector'

Fixed crash when Reflector was launched by Redgate's .NET Reflector add-in and 'Go To Source Code' couldn't find parent Visual Studio instance.

### 3183: Default to using STA thread for MSTest

MSTest projects will now be executed on a STA thread.

### 3193: Command bar buttons not visible after upgrading from TestDriven.Net 2.x to 3.0

Upgrading to TestDriven.Net 3.0 should now install buttons correctly. You may need to activate TestDriven.Net in the 'Add-in Manager' if you downgrade back to TestDriven.Net 2.x.

### 3191: 'Test With' buttons sometimes appear duplicated on VS 2010

Added workarounds for multiple issues with the VS 2010 command bar automation model.

### 3192: Show message when .NET 4.0 compatible version of NCover is required

You will be informed if you need to upgrade NCover for .NET 4.0 support.

### 3224: Add hint to look at 'Task List' when there are ignored items

Ignored tests now appear on the 'Task List' rather than the 'Output' window. They could easily be missed without some kind of hint.


## 3.0 Beta

### 3167: Add support for MSTest on Visual Studio 2010

MSTest support is now a first class citizen inside TestDriven.Net 3\. This includes support for virtually all unit testing related MSTest attributes. The 'DeploymentItem' attribute is not supported (use project item's 'Copy to Output Directory' property instead).

### 3173: Add support for Reflector 6 Pro

Reflector 6 Pro will be downloaded and installed the first time 'Go To Reflector' is used. TestDriven.Net installs 'Go To Source Code' and 'Toggle Breakpoint' commands on the Reflector's context menus. 'Go To Source Code' can navigate to source that was decompiled with Reflector Pro or that was compiled on the local machine.

### 3182: Add support for 'Test With > Coverage' when using Visual Studio 2010 Premium

Added support for integrated code coverage when using Visual Studio 2010 Premium.

### 3171: Improve MSTest execution speed in VS 2008 / 2010

Test execution speed for MSTest has been significantly improved. This is particularly noticeable when executing individual tests.

### 3181: Add support for MSTest data driven tests (VS 2008 / 2010)

The 'DataSource' attribute is now supported. For data file deployment, use 'Copy to Output Directory' property rather than 'DeploymentItem' attributes.

### 3177: Add support for MSTest's Ignore attribute

Test classes and methods marked with the 'Ignore' attribute will not be included in the test run.

### 3180: Add support for nested test classes when using MSTest

Test classes can be nested inside public test or non-test classes.

### 3174: Add support for ExpectedException attribute in VS 2010

MSTest's 'ExpectedException' attribute (including the 'AllowDerivedTypes' property) now works when using VS 2010.

### 3178: Add support for NUnit 2.5.3

Xcopy deployable version of NUnit 2.5.3 test runner is now included in the 'Program Files\TestDriven.Net 3\NUnit' directory.

### 3168: Add support for specifying ApartmentState in NUnit config section

ApartmentState can be specified using the 'NUnit' section in 'App.config', or by using a 'RequiresSTA' attribute (which is recommended).

### 3164: Improve TestDriven.Net and Isolator integration

TestDriven.Net will automatically enable or disable Typemock Isolator, depending on whether a Typemock assembly is being referenced. If a 3rd party library is being used that depends on Typemock, an empty 'LibraryName.dll.tmock' file should be placed next to the referenced assembly (e.g. 'Ivonna.dll.tmock'). This signals to TestDriven.Net that Typemock should be enabled when executing tests.

### 3170: Add support for F# functions and modules with ``escaped names``

Functions can now have complex names, for example: let ``function with complex-name``() =  ...

### 3179: Can't 'Go To Reflector' on F# project references

Right click, 'Go To Reflector' now works on F# project references.

### 3175: Add support for 'Test With > Silverlight' on VS 2010

Ad hoc, public methods can be executed with Silverlight 4.0 on Visual Studio 2010\. Silverlight 4.0 is compatible with a subset of .NET 4.0 (not just assemblies that were compiled for Silverlight).

### 3176: Fix issue with 'Test With > Silverlight' on 64-bit Windows

Ad hoc, public methods can be executed using the CoreCLR (Silverlight) on 64-bit machines.


## 3.0 (revision 1)

### 3162: xUnit.net returns a FileLoadException

By default .NET 4.0 does not enable CAS policy by default (which would allow downloaded and network shared assemblies to execute). The 'loadFromRemoteSources' switch has now been enabled, which will allow these assemblies to execute. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.


## 3.0

### 3158: Added support for Visual Studio 2010 Beta 2

This version contains numerous workarounds for issues in Visual Studio 2010 Beta 2\. Be sure to update TestDriven.Net when Visual Studio 2010 is released!

### 3161: Removed support for Visual Studio 2003

TestDriven.Net 3.x supports Visual Studio 2010, 2008 & 2005\. For Visual Studio 2003 support, please use TestDriven.Net 2.x.


## 2.24

### 3139: Add support for zero install / xcopy deployable test runners

New test runners that use a .tdnet file don't need to install registry entries in order to work. This means the test runner binaries can be checked into version control and don't need to be installed. (This feature is already supported by xUnit 1.5, Gallio 3.1.0.313 and Gallio 3.0.6.787)

### 3140: Display warning message when MbUnit, Gallio or xUnit isn't installed

When a compatible test runner can't be found when attempting to execute a MbUnit or xUnit unit test - a warning message will be displayed informing the user how to solve the issue.

### 3147: Allow test runners to specify ApartmentState in registry or .tdnet file

Test runner plug-ins can specify the default ApartmentState to use (STA or MTA).

### 3146: Change NUnit 2.5 test runner to use MTA thread

NUnit 2.5 tests will in now be executed using a MTA thread to align with the NUnit 2.5 GUI and Console.

### 3145: Cache resident test runners in separate app domains

Different versions of Gallio/MbUnit can now be executed side by side (using zero install / xcopy deployable test runners).

### 3144: Can't execute overriden tests

Fixed issue that meant overridden NUnit test methods couldn't be directly targeted.

### 3155: Parameterized tests not working in C++/CLI

'Run Test(s)' and 'Go To Reflector' should now work on C++/CLI methods with primitive parameters. NOTE: The /clr:safe option may be required to prevent memory corruption on C++/CLI tests.

### 3138: Fix logging when ReSharper is installed

ReSharper will no longer prevent TestDriven.Net's debug logs from appearing.


## 2.23

### 2350: Add option to make AnyCPU default to 32 or 64-bit

You can specify the default using 'Options\TestDriven.Net\Any CPU tests'.

### 3127: Default to running AnyCPU tests in a 32-bit process

Your tests will run almost twice as fast in a 32-bit (WOW64) process! If you need to run tests in a 64-bit process you can compile your test project for x64 or change the default using 'Any CPU tests' option. See also: [AnyCPU Exes are usually more trouble than they're worth](http://is.gd/24WtP).

### 2354: Restore focus to editor after test run

Focus will be restored to the editor after doing a 'Repeat Test Run'.

### 2341: Use project relative source paths in stack traces

Much shorter, project relative paths will be used in stack traces (assuming the relative path is unambiguous).

### 2361: Use an installed version of NUnit 2.5 if available

The same version as the referenced 'nunit.framework' will be used if available. Otherwise the latest NUnit 2.5 version will be used. This allows the latest version of NUnit 2.5.x to be used and for NUnit extensions to be stored in a consistent location.

### 3128: Update to use NUnit 2.5.1

Include NUnit 2.5.1 in package.

### 2349: Add support for .NET 1.1 on NUnit 2.5

NUnit 2.5 can now be used from Visual Studio 2003.

### 2440: NCover 1.5.8 can hang on projects with many dependencies

A workaround for this potential issue has been added.

### 2346: Add support for VSTS 2010 code coverage

Visual Studio 2010 'Test With > Team Coverage' now works. To work with VS 2010 see [here](http://is.gd/24RQL).

### 2360: Allow test runner to return friendly name for display in test run summary

For example the version of NUnit 2.5.x used will appear in the test run summary (not simply "2.5").

### 3130: Could not load file or assembly 'nunit.core.interfaces'

Added workaround for situation where NUnit registry entries are installed but binaries are missing.


## 2.22

### 2337: Add support for NUnit 2.5 RTM

TestDriven.Net now integrates with the .NET 2.0 version of NUnit 2.5 RTM.

### 2335: Support for Visual Studio 2010 Beta1

Command bar button extensibility for add-ins is disabled in VS 2010 Beta1\. Commands can still be executed by associating shortcut keys using 'Preferences... > Environment > Keyboard'. To enable commands inside VS 2010 the 'TestDriven.Net > Supported Applications > Visual Studio 2010' feature must be explicitly enabled by doing a 'Custom' install.

### 2338: Visual Studio 2010 Beta1 fails to start

Added workaround for VS 2010 Beta1 crashing on startup.

### 2316: Allow NUnit 2.4 to execute NUnit 2.5 tests when running on .NET 1.1

Full NUnit 2.5 support is currently only supported with .NET 2.0 or above. If the .NET 1.1 version of 'nunit.framework' 2.5 is referenced, the NUnit 2.4 execution engine will be used. This enables support for the new Assert.That syntax, but not the new NUnit 2.5 attributes.

### 2314: Only show 'Test With > NUnit 2.5' command for VS 2005 and higher

The 'Test With > NUnit 2.5' (launch NUnit GUI) command will appear on the 'Solution Explorer' project context menu for VS 2005 or higher.

### 2319: Add support for parametrized tests with nullable parameters

Added support for targeting methods with nullable parameters. This can be useful when executing parametrized tests or when calling 'Go To Relector'.

### 2313: Add support for methods with generic types in generic parameters

The 'Go To Relector' command can now be used on methods and fields with complex generic types.

### 2311: Add support for methods with generic parameters

It is now possible to target methods/fields/parameterized tests with concrete generic parameters.

### 2332: Include assemblies in subdirectories when executing with NCover

Only assemblies with PDB information in the target project's output directory (or subdirectories) will appear in NCoverExplorer.

### 2320: Improve support for testing localization

Added workaround so that if CurrentCulture/CurrentUICulture has been explicitly set to "en-US" on a non-English machine, exception stack traces will still be double-clickable.

### 2312: Full fixture names don't appear in test report

Resolved issue with previous NUnit 2.5 support where namespaces weren't appearing in the test results.


## 2.21

### 2306: Add support for NUnit 2.5 RC

NUnit 2.5 RC will be used to execute any tests that reference the 'nunit.framework' version 2.5.

### 2296: Add support for 'Test With > NUnit 2.5' on x86 projects

The 32-bit version of the NUnit GUI will be used to open test assemblies compiled for the x86 platform.

### 2303: Trace/debug messages should appear 'Debug' pane when debugging

Trace/debug messages will now be displayed in the 'Debug' pane when stepping through code. Previously these messages only appeared in the 'Test' pane.

### 2307: Experimental support for Visual Studio 2010

Select 'Custom Setup' to enable support for 'Supported Applications > Visual Studio 2010'. This version is known to work with the Visual Studio 2010 PDC CTP but crashes with the later April09 CTP.

### 2302: Remove redundant 'Debug' option from notify icon menu

The notify icon's 'Debug' option was redundant and potentially confusing. The 'Test With > Debugger' command should be used instead.


## 2.20

### 1751: Smart TypeMock Isolator support

TestDriven.Net will automatically enable Typemock Isolator when the target references a TypeMock assembly and disable it otherwise. The Typemock Isolator add-in can be set not to load on 'Startup' using 'Add-in Manager'.  

### 1748: Use common test process for 'Run Test(s)' and 'Test With > Debugger'

The test process used for debugging tests and normal test execution is now shared. This will mean faster start-up and and fewer rockets appearing in the notify box.

### 1749: 'Test With > Coverage' doesn't work when executing tests in 64-bit process

TestDriven.Net will now automatically execute your tests in a 32-bit process when no 64-bit version of NCover is installed.

### 1747: 'Test With > dotTrace' doesn't work when executing tests in 64-bit process

Tests will now always be executed in a 32-bit process when profiling with dotTrace.

### 1805: Make NCover 2.1/3.0 automaticaly reload coverage file

NCoverExplorer 2.1/3.0 will now automatically reload coverage file without prompting.

### 2292: Bundled version of NCoverExplorer stops working after NCover is uninstalled

Fixed issue where uninstalling Gnoso's NCover might break bundled NCoverExplorer support.

### 2293: Save file dialog appears when attempting to close NCoverExplorer 3.0

As of NCover 3.0.17, NCoverExplorer won't prompt to save coverage project when closing.

### 2291: Assembies without PDB info are displayed when using NCover 3.0

Now only assemblies with PDB information will be show up in NCoverExplorer 3.0.

### 1716: Error when executing C++/CLI tests on 64-bit OS

Fixed issue with some C++/CLI assemblies that would cause them to execute in the wrong process type (e.g. a 32-bit assembly in a 64-bit process).

### 2095: Crash when NCover/NCoverExplorer is executed on large solution

Added workaround for Visual Studio crash when executing 'Test With > Coverage' on a large number of projects.  This was caused by a memory overflow bug in Process.Start(...).

### 1848: Setup fails on Turkish localized versions of Windows

When using a Turkish version of Windows, "this".ToLower() == "this" (spot the different). Changing to use ToLowerInvariant() has fixed the installer.

### 1746: Remove obsolete 'Test With > TypeMock' command

This command is obsolete now that 'TypeMock Isolator' is being automatically enabled and disabled.

### 1750: Add 'require32bit' option for some test runners in 'TestDriven.dll.config' file

To execute all tests in 32-bit mode, you can set require32bit="true" in the '\Program Files (x86)\TestDriven.NET 2.0\TestDriven.dll.config' file. The recommended way to force 32-bit execution is to set your test project's 'Platform target' to 'x86' (under 'Build' on the project properties page).


## 2.19

### 1661: Update test runner for [NUnit 2.5 Beta 2](http://nunit.com/index.php?p=releaseNotes&r=2.5)

This version has been compiled to work with NUnit 2.5 Beta 2.

### 1628: NUnit 2.5 Exceptions reported as Skipped not Failed

Fixed so that tests that throw an exception are reported as failed tests.

### 1601: Include test runner name in test run summary

The name of the test runner used will be displayed in brackets after the test results.

### 1649: 'Test With > .NET 1.1' doesn't work on 64-bit Windows

Fixed so that .NET 1.1 is always executed in a 32-bit process.

### 1650: Error loading in Visual Studio 2003

The previous version (2.18 Beta) was broken when loaded in Visual Studio 2003.

### 1617: Clear the error list when a new build starts

The test error list and output pane will always be cleared before any project is built.

### 1654: Clean up 'Team Coverage' files when Visual Studio exits

All VSTS *.coverage files will be deleted when the last instance of Visual Studio exits. This means coverage files from the drop down list are are now usable.

### 1631: After uninstalling TestDriven.Net, ghost 'Test With' menus are left behind

'Test With' menus will be deleted as part of the uninstallation process.

### 1682: Can't run [xUnit](http://www.codeplex.com/xunit) tests on 64-bit machine

The xUnit installer will now register itself properly for executing x64 and x86 unit tests. TestDriven.Net and xUnit must be installed using the same user account.

### 1683: Multiple UAC dialogs when installing on Windows Vista/Windows 7

Privilege elevation will now only be requested once when setup is launched.


## 2.18

### 1605: Add support for NUnit 2.5 Beta 1

NUnit 2.5 Beta can be found in the 'Program Files\TestDriven.NET 2.0\NUnit\2.5' folder.

### 1606: Add support for targeting generic test fixtures with NUnit 2.5

Added support for targeting generic test fixtures. See [here](http://nunit.com/index.php?p=testFixture&r=2.5) for documentation about creating generic fixtures.

### 1607: Add support for targeting static test fixtures with NUnit 2.5

Added support for targeting static tests on attributeless static text fixtures. This is particularly useful when writing F# unit tests (where there is no explicit fixture class).

### 1603: Only attempt to execute projects that reference a know test framework assembly

When executing all tests in a solution/solution folder, only attempt to execute projects that reference a known test framework assembly. This results in faster execution and eliminates 'skipped' test runs.

### 1608: Add automatic support for 64-bit test projects when using different test runner plugins

It is no longer necessary to register test runner plugins under the 32 and 64-bit registry roots when installing for all users (under HKLM). This was a problem for some versions of xUnit and MbUnit.

### 1609: Only use the highest priority plugin for a given test framework

If there are multiple plugins installed that can handle a particular test framework (e.g. both xUnit and Gallio register for 'xunit.dll'), only the highest priority runner will be given the chance to execute the tests. This allows ah-hoc tests to be executed when a project also contains xUnit tests.

### 1610: Test runners must specify which test framework assembly they support

Test runners must now specify which test framework assembly (e.g. 'nunit.framework' / 'MbUnit.Framework') they support using the 'TargetFrameworkAssemblyName' registry key. This allows non-test projects to be quickly skipped when executing all tests in a solution.

### 1604: Drop support for Visual Studio .Net 2002

I've decided to drop support for VS.NET 2002/.NET 1.0 because .NET 1.0 isn't installable on my 64-bit development machine. At this point I believe it's more important for me to dog food x64 support than to maintain legacy support for .NET 1.0.


## 2.17

### 1598: Add support for Visual Studio 2010

Test runner, code coverage and 'Go To Reflector' functionality now works with Visual Studio 2010/.NET 4.0.

### 1593: Add support for Silverlight 2.0 RTM

Use 'Test With > Silverlight' to execute public ad-hoc tests with the Silverlight CoreCLR. This feature is compatible with Silverlight 2.0 RTM and Beta versions.

### 1599: Execute tests in namespace by targeting a project folder

When all classes in a project folder belong to the same namespace, TestDriven.Net will execute all tests in the namespace as a single test run rather than as individual test fixtures.

### 1592: Save keyboard shortcuts

Preserve keyboard shortcuts when new version of TestDriven.Net is installed. This will work when updating TestDriven.Net 2.17 and higher.

### 1595: Add options pane to view test runners

You can view installed test runners under 'Tools > Options... > TestDriven.Net > Test Runners'. A future version will allow you to enable/disable them.

### 1590: Look for unit testing framework assembly in target directory and/or target assembly references

This better supports extensible test frameworks like MbUnit or xUnit where their framework assembly ('MbUnit.Framework' or 'xunit') isn't necessarily referenced directly by the test assembly.


## 2.16

### 1585: Add support for test categories

Categories of test can be included or excluded via the TestDriven.Net options pane (this feature works for NUnit tests).

### 1580: Add 'Go To Reflector' support for F#

'Go To Reflector' now works on F# projects, modules, parameterless methods and properties.

### 1581: Add support for executing parameterless F# methods

F# methods can be executed as ad-hoc tests or via a unit testing framework that supports static test methods (e.g. xUnit).

### 1582: Add support for evaluating F# properties

You can now use 'Run Test(s)' on F# properties to evaluate them.

### 1587: Always display console output/error and test runner messages

Test runner generated messages and console output will now be displayed when running all tests in a project/solution.

### 1588: Optionally display trace/debug output when running all tests in project/solution

By default trace/debug output isn't displayed when executing all tests in a project/solution. This behaviour can be modified via the TesDriven.Net options pane.

### 1586: Add support for test runners that aren't hosted in a new app domain

This is a new extensibility point for test runners that want to manage their own test process/app domain (future versions of Gallio will use this).


## 2.15

### 1576: Make caching of test process between test runs an option

See 'Tools\Options...\TestDriven.Net' for new option

### 1577: Make hiding of output when running all tests in project/solution an option

See 'Tools\Options...\TestDriven.Net' for new option

### 1578: Add support for NUnit 2.4.8

NUnit 2.4.8 can now be found in 'NUnit\2.4' directory


## 2.14

### 1381: Add support for Silverlight 2 Beta 2

'Test With > Silverlight' now supports Silverlight 2 Beta 2.

### 1388: 'Test With > Team Coverage' isn't visible in VS2008 Team Edition

Team Coverage is now supported on a clean VS2008 Team Edition install.

### 1390: Honour the solution 'Configuration Manager' project 'Build' settings

When running all tests in a solution, only projects with 'Build' checked in the 'Configuration Manager' will be built and executed.

### 1344: Add support for Gallio's "Icarus" GUI

When Gallio is installed, 'Test With > Gallio Icarus' should appear on project context menu.

### 1379: Run all tests in Solution not working with Solution Folders

Tests in solution folders will now be executed.


## 2.13

### 1341: Add support for Silverlight 2 Beta 1

Running 'ad-hoc' public methods now works with Silverlight 2.0 Beta 1.

### 1342: Add support for NUnit 2.4.7

Updated NUnit test runner to target NUnit 2.4.7.

### 1343: Include NUnit RowTest Extension in package

Andreas Schlapsi's RowTest for NUnit can be found in the '\Program Files\TestDriven.NET 2.0\NUnit\2.4\nunit.framework.extensions.dll' assembly.

### 1268: Replace Orcas with VS2008 in setup features dialog

Made it clear that TestDriven.Net works with VS 2008 in the installer.


## 2.12

### 1197: Treat “do not build” as “do not test”

When running all tests in a solution, honor the 'Build' check box in the 'Configuration Manager'.

### 1198: Workaround for C++ assemblies remaining locked

There appears to be a bug when mixed managed/unmanaged C++ assemblies are unloaded that causes them to remain locked. As a workaround you can add the following to your App.config file's appSettings element: <add key="ShadowCopyFiles" value="true" />

### 1200: Update to use NUnit 2.4.6

NUnit 2.4.6 is now packaged with TestDriven.Net (remember to update any installed NUnit add-ins).

### 1199: Improve support for "Smart Build"

This version should correctly determine when a build is required before a test run. The previous version might incorrectly skip the build if only a non-source project item had changed. The 'Smart Build' feature is now only active when using VS 2005 and above.


## 2.11

### 1168: Add support for NUnit 2.4 parameterized test methods

You can now target for execution NUnit test methods that take parameters (e.g. when using Andreas Schlapsi's RowTestExtension for NUnit).

### 1166: Add support for VS SDK TestHostFramework when using 'Test With > In-Proc'

When using 'Test With > In-Proc' the 'Dte' and 'ServiceProvider' properties of 'VsIdeTestHostContext' will be available for use. For this to work the Visual Studio 2007 SDK must be installed and a reference to 'Microsoft.VSSDK.TestHostFramework' added.

### 1167: 'Test With > NUnit 2.4' takes a long time to launch NUnit GUI

This was caused by an obscure log4net related issue. I've implemented a workaround to avoid the delay and ensure that NUnit log files are written to the correct location ('%APPDATA%\NUnit\NUnit.log').

### 1161: NUnit extensions aren't being loaded when placed in '%ProgramFiles%\TestDriven.NET 2.0\NUnit\2.4\addins' directory

The 'addins' directory must only contain valid assembly files. I've moved the 'addins.txt' file into the parent directory.

### 1165: 'Go To Reflector' on 'Call Stack' can mix up generic and non-generic methods

This command should no longer mix up generic and non-generic implementations of a method (e.g. 'Method<T>(T x)' and 'Method(int x)').


## 2.10.2173

### 1159: Improve 'Go To Reflector' support on 'Call Stack' tool window

Added support for generic methods, generic types, overloaded methods, constructors, properties and explicitly implemented interfaces. This has been tested using C# and Visual Basic (with and without debug symbols).

### 1160: Can't 'Toggle Breakpoint' on constructor method from inside Reflector.

You can now toggle breakpoints on regular constructors from inside Reflector. Unfortunately Visual Studio doesn't appear to support setting breakpoints on static constructors by method name.


## 2.10

### 1140: Add 'Go To Reflector' support for generics

Generic types, methods and other members are now supported when using 'Go To Reflector' and 'Go To Source code' (from inside .NET Reflector).

### 1147: Skip build check if there are no changes

If no source files have been edited since the last test run, assume that a build won't be required before the next run. This leads to a significant performance improvement when dealing with large solutions.  

### 1150: Add support for VS 2008 'Test With... Team Coverage'

'Test With... Team Coverage' option is now available when using VS 2008 Team Suite/Tester/Developer.

### 1133: NCover 2.0 x64 Support

NCover 2.0 (64-bit) will now be detected and used when testing a 64-bit (or platform neutral) assembly.

### 1145: Add support for 64-bit versions of NCover 2.0 and TypeMock

TestDriven.Net will now use 64-bit versions of NCover and TypeMock when installed.

### 1005: NCover 2.0 project name support

TestDriven.Net will pass the name of the current solution to NCover 2.0 for use with NCoverExplorer's per "project" settings.

### 1125: Support for generic unit tests

Targeting generic test types and methods is now supported. The usefulness of this will depend on the individual unit testing frameworks.

### 1152: Update to use NUnit 2.4.5

This version of NUnit is significantly faster, especially when running a small number of tests.

### 1149: VS 2008 crashes on startup when 'Code Analysis Tools' feature is not installed

This appears to be a bug in the VS 2008 CommandBars automation model. I've implemented a workaround in this version that should avoid the crash.

### 1141: Uninstalling TypeMock breaks 'Test With... Coverage'

In some versions of TypeMock, the TypeMock add-in was being left behind on uninstall. This orphaned add-in would cause 'Test With... Coverage' to break. I've added a check for this and a warning message.

### 1143: TMockRunner is being used even when TypeMock is dissabled

Don't use TMockRunner with NCover if TypeMock is disabled.


## 2.9

### 1062: Update for Silverlight 1.1 Alpha September Refresh

Updated CLSID and fixed timing issue so Test With Silverlight now works with September refresh.

### 1063: Add support for running NCover 2.0 when TypeMock is enabled

Fixed so that code coverage with NCover 2.0 works when the TypeMock add-in is enabled in Visual Studio.

### 1118: Update to use NUnit 2.4.2

NUnit 2.4.2 is now included in the installer.

### 1041: Call to System.Windows.Forms.Application.CommonAppDataPath fails in DebugMode

Fixed issue that would cause tests that use Application.CommonAppDataPath to fail.


## 2.8

### 993: Retire Visual Studio Express support

See joint statement: "Jamie Cansdale and Microsoft Corporation have agreed to concentrate on working together on future releases of TestDriven.Net for Microsoft's officially extensible editions of Visual Studio, as opposed to spending time litigating their differences."

### 995: DirectoryNotFoundException is thrown on paths that contains non ASCII characters

This issue was only manifesting on machines running non-English versions of Windows.


## 2.7

### 956: Add support for 'Test With... Silverlight'

When Silverlight 1.1 is installed a new 'Test With... Silverlight' option will appear on the code context menu.  This enables the execution of any public method using the CoreCLR (similar the existing ad-hoc tests feature). At the moment no unit testing frameworks are compatible with the CoreCLR.

### 962: Include NUnit 2.4.1

See release notes [here](http://nunit.com/index.php?p=releaseNotes&r=2.4.1)

### 945: NUnit 2.4 extensions aren't working

To use NUnit extensions with TestDriven.NET you must place extension assemblies in the '\Program Files\TestDriven.NET 2.0\NUnit\2.4\addins' directory.

### 961: Exceptions in TestFixtureSetUp/TearDown not shown

Exception information was not being displayed when using new NUnit 2.4 version. This is now fixed.

### 967: Bug when running NUnit tests with '#' in path

Test assembly path was being truncated when directory contained a '#'. This is now fixed.

### 966: Problems with XNA tests (working directory issues)

See [here](http://weblogs.asp.net/nunitaddin/archive/2007/05/18/using-testdriven-net-with-xna-game-studio-express.aspx) and [here](http://www.pixelpilot.dk/Testdriven.htm) for workaround.


## 2.6

### 952: Add support for Orcas Express (C#, VB, J# and C++)

Note: Properties tool window must be open for TestDriven.NET to activate itself.

### 951: Update to NCover 1.5.8 Beta

Include new build of NCover in package.

### 943: "Test With... Coverage" Hangs

Fixed bug where "Test With... Coverage" would hang if there were too many assemblies with PDB information referenced by a project.

### 945: NUnit 2.4 extensions aren't working

In this version you must create a directory at '\Program Files\TestDriven.NET 2.0\addins' for NUnit extensions (this is a temporary solution).

### 950: Ignored tests displayed as errors in task/error list

Assert.Ignore(...) now shows up correctly as a warning in  Error List.


## 2.5

### 921: Add support for NUnit 2.4 Final Release

See [here](http://sourceforge.net/mailarchive/forum.php?thread_name=000601c76918%247820de20%246401a8c0%40FERRARI&forum_name=nunit-users) for more information.

### 922: Add support for NUnit 2.2.10 Release

See [here](http://sourceforge.net/mailarchive/forum.php?thread_name=00e201c76819%24f73909d0%246401a8c0%40FERRARI&forum_name=nunit-users) for more information.

### 924: Add support for Express SKU (C#, VB, J# and C++)

To activate TestDriven.NET when using the Express SKU - ensure that the 'Properties' tool window is visible and select any item on the 'Solution Explorer' view.


## 2.4

### 901: Use NUnit 2.4 when executing tests that reference 'nunit.framework' 2.3.*/2.4.*

Added support for version ranges when selecting the correct test runner for a given framework assembly.

### 907: Include NUnit 2.4 RC2

Build against NUnit 'Release-2-4-Current' tagged version.

### 908: Strange assert message formatting in NUnit 2.4

Added workaround for change in assert message formatting between NUnit 2.2 and NUnit 2.4.

### 898: MSTest ClassInitialize methods not working in VS2005 SP1 / Orcas

MSTest support is now working with VS2005 Team editions and Orcas.

### 899: Can't run all tests in a namespace

Running all tests in a namespace was broken during the move from NUnit 2.2.8 to NUnit 2.2.9\. This is now fixed.


## 2.3

### 673: Test With... Mono

When Mono is installed a 'Test With... Mono' option will appear on the menus. This has been tested with Mono 1.2.3.

### 886: App.config files don't work when testing with Mono

Mono only works with app domain config files that end with '.config'. Added workaround that makes temporary config file end with '.temp.config' not '.config.temp'.


## 2.2

### 833: Fix for use with Reflector 5.0

Added support for Reflector 5.0 Beta (with with C# 3.0/Linq support).

### 835: Add support for Visual Studio Orcas

Register add-in for use with Visual Studio Orcas (tested with Jan 2007 CTP version).

### 846: Icons aren't uninstalled from Visual Studio 2005/Orcas

Icons were only being uninstalled correctly from VS2005 if VS2003 was also installed.

### 758: Abort test while on breakpoint causes deadlock

Ensure that debugger is detached before aborting the test thread.

### 817: Ensure that "Go to Reflector" appears underneath "Run Test(s)" on Solution node

Make 'Go To Reflector' default to appear at bottom of solution context menu.

### 829: Empty Test with Coverage

Fixed issue where NCover coverage report would appear empty in NCoverExplorer.


## 2.1

### 795: Add 'Go To Source Code' command to Reflector

Jump from any code element in Reflector to corresponding source code in Visual Studio.

### 796: Add 'Go To Reflector' button to Project menu

Right click on Project in the 'Solution Explorer' to load into Reflector.

### 797: Add 'Go To Reflector' button to Solution menu

Right click on Solution node in the 'Solution Explorer' to load all projects into Reflector (useful when searching whole solution).

### 806: Include NCover 1.5.7

Grant Drake had done many fixes in NCover 1.5.7

### 807: Add option to use PDB info with 'Go To Source Code'

If source code isn't part of Visual Studio solution then use PDB info if available to find source file and location for method (useful when debugging).

### 700: Add support for JetBrains dotTrace profiler

'Test With... dotTrace' option will appear when dotTrace is installed.

### 751: 'Coverage' button still shows when NCover/NCoverExplorer isn't installed

Don't show 'Test With... Coverage' option when NCoverExplorer isn't installed.


## 2.0 RTM

### 772: Can't run ad-hoc tests in NUnit project

Stopped 'No fixture attribute on parent class' warning when executing a non-test method in NUnit test project.

### 317: Run Test(s) not working - Private NUnit fixtures

Warn when attempting to run a private test fixture or test. Before the test would be executed as an ad-hoc test without any setup/teardown methods being called.

### 567: Install TestDriven.NET for all users when runnign as Administrator

When running as user in Administrator role, install for all users rather than just current user. This fixes installing on Vista.

### 569: Ship NCover with TestDriven.NET

NCover is now shipped as part of the TestDriven.NET installer. NCover 1.3.3 and 1.5.6 are included. NCover 1.5 will be used if .NET 2.0 is installed (works with Visual Studio 2002, 2003 and 2005). NCover 1.3 will be used if only .NET 1.1 is installed. Thanks to Peter Waldschmidt for allowing me to ship a non-GPL version of NCover with TestDriven.NET!

### 153: Add option to build and test with .NET 1.1/MSBee when using VS2005

When using Visual Studio 2005 there is an option to build and run tests using .NET 1.1.

### 275: Exceptions in test fixture setup/teardown not reported

Output any exceptions thrown in fixture SetUp/TearDown.

### 619: Add 'Repeat Test Run' to Solution Explorer menus

Made all menus with unit testing functionality consistent.

### 629: Activate 'Test' pane at end of run

Activate the 'Test' pane at the end of a test run so test results are visible after 'Test With... Debugger'.

### 637: Output window is activated on test run in VS2003 but not VS2005

Always make output window visible on test run unless window is set to auto hide. Use 'Projects and Solutions\Show Output window when build starts' option if you want 'Output' window to pop up when set to auto hide.

### 647: Warn when no test runner is found to run test(s)

Added warning when attempting to run a fixture with attributes from an unknown/not-installed unit testing framework.

### 697: Add an easy way to switch between NCover and Team Coverage

Show NCover 'Coverage' and 'Team Coverage' options on the 'Test With' menus when code coverage tools are available for use.

### 701: Only show menu items for available test runners

Only show test runners on 'Test With' menus that are available to use use (i.e. appropriate applications are installed). For example NCover, Team Coverage, TypeMock and .NET 1.1 (MSBee) will only appear when available for use.

### 704: Enable unmanaged code debugging

Added support for mixed mode and unmanaged debugging. 'Test With... Debugger' will use the 'Enable unmanaged code debugging' or 'Debugger Type' settings for the test project. The C++ debugger type 'Auto'  will always default to managed.

### 705: Add (hidden) support for 'Test With... E&C'

To enable 'Test With... Debugger (E&C)' that works with Edit & Continue; edit the 'TestDriven.dll.config' file and uncomment <button command="DebuggerEaC" />. This test runner may 'touch' project files when used with source control (this is why it's disabled by default).

### 708: No warning when tests project has broken App.config file

An appropriate warning will be output when the 'App.config' file of a test project contains invalid XML.

### 716: Add Reflector to Tools menu

Added 'Go To Reflector' button to Tools menu. Select a solution or project in the 'Solution Explorer' and hit 'Tools\Go To Reflector' to load project assemblies into Reflector. 'Go To Reflector' can be used from many different window contexts.

### 717: Show Breakpoints Tool Window on Reflector 'Toogle Breakpoint'

Show breakpoints when a breakpoint is toggled from inside Reflector (right click on a method and 'Toggle Breakpoint').

### 720: Add 'Go To Reflector' option to 'Modules' window

One or more modules can be selected inside the debugger 'Modules' window and opened inside Reflector.

### 721: Add 'Go To Reflector' option to 'References'

One of more project references can be selected and opened inside Reflector.

### 724: Allow property get to method to be executed as ad-hoc test

Property get methods can now be executed as ad-hoc tests.

### 737: Testing a folder's worth of test fixtures

Run each test fixture in the folder as a separate test run rather than assuming the folder exactly corresponds to a namespace. Only the first class in each source file will be executed as a fixture.

### 661: Rename 'Test With...' to simply 'Test With'

Changed to conform with menu naming conventions.

### 670: Use installed NCover unless packaged version is newer

Give priority to installed versions of NCover that are newer than the built in version.

### 688: Add support for running NCover with TypeMock

Added support for testing with code coverage when TypeMock is enabled. Simply use 'Test With... Coverage' when the TypeMock add-in is enabled.

### 694: Tests not running in 64 bit mode

Honor 'x86', 'x64' or 'Itanium' platform setting of test project. If platform is set to 'Any CPU' then tests will default to running in 64 bit process.

### 695: Add 'Test With... TypeMock' support

Added option to 'Test With... TypeMock'. This allows TypeMock to only be used on tests that require it (when the TypeMock add-in is disabled). Tests that don't require TypeMock run faster when TypeMock is disabled.

### 276: Problem with 'Test With...Debugger' + SourceGear Vault in VS.NET 2005

Use much faster 'Test With... Debugger' functionality when running under Visual Studio 2005 that doesn't touch project files and interfere with source control.

### 590: TestDriven.NET 1.0 and TestDriven.NET 2.0 GUID/ProgID

Made more robust when faced with possible left over registry entries from previous installs (e.g if an uninstall was forced using msizap).

### 605: Test With Coverage fails when running as non-admin

'Team Coverage' test runner is only available when running as Administrator user. NCover 'Coverage' test runner will work when running as Limited User.

### 652: Go To Reflector problems (proxy config and loading service)

Preserve important Reflector configuration settings when using an already installed version of Reflector. Use proper download dialog to obtain Reflector on first use. Thanks to Grant Drake for contributing this feature!

### 653: Old TestDriven.NET 1.0 menus remain in VS2005

Remove any menus that might be left over from previous versions of TestDriven.NET.

### 640: Assemblies in Reflector aren't reloaded after build

Reload assemblies when 'Go To Reflector' is called if the assembly has changed.

### 636: An existing connection was forcibly closed by the remote host

Fixed issue where test process would exit without warning when stepping through test code.

### 748: Only outermost exception is shown

Show stack trace of outermost exception when nested exception is thrown from MSTest fixture.

### 750: Installed to correct folder when doing silent install

Use default 'TestDriven.NET 2.0' directory when doing slient install ("start /wait TestDriven.NET-YOUR_VERSION.exe /q").

### 696: Repeat Test Run with Debugger building wrong assemblies

Fixed issue where 'Repeat Test Run' would build wrong assemblies when testing with debugger on Visual Studio 2002/2003.

### 693: Requested Service not found

Fixed timeout if a individual test runs for more than ~6 minutes.

### 687: Team Explorer stalls uninstall

Prevent 'Team Explorer' login from stalling uninstall.

### 666: Reflector 'Toggle Breakpoint' doesn't work when only VS2005 is installed

Fixed error loading Reflector add-in when launching from Visual Studio 2005.

### 764: No warning when trying to run test in ASP.NET WebSite

Executing tests in Web Site projects aren't supported in TestDriven.NET 2.0\. Display warning in output window.

### 767: Use new MbUnit icon

Note MbUnit is now a separate install (see www.mbunit.org).





## 2.0 RC1

### 575: Add 'Go To Reflector' option to 'Code', 'Disassembly' and 'Call Stack' windows

Added 'Go To Reflector' to 'Code', 'Disassembly' and 'Call Stack' context menus.

### 577: Toggle breakpoint on any method from inside Reflector.

Using .NET Reflector right click on any method and 'Toggle Breakpoint' to add a VS breakpoint. Be sure to dissable 'Just My Code' (under 'Tools/Options.../Debugging') if using VS2005.

### 255: Unhandled exceptions crash test process in .NET 2.0

Fixed so that unhandled exceptions no longer abort the process but instead output their thread name, exception message and stack trace (output message only appears when using .NET 2.0).

### 559: Repeat last test run

Added support for 'Repeat Test Run'. Tests will be executed with the last used test runner (default, debug, coverage etc.).

### 609: New 'Test With... Debugger' implementation for VS2005

When using VS2005, 'Test With... Debugger' will launch as quickly as the default 'Run Test(s)' implementation. It won't touch the project files or add a temporary 'surrogate' project.

### 620: Multiple test suite summary not shown in status bar

When multiple test suites are executed a summary will be displayed in the status bar.

### 571: 'Default Start Unit Tests' feature breaks 'Test With... Debugger'

This feature was too experimental to release as part of TestDriven.NET 2.0 RTM.

### 324: Testdriven.NET wants to checkout the project from VSS

In VS2005 'Test With... Debugger' will no longer touch the project file (previous versions needed to disable VS hosting process).

### 583: Visual Studio 2005 Web Application Projects and test with debugger

'Test With... Debugger' now works with VS2005 'Web Application' projects (not 'Web Site' projects).

### 546: Pending changes still contains the added *.Surrogate project

'Test With... Debugger' no longer requires a 'surrogate' project when executing tests in an MSTest project.


## 2.0 Beta 2

### 427: 64-bit support

Added support for running tests in 64 bit process. The test runner will honor the test assembly's 32bit flag.

### 375: Latest release of NUnit

Now using NUnit 2.2.8.

### 448: Warn before a version that works with the Express SKU is uninstalled

Added warning before uninstall for people who may be using the Express SKU support in previous versions.

### 522: Command bar buttons not showing on 'Solution Explorer' project node

Fixed issue that could stop TestDriven.NET's command bar buttons from being installed on some menus.

### 550: Menus missing in some non-US/UK cultures

Fixed big that caused some 'Test With...' menu buttons to be missing in cultures that use ',' for decimal point.

### 560: Can't 'Test With... Debugger' when project name same as solution folder name

'Test With... Debugger' now works when a solution folder has the same name the test project

### 326: Include MSBee in TestDriven.Net installer

Added option to build and test using .NET 1.1 from Visual Studio 2005\. Use the 'Test With... .NET 1.1' command.

### 310: Icons missing from the right click menus in VS2005

Fixed issue that could cause the wrong command bar button icons to display on some machines.

### 228: Clear 'ComPlus_Version' environment variable in test runner process

Ensure that the 'ComPlus_Version' environment variable is cleared in test process. This could cause spawned .NET processes to behave unexpectedly.

### 254: VS2005 / BI context menu bug

Fixed issue with always visible grey command bar buttons when 'SQL Server Analysis Services' was installed.  You may need to delete %APPDATA%\Microsoft\VisualStudio\8.0\1033\CmdUI.PRF

### 329: Failed tests do not show up in task list

Fixed issue when using non-English localized versions of VS2005/.NET 2.0. Stack traces of failing tests weren't double clickable or showing up in the error list.

### 337: dotTrace 2.0 prevents TestDriven from running from within Visual Studio 2005

Stopped 'SerializationException' from being thrown when JetBrains dotTrace 2.0 is installed.

### 293: Build solution before running test

Fixed issue where test project dependencies were not being compiled before test run. This would only happen when an ASP.NET 2.0 Web Site project was part of the solution.

### 289: Test Failure Messages not removed from ErrorList on Build

Clear test failures from error list before building for next test run.

![TestDriven.Net Alien](http://testdriven.net/images/r_alien.gif)
