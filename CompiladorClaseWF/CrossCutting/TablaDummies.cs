using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.CrossCutting
{
    public class TablaDummies : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaDummies();

        private TablaDummies()
        {

        }

        public static TablaComponentes GetTablaDummies()
        {
            return INSTANCE;
        }
    }
}
