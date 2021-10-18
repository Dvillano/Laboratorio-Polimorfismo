
namespace WindowsFormsAppPolimorfismo
{
    partial class Form1
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
            this.btnCrearInstanciasAjedrez = new System.Windows.Forms.Button();
            this.btnCrearInstanciasTransporte = new System.Windows.Forms.Button();
            this.btnCrearInstanciasAnimales = new System.Windows.Forms.Button();
            this.btnCrearInstanciasBanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstanciasAjedrez
            // 
            this.btnCrearInstanciasAjedrez.Location = new System.Drawing.Point(52, 42);
            this.btnCrearInstanciasAjedrez.Name = "btnCrearInstanciasAjedrez";
            this.btnCrearInstanciasAjedrez.Size = new System.Drawing.Size(234, 36);
            this.btnCrearInstanciasAjedrez.TabIndex = 0;
            this.btnCrearInstanciasAjedrez.Text = "Crear instancias ajedrez";
            this.btnCrearInstanciasAjedrez.UseVisualStyleBackColor = true;
            this.btnCrearInstanciasAjedrez.Click += new System.EventHandler(this.btnCrearInstanciasAjedrez_Click);
            // 
            // btnCrearInstanciasTransporte
            // 
            this.btnCrearInstanciasTransporte.Location = new System.Drawing.Point(52, 98);
            this.btnCrearInstanciasTransporte.Name = "btnCrearInstanciasTransporte";
            this.btnCrearInstanciasTransporte.Size = new System.Drawing.Size(234, 32);
            this.btnCrearInstanciasTransporte.TabIndex = 1;
            this.btnCrearInstanciasTransporte.Text = "Crear Instancias transporte";
            this.btnCrearInstanciasTransporte.UseVisualStyleBackColor = true;
            this.btnCrearInstanciasTransporte.Click += new System.EventHandler(this.btnCrearInstanciasTransporte_Click);
            // 
            // btnCrearInstanciasAnimales
            // 
            this.btnCrearInstanciasAnimales.Location = new System.Drawing.Point(52, 156);
            this.btnCrearInstanciasAnimales.Name = "btnCrearInstanciasAnimales";
            this.btnCrearInstanciasAnimales.Size = new System.Drawing.Size(234, 23);
            this.btnCrearInstanciasAnimales.TabIndex = 2;
            this.btnCrearInstanciasAnimales.Text = "Crear Instancias Animales";
            this.btnCrearInstanciasAnimales.UseVisualStyleBackColor = true;
            this.btnCrearInstanciasAnimales.Click += new System.EventHandler(this.btnCrearInstanciasAnimales_Click);
            // 
            // btnCrearInstanciasBanco
            // 
            this.btnCrearInstanciasBanco.Location = new System.Drawing.Point(52, 200);
            this.btnCrearInstanciasBanco.Name = "btnCrearInstanciasBanco";
            this.btnCrearInstanciasBanco.Size = new System.Drawing.Size(234, 23);
            this.btnCrearInstanciasBanco.TabIndex = 3;
            this.btnCrearInstanciasBanco.Text = "Crear Instancias Banco";
            this.btnCrearInstanciasBanco.UseVisualStyleBackColor = true;
            this.btnCrearInstanciasBanco.Click += new System.EventHandler(this.btnCrearInstanciasBanco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 264);
            this.Controls.Add(this.btnCrearInstanciasBanco);
            this.Controls.Add(this.btnCrearInstanciasAnimales);
            this.Controls.Add(this.btnCrearInstanciasTransporte);
            this.Controls.Add(this.btnCrearInstanciasAjedrez);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstanciasAjedrez;
        private System.Windows.Forms.Button btnCrearInstanciasTransporte;
        private System.Windows.Forms.Button btnCrearInstanciasAnimales;
        private System.Windows.Forms.Button btnCrearInstanciasBanco;
    }
}

