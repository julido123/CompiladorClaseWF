namespace CompiladorClaseWF
{
    partial class frmIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCompilar = new Button();
            btnLimpiar = new Button();
            txtIngresoInfo = new TextBox();
            btnCargarArchivo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(418, 52);
            label1.Name = "label1";
            label1.Size = new Size(251, 17);
            label1.TabIndex = 6;
            label1.Text = "Ingresa datos en el textbox o carga un archivo";
            // 
            // btnCompilar
            // 
            btnCompilar.Location = new Point(609, 487);
            btnCompilar.Name = "btnCompilar";
            btnCompilar.Size = new Size(130, 36);
            btnCompilar.TabIndex = 14;
            btnCompilar.Text = "Compilar";
            btnCompilar.UseVisualStyleBackColor = true;
            btnCompilar.Click += btnCompilar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(523, 551);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(85, 30);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIngresoInfo
            // 
            txtIngresoInfo.Location = new Point(354, 87);
            txtIngresoInfo.Multiline = true;
            txtIngresoInfo.Name = "txtIngresoInfo";
            txtIngresoInfo.Size = new Size(385, 366);
            txtIngresoInfo.TabIndex = 10;
            // 
            // btnCargarArchivo
            // 
            btnCargarArchivo.Location = new Point(354, 487);
            btnCargarArchivo.Name = "btnCargarArchivo";
            btnCargarArchivo.Size = new Size(130, 36);
            btnCargarArchivo.TabIndex = 9;
            btnCargarArchivo.Text = "Cargar Archivo";
            btnCargarArchivo.UseVisualStyleBackColor = true;
            btnCargarArchivo.Click += btnCargarArchivo_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 604);
            Controls.Add(btnCompilar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtIngresoInfo);
            Controls.Add(btnCargarArchivo);
            Controls.Add(label1);
            Name = "frmIngreso";
            Text = "frmIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCompilar;
        private Button btnLimpiar;
        private TextBox txtIngresoInfo;
        private Button btnCargarArchivo;
    }
}