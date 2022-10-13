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
            this.label4 = new System.Windows.Forms.Label();
            this.lblpares = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblimpares = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
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
            this.btnapilar.BackColor = System.Drawing.Color.Lime;
            this.btnapilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapilar.ForeColor = System.Drawing.Color.White;
            this.btnapilar.Location = new System.Drawing.Point(245, 59);
            this.btnapilar.Name = "btnapilar";
            this.btnapilar.Size = new System.Drawing.Size(127, 36);
            this.btnapilar.TabIndex = 2;
            this.btnapilar.Text = "APILAR";
            this.btnapilar.UseVisualStyleBackColor = false;
            this.btnapilar.Click += new System.EventHandler(this.btnapilar_Click);
            // 
            // btndesapilar
            // 
            this.btndesapilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndesapilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesapilar.ForeColor = System.Drawing.Color.White;
            this.btndesapilar.Location = new System.Drawing.Point(245, 101);
            this.btndesapilar.Name = "btndesapilar";
            this.btndesapilar.Size = new System.Drawing.Size(127, 36);
            this.btndesapilar.TabIndex = 2;
            this.btndesapilar.Text = "DESAPILAR";
            this.btndesapilar.UseVisualStyleBackColor = false;
            this.btndesapilar.Click += new System.EventHandler(this.btndesapilar_Click);
            // 
            // btnvaciarpila
            // 
            this.btnvaciarpila.BackColor = System.Drawing.Color.Teal;
            this.btnvaciarpila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvaciarpila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvaciarpila.ForeColor = System.Drawing.Color.White;
            this.btnvaciarpila.Location = new System.Drawing.Point(245, 143);
            this.btnvaciarpila.Name = "btnvaciarpila";
            this.btnvaciarpila.Size = new System.Drawing.Size(127, 36);
            this.btnvaciarpila.TabIndex = 2;
            this.btnvaciarpila.Text = "VACIAR PILA";
            this.btnvaciarpila.UseVisualStyleBackColor = false;
            this.btnvaciarpila.Click += new System.EventHandler(this.btnvaciarpila_Click);
            // 
            // pilacontenedora
            // 
            this.pilacontenedora.FormattingEnabled = true;
            this.pilacontenedora.Location = new System.Drawing.Point(42, 116);
            this.pilacontenedora.Name = "pilacontenedora";
            this.pilacontenedora.Size = new System.Drawing.Size(160, 160);
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
            this.label3.Location = new System.Drawing.Point(43, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Pila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cant. ELementos Pares:";
            // 
            // lblpares
            // 
            this.lblpares.AutoSize = true;
            this.lblpares.Location = new System.Drawing.Point(186, 291);
            this.lblpares.Name = "lblpares";
            this.lblpares.Size = new System.Drawing.Size(13, 13);
            this.lblpares.TabIndex = 5;
            this.lblpares.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cant. Elem. Impares: ";
            // 
            // lblimpares
            // 
            this.lblimpares.AutoSize = true;
            this.lblimpares.Location = new System.Drawing.Point(173, 311);
            this.lblimpares.Name = "lblimpares";
            this.lblimpares.Size = new System.Drawing.Size(13, 13);
            this.lblimpares.TabIndex = 5;
            this.lblimpares.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Promedio Elementos:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Location = new System.Drawing.Point(175, 333);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(13, 13);
            this.lblpromedio.TabIndex = 5;
            this.lblpromedio.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 355);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.lblimpares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblpares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pilacontenedora);
            this.Controls.Add(this.btnvaciarpila);
            this.Controls.Add(this.btndesapilar);
            this.Controls.Add(this.btnapilar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblimpares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpromedio;
    }
}

