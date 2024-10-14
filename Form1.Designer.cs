namespace Lab_6
{
    partial class FBiblioteca
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
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.btMostrarLibro = new System.Windows.Forms.Button();
            this.btEliminarLibro = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btAgregarLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibro
            // 
            this.dgvLibro.AllowUserToOrderColumns = true;
            this.dgvLibro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(1, 145);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.RowHeadersWidth = 51;
            this.dgvLibro.RowTemplate.Height = 24;
            this.dgvLibro.Size = new System.Drawing.Size(799, 304);
            this.dgvLibro.TabIndex = 0;
            // 
            // btMostrarLibro
            // 
            this.btMostrarLibro.Location = new System.Drawing.Point(47, 47);
            this.btMostrarLibro.Name = "btMostrarLibro";
            this.btMostrarLibro.Size = new System.Drawing.Size(144, 63);
            this.btMostrarLibro.TabIndex = 1;
            this.btMostrarLibro.Text = "Mostrar Libros";
            this.btMostrarLibro.UseVisualStyleBackColor = true;
            this.btMostrarLibro.Click += new System.EventHandler(this.btMostrarLibro_Click);
            // 
            // btEliminarLibro
            // 
            this.btEliminarLibro.Location = new System.Drawing.Point(237, 47);
            this.btEliminarLibro.Name = "btEliminarLibro";
            this.btEliminarLibro.Size = new System.Drawing.Size(144, 63);
            this.btEliminarLibro.TabIndex = 2;
            this.btEliminarLibro.Text = "Eliminar Libro";
            this.btEliminarLibro.UseVisualStyleBackColor = true;
            this.btEliminarLibro.Click += new System.EventHandler(this.btEliminarLibro_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(426, 47);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(144, 63);
            this.btActualizar.TabIndex = 3;
            this.btActualizar.Text = "Actualizar Libro";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btAgregarLibro
            // 
            this.btAgregarLibro.Location = new System.Drawing.Point(616, 47);
            this.btAgregarLibro.Name = "btAgregarLibro";
            this.btAgregarLibro.Size = new System.Drawing.Size(144, 63);
            this.btAgregarLibro.TabIndex = 4;
            this.btAgregarLibro.Text = "Agregar Libro";
            this.btAgregarLibro.UseVisualStyleBackColor = true;
            this.btAgregarLibro.Click += new System.EventHandler(this.btAgregarLibro_Click);
            // 
            // FBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAgregarLibro);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btEliminarLibro);
            this.Controls.Add(this.btMostrarLibro);
            this.Controls.Add(this.dgvLibro);
            this.Name = "FBiblioteca";
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Button btMostrarLibro;
        private System.Windows.Forms.Button btEliminarLibro;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btAgregarLibro;
    }
}

