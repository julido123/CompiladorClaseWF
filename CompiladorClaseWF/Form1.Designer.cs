namespace CompiladorClaseWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            lblNormalSimbolos = new Label();
            dgvNormalSimbolos = new DataGridView();
            dgvLiteralSimbolos = new DataGridView();
            lblLiteralSimbols = new Label();
            label1 = new Label();
            dgvPalabrasReservadasSimbolos = new DataGridView();
            dgvDummiesSimbolos = new DataGridView();
            lblDummy = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvErrores = new DataGridView();
            lblException = new Label();
            lblErrorEnCompilacion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNormalSimbolos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLiteralSimbolos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPalabrasReservadasSimbolos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDummiesSimbolos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErrores).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(67, 51);
            richTextBox1.Margin = new Padding(4, 2, 4, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(489, 1623);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // lblNormalSimbolos
            // 
            lblNormalSimbolos.AutoSize = true;
            lblNormalSimbolos.Enabled = false;
            lblNormalSimbolos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNormalSimbolos.Location = new Point(449, 92);
            lblNormalSimbolos.Margin = new Padding(4, 0, 4, 0);
            lblNormalSimbolos.Name = "lblNormalSimbolos";
            lblNormalSimbolos.Size = new Size(369, 51);
            lblNormalSimbolos.TabIndex = 7;
            lblNormalSimbolos.Text = "Simbolos Normales";
            // 
            // dgvNormalSimbolos
            // 
            dgvNormalSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNormalSimbolos.Location = new Point(67, 147);
            dgvNormalSimbolos.Margin = new Padding(4, 2, 4, 2);
            dgvNormalSimbolos.Name = "dgvNormalSimbolos";
            dgvNormalSimbolos.RowHeadersWidth = 82;
            dgvNormalSimbolos.RowTemplate.Height = 41;
            dgvNormalSimbolos.Size = new Size(1270, 542);
            dgvNormalSimbolos.TabIndex = 11;
            // 
            // dgvLiteralSimbolos
            // 
            dgvLiteralSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiteralSimbolos.Location = new Point(1556, 147);
            dgvLiteralSimbolos.Margin = new Padding(4, 2, 4, 2);
            dgvLiteralSimbolos.Name = "dgvLiteralSimbolos";
            dgvLiteralSimbolos.RowHeadersWidth = 82;
            dgvLiteralSimbolos.RowTemplate.Height = 41;
            dgvLiteralSimbolos.Size = new Size(1270, 542);
            dgvLiteralSimbolos.TabIndex = 12;
            // 
            // lblLiteralSimbols
            // 
            lblLiteralSimbols.AutoSize = true;
            lblLiteralSimbols.Enabled = false;
            lblLiteralSimbols.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLiteralSimbols.Location = new Point(2022, 92);
            lblLiteralSimbols.Margin = new Padding(4, 0, 4, 0);
            lblLiteralSimbols.Name = "lblLiteralSimbols";
            lblLiteralSimbols.Size = new Size(347, 51);
            lblLiteralSimbols.TabIndex = 13;
            lblLiteralSimbols.Text = "Simbolos Literales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2022, 939);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(557, 51);
            label1.TabIndex = 17;
            label1.Text = "Simbolos Palabras Reservadas";
            // 
            // dgvPalabrasReservadasSimbolos
            // 
            dgvPalabrasReservadasSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPalabrasReservadasSimbolos.Location = new Point(1556, 1018);
            dgvPalabrasReservadasSimbolos.Margin = new Padding(4, 2, 4, 2);
            dgvPalabrasReservadasSimbolos.Name = "dgvPalabrasReservadasSimbolos";
            dgvPalabrasReservadasSimbolos.RowHeadersWidth = 82;
            dgvPalabrasReservadasSimbolos.RowTemplate.Height = 41;
            dgvPalabrasReservadasSimbolos.Size = new Size(1270, 542);
            dgvPalabrasReservadasSimbolos.TabIndex = 16;
            // 
            // dgvDummiesSimbolos
            // 
            dgvDummiesSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDummiesSimbolos.Location = new Point(50, 1018);
            dgvDummiesSimbolos.Margin = new Padding(4, 2, 4, 2);
            dgvDummiesSimbolos.Name = "dgvDummiesSimbolos";
            dgvDummiesSimbolos.RowHeadersWidth = 82;
            dgvDummiesSimbolos.RowTemplate.Height = 41;
            dgvDummiesSimbolos.Size = new Size(1270, 542);
            dgvDummiesSimbolos.TabIndex = 15;
            // 
            // lblDummy
            // 
            lblDummy.AutoSize = true;
            lblDummy.Enabled = false;
            lblDummy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDummy.Location = new Point(453, 939);
            lblDummy.Margin = new Padding(4, 0, 4, 0);
            lblDummy.Name = "lblDummy";
            lblDummy.Size = new Size(367, 51);
            lblDummy.TabIndex = 14;
            lblDummy.Text = "Simbolos Dummies";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvNormalSimbolos);
            panel1.Controls.Add(dgvPalabrasReservadasSimbolos);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvDummiesSimbolos);
            panel1.Controls.Add(lblNormalSimbolos);
            panel1.Controls.Add(dgvLiteralSimbolos);
            panel1.Controls.Add(lblLiteralSimbols);
            panel1.Controls.Add(lblDummy);
            panel1.Location = new Point(568, 51);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2849, 2061);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvErrores);
            panel2.Controls.Add(lblException);
            panel2.Controls.Add(lblErrorEnCompilacion);
            panel2.Location = new Point(568, 51);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(2849, 2061);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // dgvErrores
            // 
            dgvErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrores.Location = new Point(394, 1306);
            dgvErrores.Margin = new Padding(4, 2, 4, 2);
            dgvErrores.Name = "dgvErrores";
            dgvErrores.RowHeadersWidth = 82;
            dgvErrores.RowTemplate.Height = 41;
            dgvErrores.Size = new Size(2037, 356);
            dgvErrores.TabIndex = 16;
            // 
            // lblException
            // 
            lblException.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblException.Location = new Point(139, 644);
            lblException.Margin = new Padding(6, 0, 6, 0);
            lblException.Name = "lblException";
            lblException.Size = new Size(2613, 585);
            lblException.TabIndex = 1;
            lblException.Text = "label2";
            // 
            // lblErrorEnCompilacion
            // 
            lblErrorEnCompilacion.AutoSize = true;
            lblErrorEnCompilacion.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorEnCompilacion.Location = new Point(839, 175);
            lblErrorEnCompilacion.Margin = new Padding(6, 0, 6, 0);
            lblErrorEnCompilacion.Name = "lblErrorEnCompilacion";
            lblErrorEnCompilacion.Size = new Size(253, 99);
            lblErrorEnCompilacion.TabIndex = 0;
            lblErrorEnCompilacion.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2564, 1399);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNormalSimbolos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLiteralSimbolos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPalabrasReservadasSimbolos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDummiesSimbolos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvErrores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblDummy;
        private RichTextBox richTextBox1;
        private Label lblNormalSimbolos;
        private DataGridView dgvNormalSimbolos;
        private DataGridView dgvLiteralSimbolos;
        private Label lblLiteralSimbols;
        private Label label1;
        private DataGridView dgvPalabrasReservadasSimbolos;
        private DataGridView dgvDummiesSimbolos;
        private Panel panel1;
        private Panel panel2;
        private Label lblException;
        private Label lblErrorEnCompilacion;
        private DataGridView dgvErrores;
    }
}