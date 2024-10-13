namespace Lab_6
{
    partial class FormAniadirLibro
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelEstaticoTitulo = new System.Windows.Forms.Label();
            this.labelEstaticoAutor = new System.Windows.Forms.Label();
            this.labelEstaticoCantidad = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(137, 34);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(105, 22);
            this.txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(137, 78);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(105, 22);
            this.txtAutor.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(137, 124);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(105, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // labelEstaticoTitulo
            // 
            this.labelEstaticoTitulo.AutoSize = true;
            this.labelEstaticoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoTitulo.Location = new System.Drawing.Point(76, 34);
            this.labelEstaticoTitulo.Name = "labelEstaticoTitulo";
            this.labelEstaticoTitulo.Size = new System.Drawing.Size(55, 20);
            this.labelEstaticoTitulo.TabIndex = 3;
            this.labelEstaticoTitulo.Text = "Titulo:";
            // 
            // labelEstaticoAutor
            // 
            this.labelEstaticoAutor.AutoSize = true;
            this.labelEstaticoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoAutor.Location = new System.Drawing.Point(77, 78);
            this.labelEstaticoAutor.Name = "labelEstaticoAutor";
            this.labelEstaticoAutor.Size = new System.Drawing.Size(54, 20);
            this.labelEstaticoAutor.TabIndex = 4;
            this.labelEstaticoAutor.Text = "Autor:";
            // 
            // labelEstaticoCantidad
            // 
            this.labelEstaticoCantidad.AutoSize = true;
            this.labelEstaticoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoCantidad.Location = new System.Drawing.Point(56, 124);
            this.labelEstaticoCantidad.Name = "labelEstaticoCantidad";
            this.labelEstaticoCantidad.Size = new System.Drawing.Size(80, 20);
            this.labelEstaticoCantidad.TabIndex = 5;
            this.labelEstaticoCantidad.Text = "Cantidad:";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(105, 175);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 27);
            this.botonAceptar.TabIndex = 6;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // FormAniadirLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 239);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelEstaticoCantidad);
            this.Controls.Add(this.labelEstaticoAutor);
            this.Controls.Add(this.labelEstaticoTitulo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Name = "FormAniadirLibro";
            this.Text = "FormAniadirLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelEstaticoTitulo;
        private System.Windows.Forms.Label labelEstaticoAutor;
        private System.Windows.Forms.Label labelEstaticoCantidad;
        private System.Windows.Forms.Button botonAceptar;
    }
}