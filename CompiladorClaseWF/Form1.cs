using CompiladorClaseWF.CrossCutting;
using CompiladorClaseWF.DataCache;
using CompiladorClaseWF.ErrorManager;
using CompiladorClaseWF.LexicalAnalyzer;
using System.Data;

namespace CompiladorClaseWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            string cadena = "";
            string errores = "";

            // Precarga de datos
            Cache.AddLine(Line.Create(1, "123 456           678,8"));
            Cache.AddLine(Line.Create(2, "      678  "));
            Cache.AddLine(Line.Create(3, ""));
            Cache.AddLine(Line.Create(4, "4"));

            LexicalAnalysis.Initialize();

            try
            {
                LexicalComponent component = LexicalAnalysis.Analyze();

                while (!Category.EOF.Equals(component.GetCategory()))
                {
                    component = LexicalAnalysis.Analyze();
                }
            }
            catch (Exception exception)
            {

                /*Console.WriteLine("¡¡¡¡¡ERROR DE COMPILACION!!!!!");
                Console.WriteLine(exception.Message);*/

                errores += exception.Message;
            }

            Console.WriteLine(TablaSimbolos.GetTablaSimbolos());
            if (TablaMaestra.GetComponetsAsList(ComponentType.LITERAL).Count() > 0)
            {
                Console.WriteLine("Literales: ");
                cadena += "Literales: \n";

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.LITERAL))
                {
                    Console.WriteLine("================================");
                    cadena += "================================ \n";
                    Console.WriteLine(componentTmp.ToString());
                    cadena += componentTmp.ToString() + "\n";

                }
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.NORMAL).Count() > 0)
            {
                Console.WriteLine("Simbolos: ");
                cadena += "Simbolos: \n";

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.NORMAL))
                {
                    Console.WriteLine("================================");
                    Console.WriteLine(componentTmp.ToString());
                    cadena += componentTmp.ToString() + "\n";
                }
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.DUMMY).Count() > 0)
            {
                Console.WriteLine("Dummies: ");
                cadena += "Dummies: \n";

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.DUMMY))
                {
                    Console.WriteLine("================================");
                    Console.WriteLine(componentTmp.ToString());
                    cadena += componentTmp.ToString() + "\n";
                }
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.PALABRA_RESERVADA).Count() > 0)
            {
                Console.WriteLine("Palabras reservadas: ");
                cadena += "Palabras reservadas:  \n";

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    Console.WriteLine("================================");
                    Console.WriteLine(componentTmp.ToString());
                    cadena += componentTmp.ToString() + "\n";
                }
            }

            if (ErrorManagement.HayErrores())
            {
                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    Console.WriteLine(error.ToString());
                    Console.WriteLine("___________________________________________________________");
                }
            }



            label2.Text = errores;
            richTextBox1.Text = cadena;


            DataTable simbolos = new DataTable();
            simbolos.Columns.Add("Tipo", typeof(ComponentType));
            simbolos.Columns.Add("Categoria", typeof(string));
            simbolos.Columns.Add("Lexegema", typeof(string));
            simbolos.Columns.Add("Linea", typeof(int));
            simbolos.Columns.Add("Posicion Inicial", typeof(int));
            simbolos.Columns.Add("Posicion Final", typeof(int));

            LexicalComponent componentt = new LexicalComponent();

            simbolos.Rows.Add(ComponentType.NORMAL, "Entero", "678", 1, 1, 2);


            dgv1.DataSource = simbolos;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}