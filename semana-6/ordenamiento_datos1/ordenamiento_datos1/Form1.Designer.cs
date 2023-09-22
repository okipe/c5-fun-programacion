namespace ordenamiento_datos1
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
            this.components = new System.ComponentModel.Container();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblOrdenar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnQuicksort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(113, 127);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(304, 20);
            this.txtNumeros.TabIndex = 0;
            this.txtNumeros.Text = "1,2,3,4";
            this.txtNumeros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.Location = new System.Drawing.Point(80, 181);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(108, 23);
            this.lblOrdenar.TabIndex = 2;
            this.lblOrdenar.Text = "Ordenar Burbujha";
            this.lblOrdenar.UseVisualStyleBackColor = true;
            this.lblOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(113, 225);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(304, 20);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnQuicksort
            // 
            this.btnQuicksort.Location = new System.Drawing.Point(220, 180);
            this.btnQuicksort.Name = "btnQuicksort";
            this.btnQuicksort.Size = new System.Drawing.Size(117, 23);
            this.btnQuicksort.TabIndex = 4;
            this.btnQuicksort.Text = "Ordenar Quicksort";
            this.btnQuicksort.UseVisualStyleBackColor = true;
            this.btnQuicksort.Click += new System.EventHandler(this.btnQuicksort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuicksort);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.txtNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button lblOrdenar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnQuicksort;
    }
}

