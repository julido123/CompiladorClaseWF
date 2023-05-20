﻿using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.ErrorManager
{
    public class Error
    {
        public int LineNumber { get; set; }
        public int InitialPosition { get; set; }
        public int FinalPosition { get; set; }
        public string Fail { get; set; }
        public string Cause { get; set; }
        public string Solution { get; set; }
        public ErrorLevel Level { get; set; }
        public ErrorType Type { get; set; }
        public Category Category { get; set; }
        public string Lexeme { get; set; }

        public Error(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, ErrorLevel level, ErrorType type, Category category, string lexeme)
        {
            LineNumber = lineNumber;
            InitialPosition = initialPosition;
            FinalPosition = finalPosition;
            Fail = fail;
            Cause = cause;
            Solution = solution;
            Level = level;
            Type = type;
            Category = category;
            Lexeme = lexeme;
        }
        public static Error CreateStopperLexicalError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category category, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.LEXICO, ErrorType.STOPPER, category, lexeme);
        }
        public static Error CreateNotStopperLexicalError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category category, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.LEXICO, ErrorType.CONTROLABLE, category, lexeme);
        }
        public static Error CreateStopperSintacticError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category category, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.SINTACTICO, ErrorType.STOPPER, category, lexeme);
        }
        public static Error CreateNoStopperSintacticError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category category, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.SINTACTICO, ErrorType.CONTROLABLE, category, lexeme);
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numero de linea: ").Append(LineNumber).Append("\n");
            sb.Append("Posicion inicial: ").Append(InitialPosition).Append("\n");
            sb.Append("Posicion final: ").Append(FinalPosition).Append("\n");
            sb.Append("Fallo: ").Append(Fail).Append("\n");
            sb.Append("Causa: ").Append(Cause).Append("\n");
            sb.Append("Solucion: ").Append(Solution).Append("\n");
            sb.Append("Nivel: ").Append(Level).Append("\n");
            sb.Append("Tipo: ").Append(Type).Append("\n");
            sb.Append("Categoria: ").Append(Category).Append("\n");
            sb.Append("Lexema: ").Append(Lexeme).Append("\n");
            return sb.ToString();
        }

        public List<String> ToTableInfo()
        {
            List<String> list = new List<String>();
            list.Add(LineNumber.ToString());
            list.Add(InitialPosition.ToString());
            list.Add(FinalPosition.ToString());
            list.Add(Fail.ToString());
            list.Add(Cause.ToString());
            list.Add(Solution.ToString());
            list.Add(Level.ToString());
            list.Add(Type.ToString());
            list.Add(Category.ToString());
            list.Add(Lexeme.ToString());
            return list;
        }

    }
}
