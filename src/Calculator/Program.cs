using Ninject;
using System.Reflection;
using ConsoleManager;
using Ninject.Modules;
using ProgramManager;

namespace Calculator
{
    public class Program
    {        
        private static IProgramManager m_ProgramManager = null;


        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            m_ProgramManager = kernel.Get<IProgramManager>();
            m_ProgramManager.Run();
        }
        
        public class NinjectDependencyResolver : NinjectModule
        {
            public override void Load()
            {
                Bind<IConsoleManager>().To<ConsoleManager.ConsoleManager>();
                Bind<IProgramManager>().To<ProgramManager.ProgramManager>();
            }
        }

    }
}