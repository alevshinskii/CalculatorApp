
using System.Text.RegularExpressions;

namespace CalculatorProgram.Test
{
    public class ProgramTest
    {
        [Fact]
        public void ShouldDoAdditionWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "2";
            var num2 = "2";
            var operation = "a";

            var expectedResult = 4;
            

           console.Inputs.Enqueue(num1);
           console.Inputs.Enqueue(num2);
           console.Inputs.Enqueue(operation);
           console.Inputs.Enqueue("n");

           program.StartCalculation();

           var expectedOutput =
               "Console Calculator in C#" +
               "------------------------" +
               "Type a number, and then press Enter: " +
               "Type another number, and then press Enter: " +
               "Choose an operator from the following list:" +
               "a - Add" +
               "s - Subtract" +
               "m - Multiply" +
               "d - Divide" +
               "Your option? " +
               "Your result: " + expectedResult.ToString()+
               "------------------------" +
               "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

           Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }
        
        [Fact]
        public void ShouldDoSubtractionWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "4";
            var num2 = "1";
            var operation = "s";

            var expectedResult = 3;
            

            console.Inputs.Enqueue(num1);
            console.Inputs.Enqueue(num2);
            console.Inputs.Enqueue(operation);
            console.Inputs.Enqueue("n");

            program.StartCalculation();

            var expectedOutput =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: " + expectedResult.ToString()+
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }

        [Fact]
        public void ShouldDoMultiplyWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "4";
            var num2 = "2";
            var operation = "m";

            var expectedResult = 8;
            

            console.Inputs.Enqueue(num1);
            console.Inputs.Enqueue(num2);
            console.Inputs.Enqueue(operation);
            console.Inputs.Enqueue("n");

            program.StartCalculation();

            var expectedOutput =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: " + expectedResult.ToString()+
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }

        [Fact]
        public void ShouldDoDivideWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "8";
            var num2 = "2";
            var operation = "d";

            var expectedResult = 4;
            

            console.Inputs.Enqueue(num1);
            console.Inputs.Enqueue(num2);
            console.Inputs.Enqueue(operation);
            console.Inputs.Enqueue("n");

            program.StartCalculation();

            var expectedOutput =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: " + expectedResult.ToString()+
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }

        [Fact]
        public void ShouldNotDoDivideOnZeroWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "8";
            var num2 = "0";
            var operation = "d";

            var expectedResult = 4;
            

            console.Inputs.Enqueue(num1);
            console.Inputs.Enqueue(num2);
            console.Inputs.Enqueue(operation);
            console.Inputs.Enqueue("n");

            program.StartCalculation();

            var expectedOutput =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "Type another number, and then press Enter: " +
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "This operation will result in a mathematical error."+
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }

        [Fact]
        public void ShouldNotDoCalculationWithInvalidInputWithMockConsole()
        {
            var program = new Program();
            var console = new ConsoleMock();

            program.MyConsole = console;

            var num1 = "8";
            var num2 = "2";
            var operation = "d";

            var expectedResult = 4;
            
            console.Inputs.Enqueue("pfpjspdojf");
            console.Inputs.Enqueue(num1);
            console.Inputs.Enqueue("123,>325");
            console.Inputs.Enqueue(num2);
            console.Inputs.Enqueue(operation);
            console.Inputs.Enqueue("n");

            program.StartCalculation();

            var expectedOutput =
                "Console Calculator in C#" +
                "------------------------" +
                "Type a number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: " +
                "Type another number, and then press Enter: " +
                "This is not valid input. Please enter an integer value: "+
                "Choose an operator from the following list:" +
                "a - Add" +
                "s - Subtract" +
                "m - Multiply" +
                "d - Divide" +
                "Your option? " +
                "Your result: " + expectedResult.ToString()+
                "------------------------" +
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";

            Assert.Equal(expectedOutput,Regex.Replace(console.Outputs.ToString(),@"[\r\t\n]+",String.Empty));

        }
    }
}
