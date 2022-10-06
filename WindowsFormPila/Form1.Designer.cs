namespace WindowsFormPila
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnapilar = new System.Windows.Forms.Button();
            this.btndesapilar = new System.Windows.Forms.Button();
            this.btnvaciarpila = new System.Windows.Forms.Button();
            this.pilacontenedora = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILA";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(42, 61);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(171, 20);
            this.txtnumero.TabIndex = 1;
            // 
            // btnapilar
            // 
            this.btnapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapilar.Location = new System.Drawing.Point(240, 64);
            this.btnapilar.Name = "btnapilar";
            this.btnapilar.Size = new System.Drawing.Size(127, 36);
            this.btnapilar.TabIndex = 2;
            this.btnapilar.Text = "APILAR";
            this.btnapilar.UseVisualStyleBackColor = true;
            this.btnapilar.Click += new System.EventHandler(this.btnapilar_Click);
            // 
            // btndesapilar
            // 
            this.btndesapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesapilar.Location = new System.Drawing.Point(240, 106);
            this.btndesapilar.Name = "btndesapilar";
            this.btndesapilar.Size = new System.Drawing.Size(127, 36);
            this.btndesapilar.TabIndex = 2;
            this.btndesapilar.Text = "DESAPILAR";
            this.btndesapilar.UseVisualStyleBackColor = true;
            this.btndesapilar.Click += new System.EventHandler(this.btndesapilar_Click);
            // 
            // btnvaciarpila
            // 
            this.btnvaciarpila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvaciarpila.Location = new System.Drawing.Point(240, 148);
            this.btnvaciarpila.Name = "btnvaciarpila";
            this.btnvaciarpila.Size = new System.Drawing.Size(127, 36);
            this.btnvaciarpila.TabIndex = 2;
            this.btnvaciarpila.Text = "VACIAR PILA";
            this.btnvaciarpila.UseVisualStyleBackColor = true;
            this.btnvaciarpila.Click += new System.EventHandler(this.btnvaciarpila_Click);
            // 
            // pilacontenedora
            // 
            this.pilacontenedora.FormattingEnabled = true;
            this.pilacontenedora.Location = new System.Drawing.Point(42, 116);
            this.pilacontenedora.Name = "pilacontenedora";
            this.pilacontenedora.Size = new System.Drawing.Size(171, 160);
            this.pilacontenedora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Pila";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pilacontenedora);
            this.Controls.Add(this.btnvaciarpila);
            this.Controls.Add(this.btndesapilar);
            this.Controls.Add(this.btnapilar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PILA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnapilar;
        private System.Windows.Forms.Button btndesapilar;
        private System.Windows.Forms.Button btnvaciarpila;
        private System.Windows.Forms.ListBox pilacontenedora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

