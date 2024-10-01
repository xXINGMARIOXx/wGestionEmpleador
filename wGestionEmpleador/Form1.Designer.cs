namespace wGestionEmpleador
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
            this.gropEmpleados = new System.Windows.Forms.GroupBox();
            this.t = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoEmpleados = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btcMostrarInformacion = new System.Windows.Forms.Button();
            this.gropEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gropEmpleados
            // 
            this.gropEmpleados.Controls.Add(this.btcMostrarInformacion);
            this.gropEmpleados.Controls.Add(this.btnCalcular);
            this.gropEmpleados.Controls.Add(this.txtSalario);
            this.gropEmpleados.Controls.Add(this.txtTipoEmpleados);
            this.gropEmpleados.Controls.Add(this.lblSalario);
            this.gropEmpleados.Controls.Add(this.comboBox1);
            this.gropEmpleados.Controls.Add(this.label1);
            this.gropEmpleados.Controls.Add(this.t);
            this.gropEmpleados.Location = new System.Drawing.Point(79, 37);
            this.gropEmpleados.Name = "gropEmpleados";
            this.gropEmpleados.Size = new System.Drawing.Size(665, 362);
            this.gropEmpleados.TabIndex = 0;
            this.gropEmpleados.TabStop = false;
            this.gropEmpleados.Text = "Datos Empleados";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(80, 105);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(127, 16);
            this.t.TabIndex = 0;
            this.t.Text = "Tipo de Empleados";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Empleados";
            // 
            // txtTipoEmpleados
            // 
            this.txtTipoEmpleados.Location = new System.Drawing.Point(224, 152);
            this.txtTipoEmpleados.Name = "txtTipoEmpleados";
            this.txtTipoEmpleados.Size = new System.Drawing.Size(383, 22);
            this.txtTipoEmpleados.TabIndex = 2;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(80, 202);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(50, 16);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(224, 199);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(383, 22);
            this.txtSalario.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(181, 296);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 42);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Salario";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btcMostrarInformacion
            // 
            this.btcMostrarInformacion.Location = new System.Drawing.Point(370, 296);
            this.btcMostrarInformacion.Name = "btcMostrarInformacion";
            this.btcMostrarInformacion.Size = new System.Drawing.Size(134, 42);
            this.btcMostrarInformacion.TabIndex = 3;
            this.btcMostrarInformacion.Text = "Mostrar Informacion";
            this.btcMostrarInformacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gropEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gropEmpleados.ResumeLayout(false);
            this.gropEmpleados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gropEmpleados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtTipoEmpleados;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Button btcMostrarInformacion;
    }
}

