
namespace LectorPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExtraer = new System.Windows.Forms.Button();
            this.textBoxRFC = new System.Windows.Forms.TextBox();
            this.textBoxCURP = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxEstatus = new System.Windows.Forms.TextBox();
            this.textBoxFechaCambio = new System.Windows.Forms.TextBox();
            this.textBoxNombreComercial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(205, 630);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(126, 23);
            this.btnExtraer.TabIndex = 0;
            this.btnExtraer.Text = "EXTRAER";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // textBoxRFC
            // 
            this.textBoxRFC.Location = new System.Drawing.Point(300, 132);
            this.textBoxRFC.Name = "textBoxRFC";
            this.textBoxRFC.Size = new System.Drawing.Size(168, 22);
            this.textBoxRFC.TabIndex = 1;
            // 
            // textBoxCURP
            // 
            this.textBoxCURP.Location = new System.Drawing.Point(300, 176);
            this.textBoxCURP.Name = "textBoxCURP";
            this.textBoxCURP.Size = new System.Drawing.Size(168, 22);
            this.textBoxCURP.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(300, 225);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(168, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(300, 275);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(168, 22);
            this.textBoxApellido.TabIndex = 4;
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(300, 394);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.Size = new System.Drawing.Size(168, 22);
            this.textBoxFechaInicio.TabIndex = 5;
            // 
            // textBoxEstatus
            // 
            this.textBoxEstatus.Location = new System.Drawing.Point(300, 449);
            this.textBoxEstatus.Name = "textBoxEstatus";
            this.textBoxEstatus.Size = new System.Drawing.Size(168, 22);
            this.textBoxEstatus.TabIndex = 6;
            // 
            // textBoxFechaCambio
            // 
            this.textBoxFechaCambio.Location = new System.Drawing.Point(300, 502);
            this.textBoxFechaCambio.Name = "textBoxFechaCambio";
            this.textBoxFechaCambio.Size = new System.Drawing.Size(168, 22);
            this.textBoxFechaCambio.TabIndex = 7;
            // 
            // textBoxNombreComercial
            // 
            this.textBoxNombreComercial.Location = new System.Drawing.Point(300, 555);
            this.textBoxNombreComercial.Name = "textBoxNombreComercial";
            this.textBoxNombreComercial.Size = new System.Drawing.Size(168, 22);
            this.textBoxNombreComercial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CURP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "PRIMER APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "FECHA DE INICIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "ESTATUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "FECHA DE CAMBIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 555);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "NOMBRE COMERCIAL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 44);
            this.panel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(199, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 31);
            this.label9.TabIndex = 18;
            this.label9.Text = "DATOS PDF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "SEGUNDO APELLIDO";
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(300, 334);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(168, 22);
            this.textBoxSegundoApellido.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 677);
            this.Controls.Add(this.textBoxSegundoApellido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreComercial);
            this.Controls.Add(this.textBoxFechaCambio);
            this.Controls.Add(this.textBoxEstatus);
            this.Controls.Add(this.textBoxFechaInicio);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCURP);
            this.Controls.Add(this.textBoxRFC);
            this.Controls.Add(this.btnExtraer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LECTOR DE PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.TextBox textBoxRFC;
        private System.Windows.Forms.TextBox textBoxCURP;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxEstatus;
        private System.Windows.Forms.TextBox textBoxFechaCambio;
        private System.Windows.Forms.TextBox textBoxNombreComercial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
    }
}

