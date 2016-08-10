namespace NetFrameworkXUnit
{
    using System;
    using Xunit;
    using Xunit.Abstractions;

    public class Tests
    {
        readonly ITestOutputHelper output;

        public Tests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void WriteLine()
        {
            var setup = AppDomain.CurrentDomain.SetupInformation;
            var targetFrameworkName = setup.TargetFrameworkName;
            output.WriteLine(targetFrameworkName);
        }

        [Fact]
        public void SetupInformation_TargetFrameworkName_IsNETFramework()
        {
            var setup = AppDomain.CurrentDomain.SetupInformation;

            var targetFrameworkName = setup.TargetFrameworkName;

            Assert.Equal(".NETFramework,Version=v4.5.1", targetFrameworkName);
        }
    }
}
