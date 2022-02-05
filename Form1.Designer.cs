namespace Nuevoo
{
    partial class Datos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxdpi = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.dateTimePickeredad = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.labeldpi = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labelfechan = new System.Windows.Forms.Label();
            this.labeldatos = new System.Windows.Forms.Label();
            this.buttonmostrar = new System.Windows.Forms.Button();
            this.buttoncalcularedad = new System.Windows.Forms.Button();
            this.eactual = new System.Windows.Forms.Label();
            this.Borrarcontenido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // textBoxdpi
            // 
            this.textBoxdpi.Location = new System.Drawing.Point(102, 77);
            this.textBoxdpi.Name = "textBoxdpi";
            this.textBoxdpi.Size = new System.Drawing.Size(200, 20);
            this.textBoxdpi.TabIndex = 4;
            this.textBoxdpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdpi_KeyPress);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(121, 103);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxnombre.TabIndex = 5;
            this.textBoxnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxnombre_KeyPress);
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(121, 128);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(200, 20);
            this.textBoxapellido.TabIndex = 6;
            this.textBoxapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxapellido_KeyPress);
            // 
            // dateTimePickeredad
            // 
            this.dateTimePickeredad.Location = new System.Drawing.Point(186, 154);
            this.dateTimePickeredad.Name = "dateTimePickeredad";
            this.dateTimePickeredad.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickeredad.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeldpi
            // 
            this.labeldpi.AutoSize = true;
            this.labeldpi.Location = new System.Drawing.Point(430, 80);
            this.labeldpi.Name = "labeldpi";
            this.labeldpi.Size = new System.Drawing.Size(10, 13);
            this.labeldpi.TabIndex = 9;
            this.labeldpi.Text = "-";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(430, 106);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(10, 13);
            this.labelnombre.TabIndex = 10;
            this.labelnombre.Text = "-";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Location = new System.Drawing.Point(430, 131);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(10, 13);
            this.labelapellido.TabIndex = 11;
            this.labelapellido.Text = "-";
            // 
            // labelfechan
            // 
            this.labelfechan.AutoSize = true;
            this.labelfechan.Location = new System.Drawing.Point(430, 160);
            this.labelfechan.Name = "labelfechan";
            this.labelfechan.Size = new System.Drawing.Size(10, 13);
            this.labelfechan.TabIndex = 12;
            this.labelfechan.Text = "-";
            // 
            // labeldatos
            // 
            this.labeldatos.AutoSize = true;
            this.labeldatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatos.Location = new System.Drawing.Point(430, 63);
            this.labeldatos.Name = "labeldatos";
            this.labeldatos.Size = new System.Drawing.Size(50, 17);
            this.labeldatos.TabIndex = 13;
            this.labeldatos.Text = "Datos";
            // 
            // buttonmostrar
            // 
            this.buttonmostrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmostrar.Location = new System.Drawing.Point(433, 186);
            this.buttonmostrar.Name = "buttonmostrar";
            this.buttonmostrar.Size = new System.Drawing.Size(166, 39);
            this.buttonmostrar.TabIndex = 14;
            this.buttonmostrar.Text = "Mostrar Datos";
            this.buttonmostrar.UseVisualStyleBackColor = false;
            this.buttonmostrar.Click += new System.EventHandler(this.buttonmostrar_Click);
            // 
            // buttoncalcularedad
            // 
            this.buttoncalcularedad.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttoncalcularedad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncalcularedad.Location = new System.Drawing.Point(74, 245);
            this.buttoncalcularedad.Name = "buttoncalcularedad";
            this.buttoncalcularedad.Size = new System.Drawing.Size(166, 39);
            this.buttoncalcularedad.TabIndex = 15;
            this.buttoncalcularedad.Text = "Calcular edad";
            this.buttoncalcularedad.UseVisualStyleBackColor = false;
            this.buttoncalcularedad.Click += new System.EventHandler(this.buttoncalcularedad_Click);
            // 
            // eactual
            // 
            this.eactual.AutoSize = true;
            this.eactual.Location = new System.Drawing.Point(267, 259);
            this.eactual.Name = "eactual";
            this.eactual.Size = new System.Drawing.Size(10, 13);
            this.eactual.TabIndex = 16;
            this.eactual.Text = "-";
            // 
            // Borrarcontenido
            // 
            this.Borrarcontenido.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Borrarcontenido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrarcontenido.Location = new System.Drawing.Point(246, 186);
            this.Borrarcontenido.Name = "Borrarcontenido";
            this.Borrarcontenido.Size = new System.Drawing.Size(166, 39);
            this.Borrarcontenido.TabIndex = 17;
            this.Borrarcontenido.Text = "Limpiar";
            this.Borrarcontenido.UseVisualStyleBackColor = false;
            this.Borrarcontenido.Click += new System.EventHandler(this.Borrarcontenido_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.Borrarcontenido);
            this.Controls.Add(this.eactual);
            this.Controls.Add(this.buttoncalcularedad);
            this.Controls.Add(this.buttonmostrar);
            this.Controls.Add(this.labeldatos);
            this.Controls.Add(this.labelfechan);
            this.Controls.Add(this.labelapellido);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labeldpi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickeredad);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxdpi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Datos";
            this.Text = "Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxdpi;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.DateTimePicker dateTimePickeredad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeldpi;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labelfechan;
        private System.Windows.Forms.Label labeldatos;
        private System.Windows.Forms.Button buttonmostrar;
        private System.Windows.Forms.Button buttoncalcularedad;
        private System.Windows.Forms.Label eactual;
        private System.Windows.Forms.Button Borrarcontenido;
    }
}

