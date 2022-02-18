namespace Almacenar_datos
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
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbxlista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(354, 55);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Procesar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(435, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbxlista
            // 
            this.cbxlista.FormattingEnabled = true;
            this.cbxlista.Location = new System.Drawing.Point(130, 123);
            this.cbxlista.Name = "cbxlista";
            this.cbxlista.Size = new System.Drawing.Size(282, 23);
            this.cbxlista.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado de Alumnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese Cuantos Alumnos desea Agregar";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(248, 56);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 23);
            this.txtvalor.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Limpiar Registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(544, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxlista);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnguardar);
            this.Name = "Form1";
            this.Text = "Ingreso de Estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnguardar;
        private Button btnLimpiar;
        private ComboBox cbxlista;
        private Label label3;
        private Label label4;
        private TextBox txtvalor;
        private Button button1;
    }
}