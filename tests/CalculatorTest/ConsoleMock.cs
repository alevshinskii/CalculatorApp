using System.Text;

namespace CalculatorProgram.Test
{
    public class ConsoleMock : IConsole
    {
        public Queue<string> Inputs { get; set; } =new Queue<string>(); 
        public StringBuilder Outputs { get; set; }=new StringBuilder();

        public string ReadLine()
        {
            return Inputs.Dequeue();
        }

        public void Write(string message)
        {
            Outputs.Append(message);
        }

        public void WriteLine(string message)
        {
            Outputs.AppendLine(message);
        }
    }
}