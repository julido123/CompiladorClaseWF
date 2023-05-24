using CompiladorClaseWF.DataCache;
using CompiladorClaseWF.ErrorManager;
using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.SintacticAnalyzer
{
    public class SintacticAnalysis
    {
        private LexicalComponent Component;
        private Stack<double> StackData = new Stack<double>();

        public string Analyze()
        {
            string response = "El proceso de análisis sintáctico finalizó exitosamente...";
            LexicalAnalysis.Initialize();
            LeerSiguienteComponente();
            Expresion();

            if (ErrorManagement.HayErrores())
            {
                response = "El proceso de compilación finalizó con errores...";
            }
            else if (!Category.EOF.Equals(Component.GetCategory()))
            {
                response = "Aunque no se presentaron error durante el proceso de compilación, faltaron componentes por evaluar a nivel sintáctico...";
            }
            else if (StackData.Count > 1)
            {
                response = "Aunque no se presentaron error durante el proceso de compilación, faltaron componentes por evaluar a nivel semántico...";
            }
            else
            {
                response = "\n" + "El resultado de la operación es: " + StackData.Pop();
            }

            return response;
        }

        private void Expresion()
        {
            Termino();
            ExpresionPrima();
        }

        private void ExpresionPrima()
        {
            if (EsCategoriaEsperada(Category.SUMA))
            {
                LeerSiguienteComponente();
                TerminoPrima(); // Realizar la operación antes de analizar la siguiente expresión

                if (!ErrorManagement.HayErrores())
                {
                    double derecho = StackData.Pop();
                    double izquierdo = StackData.Pop();
                    StackData.Push(izquierdo + derecho);
                }

                ExpresionPrima(); // Llamar recursivamente después de realizar la operación
            }
            else if (EsCategoriaEsperada(Category.RESTA))
            {
                LeerSiguienteComponente();
                TerminoPrima(); // Realizar la operación antes de analizar la siguiente expresión

                if (!ErrorManagement.HayErrores())
                {
                    double derecho = StackData.Pop();
                    double izquierdo = StackData.Pop();
                    StackData.Push(izquierdo - derecho);
                }

                ExpresionPrima(); // Llamar recursivamente después de realizar la operación
            }
        }

        private void Termino()
        {
            Factor();
            TerminoPrima();
        }

        private void TerminoPrima()
        {
            if (EsCategoriaEsperada(Category.MULTIPLICACION))
            {
                LeerSiguienteComponente();
                Factor(); // Realizar la operación antes de analizar el siguiente término

                if (!ErrorManagement.HayErrores())
                {
                    double derecho = StackData.Pop();
                    double izquierdo = StackData.Pop();
                    StackData.Push(izquierdo * derecho);
                }

                TerminoPrima(); // Llamar recursivamente después de realizar la operación
            }
            else if (EsCategoriaEsperada(Category.DIVISION))
            {
                LeerSiguienteComponente();
                Factor(); // Realizar la operación antes de analizar el siguiente término

                if (!ErrorManagement.HayErrores())
                {
                    double derecho = StackData.Pop();
                    double izquierdo = StackData.Pop();

                    if (derecho == 0)
                    {
                        string fail = "División por cero...";
                        string cause = "Componente léxico igual a cero...";
                        string solution = "Asegúrese de que en este lugar esté ubicado un número diferente de cero...";
                        CreateSemanticError(ErrorType.CONTROLABLE, fail, cause, solution, Category.DECIMAL,
                            "Cero (0)");
                        derecho = 1;
                    }

                    StackData.Push(izquierdo / derecho);
                }

                TerminoPrima(); // Llamar recursivamente después de realizar la operación
            }
        }

        private void Factor()
        {
            if (EsCategoriaEsperada(Category.ENTERO))
            {
                {
                    StackData.Push(Double.Parse(Component.GetLexeme()));
                }
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DECIMAL))
            {
                {
                    StackData.Push(Double.Parse(Component.GetLexeme()));
                }
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.PARENTESIS_QUE_ABRE))
            {
                LeerSiguienteComponente();
                Expresion();

                if (EsCategoriaEsperada(Category.PARENTESIS_QUE_CIERRA))
                {
                    LeerSiguienteComponente();
                }
                else
                {
                    string fail = "Componente léxico no corresponde a un paréntesis que cierra...";
                    string cause = "Componente léxico no esperado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un paréntesis que cierra...";
                    CreateSintacticError(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_QUE_CIERRA,
                        Component.GetCategory().ToString());
                }
            }
            else
            {
                string fail = "Componente léxico no corresponde a un paréntesis que abre, Entero o Decimal...";
                string cause = "Componente léxico no esperado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un paréntesis que abre, un entero o un decimal...";
                CreateSintacticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                    Component.GetCategory().ToString());
            }
        }

        private bool EsCategoriaEsperada(Category category)
        {
            return category.Equals(Component.GetCategory());
        }

        private void LeerSiguienteComponente()
        {
            Component = LexicalAnalysis.Analyze();
        }

        private void CreateSintacticError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            int lineNumber = Component.GetLineNumber();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();

                error = Error.CreateStopperSintacticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);

                throw new Exception("Se ha presentado un error tipo STOPPER durante el anàlisis sintáctico." +
                    " No es posible continuar con el proceso de compilaciòn hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener màs detalle del " +
                    "problema que se ha presentado...");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();

                error = Error.CreateNoStopperSintacticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);
            }
        }

        private void CreateSemanticError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            int lineNumber = Component.GetLineNumber();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();

                error = Error.CreateStopperSemanticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);

                throw new Exception("Se ha presentado un error tipo STOPPER durante el anàlisis semántico." +
                    " No es posible continuar con el proceso de compilaciòn hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener màs detalle del " +
                    "problema que se ha presentado...");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();

                error = Error.CreateNoStopperSemanticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexeme);

                ErrorManagement.Agregar(error);
            }
        }
    }
}
