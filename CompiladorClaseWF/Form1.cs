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
            //Cache.AddLine(Line.Create(5, "      ??X=¿¿"));

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
                lblErrorEnCompilacion.Text = "¡¡¡¡¡ERROR DE COMPILACION!!!!! \n";
                lblException.Text = exception.Message;
                panel1.Visible = false;
                panel2.Visible = true;
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.LITERAL).Count() > 0)
            {
                cadena += "Literales: \n";

                DataTable LiteralSimbolos = crearTablaSimbolos();

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.LITERAL))
                {
                    cadena += "============================== \n";
                    cadena += componentTmp.ToString() + "\n";

                    LiteralSimbolos.Rows.Add(componentTmp.ToTableInfo().ToArray());
                }

                dgvLiteralSimbolos.DataSource = LiteralSimbolos;
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.NORMAL).Count() > 0)
            {
                cadena += "Simbolos: \n";

                DataTable NormalSimbolos = crearTablaSimbolos();

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.NORMAL))
                {
                    cadena += "============================== \n";
                    cadena += componentTmp.ToString() + "\n";

                    NormalSimbolos.Rows.Add(componentTmp.ToTableInfo().ToArray());
                }

                dgvNormalSimbolos.DataSource = NormalSimbolos;
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.DUMMY).Count() > 0)
            {
                cadena += "Dummies: \n";
                DataTable DummiesSimbolos = crearTablaSimbolos();


                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.DUMMY))
                {
                    cadena += "============================== \n";
                    cadena += componentTmp.ToString() + "\n";
                    DummiesSimbolos.Rows.Add(componentTmp.ToTableInfo().ToArray());
                }

                dgvDummiesSimbolos.DataSource = DummiesSimbolos;
            }

            if (TablaMaestra.GetComponetsAsList(ComponentType.PALABRA_RESERVADA).Count() > 0)
            {
                cadena += "Palabras reservadas:  \n";
                DataTable PalabrasReservadasSimbolos = crearTablaSimbolos();

                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponetsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    cadena += "============================== \n";
                    cadena += componentTmp.ToString() + "\n";
                    PalabrasReservadasSimbolos.Rows.Add(componentTmp.ToTableInfo().ToArray());
                }

                dgvPalabrasReservadasSimbolos.DataSource = PalabrasReservadasSimbolos;
            }

            if (ErrorManagement.HayErrores())
            {
                cadena += "-------ERRORES-------- \n";
                DataTable ErroresSimbolos = crearTablaError();
                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    cadena += error.ToString() + "\n";
                    cadena += "========================= \n";
                    ErroresSimbolos.Rows.Add(error.ToTableInfo().ToArray());
                }
                dgvErrores.DataSource = ErroresSimbolos;
            }

            //label2.Text = errores;
            richTextBox1.Text = cadena;

        }

        public DataTable crearTablaSimbolos()
        {
            DataTable tablaSimbolos = new DataTable();
            tablaSimbolos.Columns.Add("Tipo", typeof(string));
            tablaSimbolos.Columns.Add("Categoria", typeof(string));
            tablaSimbolos.Columns.Add("Lexema", typeof(string));
            tablaSimbolos.Columns.Add("Linea", typeof(string));
            tablaSimbolos.Columns.Add("Posicion Inicial", typeof(string));
            tablaSimbolos.Columns.Add("Posicion Final", typeof(string));

            return tablaSimbolos;

        }

        public DataTable crearTablaError()
        {
            DataTable tablaError = new DataTable();
            tablaError.Columns.Add("Numero Linea", typeof(string));
            tablaError.Columns.Add("Posicion inicial", typeof(string));
            tablaError.Columns.Add("Posicion final", typeof(string));
            tablaError.Columns.Add("Fallo", typeof(string));
            tablaError.Columns.Add("Causa", typeof(string));
            tablaError.Columns.Add("Solucion", typeof(string));
            tablaError.Columns.Add("Nivel", typeof(string));
            tablaError.Columns.Add("Tipo", typeof(string));
            tablaError.Columns.Add("Categoria", typeof(string));
            tablaError.Columns.Add("Lexema", typeof(string));

            return tablaError;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}