using Calculator;
using ConsoleManager;

namespace ProgramManager
{
    public interface IProgramManager
    {
        void Run();
    }
    public abstract class ProgramManagerBase : IProgramManager
    {
        public abstract void Run();
    }
    public class ProgramManager : ProgramManagerBase
    {
        private readonly IConsoleManager m_ConsoleManager;

        public ProgramManager(IConsoleManager consoleManager)
        {
            m_ConsoleManager = consoleManager;
        }

        public override void Run()
        {
            string input;

            do
            {
                bool endApp = false;
                // Display title as the C# console calculator app.
                m_ConsoleManager.WriteLine("Console Calculator in C#\r");
                m_ConsoleManager.WriteLine("------------------------\n");

                while (!endApp)
                {
                    // Declare variables and set to empty.
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;

                    // Ask the user to type the first number.
                    m_ConsoleManager.Write("Type a number, and then press Enter: ");
                    numInput1 = m_ConsoleManager.ReadLine();

                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        m_ConsoleManager.Write("This is not valid input. Please enter an integer value: ");
                        numInput1 = m_ConsoleManager.ReadLine();
                    }

                    // Ask the user to type the second number.
                    m_ConsoleManager.Write("Type another number, and then press Enter: ");
                    numInput2 = m_ConsoleManager.ReadLine();

                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        m_ConsoleManager.Write("This is not valid input. Please enter an integer value: ");
                        numInput2 = m_ConsoleManager.ReadLine();
                    }

                    // Ask the user to choose an operator.
                    m_ConsoleManager.WriteLine("Choose an operator from the following list:");
                    m_ConsoleManager.WriteLine("\ta - Add");
                    m_ConsoleManager.WriteLine("\ts - Subtract");
                    m_ConsoleManager.WriteLine("\tm - Multiply");
                    m_ConsoleManager.WriteLine("\td - Divide");
                    m_ConsoleManager.Write("Your option? ");

                    string op = m_ConsoleManager.ReadLine();

                    try
                    {
                        result = Calculator.Calculator.DoOperation(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            m_ConsoleManager.WriteLine("This operation will result in a mathematical error.\n");
                        }
                        else m_ConsoleManager.WriteLine("Your result: "+result+"\n");
                    }
                    catch (Exception e)
                    {
                        //m_ConsoleManager.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    }

                    m_ConsoleManager.WriteLine("------------------------\n");

                    // Wait for the user to respond before closing.
                    m_ConsoleManager.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (m_ConsoleManager.ReadLine() == "n") endApp = true;

                    m_ConsoleManager.WriteLine("\n"); // Friendly linespacing.
                }
                return;
            }
            while (input != "1" && input != "2" && input != "Exit");
        }
    }
}
