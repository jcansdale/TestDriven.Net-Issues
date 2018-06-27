<html><head><title>TestDriven.NET - Release Notes</title>
		      
	      <style>
				<!--
				.FogBugzReleaseNotes     { font-family: Verdana,Arial,sans-serif }
				.FogBugzReleaseNotes h1  { border-bottom: 1px solid #449; font-size: 1.2em; color: #449; }
				.FogBugzReleaseNotes h2  { font-size: 1em; }
				.FogBugzReleaseNotes p   { font-family: Georgia,'Times New Roman',serif; margin-left: 0.5in; font-size: 0.9em; }
				.FogBugzFooter           { font-size: 10px; text-align:center }
				-->
	      </style></head><body>
	      
	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.2 Beta</h1>
            
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/105">TDI105</a>: Add support for Visual Studio 2017 Preview Editions</h2>
    <p>Preview versions can be installed side by side with regular versions. Default install location is assumed.</p>
  </div>
	      
	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.1 RTM</h1>
            
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/104">TDI104</a>: TestDriven.Net doesn't appear in Visual Studio 2017 / 15.3</h2>
    <p>devenv /updateconfiguration no longer updates Visual Studio's state on first launch. This exposed an issue with TestDriven.Net's installer.</p>
  </div>
	      
	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.1 Alpha</h1>
    
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/90">TDI90</a>: Add 'Test With &gt; In Proc (VS SDK)' for spelunking Visual Studio services and MEF exports</h2>
    <p>Target methods can define any number of service interfaces and MEF [Import/ImportMany] parameters. More information <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/90">here</a>.</p>
  </div>
	      
	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.0 RTM</h1>
    
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/88">TDI88</a>: Please re-introduce "Navigate to test or code"</h2>
    <p>Add a keyboard shortcut to the 'TestDriven.NET.GoToTestOrCode' command to execute the 'Go To Code/Test' functionality (it's no longer on the code context menu).</p>
    
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/92">TDI92</a>: Remove support for legacy project.json/.NET Core projects</h2>
    <p>.NET Core isn't currently supported. I'll revisit this when .NET Core 2.0 is released.</p>
  </div>

	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.0 Beta 3</h1>

    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/76">TDI76</a>: Add support for Visual Studio 2017 RC</h2>
    <p>TestDriven.Net will be installed for Visual Studio 2017 RC (Community, Professional and Enterprise in their default locations).</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/77">TDI77</a>: Setup prompts to download .NET 3.5 on Windows 10</h2>
    <p>Installer (setup.exe) is now built using .NET 4.0 so that is can be installed on a clean installation without .NET 2.0/3.5. Also made NCoverExplorer default to using .NET 4.0.</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/80">TDI80</a>: TestDriven.Net doesn't work on a 32-bit OS in Visual Studio 2015+</h2>
    <p>Fixed issue where TestDriven.Net couldn't find its home directory when running on a 32-bit version of Windows.</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/83">TDI83</a>: Test With &gt; NCover doesn't work when .NET 2.0/3.5 isn't installed</h2>
    <p>Allow NCover/NCoverExplorer to run when just .NET 4.x is installed.</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/72">TDI72</a>: Can you put the .csproj context menu buttons back below "build" like in VS2012?</h2>
    <p>Project context menu buttons are now placed in consistent locations.</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/65">TDI65</a>: Update for NUnit 3.5</h2>
    <p>Update installer to include latest version of NUnit.</p>
    <h2><a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/71">TDI71</a>: Test With &gt; NUnit not working in 4.0 Beta 2</h2>
    <p>Restore option to test using the old NUnit 2.5.10 GUI from project context menu.</p>
  </div>

	<div class="FogBugzReleaseNotes"> 
    <h1>Release Notes - TestDriven.NET: 4.0 Beta 2</h1>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/59">TDI59</a>: Add support for running "Ad hoc" async methods</h2>

    <p>Async methods can be targeted directly and the "Ad hoc" runner will wait for them to complete (the async method mustn't return void).</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/60">TDI60</a>: Develop library for testing classes that call static methods</h2>

    <p>This version of TestDriven.Net was tested using <a href="https://jcansdale.github.io/StaticMocks">StaticMocks</a>, a helper library for mocking static methods. If you're interested, you can find it <a href="https://jcansdale.github.io/StaticMocks">here</a>.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/54">TDI54</a>: Label text sent to console when running multiple tests</h2>

    <p>When running all tests in a project/solution, any console/trace output will be labeled with the name of the test that output it.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/63">TDI63</a>: Testing .NET Core project might fail with: "MyTests.exe isn't a .NET assembly"</h2>

    <p>When a "runtimes" element was defined in a .NET Core project, it was attempting to execute the native EXE shim rather than the target assembly DLL.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/17">TDI17</a>: Automatically pass DTE object to "Ad hoc" test methods that take DTE as a parameter</h2>

    <p>The 'Test With &gt; In-Proc' command will pass the current <code>DTE</code> (Visual Studio) object to "Ad hoc" test methods that take <code>DTE</code> (or <code>DTE2</code>) as a parameter.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/52">TDI52</a>: Add support for new VSTestHost when executing 'Test With &gt; In-Proc'</h2>

    <p>VisualStudio <a href="https://github.com/Microsoft/VisualStudio-TestHost">TestHost</a> project can be used for writing Visual Studio integration tests. As a quick way to prototype a test, the 'Test With &gt; In-Proc' command will populate initialize the <code>VSTestContext</code> class, giving easy to the current <code>ServiceProvider</code> and <code>DTE</code> objects. Click on this issue for an example.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/29">TDI29</a>: Run using .NET Framework (and "quirks mode") that project.json is targeting</h2>

    <p>When running tests using the 'dotnet test' based runners, run using the exact .NET Framework version and "quirks mode" they were compiled for.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/50">TDI50</a>: CurrentDirectory not set for dotnet-test based test runners</h2>

    <p>The current directory wasn't being set when executing using a 'dotnet test' based test runner. It is now being set to the output directory (consistent with other TestDriven.Net runners).</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/53">TDI53</a>: When running project.json tests, always target tests specified by <code>testRunner</code>
    </h2>

    <p>When targeting a 'project.json' based project, run using the "Ad hoc" runner if a non-test method is targeted (no test attribute), otherwise only consider the <code>testRunner</code> specified in 'project.json'.</p>

    <h2>
    <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/44">TDI44</a>: Remove <code>Go To Code/Test</code> command</h2>

    <p>This command was rarely being used and taking up valuable space on the context menu.</p>
  </div>
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 4.0 Beta</h1>
		
 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/21">21</a>: Add 'Test With > .NET' and 'Test With > .NET Core' commands</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/40">40</a>: Add support for .NET Framework / .xproj based projects that use `ITestRunner` interface</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/36">36</a>: Add support for App.config when running .xproj / .NET Framework tests</h2>

		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/14">14</a>: Add support for running "Ad hoc" test methods in .NET Core Class Library projects</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/27">27</a>: Add support for targeting .NET Framework .xproj 'Library' projects</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/23">23</a>: TestDriven.Net tries to run tests in .NET Core projects that don't contain tests</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/18">18</a>: .NET Core test runner should honor the NUGET_PACKAGES environment variable</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/7">7</a>: Can't resolve some assemblies when targeting .NET Core 'Class Library' projects</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/33">33</a>: Skip .xproj / project.json style projects that don't contain any tests</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/34">34</a>: Can't find .xproj assembly when project name is different to folder name</h2>

 		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/37">37</a>: Look for DLLs in RID directory, not just EXEs</h2>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 4.0 Alpha</h1>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/3">3</a>: Add support for .NET Core testing</h2>
		<p>.NET Core assemblies can now be targeted using Visual Studio 2015 Update 3 with .NET Core 1.0</a>
		
		<h2>TD#7: Add support for Visual Studio "15" preview (full and lightweight installs)</h2>
		<p>If you add or remove features using the lightweight installer, you will need to reinstall TestDriven.Net 4.</p>		
		
    <h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/14">14</a>: Add support for running "Ad hoc" test methods in .NET Core Console and Class Library projects</h2>
    <p>Any .NET Core method or property can be executed using the 'Run Test(s)' command. Any returned value or object will be expanded on the output window.</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/10">10</a>: Add support for .NET Core debugging</h2>
		<p>.NET Core projects can be debugged using the Test With &gt; Debugger' command.</p>
				
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/6">6</a>: Add support for running NUnit tests using .NET Core</h2>
		<p>Install the 'dotnet-test-nunit' and 'NUnit' packages from NuGet to run NUnit .NET core tests.</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/5">5</a>: Add support for running xUnit tests using .NET Core</h2>
		<p>Install the 'dotnet-test-xunit' and 'xUnit' packages from NuGet to run xUnit .NET core tests.</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/8">8</a>:  Allow .NET Core test runner projects to test themselves</h2>
		<p>The tests for .NET Core <a href="https://github.com/xunit/dotnet-test-xunit">xUnit</a> and <a href="https://github.com/nunit/dotnet-test-nunit">NUnit</a> test runner projects can now be executed using TestDriven.Net (the test runner is used to run tests on itself).</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/11">11</a>: Can't target tests in .NET Core nested types</h2>
		<p>The tests in nested types will now be executed when an outer type is targeted (xUnit and NUnit).</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/5">5</a>: Clean up output when an xUnit test fails</h2>
		<p>Cleaned up the reporting of failed tests and changed to use relative paths in stack frames.</p>
		
		<h2>Please add a feature request <a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues">here</a> if there is another test runner you would like to see supported.<h2>
		
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.10 RTM</h1>
		
    <h2>
      TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/28">28</a>:
      Can't evaluate "Ad hoc" properties in NUnit test projects
    </h2>
    <p>Attempting to target a property in NUnit test projects would result in an exception rathere than property being evaluated.</p>

    <h2>
      TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/22">22</a>:
      'Test With > Performance' not working on Visual Studio 2013 Premium
    </h2>
    <p>Symbols appeared not to be found when attempting to profile a test in Visual Studio 2013 Premium.</p>

    <h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter/issues/12">12</a>: Add support for running nested classes when a parent class is targeted (NUnit 3.x)</h2>
    <p>Some people like to use nested classes to arrange their tests.</p>

    <h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter/issues/5">5</a>: Add support for executing tests in concrete sub-classes when abstract class is targeted (NUnit 3.x)</h2>
    <p>Targeting abstract test fixtures in now supported.</p>

    <h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter/issues/6">6</a>: Add support for targeting generic test fixtures (NUnit 3.x)</h2>		
    <p>Generix fixtures and their contained methods can now be targeted.</p>
		
		<h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter/issues/1">1</a>: Fixed - Inconclusive tests were being reported as Failed (NUnit 3.x)</h2>
		<p>For example, Assume.That(false) was being counted as a failed test rather than inconclusive/ignored.</p>
		
		<h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter/issues/2">2</a>: Update to use NUnit v3.4.1</h2>
		<p>TestDriven.Net shoud still work with all NUnit 3.x tests, but packaged version is now NUnit v3.4.1.</p>
				
		<h2>NTA#<a href="https://github.com/nunit/nunit3-tdnet-adapter">0</a>: Move NUnit 3.x adapter for TestDriven.Net to NUnit ogarnization on GitHub</h2>
		<p>Please report any issues with the NUnit 3.x support in TestDriven.Net <a href="https://github.com/nunit/nunit3-tdnet-adapter">here</a>.</p>
		
		<h2>TDI#<a href="https://github.com/jcansdale/TestDriven.Net-Issues/issues/13">13</a>: Can't execute all tests in project if properties window is open</h2>
		<p>There is a bug in Visual Studio 2015 that causes an exception to be thrown when a properties window is open and the active document is queried. I've added a workaround for this.</p>
  </div>
		
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.10 Beta 2</h1>
		
		<h2>NTA#<a href="https://github.com/jcansdale/nunit3-tdnet-adapter/issues/18">18</a>: Remove extra new line after assert fail message when running NUnit 3.x tests</h2>
		<p>When an assert fail message contains multiple lines, NUnit 3 ends it with a trailing new line. The extra new line clutters up test results, especially if there are multiple failing tests.</p>
  </div>
		
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.10 Beta</h1>
		
		<h2>TD#11: Add native support for all NUnit 3.x versions</h2> <p>Previously you needed to reference the 'NUnitTDNet' package on NuGet to run
		NUnit 3.x tests. You can now execute any NUnit 3.x tests without special references or setup. This installer includes NUnit 3.4.0, but can execute any NUnit 3.x tests.</p>

		<h2>TD#1: Reinstate support for legacy NUnit 2.2 version</h2> <p>Useful when converting old .NET 1.x projects that reference this early NUnit framework version.</p>
		
		<h2>TD#4: Uninstall fails when launched from 'Add or remove programs'</h2> <p>Uninstall worked properly when using'setup.exe' or from the command line. Simply run 'setup.exe' when upgrading to new version.</p>
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.9 RTM</h1>
		
		<h2>9547: Add support for options pane in VS 2015</h2> <p>General options are now available in VS 2015 under Tools &gt; Options &gt; TestDriven.Net.</p>

    <h2>9546: Suggest using 'NUnitTDNet' NuGet package when tests reference NUnit 3.0</h2> <p>Give suggestions when referencing a version of 'nunit.framework' that isnt included with installer.</p>
		
    <h2>9545: Remove NUnit 3.0 beta 2 from installer</h2> <p>Ready to release TestDriven.NET 3.9 RTM, but can't release it with Beta version of NUnit.</p>
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.9 Beta 3</h1>
		
    <h2>9543: Add support for NUnit 3.0 beta 2/3</h2> <p>Tests that reference nunit.framework 3.0 beta 2/3 can be executed with this version. Future versions of NUnit 3.0 might be compatible with this release (depending on interface changes).</p>
    
    <h2>9544: Add support for Test With &gt; Performance in Visual Studio Enterprise 2015</h2> <p>This is an easy way to do performance profiling if youre using an Enterprise version of Visual Studio.</p>
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.9 Beta 2</h1>
		
    <h2>9539: Applications can run slightly differently when compiled to target .NET 4.0 compared to .NET 4.5 and later</h2> <p>Add support for running with quirks when tests are compiled to target .NET 4.5 and later.</p>
    
    <h2>9540: Unknown .NET Framework Version: v4.6</h2> <p>Removed warning message when targeting .NET v4.5.2 and later.</p>

    <h2>9541: Ignored tests not visible on Task List when using VS 2015</h2> <p>Display ignored tests on Error List / Messages when using VS 2015.</p>

    <h2>9542: Cant jump to ignored tests that take parameters</h2> <p>Allow double clicking on Task List / Error List for tests that take parameters.</p>
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.9 Beta</h1>
		
		<h2>9538: Test run sometimes aborts when project properties are on tab list (VS 2015 RC)</h2> <p>Added workaround for bug in VS 2015 RC when project properties havent been activated yet.</p>
		
		<h2>9536: Cant target F# tests that take parameters</h2> <p>Added support for F# tests that take parameters (test must have unique name).</p>
		
		<h2>9537: F# projects dont always build before test on VS 2015 RC</h2> <p>Added workaround for issue in VS 2015 RC. This should be fixed in VS 2015 RTM.</p>
	</div>
	      
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.8 RTM</h1>
		
		<h2>9535: Clean up security warnings during installation</h2> <p>TestDriven.Nets setup and installer files are now signed with Mutant Designs code signing key.</p>
	</div>
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.8 Beta 2</h1>

		<h2>9533: Add support for Test With &gt; Coverage in Visual Studio 2015</h2> <p>Coverage wasnt working in Visual Studio 2015.</p>

		<h2>9532: Warnings not visible when Task List is activated</h2> <p>When Lask List is automatically activated, the Add-ins category will now be selected. If user navigates to Lask List, this category may need to be manually selected.</p>

		<h2>9534: Add support for NUnit 2.6.4</h2> <p>This version of NUnit will warn rather than attempt to execute tests built with future NUnit 3.x versions.</p>
	</div>
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.8 Beta</h1>

		<h2>9528: Add support for Visual Studio 14 CTP</h2> <p>Convert TestDriven.Net from integrating with Visual Studio as an add-in to integrating as a package.</p>

		<h2>9531: Add support for VS 14 version of MSTest</h2> <p>Install test runner adapter that is compatible with the VS 14 version of MSTest.</p>
		
		<h2>9529: Ignored tests keep being added to Task List on each test run</h2> <p>Fixed bug where ignored tests werent being deleted from Task List before test run in Visual Studio 2012+.</p>

		<h2>9530: A resource leak has been shown to occur when adding test warnings to Task List</h2> <p>Reduce this by limiting the number of warnings that can be added to Task List in a single test run.</p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.7 Beta</h1>

		<h2>9524: Non-admin user cant test with coverage when solution contains any signed assemblies</h2> <p>Allow non-admin users to test with coverage on any unsigned assemblies in solution.</p>

		<h2>9525: Unknown .NET Framework Version: v4.5.1</h2> <p>Fixed warning when executing tests compiled with .NET v4.5.1.</p>

		<h2>9526: Build sometimes shows output window Test instead of Build</h2> <p>This would happen the first time a solution was built before running any tests.</p>

		<h2>9527: TestDriven.Net version number not shown on Add-in Manager or Visual Studio About window</h2> <p>This was an issue in Visual Studio 2012 and 2013.</p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.6 RTM</h1>

		<h2>9521: Not all projects built before test when keyboard used to start test execution on VS2012/VS2013</h2> <p>Caused by a strange Solution Explorer / keyboard interaction. Added a workaround for this issue.</p>

		<h2>9522: When build before test fails, build status message is being cleared</h2> <p>Fixed.</p>

		<h2>9523: When build before test fails, remain on output window.</h2> <p>This allows enter key to be pressed to jump to source that caused build to fail.</p>

		<h2>9524: TestDriven.Net not working on Windows XP</h2> <p>Fixed.</p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 RTM</h1>

		<h2>9520: Options dialog shows "the control to display here could not be loaded"</h2> <p>Fixed options dialog issue when TestDriven.Net is installed for all users<p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5.2830 RTM</h1>

		<h2>No new features</h2> <p>No bugs reported. Ready to RTM!<p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 RC 2</h1>

		<h2>9519 - TestDriven.Net doesnt show up when installed for all users on VS 2012 and 2013</h2> <p>Add-in now installed for all users, not just current user.</p>
		
		<h2>9520 - Visual Studio crashes when testing solution that contains WiX setup project</h2> <p>WiX project extension causes Visual Studio to quit when interacting with the WiX project model. Added workaround to avoid this.<p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 RC</h1>

		<h2>9517: Add support for Visual Studio 2013 version of MSTest</h2> <p>Added support for Visual Studio's built in unit test runner.</p>

		<h2>Add support for Visual Studio 2013 version of code coverage / performance profiling</h2> <p>'Test With &gt; Code Coverage' and 'Test With &gt; Performance' can be used on Visual Studio 2013 Premium and Ultimate.</p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 Beta 3</h1>

		<h2>9516: Add support for Visual Studio 2013</h2> <p>Added preliminary support for VS 2013. Needs lots of testing.</p>

		<h2>9515: Exclude compiler generated code from NCover coverage reports</h2> <p>Exclude any methods tagged with 'System.Runtime.CompilerServices.CompilerGeneratedAttribute' from coverage.</p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 Beta 2</h1>

		<h2>9513: Add support for NUnit 2.6.2</h2> <p>This version now includes the NUnit 2.6.2 test runner.</p>
		
		<h2>9514: Add support for Danish language</h2> <p>Stack traces in Danish language are now double clickable.</p>
	</div> 

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.5 Beta 1</h1>

		<h2>9512: Test With &gt; Performance not working on 2012</h2> <p>Fixed .NET profiler environment variables when using VS2012.</p>

		<h2>9511: Add support for Should naming convention with Go To Test/Code</h2> <p>Jumping between 'Target.cs' and 'TargetShould.cs' test file naming convention now supported.</p>
		
		<h2>9510: Tests wont run in MSTest when directory contains a #</h2> <p>Fixed issue when solution directory conatained a '#'.</p>
	</div> 


	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.4 RTM</h1>
		
		<h2>9508: Add support for running all tests in current solution</h2> <p>Theres a new command called TestDriven.NET.RunAllTestsInSolution. Bind this to a keyboard shortcut to execute all tests in the current solution.</p>
		
		<h2>9509: Add support for MSTest when only Visual Studio 2012 is installed</h2> <p>There was an issue running tests in VS 2012 when VS 2012 wasn't also installed.</p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.4 Beta 3</h1> 
		
		<h2>9506: Add support for NUnit 2.6.1</h2> <p>This version now includes the latest stable NUnit release.</p>

		<h2>9504: Add support for Reflector 6.8</h2> <p>Reflector 6.8 is the last free version of Reflector that all older versions will be upgraded to. Register the location of your Reflector.exe using Tools &gt; Options... &gt; TestDriven.Net &gt; Reflector.</p>
		
		<h2>9507: 'Test With &gt; Coverage' doesn't work if only VS 2012 is installed</h2> <p>The location of the .NET tools changed in the latest WinSDK. Coverage will now work in VS 2012.</p>
		
		<h2>9505: Fix issue with German stack traces</h2> <p>This fixes an issue where stack traces arent double clickable when Visual Studio is internationalized into English but the test process is German.</p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.4 Beta 2</h1> 

		<h2>9501: Add support for VS 2012 RTM</h2> <p>When installing for VS 2012, TestDriven.Net will only be installed for the current user. The HKLM add-in key no longer appears to work in the VS 2012 RTM release.</p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.4 Beta</h1> 

		<h2>9501: Add support for VS 2012 RC</h2> <p>This version has been tested with Visual Studio 2012 RC</p>
		
		<h2>9500: Cant run MSTests when VS 11 Beta is installed.</h2> <p>In VS 11 Beta the directory that contains MSTest public assemblies was changed. This stopped MSTest support from working in VS 2010 as well as VS 11 Beta. This has now been fixed.</p>
		
		<h2>9502: 'Test With > Silverlight' has been deprecated in this version.</h2> <p>If you still use this feature, you can re-enable it by editing the 'TestDriven.dll.config' file (see comments)</p>
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.3 Beta 2</h1> 

		<h2>9496: Add support for NUnit 2.6 Final Release (2.6.0.12051)</h2> <p>NUnit 2.6 Final Release is now included in the TestDriven.Net installer.</p> 

		<h2>9498: NUnit 2.6 GUI crashes when opening 32-bit test project</h2> <p>The NUnit GUI would crash when opening AnyCPU or x86 projects. This is now working.</p> 
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.3 Beta</h1> 

		<h2>9042: Add support for NUnit 2.6 RC</h2> <p>Xcopy deployable version of NUnit 2.6 RC can be found in the '\Program Files (x86)\TestDriven.NET 3\NUnit\2.6' directory.</p> 
	</div> 
		      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.2 Beta 2</h1> 

		<h2>7423: Add support for MSTest in VS 11 Developer Preview</h2> <p>The previous 3.2 Beta was defaulting to the simple MSTest support that was developed for VS 2005. Most MSTest attributes (deployment items etc) should now be working in this version.</p> 

		<h2>7424: Remove legacy support for MSTest in Visual Studio 2005</h2> <p>Removed the simple MSTest support that was originally developed for VS 2005, but was also set as the default for when a appropriate MSTest runner couldn't be found. Defaulting to this early MSTest runner would cause many MSTest attributes to be ignored and was potentially confusing.</p> 
	</div> 
	            
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.2 Beta</h1> 

		<h2>7302: Add support for Visual Studio 11 Developer Preview</h2> <p>You can find the VS 11 preview version here: <a href="http://msdn.microsoft.com/en-us/vstudio/hh127353">http://msdn.microsoft.com/en-us/vstudio/hh127353</a></p>	      
	</div> 
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.1 Beta</h1>
		
		<h2>6978: Code coverage doesn't work when solution contains native code</h2> <p>'Test With &gt; Coverage' wasn't working when target project contained native code DLLs with PDB information.</p> 

		<h2>6979: Can't double click on stack trace when Visual Studio is localized to a different language than Windows</h2> <p>This is now fixed for French versions of Windows, but will need to be fixed for each individual language (if Visual Studio isn't localized for the same language). Please contact me if you're being bitten by this issue.</p> 		

		<h2>5806: Add support for Reflector 7</h2> <p>Reflector 7 can be registered using 'Options &gt; TestDriven.Net &gt; Reflector'. Once registered the 'Go To Reflector' buttons will be visible.</p> 

		<h2>5807: Add support for NUnit 2.5.10</h2> <p>Xcopy deployable version of NUnit 2.5.10 test runner is now included in the 'Program Files\TestDriven.Net 3\NUnit' directory.</p> 

		<h2>5808: Error loading settings file</h2> <p>No need to load 'NUnitsettings.xml' file when executed using TestDriven.Net.</p> 
 	</div>
					 	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 RTM</h1>

		<h2>3278: Add option to activate 'Output' window on test failure/output/warning</h2> <p>By default the 'Output' window will be activated when there's significant text output to see. This can be disabled via 'Options &gt; TestDriven.Net &gt; General'.</p>

		<h2>3276: 'View.NextError' doesn't work until 'Error List' window is activated</h2> <p>Ensure that 'Error List' and 'Task List' windows are ready before starting test run.</p>

		<h2>3280: Fixed bug that might have caused default for AnyCPU tests to change to 64-bit</h2> <p>When upgrading from a pre-2.23 version, the default for AnyCPU tests might have changed to 64-bit. This has been reset back to 32-bit in this version (see 'Options &gt; TestDriven.Net &gt; General').</p>

		<h2>3279: Ensure the summary status message remains visible at end of test run</h2> <p>The summary status message was being lost when focus was away from Visual Studio.</p>
 	</div>
					 	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 RC 6</h1> 

        <h2>3267: Add 'Go To Test/Code' command to code context menu</h2> <p>This command has been added to the code context menu to make it more discoverable (think of it as 'Ctrl-Tab' for test driven developers). You can assign a keyboard shortcut to 'TestDriven.NET.GoToTestOrCode'.</p>

		<h2>3265: Rename the 'TestDriven.NET.GoToTest' command to 'TestDriven.NET.GoToTestOrCode'</h2> <p>This name makes it clearer that the command can be used to navigate back and forth between your tests and code under test.</p>

        <h2>3269: If multiple source files are found using 'Go To Test/Code', try to match based on containing folder</h2> <p>This will resolve the case when there are similarly named types in multiple namespaces (assuming the test/code under test folder structure matches).</p> 
        
		<h2>3274: Visual Studio sometimes hangs with 'Stop Debugging in Progress...' when using 'Test With &gt; Debugger' (VS 2010)</h2> <p>This is caused by a bug in Visual Studio 2010. I've added a workaround that seems to resolve the issue.</p> 
        
		<h2>3271: Add support for 'System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute' when testing with code coverage (.NET 4.0)</h2> <p>This .NET 4.0 attribute can be used with both NCover and Microsoft's code coverage support.</p>
        
		<h2>3270: 'Test With &gt; Coverage' doesn't work when 'Run in 64-bit process' option is active</h2> <p>When testing with code coverage / performance profiling, tests compiled for AnyCPU will be executed in a 32-bit process.</p>

		<h2>3275: 'Test With &gt; NCover' could crash when testing a very large number of assemblies</h2> <p>If the list of assemblies with PDB information exceeds a certain limit, all assemblies will be covered (whether or not they have a PDB file).</p> 

		<h2>3264: 'Go To Source Code' sometimes can't navigate to types (.NET Reflector)</h2> <p>Fixed issue where 'Go To Source Code' would sometimes fail when target source was referenced from another project.</p> 
		
		<h2>3266: Add 'TestDriven.NET.GoToCref' command</h2> <p>This command is used by 'Go To Source Code' from inside .NET Reflector. It takes a single cref string as a parameter.</p> 
 	</div>
					 	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 RC 5</h1> 

		<h2>3263: Simplify 'TestDriven.NET.GoToTests' command so that it flips between test and test target source</h2> <p>This command can be used to flip between your tests and the code your tests are targeting (e.g. between 'Target.cs' and 'TargetTests.cs'). Your tests filename must end with 'Tests', 'UnitTests', 'Fixture' or 'TestFixture'. The command 'TestDriven.NET.GoToTests' can be called via a keyboard shortcut.</p> 

		<h2>3246: Only show source files that actually exist on stack trace</h2> <p>This stops Visual Studio trying to navigate to source that doesn't exist when using test frameworks that distribute their PDB files.</p> 

		<h2>3254: 'Test With &gt; NUnit' should use xcopy deployable NUnit GUI when available</h2> <p>The NUnit GUI can be xcopy deployed along with your solution (use the files in '\Program Files (x86)\TestDriven.NET 3\NUnit\2.5'). The 'Test With &gt; NUnit' command (on the project context menu) will now launch the xcopy deployed NUnit GUI application.</p> 

		<h2>3261: Ask user which version of .NET Reflector to use / where to install it</h2> <p>The 'Go To Reflector' command will no longer use a private copy of Reflector that TestDriven.Net downloads. This should prevent a confusing situation when updating to a new version of Reflector. TestDriven.Net will default to using the same version of Reflector as Red Gate's .NET Reflector add-in.</p> 

		<h2>3262: Add 'Options &gt; TestDriven.Net &gt; Reflector' page for registering .NET Reflector</h2> <p>This options page can be used if you need to change the location .NET Reflector is installed at.</p> 

		<h2>3253: Allow 'Error List' to activate when running tests and build fails</h2> <p>The 'Error List' was failing to activate properly when running tests using the 'Solution Explorer' or 'Repeat Test Run'.</p> 

		<h2>3257: ConfigurationException error when running 'setup.exe'</h2> <p>Found a workaround for an issue that could be triggered by a corrupted 'machine.config' file.</p> 
	</div>
					 
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 RC 4</h1> 
		
		<h2>3240: Leave cursor on last failed test</h2> <p>If the 'Output' window is set to auto-hide, simply hit 'Enter' to jump to the last failed test. Otherwise hit 'Ctrl + Alt + O' to activate the 'Output' window and then 'Enter'.</p> 
		
		<h2>3241: Automatically show 'Output' window if there is test output or failed tests</h2> <p>The 'Output' window will automatically appear when there is something significant to see. It won't appear for general test runner info messages.</p> 

		<h2>3234: Include xcopy deployable version of NUnit 2.5.5 test runner</h2> <p>The files at '\Program Files (x86)\TestDriven.NET 3\NUnit\2.5' can (optionally) be stored with your solution. This will ensure that your tests are always executed using a known version of NUnit. For more information see: <a href="http://bit.ly/bPlwRm">http://bit.ly/bPlwRm</a> and <a href="http://bit.ly/rjeXn">http://bit.ly/rjeXn</a>.</p> 

		<h2>3244: Show hints when NCover can't be run with Typemock Isolator</h2> <p>Warn when Typemock Isolator 6.0.3 or admin privs is required to run with NCover. This is the case when running with NCover and Isolator on .NET 4.0.</p>

		<h2>3245: Don't automatically disable JustMock when Typemock Isolator is installed</h2> <p>Fixed issue where JustMock (and other profilers) were being disabled when Typemock Isolator was installed.</p> 

		<h2>3250: Don't automatically use installed version of NUnit 2.5.x</h2> <p>Automatically using the installed version of NUnit turned out to be too brittle. This has been deprecated in favour of xcopy deployable test runners. If you need to execute your tests using a specific version of NUnit (which may include custom extensions), you can find instructions here: <a href="http://bit.ly/bPlwRm">http://bit.ly/bPlwRm</a></p> 

		<h2>3249: Don't include .NET 1.1 version of NUnit 2.5 in package</h2> <p>Since TestDriven.Net 3.0 is focused on .NET 2.0 &amp; 4.0 development, including the .NET 1.1 version of NUnit 2.5 was redundant.</p> 
	</div>
					 
	<div class="FogBugzReleaseNotes"> 
        <h1>Release Notes - TestDriven.NET: 3.0 RC 3</h1> 
			
        <h2>3238: Automatically show 'Output' window if there is output/errors at end of test run</h2> <p>The 'Output' window will be activated if it's hidden and there is new output/error information to see.</p> 
					
        <h2>3239: Add double-clickable 'Error List' entries for failed tests don't have stack trace information (VS 2010)</h2> <p>Test failures that are due to an attribute (such as 'ExpectedException') don't contain any stack trace information. These failed tests can now be navigated to via the 'Error List' (only on VS 2010).</p> 
	</div>

	<div class="FogBugzReleaseNotes"> 
        <h1>Release Notes - TestDriven.NET: 3.0 RC 2</h1> 
			
        <h2>3163: Run tests with .NET version they were compiled for</h2> <p>The test project's 'Target Framework' property will be used to decide which .NET version to execute with.</p> 
					
        <h2>3227: Automatically show 'Task List' if there are only skipped tests</h2> <p>The 'Task List' tool window will appear if all targeted tests have been skipped.</p> 
					
        <h2>3226: Tests with ExpectedException are skipped on VS 2008 (MSTest)</h2> <p>Fixed bug in ExpectedException support that would cause tests declared this attribute to be skipped.</p> 
	</div>

	<div class="FogBugzReleaseNotes"> 
        <h1>Release Notes - TestDriven.NET: 3.0 RC</h1> 

        <h2>3218: Add support for performance profiling in Visual Studio 2005-2010 Team/Premium SKUs</h2> <p>Use 'Test With &gt; Performance' to perform instrumented performance profiling on target code.</p> 

        <h2>3213: Show ignored or otherwise excluded tests on the 'Task List' window</h2> <p>Any skipped tests will be displayed on the 'Task List' as double-clickable items.</p> 

        <h2>3217: Add support for NCover in Visual Studio 2010</h2> <p>All versions of NCover can now be used with Visual Studio 2010 / .NET 4.0.</p> 

        <h2>3223: Add support for MSTest's DeploymentItem attribute</h2> <p>Solution relative and project output relative deployment items are now supported. Files will be deployed in the test project's output directory when required.</p> 

        <h2>3210: Add support for targeting abstract types and methods in VS 2010 version of MSTest</h2> <p>Targeting an abstract base class will execute concrete test classes. Targeting a test method on the base class will execute this method for all concrete classes.</p> 

        <h2>3219: Don't require admin privs when doing coverage/profiling of unsigned assemblies</h2> <p>Visual Studio no longer needs to be run as administrator when performing coverage/profiling on unsigned assemblies.</p> 

        <h2>3221: Remove redundant whitespace from output window</h2> <p>Output the minimum amount of whitespace to ensure that test output and exceptions are clearly separated. This change is particularly noticeable when executing all tests in a solution.</p> 

        <h2>3203: Don't execute tests that require a custom HostType (MSTest)</h2> <p>Tests with the HostType attribute will be skipped and indicated in the 'Task List'.</p> 

        <h2>3204: Add support for TestClassExtensionAttribute (MSTest)</h2> <p>This was tested with the RowTest Unit Test Extensibility Sample (for Visual Studio 2010), which can be found here: http://code.msdn.microsoft.com/UnitTestExtendSample</p> 

        <h2>3205: Add support for TestCategoryBaseAttribute (MSTest)</h2> <p>Custom categories that extend this attribute will now be taken into account.</p> 

        <h2>3206: Add support for ExpectedExceptionBaseAttribute (MSTest)</h2> <p>Custom exception filters that extend this attribute will now be taken into account.</p> 

        <h2>3200: Include 'Description' of ignored tests in 'Task List' summary (MSTest)</h2> <p>The reason why a test is being ignored can be included in the description like this: [Ignore, Description(&quot;Reason for ignoring.&quot;)]</p> 

        <h2>3212: Output warning when installed version of NCover isn't registered</h2> <p>Confusing &quot;NCover couldn't create a coverage report&quot; message was being output when NCover had expired. This version will output a more meaningful warning.</p> 

        <h2>3201: Add support for MSTest's 'TestDeploymentDir' and 'DeploymentDirectory' properties (MSTest)</h2> <p>Set these properties to be the test project's output directory (which TestDriven.Net uses for deployment).</p> 

        <h2>3209: Output window text doesn't appear when window starts auto-hidden (VS 2010)</h2> <p>Added workaround for this Visual Studio 2010 painting bug.</p> 

        <h2>3214: Can't 'Go To Source Code' from Reflector when target is nested inside a 'Solution Folder'</h2> <p>Navigation from Reflector to code inside solution folders wasn't working. This has been fixed.</p> 
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 Beta 2</h1> 
		
        <h2>3172: Add support for TestCategory attribute when using MSTest </h2> <p>Test categories can be specified using the TestCategory attribute on VS 2010 or [TestProperty(&quot;TestCategory&quot;, &quot;MyCategory&quot;)] on VS 2008. Tests can be filtered using the 'TestDriven.Net &gt; General &gt; Categories' option.</p>	
        
		<h2>3199: 'Test With' menus sometimes missing on VS 2005 / 2008 (issue in TestDriven.Net 3.0.2611 Beta 2)</h2> <p>Must use CommandBarControls.Add on VS 2010 and Commands.AddCommandBar on VS 2005 / 2008.</p> 
					 			
		<h2>3189: Can't build test project after 'Test With &gt; In-Proc' on VS 2010</h2> <p>Fixed issue where test assemblies were ending up locked after being executed inside the Visual Studio process.</p> 

		<h2>3190: Move Reflector 6 Pro's 'Open in .NET Reflector' button to below 'Go To Definition'</h2> <p>This button has been moved so that it doesn't accidentally get pressed when attempting to run tests.</p> 
		
		<h2>3184: 'Go To Source Code' and 'Toggle Breakpoint' not available when Reflector is started using 'Open in .NET Reflector'</h2> <p>If these commands aren't visible on Reflector's context menu, launch Reflector using 'Go To Reflector', open 'Tools &gt; Integration Options', deactivate Visual Studio add-in, press 'OK', then reactivate the add-in.</p> 
		
		<h2>3187: 'TestDriven.Reflector' failed to load when Reflector 6 Pro add-in starts</h2> <p>This could happen when the Reflector Pro add-in activated Reflector inside the Visual Studio process (e.g. when using commands on the '.NET Reflector' menu).</p> 
		
		<h2>3188: 'Go To Source Code' crashes when Reflector launched using 'Open in .NET Reflector'</h2> <p>Fixed crash when Reflector was launched by Redgate's .NET Reflector add-in and 'Go To Source Code' couldn't find parent Visual Studio instance.</p> 
		
		<h2>3183: Default to using STA thread for MSTest</h2> <p>MSTest projects will now be executed on a STA thread.</p> 

		<h2>3193: Command bar buttons not visible after upgrading from TestDriven.Net 2.x to 3.0</h2> <p>Upgrading to TestDriven.Net 3.0 should now install buttons correctly. You may need to activate TestDriven.Net in the 'Add-in Manager' if you downgrade back to TestDriven.Net 2.x.</p> 
							
		<h2>3191: 'Test With' buttons sometimes appear duplicated on VS 2010</h2> <p>Added workarounds for multiple issues with the VS 2010 command bar automation model.</p> 
		
		<h2>3192: Show message when .NET 4.0 compatible version of NCover is required</h2> <p>You will be informed if you need to upgrade NCover for .NET 4.0 support.</p> 
							
		<h2>3224: Add hint to look at 'Task List' when there are ignored items</h2> <p>Ignored tests now appear on the 'Task List' rather than the 'Output' window. They could easily be missed without some kind of hint.</p>
    </div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 Beta</h1> 
			
		<h2>3167: Add support for MSTest on Visual Studio 2010</h2> <p>MSTest support is now a first class citizen inside TestDriven.Net 3. This includes support for virtually all unit testing related MSTest attributes. The 'DeploymentItem' attribute is not supported (use project item's 'Copy to Output Directory' property instead).</p> 

		<h2>3173: Add support for Reflector 6 Pro</h2> <p>Reflector 6 Pro will be downloaded and installed the first time 'Go To Reflector' is used. TestDriven.Net installs 'Go To Source Code' and 'Toggle Breakpoint' commands on the Reflector's context menus. 'Go To Source Code' can navigate to source that was decompiled with Reflector Pro or that was compiled on the local machine.</p> 

		<h2>3182: Add support for 'Test With &gt; Coverage' when using Visual Studio 2010 Premium</h2> <p>Added support for integrated code coverage when using Visual Studio 2010 Premium.</p> 

		<h2>3171: Improve MSTest execution speed in VS 2008 / 2010</h2> <p>Test execution speed for MSTest has been significantly improved. This is particularly noticeable when executing individual tests.</p> 

		<h2>3181: Add support for MSTest data driven tests (VS 2008 / 2010)</h2> <p>The 'DataSource' attribute is now supported. For data file deployment, use 'Copy to Output Directory' property rather than 'DeploymentItem' attributes.</p> 
		
		<h2>3177: Add support for MSTest's Ignore attribute</h2> <p>Test classes and methods marked with the 'Ignore' attribute will not be included in the test run.</p> 

		<h2>3180: Add support for nested test classes when using MSTest</h2> <p>Test classes can be nested inside public test or non-test classes.</p> 

		<h2>3174: Add support for ExpectedException attribute in VS 2010</h2> <p>MSTest's 'ExpectedException' attribute (including the 'AllowDerivedTypes' property) now works when using VS 2010.</p> 

		<h2>3178: Add support for NUnit 2.5.3</h2> <p>Xcopy deployable version of NUnit 2.5.3 test runner is now included in the 'Program Files\TestDriven.Net 3\NUnit' directory.</p> 

		<h2>3168: Add support for specifying ApartmentState in NUnit config section</h2> <p>ApartmentState can be specified using the 'NUnit' section in 'App.config', or by using a 'RequiresSTA' attribute (which is recommended).</p> 

		<h2>3164: Improve TestDriven.Net and Isolator integration</h2> <p>TestDriven.Net will automatically enable or disable Typemock Isolator, depending on whether a Typemock assembly is being referenced. If a 3rd party library is being used that depends on Typemock, an empty 'LibraryName.dll.tmock' file should be placed next to the referenced assembly (e.g. 'Ivonna.dll.tmock'). This signals to TestDriven.Net that Typemock should be enabled when executing tests.</p> 

		<h2>3170: Add support for F# functions and modules with ``escaped names``</h2> <p>Functions can now have complex names, for example: let ``function with complex-name``() =&nbsp; ...</p> 
		
		<h2>3179: Can't 'Go To Reflector' on F# project references</h2> <p>Right click, 'Go To Reflector' now works on F# project references.</p> 

		<h2>3175: Add support for 'Test With &gt; Silverlight' on VS 2010</h2> <p>Ad hoc, public methods can be executed with Silverlight 4.0 on Visual Studio 2010. Silverlight 4.0 is compatible with a subset of .NET 4.0 (not just assemblies that were compiled for Silverlight).</p> 
		
		<h2>3176: Fix issue with 'Test With &gt; Silverlight' on 64-bit Windows</h2> <p>Ad hoc, public methods can be executed using the CoreCLR (Silverlight) on 64-bit machines.</p> 
	</div>


	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0 (revision 1)</h1> 

		<h2>3162: xUnit.net returns a FileLoadException</h2> <p>By default .NET 4.0 does not enable CAS policy by default (which would allow downloaded and network shared assemblies to execute). The 'loadFromRemoteSources' switch has now been enabled, which will allow these assemblies to execute. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.</p> 	      
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 3.0</h1> 
		
		<h2>3158: Added support for Visual Studio 2010 Beta 2</h2> <p>This version contains numerous workarounds for issues in Visual Studio 2010 Beta 2. Be sure to update TestDriven.Net when Visual Studio 2010 is released!</p> 
		
		<h2>3161: Removed support for Visual Studio 2003</h2> <p>TestDriven.Net 3.x supports Visual Studio 2010, 2008 &amp; 2005. For Visual Studio 2003 support, please use TestDriven.Net 2.x.</p> 	      
	</div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.24</h1> 
			
		<h2>3139: Add support for zero install / xcopy deployable test runners</h2> <p>New test runners that use a .tdnet file don't need to install registry entries in order to work. This means the test runner binaries can be checked into version control and don't need to be installed. (This feature is already supported by xUnit 1.5, Gallio 3.1.0.313 and Gallio 3.0.6.787)</p> 
		
		<h2>3140: Display warning message when MbUnit, Gallio or xUnit isn't installed</h2> <p>When a compatible test runner can't be found when attempting to execute a MbUnit or xUnit unit test - a warning message will be displayed informing the user how to solve the issue.</p> 

		<h2>3147: Allow test runners to specify ApartmentState in registry or .tdnet file</h2> <p>Test runner plug-ins can specify the default ApartmentState to use (STA or MTA).</p> 
		
		<h2>3146: Change NUnit 2.5 test runner to use MTA thread</h2> <p>NUnit 2.5 tests will in now be executed using a MTA thread to align with the NUnit 2.5 GUI and Console.</p> 
		
		<h2>3145: Cache resident test runners in separate app domains</h2> <p>Different versions of Gallio/MbUnit can now be executed side by side (using zero install / xcopy deployable test runners).</p> 

		<h2>3144: Can't execute overriden tests</h2> <p>Fixed issue that meant overridden NUnit test methods couldn't be directly targeted.</p> 
		
		<h2>3155: Parameterized tests not working in C++/CLI</h2> <p>'Run Test(s)' and 'Go To Reflector' should now work on C++/CLI methods with primitive parameters. NOTE: The /clr:safe option may be required to prevent memory corruption on C++/CLI tests.</p> 

		<h2>3138: Fix logging when ReSharper is installed</h2> <p>ReSharper will no longer prevent TestDriven.Net's debug logs from appearing.</p> 
	</div>
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.23</h1> 
			
		<h2>2350: Add option to make AnyCPU default to 32 or 64-bit</h2> <p>You can specify the default using 'Options\TestDriven.Net\Any CPU tests'.</p> 

		<h2>3127: Default to running AnyCPU tests in a 32-bit process </h2> <p>Your tests will run almost twice as fast in a 32-bit (WOW64) process! If you need to run tests in a 64-bit process you can compile your test project for x64 or change the default using 'Any CPU tests' option. See also: <a href="http://is.gd/24WtP">AnyCPU Exes are usually more trouble than they're worth</a>.</p> 

		<h2>2354: Restore focus to editor after test run</h2> <p>Focus will be restored to the editor after doing a 'Repeat Test Run'.</p> 

		<h2>2341: Use project relative source paths in stack traces</h2> <p>Much shorter, project relative paths will be used in stack traces (assuming the relative path is unambiguous).</p> 
		
		<h2>2361: Use an installed version of NUnit 2.5 if available</h2> <p>The same version as the referenced 'nunit.framework' will be used if available. Otherwise the latest NUnit 2.5 version will be used. This allows the latest version of NUnit 2.5.x to be used and for NUnit extensions to be stored in a consistent location.</p> 

		<h2>3128: Update to use NUnit 2.5.1</h2> <p>Include NUnit 2.5.1 in package.</p> 

		<h2>2349: Add support for .NET 1.1 on NUnit 2.5</h2> <p>NUnit 2.5 can now be used from Visual Studio 2003.</p> 

		<h2>2440: NCover 1.5.8 can hang on projects with many dependencies</h2> <p>A workaround for this potential issue has been added.</p> 

		<h2>2346: Add support for VSTS 2010 code coverage</h2> <p>Visual Studio 2010 'Test With &gt; Team Coverage' now works. To work with VS 2010 see <a href="http://is.gd/24RQL">here</a>.</p> 
			
		<h2>2360: Allow test runner to return friendly name for display in test run summary</h2> <p>For example the version of NUnit 2.5.x used will appear in the test run summary (not simply "2.5").</p> 
		
		<h2>3130: Could not load file or assembly 'nunit.core.interfaces'</h2> <p>Added workaround for situation where NUnit registry entries are installed but binaries are missing.</p> 		
	</div>
			  
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.22</h1> 

		<h2>2337: Add support for NUnit 2.5 RTM</h2> <p>TestDriven.Net now integrates with the .NET 2.0 version of NUnit 2.5 RTM.</p> 

		<h2>2335: Support for Visual Studio 2010 Beta1</h2> <p>Command bar button extensibility for add-ins is disabled in VS 2010 Beta1. Commands can still be executed by associating shortcut keys using 'Preferences... &gt; Environment &gt; Keyboard'. To enable commands inside VS 2010 the 'TestDriven.Net &gt; Supported Applications &gt; Visual Studio 2010' feature must be explicitly enabled by doing a 'Custom' install.</p> 

		<h2>2338: Visual Studio 2010 Beta1 fails to start</h2> <p>Added workaround for VS 2010 Beta1 crashing on startup.</p>

		<h2>2316: Allow NUnit 2.4 to execute NUnit 2.5 tests when running on .NET 1.1</h2> <p>Full NUnit 2.5 support is currently only supported with .NET 2.0 or above. If the .NET 1.1 version of 'nunit.framework' 2.5 is referenced, the NUnit 2.4 execution engine will be used. This enables support for the new Assert.That syntax, but not the new NUnit 2.5 attributes.</p> 

		<h2>2314: Only show 'Test With &gt; NUnit 2.5' command for VS 2005 and higher</h2> <p>The 'Test With &gt; NUnit 2.5' (launch NUnit GUI) command will appear on the 'Solution Explorer' project context menu for VS 2005 or higher.</p> 	
		
		<h2>2319: Add support for parametrized tests with nullable parameters</h2> <p>Added support for targeting methods with nullable parameters. This can be useful when executing parametrized tests or when calling 'Go To Relector'.</p> 

		<h2>2313: Add support for methods with generic types in generic parameters</h2> <p>The 'Go To Relector' command can now be used on methods and fields with complex generic types.</p> 
		
		<h2>2311: Add support for methods with generic parameters</h2> <p>It is now possible to target methods/fields/parameterized tests with concrete generic parameters.</p> 
			
		<h2>2332: Include assemblies in subdirectories when executing with NCover</h2> <p>Only assemblies with PDB information in the target project's output directory (or subdirectories) will appear in NCoverExplorer.</p> 	
	
		<h2>2320: Improve support for testing localization</h2> <p>Added workaround so that if CurrentCulture/CurrentUICulture has been explicitly set to &quot;en-US&quot; on a non-English machine, exception stack traces will still be double-clickable.</p> 

		<h2>2312: Full fixture names don't appear in test report</h2> <p>Resolved issue with previous NUnit 2.5 support where namespaces weren't appearing in the test results.</p> 
	</div>
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.21</h1> 
		
		<h2>2306: Add support for NUnit 2.5 RC</h2> <p>NUnit 2.5 RC will be used to execute any tests that reference the 'nunit.framework' version 2.5.</p> 

		<h2>2296: Add support for 'Test With &gt; NUnit 2.5' on x86 projects</h2> <p>The 32-bit version of the NUnit GUI will be used to open test assemblies compiled for the x86 platform.</p> 
		
		<h2>2303: Trace/debug messages should appear 'Debug' pane when debugging</h2> <p>Trace/debug messages will now be displayed in the 'Debug' pane when stepping through code. Previously these messages only appeared in the 'Test' pane.</p> 
		
		<h2>2307: Experimental support for Visual Studio 2010</h2> <p>Select 'Custom Setup' to enable support for 'Supported Applications &gt; Visual Studio 2010'. This version is known to work with the Visual Studio 2010 PDC CTP but crashes with the later April09 CTP.</p> 
		
		<h2>2302: Remove redundant 'Debug' option from notify icon menu</h2> <p>The notify icon's 'Debug' option was redundant and potentially confusing. The 'Test With &gt; Debugger' command should be used instead.</p> 
	 </div>
					 	      
	      
	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.20</h1> 

		<h2>1751: Smart TypeMock Isolator support</h2> <p>TestDriven.Net will automatically enable Typemock Isolator when the target references a TypeMock assembly and disable it otherwise. The Typemock Isolator add-in can be set not to load on 'Startup' using 'Add-in Manager'.<br /></p> 

		<h2>1748: Use common test process for 'Run Test(s)' and 'Test With &gt; Debugger'</h2> <p>The test process used for debugging tests and normal test execution is now shared. This will mean faster start-up and and fewer rockets appearing in the notify box.</p> 

		<h2>1749: 'Test With &gt; Coverage' doesn't work when executing tests in 64-bit process</h2> <p>TestDriven.Net will now automatically execute your tests in a 32-bit process when no 64-bit version of NCover is installed.</p> 

		<h2>1747: 'Test With &gt; dotTrace' doesn't work when executing tests in 64-bit process</h2> <p>Tests will now always be executed in a 32-bit process when profiling with dotTrace.</p> 	      

		<h2>1805: Make NCover 2.1/3.0 automaticaly reload coverage file</h2> <p>NCoverExplorer 2.1/3.0 will now automatically reload coverage file without prompting.</p> 

		<h2>2292: Bundled version of NCoverExplorer stops working after NCover is uninstalled</h2> <p>Fixed issue where uninstalling Gnoso's NCover might break bundled NCoverExplorer support.</p> 

		<h2>2293: Save file dialog appears when attempting to close NCoverExplorer 3.0</h2> <p>As of NCover 3.0.17, NCoverExplorer won't prompt to save coverage project when closing.</p> 

		<h2>2291: Assembies without PDB info are displayed when using NCover 3.0</h2> <p>Now only assemblies with PDB information will be show up in NCoverExplorer 3.0.</p> 
	
		<h2>1716: Error when executing C++/CLI tests on 64-bit OS</h2> <p>Fixed issue with some C++/CLI assemblies that would cause them to execute in the wrong process type (e.g. a 32-bit assembly in a 64-bit process).</p> 
		
		<h2>2095: Crash when NCover/NCoverExplorer is executed on large solution</h2> <p>Added workaround for Visual Studio crash when executing 'Test With &gt; Coverage' on a large number of projects.&nbsp; This was caused by a memory overflow bug in Process.Start(...).</p> 
		
		<h2>1848: Setup fails on Turkish localized versions of Windows</h2> <p>When using a Turkish version of Windows, &quot;this&quot;.ToLower() == &quot;th&#305;s&quot; (spot the different). Changing to use ToLowerInvariant() has fixed the installer.</p> 

		<h2>1746: Remove obsolete 'Test With &gt; TypeMock' command</h2> <p>This command is obsolete now that 'TypeMock Isolator' is being automatically enabled and disabled.</p> 
		
		<h2>1750: Add 'require32bit' option for some test runners in 'TestDriven.dll.config' file</h2> <p>To execute all tests in 32-bit mode, you can set require32bit=&quot;true&quot; in the '\Program Files (x86)\TestDriven.NET 2.0\TestDriven.dll.config' file. The recommended way to force 32-bit execution is to set your test project's 'Platform target' to 'x86' (under 'Build' on the project properties page).</p> 
	 </div>

	<div class="FogBugzReleaseNotes"> 
		<h1>Release Notes - TestDriven.NET: 2.19</h1> 
		
		<h2>1661: Update test runner for <a href="http://nunit.com/index.php?p=releaseNotes&r=2.5">NUnit 2.5 Beta 2</a></h2> <p>This version has been compiled to work with NUnit 2.5 Beta 2.</p> 
		
		<h2>1628: NUnit 2.5 Exceptions reported as Skipped not Failed</h2> <p>Fixed so that tests that throw an exception are reported as failed tests.</p> 
		
		<h2>1601: Include test runner name in test run summary</h2> <p>The name of the test runner used will be displayed in brackets after the test results.</p> 
		
		<h2>1649: 'Test With &gt; .NET 1.1' doesn't work on 64-bit Windows</h2> <p>Fixed so that .NET 1.1 is always executed in a 32-bit process.</p> 
		
		<h2>1650: Error loading in Visual Studio 2003</h2> <p>The previous version (2.18 Beta) was broken when loaded in Visual Studio 2003.</p>
		
		<h2>1617: Clear the error list when a new build starts</h2> <p>The test error list and output pane will always be cleared before any project is built.</p> 
		
		<h2>1654: Clean up 'Team Coverage' files when Visual Studio exits</h2> <p>All VSTS *.coverage files will be deleted when the last instance of Visual Studio exits. This means coverage files from the drop down list are are now usable.</p>
					
		<h2>1631: After uninstalling TestDriven.Net, ghost 'Test With' menus are left behind</h2> <p>'Test With' menus will be deleted as part of the uninstallation process.</p>
		
		<h2>1682: Can't run <a href="http://www.codeplex.com/xunit">xUnit</a> tests on 64-bit machine</h2> <p>The xUnit installer will now register itself properly for executing x64 and x86 unit tests. TestDriven.Net and xUnit must be installed using the same user account.</p> 
		
		<h2>1683: Multiple UAC dialogs when installing on Windows Vista/Windows 7</h2> <p>Privilege elevation will now only be requested once when setup is launched.</p> 
	 </div>
					 	      
	<div class="FogBugzReleaseNotes"> 
	
		 <h1>Release Notes - TestDriven.NET: 2.18</h1> 
		
		 <h2>1605: Add support for NUnit 2.5 Beta 1</h2> <p>NUnit 2.5 Beta can be found in the 'Program Files\TestDriven.NET 2.0\NUnit\2.5' folder.</p> 

		 <h2>1606: Add support for targeting generic test fixtures with NUnit 2.5</h2> <p>Added support for targeting generic test fixtures. See <a href="http://nunit.com/index.php?p=testFixture&amp;r=2.5">here</a> for documentation about creating generic fixtures.</p> 
		
		 <h2>1607: Add support for targeting static test fixtures with NUnit 2.5</h2> <p>Added support for targeting static tests on attributeless static text fixtures. This is particularly useful when writing F# unit tests (where there is no explicit fixture class).</p> 

		 <h2>1603: Only attempt to execute projects that reference a know test framework assembly</h2> <p>When executing all tests in a solution/solution folder, only attempt to execute projects that reference a known test framework assembly. This results in faster execution and eliminates 'skipped' test runs.</p> 
			
		 <h2>1608: Add automatic support for 64-bit test projects when using different test runner plugins</h2> <p>It is no longer necessary to register test runner plugins under the 32 and 64-bit registry roots when installing for all users (under HKLM). This was a problem for some versions of xUnit and MbUnit.</p> 
		
		 <h2>1609: Only use the highest priority plugin for a given test framework</h2> <p>If there are multiple plugins installed that can handle a particular test framework (e.g. both xUnit and Gallio register for 'xunit.dll'), only the highest priority runner will be given the chance to execute the tests. This allows ah-hoc tests to be executed when a project also contains xUnit tests.</p> 
		
		 <h2>1610: Test runners must specify which test framework assembly they support</h2> <p>Test runners must now specify which test framework assembly (e.g. 'nunit.framework' / 'MbUnit.Framework') they support using the 'TargetFrameworkAssemblyName' registry key. This allows non-test projects to be quickly skipped when executing all tests in a solution.</p> 

		 <h2>1604: Drop support for Visual Studio .Net 2002</h2> <p>I've decided to drop support for VS.NET 2002/.NET 1.0 because .NET 1.0 isn't installable on my 64-bit development machine. At this point I believe it's more important for me to dog food x64 support than to maintain legacy support for .NET 1.0.</p> 
				
	 </div>
		 

	<div class="FogBugzReleaseNotes">
		<h1>Release Notes - TestDriven.NET: 2.17</h1> 
		
		<h2>1598: Add support for Visual Studio 2010</h2> <p>Test runner, code coverage and 'Go To Reflector' functionality now works with Visual Studio 2010/.NET 4.0.</p> 

		<h2>1593: Add support for Silverlight 2.0 RTM</h2> <p>Use 'Test With &gt; Silverlight' to execute public ad-hoc tests with the Silverlight CoreCLR. This feature is compatible with Silverlight 2.0 RTM and Beta versions.</p> 
		
		<h2>1599: Execute tests in namespace by targeting a project folder</h2> <p>When all classes in a project folder belong to the same namespace, TestDriven.Net will execute all tests in the namespace as a single test run rather than as individual test fixtures.</p>
	
		<h2>1592: Save keyboard shortcuts</h2> <p>Preserve keyboard shortcuts when new version of TestDriven.Net is installed. This will work when updating TestDriven.Net 2.17 and higher.</p> 

		<h2>1595: Add options pane to view test runners</h2> <p>You can view installed test runners under 'Tools &gt; Options... &gt; TestDriven.Net &gt; Test Runners'. A future version will allow you to enable/disable them.</p> 

		<h2>1590: Look for unit testing framework assembly in target directory and/or target assembly references</h2> <p>This better supports extensible test frameworks like MbUnit or xUnit where their framework assembly ('MbUnit.Framework' or 'xunit') isn't necessarily referenced directly by the test assembly.</p> 
	</div>
	  

	<div class="FogBugzReleaseNotes">
		<H1>Release Notes - TestDriven.NET: 2.16</H1> 
			 
		 <H2>1585: Add support for test categories</H2> <P>Categories of test can be included or excluded via the TestDriven.Net options pane (this feature works for NUnit tests).</P> 
	
		 <H2>1580: Add &#39;Go To Reflector&#39; support for F#</H2> <P>&#39;Go To Reflector&#39; now works on F# projects, modules, parameterless methods and properties.</P> 

		 <H2>1581: Add support for executing parameterless F# methods</H2> <P>F# methods can be executed as ad-hoc tests or via a unit testing framework that supports static test methods (e.g. xUnit).</P> 
		
		 <H2>1582: Add support for evaluating F# properties</H2> <P>You can now use &#39;Run Test(s)&#39; on F# properties to evaluate them.</P> 
			
		 <H2>1587: Always display console output/error and test runner messages</H2> <P>Test runner generated messages and console output will now be displayed when running all tests in a project/solution.</P> 
		
		 <H2>1588: Optionally display trace/debug output when running all tests in project/solution</H2> <P>By default trace/debug output isn&#39;t displayed when executing all tests in a project/solution. This behaviour can be modified via the TesDriven.Net options pane.</P>
		 
		 <H2>1586: Add support for test runners that aren&#39;t hosted in a new app domain</H2> <P>This is a new extensibility point for test runners that want to manage their own test process/app domain (future versions of Gallio will use this).</P> 
	</div>
	      


	<div class="FogBugzReleaseNotes">
			<h1>Release Notes - TestDriven.NET: 2.15</h1> 

			 <h2>1576: Make caching of test process between test runs an option</h2> <p>See 'Tools\Options...\TestDriven.Net' for new option</p> 
					
			 <h2>1577: Make hiding of output when running all tests in project/solution an option</h2> <p>See 'Tools\Options...\TestDriven.Net' for new option</p> 
					
			 <h2>1578: Add support for NUnit 2.4.8</h2> <p>NUnit 2.4.8 can now be found in 'NUnit\2.4' directory</p> 
	</div>



	<div class="FogBugzReleaseNotes">
			<h1>Release Notes - TestDriven.NET: 2.14</h1> 
									
			<h2>1381: Add support for Silverlight 2 Beta 2</h2> <p>'Test With &gt; Silverlight' now supports Silverlight 2 Beta 2.</p> 
			
			<h2>1388: 'Test With &gt; Team Coverage' isn't visible in VS2008 Team Edition</h2> <p>Team Coverage is now supported on a clean VS2008 Team Edition install.</p> 
			
			<h2>1390: Honour the solution 'Configuration Manager' project 'Build' settings</h2> <p>When
			running all tests in a solution, only projects with 'Build' checked in
			the 'Configuration Manager' will be built and executed.</p> 

			<h2>1344: Add support for Gallio's "Icarus" GUI</h2> <p>When Gallio is installed, 'Test With &gt; Gallio Icarus' should appear on project context menu.</p> 
			
			<h2>1379: Run all tests in Solution not working with Solution Folders</h2> <p>Tests in solution folders will now be executed.</p> 
	</div>


	<div class="FogBugzReleaseNotes">
			 <h1>Release Notes - TestDriven.NET: 2.13</h1> 
	
			 <h2>1341: Add support for Silverlight 2 Beta 1</h2> <p>Running 'ad-hoc' public methods now works with Silverlight 2.0 Beta 1.</p> 
			
			 <h2>1342: Add support for NUnit 2.4.7</h2> <p>Updated NUnit test runner to target NUnit 2.4.7.</p> 
			
			 <h2>1343: Include NUnit RowTest Extension in package</h2> <p>Andreas Schlapsi's RowTest for NUnit can be found in the '\Program Files\TestDriven.NET 2.0\NUnit\2.4\nunit.framework.extensions.dll' assembly.</p> 
			
			 <h2>1268: Replace Orcas with VS2008 in setup features dialog</h2> <p>Made it clear that TestDriven.Net works with VS 2008 in the installer.</p> 
	</div>
							

	   <div class="FogBugzReleaseNotes">
			 <h1>Release Notes - TestDriven.NET: 2.12</h1> 
			
					 <h2>1197: Treat do not build as do not test</h2> <p>When running all tests in a solution, honor the 'Build' check box in the 'Configuration Manager'.</p> 
					
					 <h2>1198: Workaround for C++ assemblies remaining locked</h2> <p>There
appears to be a bug when mixed managed/unmanaged C++ assemblies are
unloaded that causes them to remain locked. As a workaround you can add
the following to your App.config file's appSettings element: &lt;add
key="ShadowCopyFiles" value="true" /&gt;</p> 
					
					 <h2>1200: Update to use NUnit 2.4.6</h2> <p>NUnit 2.4.6 is now packaged with TestDriven.Net (remember to update any installed NUnit add-ins).</p> 
					
					 <h2>1199: Improve support for "Smart Build"</h2> <p>This
version should correctly determine when a build is required before a
test run. The previous version might incorrectly skip the build if only
a non-source project item had changed. The 'Smart Build' feature is now
only active when using VS 2005 and above.</p>
           </div>



	   <div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.11</h1>
					
								<h2>1168: Add support for NUnit 2.4 parameterized test methods</h2>
								<p>You
can now target for execution NUnit test methods that take parameters
(e.g. when using Andreas Schlapsi's RowTestExtension for NUnit).</p>

								<h2>1166: Add support for VS SDK TestHostFramework when using 'Test With &gt; In-Proc'</h2>
								<p>When
using 'Test With &gt; In-Proc' the 'Dte' and 'ServiceProvider'
properties of 'VsIdeTestHostContext' will be available for use. For
this to work the Visual Studio 2007 SDK must be installed and a
reference to 'Microsoft.VSSDK.TestHostFramework' added.</p>
						
								<h2>1167: 'Test With &gt; NUnit 2.4' takes a long time to launch NUnit GUI</h2>
								<p>This
was caused by an obscure log4net related issue. I've implemented a
workaround to avoid the delay and ensure that NUnit log files are
written to the correct location ('%APPDATA%\NUnit\NUnit.log').</p>
						
								<h2>1161: NUnit extensions aren't being loaded when placed in '%ProgramFiles%\TestDriven.NET 2.0\NUnit\2.4\addins' directory</h2>
								<p>The 'addins' directory must only contain valid assembly files. I've moved the 'addins.txt' file into the parent directory.</p>
						
								<h2>1165: 'Go To Reflector' on 'Call Stack' can mix up generic and non-generic methods</h2>
								<p>This
command should no longer mix up generic and non-generic implementations
of a method (e.g. 'Method&lt;T&gt;(T x)' and 'Method(int x)').</p>
						
						
		
		</div>



	   <div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.10.2173</h1>
					
								<h2>1159: Improve 'Go To Reflector' support on 'Call Stack' tool window</h2>
								<p>Added
support for generic methods, generic types, overloaded methods,
constructors, properties and explicitly implemented interfaces. This
has been tested using C# and Visual Basic (with and without debug
symbols).</p>
						
								<h2>1160: Can't 'Toggle Breakpoint' on constructor method from inside Reflector.</h2>
								<p>You
can now toggle breakpoints on regular constructors from inside
Reflector. Unfortunately Visual Studio doesn't appear to support
setting breakpoints on static constructors by method name.</p>
						
		</div>
		
		
	   <div class="FogBugzReleaseNotes">

				<h1>Release Notes - TestDriven.NET: 2.10</h1>
				
								<h2>1140: Add 'Go To Reflector' support for generics</h2>
								<p>Generic
types, methods and other members are now supported when using 'Go To
Reflector' and 'Go To Source code' (from inside .NET Reflector).</p>

								<h2>1147: Skip build check if there are no changes</h2>
								<p>If
no source files have been edited since the last test run, assume that a
build won't be required before the next run. This leads to a
significant performance improvement when dealing with large solutions.<br></p>

								<h2>1150: Add support for VS 2008 'Test With... Team Coverage'</h2>
								<p>'Test With... Team Coverage' option is now available when using VS 2008 Team Suite/Tester/Developer.</p>
				
								<h2>1133: NCover 2.0 x64 Support</h2>
								<p>NCover 2.0 (64-bit) will now be detected and used when testing a 64-bit (or platform neutral) assembly.</p>
								
								<h2>1145: Add support for 64-bit versions of NCover 2.0 and TypeMock</h2>
								<p>TestDriven.Net will now use 64-bit versions of NCover and TypeMock when installed.</p>
					
								<h2>1005: NCover 2.0 project name support</h2>
								<p>TestDriven.Net will pass the name of the current solution to NCover 2.0 for use with NCoverExplorer's per "project" settings.</p>
						
								<h2>1125: Support for generic unit tests</h2>
								<p>Targeting
generic test types and methods is now supported. The usefulness of this
will depend on the individual unit testing frameworks.</p>
						
								<h2>1152: Update to use NUnit 2.4.5</h2>
								<p>This version of NUnit is significantly faster, especially when running a small number of tests.</p>
												
								<h2>1149: VS 2008 crashes on startup when 'Code Analysis Tools' feature is not installed</h2>
								<p>This appears to be a bug in the VS 2008 CommandBars automation model. I've implemented a workaround
								in this version that should avoid the crash.</p>
						
								<h2>1141: Uninstalling TypeMock breaks 'Test With... Coverage'</h2>
								<p>In
some versions of TypeMock, the TypeMock add-in was being left behind on
uninstall. This orphaned add-in would cause 'Test With... Coverage' to
break. I've added a check for this and a warning message.</p>
						
								<h2>1143: TMockRunner is being used even when TypeMock is dissabled</h2>
								<p>Don't use TMockRunner with NCover if TypeMock is disabled.</p>
		</div> 



		<div class="FogBugzReleaseNotes">
			<h1>Release Notes - TestDriven.NET: 2.9</h1>
			
			<h2>1062: Update for Silverlight 1.1 Alpha September Refresh</h2>
			<p>Updated CLSID and fixed timing issue so Test With Silverlight now works with September refresh.</p>
			
			<h2>1063: Add support for running NCover 2.0 when TypeMock is enabled</h2>
			<p>Fixed so that code coverage with NCover 2.0 works when the TypeMock add-in is enabled in Visual Studio.</p>
			
			<h2>1118: Update to use NUnit 2.4.2</h2>
			<p>NUnit 2.4.2 is now included in the installer.</p>
			
			<h2>1041: Call to System.Windows.Forms.Application.CommonAppDataPath fails in DebugMode</h2>
			<p>Fixed issue that would cause tests that use Application.CommonAppDataPath to fail.</p>
		</div>		

		<div class="FogBugzReleaseNotes">
				<h1>Release Notes - TestDriven.NET: 2.8</h1>
				<h2>993: Retire Visual Studio Express support</h2>
				<p>See joint statement: &quot;Jamie Cansdale and Microsoft Corporation have agreed to concentrate on working together on future releases of TestDriven.Net for Microsoft's officially extensible editions of Visual Studio, as opposed to spending time litigating their differences.&quot;</p>
				
				<h2>995: DirectoryNotFoundException is thrown on paths that contains non ASCII characters</h2>
				<p>This issue was only manifesting on machines running non-English versions of Windows.</p>			
		</div>

				
		<div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.7</h1>
								
								<h2>956: Add support for 'Test With... Silverlight'</h2>
								<p>When
Silverlight 1.1 is installed a new 'Test With... Silverlight' option
will appear on the code context menu.&nbsp; This enables the execution
of any public method using the CoreCLR (similar the existing ad-hoc
tests feature). At the moment no unit testing frameworks are compatible
with the CoreCLR.</p>
						
								<h2>962: Include NUnit 2.4.1</h2>
								<p>See release notes <a href="http://nunit.com/index.php?p=releaseNotes&amp;r=2.4.1">here</a></p>
						
								<h2>945: NUnit 2.4 extensions aren't working</h2>
								<p>To
use NUnit extensions with TestDriven.NET you must place extension
assemblies in the '\Program Files\TestDriven.NET 2.0\NUnit\2.4\addins'
directory.</p>
						
								<h2>961: Exceptions in TestFixtureSetUp/TearDown not shown</h2>
								<p>Exception information was not being displayed when using new NUnit 2.4 version. This is now fixed.</p>
								
								<h2>967: Bug when running NUnit tests with '#' in path</h2>
								<p>Test assembly path was being truncated when directory contained a '#'. This is now fixed.</p>
								
								<h2>966: Problems with XNA tests (working directory issues)</h2>
								<p>See <a href="http://weblogs.asp.net/nunitaddin/archive/2007/05/18/using-testdriven-net-with-xna-game-studio-express.aspx">here</a> and <a href="http://www.pixelpilot.dk/Testdriven.htm">here</a> for workaround.</p>
						
		
		</div>

			
			
		<div class="FogBugzReleaseNotes">
				<h1>Release Notes - TestDriven.NET: 2.6</h1>

								<h2>952: Add support for Orcas Express (C#, VB, J# and C++)</h2>
								<p>Note: Properties tool window must be open for TestDriven.NET to activate itself.</p>
					
								<h2>951: Update to NCover 1.5.8 Beta</h2>
								<p>Include new build of NCover in package.</p>					
						
								<h2>943: "Test With... Coverage" Hangs</h2>
								<p>Fixed
bug where "Test With... Coverage" would hang if there were too many
assemblies with PDB information referenced by a project.</p>
						
								<h2>945: NUnit 2.4 extensions aren't working</h2>
								<p>In
this version you must create a directory at '\Program
Files\TestDriven.NET 2.0\addins' for NUnit extensions (this is a
temporary solution).</p>
						
								<h2>950: Ignored tests displayed as errors in task/error list</h2>
								<p>Assert.Ignore(...) now shows up correctly as a warning in&nbsp; Error List.</p>
						
		</div>



		   <div class="FogBugzReleaseNotes">
				<h1>Release Notes - TestDriven.NET: 2.5</h1>

				<h2>921: Add support for NUnit 2.4 Final Release</h2>
				<p>See <a href="http://sourceforge.net/mailarchive/forum.php?thread_name=000601c76918%247820de20%246401a8c0%40FERRARI&amp;forum_name=nunit-users">here</a> for more information.</p>

				<h2>922: Add support for NUnit 2.2.10 Release</h2>
				<p>See <a href="http://sourceforge.net/mailarchive/forum.php?thread_name=00e201c76819%24f73909d0%246401a8c0%40FERRARI&amp;forum_name=nunit-users">here</a> for more information.</p>

				<h2>924: Add support for Express SKU (C#, VB, J# and C++)</h2>
				<p>To activate TestDriven.NET when using the Express SKU - ensure that the 'Properties' tool window is visible and select any item on the 'Solution Explorer' view.</p>
			</div>


			<div class="FogBugzReleaseNotes">

				<h1>Release Notes - TestDriven.NET: 2.4</h1>

				<h2>901: Use NUnit 2.4 when executing tests that reference 'nunit.framework' 2.3.*/2.4.*</h2>
				<p>Added support for version ranges when selecting the correct test runner for a given framework assembly.</p>
		
				<h2>907: Include NUnit 2.4 RC2</h2>
				<p>Build against NUnit 'Release-2-4-Current' tagged version.</p>
		
				<h2>908: Strange assert message formatting in NUnit 2.4</h2>
				<p>Added workaround for change in assert message formatting between NUnit 2.2 and NUnit 2.4.</p>
		
				<h2>898: MSTest ClassInitialize methods not working in VS2005 SP1 / Orcas</h2>
				<p>MSTest support is now working with VS2005 Team editions and Orcas.</p>									
		
				<h2>899: Can't run all tests in a namespace</h2>
				<p>Running all tests in a namespace was broken during the move from NUnit 2.2.8 to NUnit 2.2.9. This is now fixed.</p>

			</div>	


			<div id=FogBugzReleaseNotes>
			<H1>Release Notes - TestDriven.NET: 2.3</H1>
			<H2>673: Test With... Mono</H2>
			<P>When Mono is installed a 'Test With... Mono' option will appear on the menus. 
			This has been tested with Mono 1.2.3.</P>
			<H2>886: App.config files don't work when testing with Mono</H2>
			<P>Mono only works with app domain config files that end with '.config'. Added 
			workaround that makes temporary config file end with '.temp.config' not 
			'.config.temp'.</P>
			</div>

			<div class="FogBugzReleaseNotes">
			
				
					<h1>Release Notes - TestDriven.NET: 2.2</h1>
						
									<h2>833: Fix for use with Reflector 5.0</h2>
									<p>Added support for Reflector 5.0 Beta (with with C# 3.0/Linq support).</p>
							
									<h2>835: Add support for Visual Studio Orcas</h2>
									<p>Register add-in for use with Visual Studio Orcas (tested with Jan 2007 CTP version).</p>
							
									<h2>846: Icons aren't uninstalled from Visual Studio 2005/Orcas</h2>
									<p>Icons were only being uninstalled correctly from VS2005 if VS2003 was also installed.</p>
							
									<h2>758: Abort test while on breakpoint causes deadlock</h2>
									<p>Ensure that debugger is detached before aborting the test thread.</p>
							
									<h2>817: Ensure that "Go to Reflector" appears underneath "Run Test(s)" on Solution node</h2>
									<p>Make 'Go To Reflector' default to appear at bottom of solution context menu.</p>
							
									<h2>829: Empty Test with Coverage</h2>
									<p>Fixed issue where NCover coverage report would appear empty in NCoverExplorer.</p>
							
			</div>	
		



	   <div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.1</h1>
					
								<h2>795: Add 'Go To Source Code' command to Reflector</h2>
								<p>Jump from any code element in Reflector to corresponding source code in Visual Studio.</p>
						
								<h2>796: Add 'Go To Reflector' button to Project menu</h2>
								<p>Right click on Project in the 'Solution Explorer' to load into Reflector.</p>
						
								<h2>797: Add 'Go To Reflector' button to Solution menu</h2>
								<p>Right
click on Solution node in the 'Solution Explorer' to load all projects
into Reflector (useful when searching whole solution).</p>
						
								<h2>806: Include NCover 1.5.7</h2>
								<p>Grant Drake had done many fixes in NCover 1.5.7</p>
						
								<h2>807: Add option to use PDB info with 'Go To Source Code'</h2>
								<p>If
source code isn't part of Visual Studio solution then use PDB info if
available to find source file and location for method (useful when
debugging).</p>
						
								<h2>700: Add support for JetBrains dotTrace profiler</h2>
								<p>'Test With... dotTrace' option will appear when dotTrace is installed.</p>
						
								<h2>751: 'Coverage' button still shows when NCover/NCoverExplorer isn't installed</h2>
								<p>Don't show 'Test With... Coverage' option when NCoverExplorer isn't installed.</p>
							</div>	
						
		





	   <div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.0 RTM</h1>
					
								<h2>772: Can't run ad-hoc tests in NUnit project</h2>
								<p>Stopped 'No fixture attribute on parent class' warning when executing a non-test method in NUnit test project.</p>
						
								<h2>317: Run Test(s) not working - Private NUnit fixtures</h2>
								<p>Warn
when attempting to run a private test fixture or test. Before the test
would be executed as an ad-hoc test without any setup/teardown methods
being called.</p>
						
								<h2>567: Install TestDriven.NET for all users when runnign as Administrator</h2>
								<p>When running as user in Administrator role, install for all users rather than just current user. This fixes installing on Vista.</p>
						
								<h2>569: Ship NCover with TestDriven.NET</h2>
								<p>NCover
is now shipped as part of the TestDriven.NET installer. NCover 1.3.3
and 1.5.6 are included. NCover 1.5 will be used if .NET 2.0 is
installed (works with Visual Studio 2002, 2003 and 2005). NCover 1.3
will be used if only .NET 1.1 is installed. Thanks to Peter Waldschmidt
for allowing me to ship a non-GPL version of NCover with TestDriven.NET!</p>
						
								<h2>153: Add option to build and test with .NET 1.1/MSBee when using VS2005</h2>
								<p>When using Visual Studio 2005 there is an option to build and run tests using .NET 1.1.</p>
						
								<h2>275: Exceptions in test fixture setup/teardown not reported</h2>
								<p>Output any exceptions thrown in fixture SetUp/TearDown.</p>
						
								<h2>619: Add 'Repeat Test Run' to Solution Explorer menus</h2>
								<p>Made all menus with unit testing functionality consistent.</p>
						
								<h2>629: Activate 'Test' pane at end of run</h2>
								<p>Activate the 'Test' pane at the end of a test run so test results are visible after 'Test With... Debugger'.</p>
						
								<h2>637: Output window is activated on test run in VS2003 but not VS2005</h2>
								<p>Always
make output window visible on test run unless window is set to auto
hide. Use 'Projects and Solutions\Show Output window when build starts'
option if you want 'Output' window to pop up when set to auto hide.</p>
						
								<h2>647: Warn when no test runner is found to run test(s)</h2>
								<p>Added warning when attempting to run a fixture with attributes from an unknown/not-installed unit testing framework.</p>
						
								<h2>697: Add an easy way to switch between NCover and Team Coverage</h2>
								<p>Show NCover 'Coverage' and 'Team Coverage' options on the 'Test With' menus when code coverage tools are available for use.</p>
						
								<h2>701: Only show menu items for available test runners</h2>
								<p>Only
show test runners on 'Test With' menus that are available to use use
(i.e. appropriate applications are installed). For example NCover, Team
Coverage, TypeMock and .NET 1.1 (MSBee) will only appear when available
for use.</p>
						
								<h2>704: Enable unmanaged code debugging</h2>
								<p>Added
support for mixed mode and unmanaged debugging. 'Test With... Debugger'
will use the 'Enable unmanaged code debugging' or 'Debugger Type'
settings for the test project. The C++ debugger type 'Auto'&nbsp; will
always default to managed.</p>
						
								<h2>705: Add (hidden) support for 'Test With... E&amp;C'</h2>
								<p>To
enable 'Test With... Debugger (E&amp;C)' that works with Edit &amp;
Continue; edit the 'TestDriven.dll.config' file and uncomment
&lt;button command="DebuggerEaC" /&gt;. This test runner may 'touch'
project files when used with source control (this is why it's disabled
by default).</p>
						
								<h2>708: No warning when tests project has broken App.config file</h2>
								<p>An appropriate warning will be output when the 'App.config' file of a test project contains invalid XML.</p>
						
								<h2>716: Add Reflector to Tools menu</h2>
								<p>Added
'Go To Reflector' button to Tools menu. Select a solution or project in
the 'Solution Explorer' and hit 'Tools\Go To Reflector' to load project
assemblies into Reflector. 'Go To Reflector' can be used from many
different window contexts.</p>
						
								<h2>717: Show Breakpoints Tool Window on Reflector 'Toogle Breakpoint'</h2>
								<p>Show breakpoints when a breakpoint is toggled from inside Reflector (right click on a method and 'Toggle Breakpoint').</p>
						
								<h2>720: Add 'Go To Reflector' option to 'Modules' window </h2>
								<p>One or more modules can be selected inside the debugger 'Modules' window and opened inside Reflector.</p>
						
								<h2>721: Add 'Go To Reflector' option to 'References'</h2>
								<p>One of more project references can be selected and opened inside Reflector.</p>
						
								<h2>724: Allow property get to method to be executed as ad-hoc test</h2>
								<p>Property get methods can now be executed as ad-hoc tests.</p>
						
								<h2>737: Testing a folder's worth of test fixtures</h2>
								<p>Run
each test fixture in the folder as a separate test run rather than
assuming the folder exactly corresponds to a namespace. Only the first
class in each source file will be executed as a fixture.</p>
						
								<h2>661: Rename 'Test With...' to simply 'Test With'</h2>
								<p>Changed to conform with menu naming conventions.</p>
						
								<h2>670: Use installed NCover unless packaged version is newer</h2>
								<p>Give priority to installed versions of NCover that are newer than the built in version.</p>
						
								<h2>688: Add support for running NCover with TypeMock</h2>
								<p>Added
support for testing with code coverage when TypeMock is enabled. Simply
use 'Test With... Coverage' when the TypeMock add-in is enabled.</p>
						
								<h2>694: Tests not running in 64 bit mode</h2>
								<p>Honor
'x86', 'x64' or 'Itanium' platform setting of test project. If platform
is set to 'Any CPU' then tests will default to running in 64 bit
process.</p>
						
								<h2>695: Add 'Test With... TypeMock' support</h2>
								<p>Added
option to 'Test With... TypeMock'. This allows TypeMock to only be used
on tests that require it (when the TypeMock add-in is disabled). Tests
that don't require TypeMock run faster when TypeMock is disabled.</p>
						
								<h2>276: Problem with 'Test With...Debugger' + SourceGear Vault in VS.NET 2005</h2>
								<p>Use
much faster 'Test With... Debugger' functionality when running under
Visual Studio 2005 that doesn't touch project files and interfere with
source control.</p>
						
								<h2>590: TestDriven.NET 1.0 and TestDriven.NET 2.0 GUID/ProgID</h2>
								<p>Made
more robust when faced with possible left over registry entries from
previous installs (e.g if an uninstall was forced using msizap).</p>
						
								<h2>605: Test With Coverage fails when running as non-admin</h2>
								<p>'Team
Coverage' test runner is only available when running as Administrator
user. NCover 'Coverage' test runner will work when running as Limited
User.</p>
						
								<h2>652: Go To Reflector problems (proxy config and loading service)</h2>
								<p>Preserve
important Reflector configuration settings when using an already
installed version of Reflector. Use proper download dialog to obtain
Reflector on first use. Thanks to Grant Drake for contributing this
feature!</p>
						
								<h2>653: Old TestDriven.NET 1.0 menus remain in VS2005</h2>
								<p>Remove any menus that might be left over from previous versions of TestDriven.NET.</p>
						
								<h2>640: Assemblies in Reflector aren't reloaded after build</h2>
								<p>Reload assemblies when 'Go To Reflector' is called if the assembly has changed.</p>
						
								<h2>636: An existing connection was forcibly closed by the remote host</h2>
								<p>Fixed issue where test process would exit without warning when stepping through test code.</p>
						
								<h2>748: Only outermost exception is shown</h2>
								<p>Show stack trace of outermost exception when nested exception is thrown from MSTest fixture.</p>
						
								<h2>750: Installed to correct folder when doing silent install</h2>
								<p>Use default 'TestDriven.NET 2.0' directory when doing slient install ("start /wait TestDriven.NET-YOUR_VERSION.exe /q").</p>
						
								<h2>696: Repeat Test Run with Debugger building wrong assemblies</h2>
								<p>Fixed issue where 'Repeat Test Run' would build wrong assemblies when testing with debugger on Visual Studio 2002/2003.</p>
						
								<h2>693: Requested Service not found</h2>
								<p> Fixed timeout if a individual test runs for more than ~6 minutes.</p>
						
								<h2>687: Team Explorer stalls uninstall</h2>
								<p>Prevent 'Team Explorer' login from stalling uninstall.</p>
						
								<h2>666: Reflector 'Toggle Breakpoint' doesn't work when only VS2005 is installed</h2>
								<p>Fixed error loading Reflector add-in when launching from Visual Studio 2005.</p>
						
								<h2>764: No warning when trying to run test in ASP.NET WebSite </h2>
								<p>Executing tests in Web Site projects aren't supported in TestDriven.NET 2.0. Display warning in output window.</p>
						
								<h2>767: Use new MbUnit icon</h2>
								<p>Note MbUnit is now a separate install (see www.mbunit.org).</p>
							</div>	
						
		






	   <div class="FogBugzReleaseNotes">

			
				<h1>Release Notes - TestDriven.NET: 2.0 RC1</h1>
					
								<h2>575: Add 'Go To Reflector' option to 'Code', 'Disassembly' and 'Call Stack' windows</h2>
								<p>Added 'Go To Reflector' to 'Code', 'Disassembly' and 'Call Stack' context menus.</p>
						
								<h2>577: Toggle breakpoint on any method from inside Reflector.</h2>
								<p>Using
.NET Reflector right click on any method and 'Toggle Breakpoint' to add
a VS breakpoint. Be sure to dissable 'Just My Code' (under
'Tools/Options.../Debugging') if using VS2005.</p>
						
								<h2>255: Unhandled exceptions crash test process in .NET 2.0</h2>
								<p>Fixed
so that unhandled exceptions no longer abort the process but instead
output their thread name, exception message and stack trace (output
message only appears when using .NET 2.0).</p>
						
								<h2>559: Repeat last test run</h2>
								<p>Added support for 'Repeat Test Run'. Tests will be executed with the last used test runner (default, debug, coverage etc.).</p>
						
								<h2>609: New 'Test With... Debugger' implementation for VS2005</h2>
								<p>When
using VS2005, 'Test With... Debugger' will launch as quickly as the
default 'Run Test(s)' implementation. It won't touch the project files
or add a temporary 'surrogate' project.</p>
						
								<h2>620: Multiple test suite summary not shown in status bar</h2>
								<p>When multiple test suites are executed a summary will be displayed in the status bar.</p>
						
								<h2>571: 'Default Start Unit Tests' feature breaks 'Test With... Debugger'</h2>
								<p>This feature was too experimental to release as part of TestDriven.NET 2.0 RTM.</p>
						
								<h2>324: Testdriven.NET wants to checkout the project from VSS</h2>
								<p>In
VS2005 'Test With... Debugger' will no longer touch the project file
(previous versions needed to disable VS hosting process).</p>
						
								<h2>583: Visual Studio 2005 Web Application Projects and test with debugger</h2>
								<p>'Test With... Debugger' now works with VS2005 'Web Application' projects (not 'Web Site' projects).</p>
						
								<h2>546: Pending changes still contains the added *.Surrogate project</h2>
								<p>'Test With... Debugger' no longer requires a 'surrogate' project when executing tests in an MSTest project.</p>
							</div>	
						
		






	   <div class="FogBugzReleaseNotes">

				<h1>Release Notes - TestDriven.NET: 2.0 Beta 2</h1>
					
								<h2>427: 64-bit support</h2>
								<p>Added support for running tests in 64 bit process. The test runner will honor the test assembly's 32bit flag.</p>
						
								<h2>375: Latest release of NUnit</h2>
								<p>Now using NUnit 2.2.8.</p>
						
								<h2>448: Warn before a version that works with the Express SKU is uninstalled</h2>
								<p>Added warning before uninstall for people who may be using the Express SKU support in previous versions.</p>
						
								<h2>522: Command bar buttons not showing on 'Solution Explorer' project node</h2>
								<p>Fixed issue that could stop TestDriven.NET's command bar buttons from being installed on some menus.</p>
						
								<h2>550: Menus missing in some non-US/UK cultures</h2>
								<p>Fixed big that caused some 'Test With...' menu buttons to be missing in cultures that use ',' for decimal point.</p>
						
								<h2>560: Can't 'Test With... Debugger' when project name same as solution folder name</h2>
								<p>'Test With... Debugger' now works when a solution folder has the same name the test project</p>
						
								<h2>326: Include MSBee in TestDriven.Net installer</h2>
								<p>Added option to build and test using .NET 1.1 from Visual Studio 2005. Use the 'Test With... .NET 1.1' command.</p>
						
								<h2>310: Icons missing from the right click menus in VS2005</h2>
								<p>Fixed issue that could cause the wrong command bar button icons to display on some machines.</p>
						
								<h2>228: Clear 'ComPlus_Version' environment variable in test runner process</h2>
								<p>Ensure
that the 'ComPlus_Version' environment variable is cleared in test
process. This could cause spawned .NET processes to behave unexpectedly.</p>
						
								<h2>254: VS2005 / BI context menu bug</h2>
								<p>Fixed
issue with always visible grey command bar buttons when 'SQL Server
Analysis Services' was installed.&nbsp; You may need to delete
%APPDATA%\Microsoft\VisualStudio\8.0\1033\CmdUI.PRF</p>
						
								<h2>329: Failed tests do not show up in task list</h2>
								<p>Fixed
issue when using non-English localized versions of VS2005/.NET 2.0.
Stack traces of failing tests weren't double clickable or showing up in
the error list.</p>
						
								<h2>337: dotTrace 2.0 prevents TestDriven from running from within Visual Studio 2005</h2>
								<p>Stopped 'SerializationException' from being thrown when JetBrains dotTrace 2.0 is installed.</p>
						
								<h2>293: Build solution before running test</h2>
								<p>Fixed
issue where test project dependencies were not being compiled before
test run. This would only happen when an ASP.NET 2.0 Web Site project
was part of the solution.</p>
						
								<h2>289: Test Failure Messages not removed from ErrorList on Build</h2>
								<p>Clear test failures from error list before building for next test run.</p>
							</div>	
						
		
		
	    </body></html>
