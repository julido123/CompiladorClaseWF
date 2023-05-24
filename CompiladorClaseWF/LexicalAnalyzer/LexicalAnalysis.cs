using CompiladorClaseWF.CrossCutting;
using CompiladorClaseWF.DataCache;
using CompiladorClaseWF.ErrorManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.LexicalAnalyzer
{
    public class LexicalAnalysis
    {
        private readonly static LexicalAnalysis INSTANCE = new LexicalAnalysis();
        private int CurrentState;
        private string Lexeme;
        private bool Continue;
        private LexicalComponent Component;


        public static LexicalAnalysis GetInstance() { return INSTANCE; }
        public static void Initialize()
        {
            Scanner.Initialize();
            TablaMaestra.Inicializar();
            ErrorManagement.Inicializar();
        }

        private static void Restart()
        {
            INSTANCE.CurrentState = 0;
            INSTANCE.Lexeme = "";
            INSTANCE.Continue = true;
        }

        private static void Concanate()
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + Scanner.GetCurrentCharacter();
        }

        private static void Concanate(string character)
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + character;
        }

        private static void DevourBlankCharacter()
        {
            Scanner.ReadNextCharacter();

            while (" ".Equals(Scanner.GetCurrentCharacter()))
            {
                Scanner.ReadNextCharacter();
            }
        }


        public static LexicalComponent Analyze()
        {
            Restart();

            while (INSTANCE.Continue)
            {
                if (INSTANCE.CurrentState == 0)
                {
                    ProcessState0();
                }
                if (INSTANCE.CurrentState == 1)
                {
                    ProcessState1();
                }
                if (INSTANCE.CurrentState == 2)
                {
                    ProcessState2();
                }
                if (INSTANCE.CurrentState == 3)
                {
                    ProcessState3();
                }
                if (INSTANCE.CurrentState == 4)
                {
                    ProcessState4();
                }
                if (INSTANCE.CurrentState == 5)
                {
                    ProcessState5();
                }
                if (INSTANCE.CurrentState == 6)
                {
                    ProcessState6();
                }
                if (INSTANCE.CurrentState == 7)
                {
                    ProcessState7();
                }
                if (INSTANCE.CurrentState == 8)
                {
                    ProcessState8();
                }
                if (INSTANCE.CurrentState == 9)
                {
                    ProcessState9();
                }
                if (INSTANCE.CurrentState == 10)
                {
                    ProcessState10();
                }
                if (INSTANCE.CurrentState == 11)
                {
                    ProcessState11();
                }
                if (INSTANCE.CurrentState == 12)
                {
                    ProcessState12();
                }
                if (INSTANCE.CurrentState == 13)
                {
                    ProcessState13();
                }
                if (INSTANCE.CurrentState == 14)
                {
                    ProcessState14();
                }
                if (INSTANCE.CurrentState == 15)
                {
                    ProcessState15();
                }
                if (INSTANCE.CurrentState == 16)
                {
                    ProcessState16();
                }
                if (INSTANCE.CurrentState == 17)
                {
                    ProcessState17();
                }
                if (INSTANCE.CurrentState == 18)
                {
                    ProcessState18();
                }
                if (INSTANCE.CurrentState == 19)
                {
                    ProcessState19();
                }
                if (INSTANCE.CurrentState == 20)
                {
                    ProcessState20();
                }
                if (INSTANCE.CurrentState == 21)
                {
                    ProcessState21();
                }
                if (INSTANCE.CurrentState == 22)
                {
                    ProcessState22();
                }
                if (INSTANCE.CurrentState == 23)
                {
                    ProcessState23();
                }
                if (INSTANCE.CurrentState == 24)
                {
                    ProcessState24();
                }
                if (INSTANCE.CurrentState == 25)
                {
                    ProcessState25();
                }
                if (INSTANCE.CurrentState == 26)
                {
                    ProcessState26();
                }
                if (INSTANCE.CurrentState == 27)
                {
                    ProcessState27();
                }
                if (INSTANCE.CurrentState == 28)
                {
                    ProcessState28();
                }
                if (INSTANCE.CurrentState == 29)
                {
                    ProcessState29();
                }
                if (INSTANCE.CurrentState == 30)
                {
                    ProcessState30();
                }
                if (INSTANCE.CurrentState == 31)
                {
                    ProcessState31();
                }
                if (INSTANCE.CurrentState == 32)
                {
                    ProcessState32();
                }
                if (INSTANCE.CurrentState == 33)
                {
                    ProcessState33();
                }
                if (INSTANCE.CurrentState == 34)
                {
                    ProcessState34();
                }
                if (INSTANCE.CurrentState == 35)
                {
                    ProcessState35();
                }
                if (INSTANCE.CurrentState == 36)
                {
                    ProcessState36();
                }


            }

            TablaMaestra.Add(INSTANCE.Component);
            return INSTANCE.Component;
        }

        private static void ProcessState0()
        {
            DevourBlankCharacter();

            if (IsLetter() || IsCurrency() || IsUnderline())
            {
                Concanate();
                INSTANCE.CurrentState = 4;
            }
            else if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 1;
            }
            else if (IsAddition())
            {
                Concanate();
                INSTANCE.CurrentState = 5;
            }
            else if (IsMinus())
            {
                Concanate();
                INSTANCE.CurrentState = 6;
            }
            else if (IsMultiplication())
            {
                Concanate();
                INSTANCE.CurrentState = 7;
            }
            else if (IsLeftParenthesis())
            {
                Concanate();
                INSTANCE.CurrentState = 10;
            }
            else if (IsRightParenthesis())
            {
                Concanate();
                INSTANCE.CurrentState = 11;
            }
            else if (IsSlash())
            {
                Concanate();
                INSTANCE.CurrentState = 33;
            }
            else if (IsEndOfFile())
            {
                INSTANCE.CurrentState = 12;
            }
            else if (IsEndOfLine())
            {
                INSTANCE.CurrentState = 13;
            }
            else
            {
                INSTANCE.CurrentState = 18;
            }
        }

       private static void ProcessState1()
        {
            Scanner.ReadNextCharacter();

            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 1;
            }
            else if (IsComma())
            {
                Concanate();
                INSTANCE.CurrentState = 2;
            }
            else
            {
                INSTANCE.CurrentState = 14;
            }
        }

        private static void ProcessState2()
        {
            Scanner.ReadNextCharacter();

            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 3;
            }
            else
            {
                INSTANCE.CurrentState = 17;
            }
        }

        private static void ProcessState3()
        {
            Scanner.ReadNextCharacter();

            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 3;
            }
            else
            {
                INSTANCE.CurrentState = 15;
            }
        }


        private static void ProcessState4()
        {
            Scanner.ReadNextCharacter();

            if (IsLetter() || IsCurrency() || IsUnderline() || IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 4;
            }
            else
            {
                INSTANCE.CurrentState = 16;
            }
        }

        private static void ProcessState5()
        {
            CreateComponentWithoutReturnIndex(Category.SUMA, ComponentType.NORMAL);
        }

        private static void ProcessState6()
        {
            CreateComponentWithoutReturnIndex(Category.RESTA, ComponentType.NORMAL);
        }

        private static void ProcessState7()
        {
            CreateComponentWithoutReturnIndex(Category.MULTIPLICACION, ComponentType.NORMAL);
        }
        private static void ProcessState8()
        {
            Scanner.ReadNextCharacter();

            if (IsMultiplication())
            {
                Concanate();
                INSTANCE.CurrentState = 34;
            }
            else if (IsSlash())
            {
                Concanate();
                INSTANCE.CurrentState = 36;
            }
            else
            {
                INSTANCE.CurrentState = 33;
            }
        }
        private static void ProcessState9()
        {
            CreateComponentReturningIndex(Category.MODULO, ComponentType.NORMAL);
        }

        private static void ProcessState10()
        {
            CreateComponentReturningIndex(Category.PARENTESIS_QUE_ABRE, ComponentType.NORMAL);
        }
        private static void ProcessState11()
        {
            CreateComponentReturningIndex(Category.PARENTESIS_QUE_CIERRA, ComponentType.NORMAL);
        }
        private static void ProcessState12()
        {
            CreateComponentWithoutReturnIndex(Category.EOF, ComponentType.NORMAL);
        }
        private static void ProcessState13()
        {
            Scanner.LoadNextLine();
            Restart();
        }

        private static void ProcessState14()
        {
            CreateComponentReturningIndex(Category.ENTERO, ComponentType.NORMAL);
        }

        private static void ProcessState15()
        {
            CreateComponentReturningIndex(Category.DECIMAL, ComponentType.NORMAL);
        }
        private static void ProcessState16()
        {
            CreateComponentReturningIndex(Category.IDENTIFICADOR, ComponentType.NORMAL);
        }
        private static void ProcessState17()
        {
            string fail = "Número decimal no válido...";
            string cause = "Se ha recibido un caracter que no corresponde a un dígito...";
            string solution = "Asegúrese de que luego del separador decimal, continue un dígito...";
            CreateLexicalError(ErrorType.CONTROLABLE, fail, cause, solution, Category.DECIMAL,
                INSTANCE.Lexeme + Scanner.GetCurrentCharacter());

            Concanate("0");
            CreateComponentReturningIndex(Category.DECIMAL, ComponentType.DUMMY);
        }

        private static void ProcessState18()
        {
            string fail = "Componente léxico no válido...";
            string cause = "Se ha recibo un símbolo desconocido por el lenguaje...";
            string solution = "Asegúrese de que sólo existan símbolos aceptados por el lenguaje...";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                Scanner.GetCurrentCharacter());
        }


        private static void ProcessState19()
        {
            CreateComponentWithoutReturnIndex(Category.IGUAL_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState20()
        {
            Scanner.ReadNextCharacter();
            if (IsEqualTo(">"))
            {
                Concanate();
                INSTANCE.CurrentState = 23;
            }
            else if (IsEqualTo("="))
            {
                Concanate();
                INSTANCE.CurrentState = 24;
            }
            else
            {
                INSTANCE.CurrentState = 25;
            }
        }
        private static void ProcessState21()
        {
            Scanner.ReadNextCharacter();
            if (IsEqualTo("="))
            {
                Concanate();
                INSTANCE.CurrentState = 26;
            }
            else
            {
                INSTANCE.CurrentState = 27;
            }
        }

        private static void ProcessState22()
        {
            Scanner.ReadNextCharacter();
            if (IsEqualTo("="))
            {
                Concanate();
                INSTANCE.CurrentState = 28;
            }
            else
            {
                INSTANCE.CurrentState = 29;
            }
        }

        private static void ProcessState23()
        {
            CreateComponentWithoutReturnIndex(Category.DIFERENTE_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState24()
        {
            CreateComponentWithoutReturnIndex(Category.MENOR_IGUAL_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState25()
        {
            CreateComponentReturningIndex(Category.MENOR_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState26()
        {
            CreateComponentWithoutReturnIndex(Category.MAYOR_IGUAL_QUE, ComponentType.NORMAL);
        }


        private static void CreateComponent(Category category, ComponentType type)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();
            int initialPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;
            int finalPosition = Scanner.GetCurrentIndex() - 1;

            if (ComponentType.NORMAL.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateNormalComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);
            }
            else if (ComponentType.DUMMY.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateDummyComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);
            }


        }

        private static void CreateLexicalError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Scanner.GetCurrentIndex() - 1;
                int finalPosition = Scanner.GetCurrentIndex() - 1;

                error = Error.CreateStopperLexicalError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);

                throw new Exception("Se ha presentado un error tipo STOPPER durante el anàlisis lèxico." +
                    " No es posible continuar con el proceso de compilaciòn hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener màs detalle del " +
                    "problema que se ha presentado...");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;
                int finalPosition = Scanner.GetCurrentIndex() - 1;


                error = Error.CreateNoStopperLexicalError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);
            }
        }

        private static void CreateComponentWithoutReturnIndex(Category category, ComponentType type)
        {
            INSTANCE.Continue = false;

            CreateComponent(category, type);
        }

        private static void CreateComponentReturningIndex(Category category, ComponentType type)
        {
            Scanner.ReturnIndex();
            INSTANCE.Continue = false;

            CreateComponent(category, type);
        }

        private static void ProcessState27()
        {
            CreateComponentReturningIndex(Category.MAYOR_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState28()
        {
            CreateComponentWithoutReturnIndex(Category.ASIGNACION, ComponentType.NORMAL);
        }
        private static void ProcessState29()
        {
            Concanate("0");
            CreateComponentReturningIndex(Category.ASIGNACION, ComponentType.NORMAL);
        }
        private static void ProcessState30()
        {
            Scanner.ReadNextCharacter();
            if (IsEqualTo("="))
            {
                Concanate();
                INSTANCE.CurrentState = 31;
            }
            else
            {
                INSTANCE.CurrentState = 32;
            }
        }
        private static void ProcessState31()
        {
            CreateComponentWithoutReturnIndex(Category.DIFERENTE_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState32()
        {
            Concanate("0");
            CreateComponentReturningIndex(Category.ASIGNACION, ComponentType.NORMAL);
        }
        private static void ProcessState33()
        {
            CreateComponentWithoutReturnIndex(Category.DIVISION, ComponentType.NORMAL);
        }

        private static void ProcessState34()
        {
            Scanner.ReadNextCharacter();
            if (IsMultiplication())
            {
                Concanate();
                INSTANCE.CurrentState = 34;
            }
            else
            {
                INSTANCE.CurrentState = 35;
            }
        }
        private static void ProcessState35()
        {
            Scanner.ReadNextCharacter();
            if (IsMultiplication())
            {
                Concanate();
                INSTANCE.CurrentState = 35;
            }
            else if (IsMultiplication() || IsSlash())
            {
                INSTANCE.CurrentState = 34;
            }
        }
        private static void ProcessState36()
        {

            Scanner.ReadNextCharacter();
            if (IsEndOfLine())
            {
                Concanate();
                INSTANCE.CurrentState = 13;
            }
            else
            {
                INSTANCE.CurrentState = 36;
            }
        }
        
        private static bool IsLetter()
        {
            return Char.IsLetter(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }
        private static bool IsDigit()
        {
            return Char.IsDigit(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }
        private static bool IsCurrency()
        {
            return "$".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsUnderline()
        {
            return "_".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsAddition()
        {
            return "+".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsMinus()
        {
            return "-".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsMultiplication()
        {
            return "*".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsComma()
        {
            return ",".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsSlash()
        {
            return "/".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsModule()
        {
            return "%".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsLeftParenthesis()
        {
            return "(".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsRightParenthesis()
        {
            return ")".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEqual()
        {
            return "=".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsColon()
        {
            return ":".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsGreaterThan()
        {
            return ">".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsLessThan()
        {
            return "<".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsExclamationMark()
        {
            return "!".Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEqualTo(String s)
        {
            return s.Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEndOfLine()
        {
            return "@FL@".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsEndOfFile()
        {
            return "@EOF@".Equals(Scanner.GetCurrentCharacter());
        }

    }
}
