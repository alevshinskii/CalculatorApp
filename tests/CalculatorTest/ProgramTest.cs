using ConsoleManager;

namespace Program.Test
{
    public class ProgramTest
    {
        [Fact]
        public void AddOperation()
        {
            ConsoleManagerStub m_ConsoleManager = new ConsoleManagerStub();
            ProgramManager.ProgramManager m_ProgramManager = new ProgramManager.ProgramManager(m_ConsoleManager);

            var num1 = "2";
            var num2 = "2";
            var operation = "a";
            var expectedResult = "4";

            m_ConsoleManager.UserInputs.Enqueue(num1);
            m_ConsoleManager.UserInputs.Enqueue(num2);
            m_ConsoleManager.UserInputs.Enqueue(operation);
            m_ConsoleManager.UserInputs.Enqueue("n");

            var expectedOutput = new List<string>
            {
                "Console Calculator in C#\r\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"2\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n\n\r\n",


                "E:\\projects\\CalculatorApp\\src\\Calculator\\bin\\Debug\\net6.0\\Calculator.exe (process 30356) exited with code 0.",
                "To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.",
                "Press any key to close this window . . ."
            };

            m_ConsoleManager.OutputsUpdated +=
                    outputEntryNumber =>
                    {
                        Assert.Equal(
                    expectedOutput[outputEntryNumber - 1],
                    m_ConsoleManager.ToString());
                    };

            m_ProgramManager.Run();
        }

        [Fact]
        public void SubtractOperation()
        {

            ConsoleManagerStub m_ConsoleManager = new ConsoleManagerStub();
            ProgramManager.ProgramManager m_ProgramManager = new ProgramManager.ProgramManager(m_ConsoleManager);

            var num1 = "2";
            var num2 = "1";
            var operation = "s";
            var expectedResult = "1";

            m_ConsoleManager.UserInputs.Enqueue(num1);
            m_ConsoleManager.UserInputs.Enqueue(num2);
            m_ConsoleManager.UserInputs.Enqueue(operation);
            m_ConsoleManager.UserInputs.Enqueue("n");

            var expectedOutput = new List<string>
            {
                "Console Calculator in C#\r\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"2\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n\n\r\n",


                "E:\\projects\\CalculatorApp\\src\\Calculator\\bin\\Debug\\net6.0\\Calculator.exe (process 30356) exited with code 0.",
                "To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.",
                "Press any key to close this window . . ."
            };

            m_ConsoleManager.OutputsUpdated +=
                    outputEntryNumber =>
                    {
                        Assert.Equal(
                    expectedOutput[outputEntryNumber - 1],
                    m_ConsoleManager.ToString());
                    };

            m_ProgramManager.Run();
        }

        [Fact]
        public void DivideOperation()
        {
            ConsoleManagerStub m_ConsoleManager = new ConsoleManagerStub();
            ProgramManager.ProgramManager m_ProgramManager = new ProgramManager.ProgramManager(m_ConsoleManager);

            var num1 = "6";
            var num2 = "2";
            var operation = "d";
            var expectedResult = "3";

            m_ConsoleManager.UserInputs.Enqueue(num1);
            m_ConsoleManager.UserInputs.Enqueue(num2);
            m_ConsoleManager.UserInputs.Enqueue(operation);
            m_ConsoleManager.UserInputs.Enqueue("n");

            var expectedOutput = new List<string>
            {
                "Console Calculator in C#\r\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"2\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n\n\r\n",


                "E:\\projects\\CalculatorApp\\src\\Calculator\\bin\\Debug\\net6.0\\Calculator.exe (process 30356) exited with code 0.",
                "To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.",
                "Press any key to close this window . . ."
            };

            m_ConsoleManager.OutputsUpdated +=
                    outputEntryNumber =>
                    {
                        Assert.Equal(
                    expectedOutput[outputEntryNumber - 1],
                    m_ConsoleManager.ToString());
                    };

            m_ProgramManager.Run();
        }

        [Fact]
        public void MultiplyOperation()
        {
            ConsoleManagerStub m_ConsoleManager = new ConsoleManagerStub();
            ProgramManager.ProgramManager m_ProgramManager = new ProgramManager.ProgramManager(m_ConsoleManager);

            var num1 = "6";
            var num2 = "2";
            var operation = "m";
            var expectedResult = "12";

            m_ConsoleManager.UserInputs.Enqueue(num1);
            m_ConsoleManager.UserInputs.Enqueue(num2);
            m_ConsoleManager.UserInputs.Enqueue(operation);
            m_ConsoleManager.UserInputs.Enqueue("n");

            var expectedOutput = new List<string>
            {
                "Console Calculator in C#\r\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"2\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n\n\r\n",


                "E:\\projects\\CalculatorApp\\src\\Calculator\\bin\\Debug\\net6.0\\Calculator.exe (process 30356) exited with code 0.",
                "To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.",
                "Press any key to close this window . . ."
            };

            m_ConsoleManager.OutputsUpdated +=
                    outputEntryNumber =>
                    {
                        Assert.Equal(
                    expectedOutput[outputEntryNumber - 1],
                    m_ConsoleManager.ToString());
                    };

            m_ProgramManager.Run();
        }

        [Fact]
        public void OperationWithDouble()
        {
            ConsoleManagerStub m_ConsoleManager = new ConsoleManagerStub();
            ProgramManager.ProgramManager m_ProgramManager = new ProgramManager.ProgramManager(m_ConsoleManager);

            var num1 = "1.1";
            var num2 = "1.1";
            var operation = "a";
            var expectedResult = "2.2";

            m_ConsoleManager.UserInputs.Enqueue(num1);
            m_ConsoleManager.UserInputs.Enqueue(num2);
            m_ConsoleManager.UserInputs.Enqueue(operation);
            m_ConsoleManager.UserInputs.Enqueue("n");

            var expectedOutput = new List<string>
            {
                "Console Calculator in C#\r\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, and then press Enter: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"2\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ",

                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n",


                "Console Calculator in C#\r\r\n------------------------\n\r\n" +
                "Type a number, and then press Enter: "+num1+"\r\nType another number, " +
                "and then press Enter: "+num2+"\r\nChoose an operator from the following list:\r\n\t"+
                "a - Add\r\n\t"+
                "s - Subtract\r\n\t"+
                "m - Multiply\r\n\t"+
                "d - Divide\r\n"+
                "Your option? "+operation+"\r\n"+
                "Your result: "+expectedResult+"\n\r\n"+
                "------------------------\n\r\n"+
                "Press 'n' and Enter to close the app, or press any other key and Enter to continue: n\r\n\n\r\n",


                "E:\\projects\\CalculatorApp\\src\\Calculator\\bin\\Debug\\net6.0\\Calculator.exe (process 30356) exited with code 0.",
                "To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.",
                "Press any key to close this window . . ."
            };

            m_ConsoleManager.OutputsUpdated +=
                    outputEntryNumber =>
                    {
                        Assert.Equal(
                    expectedOutput[outputEntryNumber - 1],
                    m_ConsoleManager.ToString());
                    };

            m_ProgramManager.Run();
        }


    }
}
