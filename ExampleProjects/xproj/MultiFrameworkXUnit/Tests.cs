namespace MultiFrameworkXUnit
{
    using System;
    using System.Reflection;
    using System.Runtime.Versioning;
    using Xunit;

    public class Tests
    {
        // Which framework is used depends on `frameworks` element in `project.json`:
        // Test should pass using `Test With > .NET Framework` (defaults to first .NET Framework defined)
        // Test should fail using `Test With > .NET Core` (defaults to first .NET Core)
        // Test should pass using `Run Test(s)` (defaults to first framework)
        // Test should pass using `Test With > Debugger` (defaults to first framework)
        [Fact]
        public void GetCustomAttribute_FrameworkName_NETFramework()
        {
            var assembly = GetType().GetTypeInfo().Assembly;

            var targetFrameworkAttribute = assembly.GetCustomAttribute<TargetFrameworkAttribute>();

            Assert.Equal(".NETFramework,Version=v4.5.1", targetFrameworkAttribute.FrameworkName);
        }
    }

}
