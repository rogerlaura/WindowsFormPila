﻿namespace WindowsFormPila
{
    partial class Form2
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
            this.txtcapmax = new System.Windows.Forms.TextBox();
            this.btncomenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcapmax
            // 
            this.txtcapmax.Location = new System.Drawing.Point(65, 41);
            this.txtcapmax.Name = "txtcapmax";
            this.txtcapmax.Size = new System.Drawing.Size(144, 20);
            this.txtcapmax.TabIndex = 0;
            // 
            // btncomenzar
            // 
            this.btncomenzar.BackColor = System.Drawing.Color.LimeGreen;
            this.btncomenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomenzar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomenzar.ForeColor = System.Drawing.Color.White;
            this.btncomenzar.Location = new System.Drawing.Point(88, 67);
            this.btncomenzar.Name = "btncomenzar";
            this.btncomenzar.Size = new System.Drawing.Size(93, 31);
            this.btncomenzar.TabIndex = 1;
            this.btncomenzar.Text = "COMENZAR";
            this.btncomenzar.UseVisualStyleBackColor = false;
            this.btncomenzar.Click += new System.EventHandler(this.btncomenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cap. Maxima";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(269, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncomenzar);
            this.Controls.Add(this.txtcapmax);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAPACIDAD PILA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcapmax;
        private System.Windows.Forms.Button btncomenzar;
        private System.Windows.Forms.Label label1;
    }
}