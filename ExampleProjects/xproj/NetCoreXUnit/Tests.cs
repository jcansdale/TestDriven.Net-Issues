namespace NetCoreXUnit
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.Versioning;
    using Xunit;

    public class Tests
    {
        [Fact]
        public void GetCurrentProcess_ProcessName_IsDotNet()
        {
            var currentProcess = Process.GetCurrentProcess();

            var processName = currentProcess.ProcessName;

            Assert.Equal("dotnet", processName);
        }

        [Fact]
        public void GetCustomAttribute_FrameworkName_NETCoreApp()
        {
            var assembly = GetType().GetTypeInfo().Assembly;

            var targetFrameworkAttribute = assembly.GetCustomAttribute<TargetFrameworkAttribute>();

            Assert.Equal(".NETCoreApp,Version=v1.0", targetFrameworkAttribute.FrameworkName);
        }
    }
}
