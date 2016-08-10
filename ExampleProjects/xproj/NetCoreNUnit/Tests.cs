namespace NetCoreNUnit
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.Versioning;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void GetCurrentProcess_ProcessName_IsDotNet()
        {
            var currentProcess = Process.GetCurrentProcess();

            var processName = currentProcess.ProcessName;

            Assert.That(processName, Is.EqualTo("dotnet"));
        }

        [Test]
        public void GetCustomAttribute_FrameworkName_NETCoreApp()
        {
            var assembly = GetType().GetTypeInfo().Assembly;

            var targetFrameworkAttribute = assembly.GetCustomAttribute<TargetFrameworkAttribute>();

            Assert.That(targetFrameworkAttribute.FrameworkName, Is.EqualTo(".NETCoreApp,Version=v1.0"));
        }
    }
}
