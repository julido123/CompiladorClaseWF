using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.CrossCutting
{
    public class TablaLiterales : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaComponentes();

        private TablaLiterales()
        {

        }

        public static TablaComponentes GetTablaLiterales()
        {
            return INSTANCE;
        }

        public static void Inicializar()
        {
            INSTANCE.Initialize();
        }

        public static void Add(LexicalComponent component)
        {
            INSTANCE.Add(component);
        }

        public static List<LexicalComponent> GetComponetsAsList()
        {
            return INSTANCE.GetComponentsAsList();
        }

        public static Dictionary<string, List<LexicalComponent>> GetComponets()
        {
            return INSTANCE.GetComponents();
        }
    }
}
