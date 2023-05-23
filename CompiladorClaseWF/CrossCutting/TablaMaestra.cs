using CompiladorClaseWF.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseWF.CrossCutting
{
    public class TablaMaestra
    {
        private static Dictionary<ComponentType, TablaComponentes> TABLAS = new Dictionary<ComponentType, TablaComponentes>();

        static TablaMaestra()
        {
            TABLAS.Add(ComponentType.NORMAL, TablaSimbolos.GetTablaSimbolos());
            TABLAS.Add(ComponentType.DUMMY, TablaDummies.GetTablaDummies());
            TABLAS.Add(ComponentType.LITERAL, TablaLiterales.GetTablaLiterales());
            TABLAS.Add(ComponentType.PALABRA_RESERVADA, TablaPalabrasReservadas.GetTablaPalabrasReservadas());
        }
        public static void Inicializar()
        {
            TablaSimbolos.GetTablaSimbolos().Initialize();
            TablaPalabrasReservadas.GetTablaPalabrasReservadas().Initialize();
            TablaLiterales.GetTablaLiterales().Initialize();
            TablaDummies.GetTablaDummies().Initialize();
        }

        public static void Add(LexicalComponent component)
        {
            if (component != null)
            {
                component = TablaPalabrasReservadas.ComprobarComponente(component);
                TABLAS[component.Type].Add(component);
            }
        }
        public static List<LexicalComponent> GetComponetsAsList(ComponentType type)
        {
            return TABLAS[type].GetComponentsAsList();
        }

        public static Dictionary<string, List<LexicalComponent>> GetComponets(ComponentType type)
        {
            return TABLAS[type].GetComponents();
        }
    }
}
