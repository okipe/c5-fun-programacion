namespace Personas
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
            this.groupBoxRegistroPersona = new System.Windows.Forms.GroupBox();
            this.lblRegNombres = new System.Windows.Forms.Label();
            this.lblRegDireccion = new System.Windows.Forms.Label();
            this.lblRegTelefono = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.lblRegFechaNacimeinto = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBoxResultado = new System.Windows.Forms.GroupBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.groupBoxRegistroPersona.SuspendLayout();
            this.groupBoxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistroPersona
            // 
            this.groupBoxRegistroPersona.Controls.Add(this.dtpFechaNacimiento);
            this.groupBoxRegistroPersona.Controls.Add(this.txtEmail);
            this.groupBoxRegistroPersona.Controls.Add(this.txtTelefono);
            this.groupBoxRegistroPersona.Controls.Add(this.txtDireccion);
            this.groupBoxRegistroPersona.Controls.Add(this.txtNombres);
            this.groupBoxRegistroPersona.Controls.Add(this.lblRegFechaNacimeinto);
            this.groupBoxRegistroPersona.Controls.Add(this.lblRegEmail);
            this.groupBoxRegistroPersona.Controls.Add(this.lblRegTelefono);
            this.groupBoxRegistroPersona.Controls.Add(this.lblRegDireccion);
            this.groupBoxRegistroPersona.Controls.Add(this.lblRegNombres);
            this.groupBoxRegistroPersona.Location = new System.Drawing.Point(35, 27);
            this.groupBoxRegistroPersona.Name = "groupBoxRegistroPersona";
            this.groupBoxRegistroPersona.Size = new System.Drawing.Size(417, 210);
            this.groupBoxRegistroPersona.TabIndex = 0;
            this.groupBoxRegistroPersona.TabStop = false;
            this.groupBoxRegistroPersona.Text = "Registro de persona";
            this.groupBoxRegistroPersona.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRegNombres
            // 
            this.lblRegNombres.AutoSize = true;
            this.lblRegNombres.Location = new System.Drawing.Point(7, 31);
            this.lblRegNombres.Name = "lblRegNombres";
            this.lblRegNombres.Size = new System.Drawing.Size(52, 13);
            this.lblRegNombres.TabIndex = 0;
            this.lblRegNombres.Text = "Nombres:";
            this.lblRegNombres.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRegDireccion
            // 
            this.lblRegDireccion.AutoSize = true;
            this.lblRegDireccion.Location = new System.Drawing.Point(7, 58);
            this.lblRegDireccion.Name = "lblRegDireccion";
            this.lblRegDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblRegDireccion.TabIndex = 1;
            this.lblRegDireccion.Text = "Dirección";
            // 
            // lblRegTelefono
            // 
            this.lblRegTelefono.AutoSize = true;
            this.lblRegTelefono.Location = new System.Drawing.Point(7, 89);
            this.lblRegTelefono.Name = "lblRegTelefono";
            this.lblRegTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblRegTelefono.TabIndex = 2;
            this.lblRegTelefono.Text = "Teléfono";
            this.lblRegTelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Location = new System.Drawing.Point(10, 120);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(35, 13);
            this.lblRegEmail.TabIndex = 3;
            this.lblRegEmail.Text = "E-mail";
            // 
            // lblRegFechaNacimeinto
            // 
            this.lblRegFechaNacimeinto.AutoSize = true;
            this.lblRegFechaNacimeinto.Location = new System.Drawing.Point(10, 152);
            this.lblRegFechaNacimeinto.Name = "lblRegFechaNacimeinto";
            this.lblRegFechaNacimeinto.Size = new System.Drawing.Size(108, 13);
            this.lblRegFechaNacimeinto.TabIndex = 4;
            this.lblRegFechaNacimeinto.Text = "Fecha de Nacimiento";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(157, 31);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(157, 58);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(157, 86);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(157, 152);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(174, 254);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // groupBoxResultado
            // 
            this.groupBoxResultado.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxResultado.Controls.Add(this.lblEmail);
            this.groupBoxResultado.Controls.Add(this.lblTelefono);
            this.groupBoxResultado.Controls.Add(this.lblDireccion);
            this.groupBoxResultado.Controls.Add(this.lblNombres);
            this.groupBoxResultado.Location = new System.Drawing.Point(35, 299);
            this.groupBoxResultado.Name = "groupBoxResultado";
            this.groupBoxResultado.Size = new System.Drawing.Size(417, 166);
            this.groupBoxResultado.TabIndex = 2;
            this.groupBoxResultado.TabStop = false;
            this.groupBoxResultado.Text = "Resultado";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(10, 26);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(0, 13);
            this.lblNombres.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(10, 55);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(0, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Click += new System.EventHandler(this.z_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(10, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(0, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Click += new System.EventHandler(this.z_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Click += new System.EventHandler(this.z_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(10, 141);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(0, 13);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Click += new System.EventHandler(this.z_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 477);
            this.Controls.Add(this.groupBoxResultado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBoxRegistroPersona);
            this.Name = "Form1";
            this.Text = "Estructura";
            this.groupBoxRegistroPersona.ResumeLayout(false);
            this.groupBoxRegistroPersona.PerformLayout();
            this.groupBoxResultado.ResumeLayout(false);
            this.groupBoxResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistroPersona;
        private System.Windows.Forms.Label lblRegNombres;
        private System.Windows.Forms.Label lblRegTelefono;
        private System.Windows.Forms.Label lblRegDireccion;
        private System.Windows.Forms.Label lblRegFechaNacimeinto;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBoxResultado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
    }
}

