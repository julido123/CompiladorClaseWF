﻿using CompiladorClaseWF.DataCache;
using CompiladorClaseWF.ErrorManager;
using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.SintacticAnalyzer
{
    public class SintacticAnalysis
    {
        private LexicalComponent Component;

        public string Analyze()
        {
            string response = "El proceso de analisis sintactico finalizo exitosamente...";
            LexicalAnalysis.Initialize();
            LeerSiguienteComponente();
            Expresion();

            if (ErrorManagement.HayErrores())
            {
                response = "El proceso de compilacion finalizo con errores...";
            }
            else if (Category.EOF.Equals(Component.GetCategory()))
            {
                response = "Aunque no se presentaron errores durante el proceso de compilacion, faltan componentes por evaluar...";
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
                Expresion();
            }
            else if (EsCategoriaEsperada(Category.RESTA))
            {
                LeerSiguienteComponente();
                Expresion();
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
                Termino();
            }
            else if (EsCategoriaEsperada(Category.DIVISION))
            {
                LeerSiguienteComponente();
                Termino();
            }
        }
        private void Factor() {
            if (EsCategoriaEsperada(Category.ENTERO))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DECIMAL))                
            {
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
                    string fail = "Componente lexico no corresponde a un parentesis que cierra";
                    string cause = "Componente lexico no esperdo en este lugar";
                    string solution = "Asegurese de que en este lugar este ubicado un parentesis que cierra";
                    CreateSintacticEror(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_QUE_CIERRA, Component.GetCategory().ToString());
                }
            }
            else
            {
                string fail = "Componente lexico no corresponde a un parentesis que abre, entero o decimal";
                string cause = "Componente lexico no esperdo en este lugar";
                string solution = "Asegurese de que en este lugar este ubicado un parentesis que abre, un entero o un decimal";
                CreateSintacticEror(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, Component.GetCategory().ToString());
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
        private static void CreateSintacticEror(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            int lineNumber = Component.GetLineNumber();

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();
                Error error = Error.CreateStopperSintacticError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expectedCategory, lexeme);
                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error de tipo STOPPER durante el analisis sintactico" +
                    "No es posible continuar con el proceso de compilacion hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tender mas detalle del " +
                    "problema que se ha presentado...");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();
                Error error = Error.CreateNoStopperSintacticError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expectedCategory, lexeme);
                ErrorManagement.Agregar(error);
            }
        }
    }
}
