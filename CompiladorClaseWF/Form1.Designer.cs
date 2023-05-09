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
            richTextBox1.Location = new Point(36, 24);
            richTextBox1.Margin = new Padding(2, 1, 2, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(265, 763);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // lblNormalSimbolos
            // 
            lblNormalSimbolos.AutoSize = true;
            lblNormalSimbolos.Enabled = false;
            lblNormalSimbolos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNormalSimbolos.Location = new Point(242, 43);
            lblNormalSimbolos.Margin = new Padding(2, 0, 2, 0);
            lblNormalSimbolos.Name = "lblNormalSimbolos";
            lblNormalSimbolos.Size = new Size(184, 25);
            lblNormalSimbolos.TabIndex = 7;
            lblNormalSimbolos.Text = "Simbolos Normales";
            // 
            // dgvNormalSimbolos
            // 
            dgvNormalSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNormalSimbolos.Location = new Point(36, 69);
            dgvNormalSimbolos.Margin = new Padding(2, 1, 2, 1);
            dgvNormalSimbolos.Name = "dgvNormalSimbolos";
            dgvNormalSimbolos.RowHeadersWidth = 82;
            dgvNormalSimbolos.RowTemplate.Height = 41;
            dgvNormalSimbolos.Size = new Size(684, 254);
            dgvNormalSimbolos.TabIndex = 11;
            // 
            // dgvLiteralSimbolos
            // 
            dgvLiteralSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLiteralSimbolos.Location = new Point(838, 69);
            dgvLiteralSimbolos.Margin = new Padding(2, 1, 2, 1);
            dgvLiteralSimbolos.Name = "dgvLiteralSimbolos";
            dgvLiteralSimbolos.RowHeadersWidth = 82;
            dgvLiteralSimbolos.RowTemplate.Height = 41;
            dgvLiteralSimbolos.Size = new Size(684, 254);
            dgvLiteralSimbolos.TabIndex = 12;
            // 
            // lblLiteralSimbols
            // 
            lblLiteralSimbols.AutoSize = true;
            lblLiteralSimbols.Enabled = false;
            lblLiteralSimbols.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLiteralSimbols.Location = new Point(1089, 43);
            lblLiteralSimbols.Margin = new Padding(2, 0, 2, 0);
            lblLiteralSimbols.Name = "lblLiteralSimbols";
            lblLiteralSimbols.Size = new Size(172, 25);
            lblLiteralSimbols.TabIndex = 13;
            lblLiteralSimbols.Text = "Simbolos Literales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1089, 440);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 17;
            label1.Text = "Simbolos Palabras Reservadas";
            // 
            // dgvPalabrasReservadasSimbolos
            // 
            dgvPalabrasReservadasSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPalabrasReservadasSimbolos.Location = new Point(838, 477);
            dgvPalabrasReservadasSimbolos.Margin = new Padding(2, 1, 2, 1);
            dgvPalabrasReservadasSimbolos.Name = "dgvPalabrasReservadasSimbolos";
            dgvPalabrasReservadasSimbolos.RowHeadersWidth = 82;
            dgvPalabrasReservadasSimbolos.RowTemplate.Height = 41;
            dgvPalabrasReservadasSimbolos.Size = new Size(684, 254);
            dgvPalabrasReservadasSimbolos.TabIndex = 16;
            // 
            // dgvDummiesSimbolos
            // 
            dgvDummiesSimbolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDummiesSimbolos.Location = new Point(27, 477);
            dgvDummiesSimbolos.Margin = new Padding(2, 1, 2, 1);
            dgvDummiesSimbolos.Name = "dgvDummiesSimbolos";
            dgvDummiesSimbolos.RowHeadersWidth = 82;
            dgvDummiesSimbolos.RowTemplate.Height = 41;
            dgvDummiesSimbolos.Size = new Size(684, 254);
            dgvDummiesSimbolos.TabIndex = 15;
            // 
            // lblDummy
            // 
            lblDummy.AutoSize = true;
            lblDummy.Enabled = false;
            lblDummy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDummy.Location = new Point(244, 440);
            lblDummy.Margin = new Padding(2, 0, 2, 0);
            lblDummy.Name = "lblDummy";
            lblDummy.Size = new Size(182, 25);
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
            panel1.Location = new Point(306, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 966);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvErrores);
            panel2.Controls.Add(lblException);
            panel2.Controls.Add(lblErrorEnCompilacion);
            panel2.Location = new Point(306, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1534, 966);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // dgvErrores
            // 
            dgvErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrores.Location = new Point(212, 612);
            dgvErrores.Margin = new Padding(2, 1, 2, 1);
            dgvErrores.Name = "dgvErrores";
            dgvErrores.RowHeadersWidth = 82;
            dgvErrores.RowTemplate.Height = 41;
            dgvErrores.Size = new Size(1097, 167);
            dgvErrores.TabIndex = 16;
            // 
            // lblException
            // 
            lblException.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblException.Location = new Point(75, 302);
            lblException.Name = "lblException";
            lblException.Size = new Size(1407, 274);
            lblException.TabIndex = 1;
            lblException.Text = "label2";
            // 
            // lblErrorEnCompilacion
            // 
            lblErrorEnCompilacion.AutoSize = true;
            lblErrorEnCompilacion.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorEnCompilacion.Location = new Point(452, 82);
            lblErrorEnCompilacion.Name = "lblErrorEnCompilacion";
            lblErrorEnCompilacion.Size = new Size(128, 50);
            lblErrorEnCompilacion.TabIndex = 0;
            lblErrorEnCompilacion.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 1002);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
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