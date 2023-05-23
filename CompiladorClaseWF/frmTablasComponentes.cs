using CompiladorClaseWF.CrossCutting;
using CompiladorClaseWF.DataCache;
using CompiladorClaseWF.ErrorManager;
using CompiladorClaseWF.LexicalAnalyzer;
using CompiladorClaseWF.SintacticAnalyzer;
using System.Data;

namespace CompiladorClaseWF
{
    public partial class frmTablasComponentes : Form
    {
        private codigoIngresoUsuario codigoTxtIngresoUsuario;
        public frmTablasComponentes()
        {
            InitializeComponent();
            codigoTxtIngresoUsuario = codigoIngresoUsuario.ObtenerInstancia();
            cargarDatos();
        }

        public void cargarDatos()
        {
            string cadena = "";

            for (int i = 0; i < codigoTxtIngresoUsuario.Codigo.Lines.Length; i++)
            {
                string linea = codigoTxtIngresoUsuario.Codigo.Lines[i];
                Cache.AddLine(Line.Create(i+1, linea));
            }

            LexicalAnalysis.Initialize();
            


            try
            {
                SintacticAnalysis SinAna = new SintacticAnalysis();
                string response = SinAna.Analyze();

                cadena += response + "\n";

                /*while (!Category.EOF.Equals(component.GetCategory()))
                {
                    component = LexicalAnalysis.Analyze();
                    response = SinAna.Analyze();
                    cadena += response;
                } */

            }
            catch (Exception exception)
            {
                //¡¡¡ERROR DE COMPILACIÓN!!!
                lblException.Text = exception.Message;
            }

            //Pintar resultados
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

                cadena += "-------ERRORES LEXICOS------ \n";
                DataTable ErroresSimboloslexicos = crearTablaErrorLexico();
                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    cadena += error.ToString() + "\n";
                    cadena += "========================= \n";
                    ErroresSimboloslexicos.Rows.Add(error.ToTableInfo().ToArray());
                }

                cadena += "-------ERRORES SINTÁCCTICOS---- \n";
                DataTable ErroresSimbolosSintacticos = crearTablaErrorLexico();
                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.SINTACTICO))
                {
                    cadena += error.ToString() + "\n";
                    cadena += "========================= \n";
                    ErroresSimbolosSintacticos.Rows.Add(error.ToTableInfo().ToArray());
                }


                dgvErrores.DataSource = ErroresSimboloslexicos;
                dgvErroresSintacticos.DataSource = ErroresSimbolosSintacticos;
            }
            Cache.Clear();
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

        public DataTable crearTablaErrorLexico()
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
            tablaError.Columns.Add("Lexema", typeof(string));

            return tablaError;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}