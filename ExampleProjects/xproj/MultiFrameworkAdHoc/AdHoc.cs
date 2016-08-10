namespace MultiFrameworkAdHoc
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
#if !NET451
    using System.Runtime.Loader;
#endif

    // Try running these methods with `Test With > .NET Framework`, `Test With > .NET Core` and `Test With > In-Proc`.
    public class AdHoc
    {
        void dumpModules()
        {
            foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
            {
                Console.WriteLine(module.FileName);
            }
        }

        void dumpAssemblies()
        {
            foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
            {
                var assemblyName = tryGetAssemblyName(module.FileName);
                if(assemblyName != null)
                {
                    Console.WriteLine(assemblyName);
                }
            }
        }

        static AssemblyName tryGetAssemblyName(string file)
        {
            try
            {
#if NET451
                return AssemblyName.GetAssemblyName(file);
#else
                return AssemblyLoadContext.GetAssemblyName(file);
#endif
            }
            catch (BadImageFormatException e)
            {
                return null;
            }
        }
    }
}
