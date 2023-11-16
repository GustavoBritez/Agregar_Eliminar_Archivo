namespace Archivos_Pratica_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TX_NOMBRE = new System.Windows.Forms.TextBox();
            this.BTN_INGRESAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_APELLIDO = new System.Windows.Forms.TextBox();
            this.UP_DNI = new System.Windows.Forms.NumericUpDown();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.BTN_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UP_DNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TX_NOMBRE
            // 
            this.TX_NOMBRE.Location = new System.Drawing.Point(73, 53);
            this.TX_NOMBRE.Name = "TX_NOMBRE";
            this.TX_NOMBRE.Size = new System.Drawing.Size(120, 20);
            this.TX_NOMBRE.TabIndex = 0;
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.Location = new System.Drawing.Point(224, 86);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INGRESAR.TabIndex = 1;
            this.BTN_INGRESAR.Text = "INGRESAR";
            this.BTN_INGRESAR.UseVisualStyleBackColor = true;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTN_INGRESAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // TX_APELLIDO
            // 
            this.TX_APELLIDO.Location = new System.Drawing.Point(73, 88);
            this.TX_APELLIDO.Name = "TX_APELLIDO";
            this.TX_APELLIDO.Size = new System.Drawing.Size(120, 20);
            this.TX_APELLIDO.TabIndex = 5;
            // 
            // UP_DNI
            // 
            this.UP_DNI.Location = new System.Drawing.Point(73, 120);
            this.UP_DNI.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.UP_DNI.Name = "UP_DNI";
            this.UP_DNI.Size = new System.Drawing.Size(120, 20);
            this.UP_DNI.TabIndex = 6;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(161, 205);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(350, 177);
            this.DGV.TabIndex = 7;
            // 
            // BTN_ELIMINAR
            // 
            this.BTN_ELIMINAR.Location = new System.Drawing.Point(531, 359);
            this.BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            this.BTN_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ELIMINAR.TabIndex = 8;
            this.BTN_ELIMINAR.Text = "Eliminar";
            this.BTN_ELIMINAR.UseVisualStyleBackColor = true;
            this.BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 417);
            this.Controls.Add(this.BTN_ELIMINAR);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.UP_DNI);
            this.Controls.Add(this.TX_APELLIDO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.TX_NOMBRE);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UP_DNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_NOMBRE;
        private System.Windows.Forms.Button BTN_INGRESAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TX_APELLIDO;
        private System.Windows.Forms.NumericUpDown UP_DNI;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button BTN_ELIMINAR;
    }
}

