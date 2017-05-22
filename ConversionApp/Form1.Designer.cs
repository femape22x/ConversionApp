namespace ConversionApp
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabControlCalculator = new System.Windows.Forms.TabPage();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cbxOperador = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.TabControlConversions = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cbxConversion = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblConversion = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.rdbAutor = new System.Windows.Forms.RadioButton();
            this.rdbConversions = new System.Windows.Forms.RadioButton();
            this.rdbCalculator = new System.Windows.Forms.RadioButton();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabControlCalculator.SuspendLayout();
            this.TabControlConversions.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabControlCalculator);
            this.TabControl.Controls.Add(this.TabControlConversions);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(6, 18);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(573, 316);
            this.TabControl.TabIndex = 0;
            // 
            // TabControlCalculator
            // 
            this.TabControlCalculator.Controls.Add(this.btnBorrar);
            this.TabControlCalculator.Controls.Add(this.lblResult);
            this.TabControlCalculator.Controls.Add(this.txtNumero2);
            this.TabControlCalculator.Controls.Add(this.cbxOperador);
            this.TabControlCalculator.Controls.Add(this.btnCalcular);
            this.TabControlCalculator.Controls.Add(this.txtNumero1);
            this.TabControlCalculator.Controls.Add(this.lblResultado);
            this.TabControlCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlCalculator.Location = new System.Drawing.Point(4, 59);
            this.TabControlCalculator.Name = "TabControlCalculator";
            this.TabControlCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.TabControlCalculator.Size = new System.Drawing.Size(565, 253);
            this.TabControlCalculator.TabIndex = 0;
            this.TabControlCalculator.Text = "tabPage1";
            this.TabControlCalculator.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(44, 99);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(91, 20);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Resultado";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(281, 29);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(155, 26);
            this.txtNumero2.TabIndex = 7;
            this.txtNumero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero2_KeyPress);
            // 
            // cbxOperador
            // 
            this.cbxOperador.FormattingEnabled = true;
            this.cbxOperador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cbxOperador.Location = new System.Drawing.Point(219, 29);
            this.cbxOperador.Name = "cbxOperador";
            this.cbxOperador.Size = new System.Drawing.Size(45, 28);
            this.cbxOperador.TabIndex = 6;
            this.cbxOperador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxOperador_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(442, 27);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 34);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(48, 29);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(155, 26);
            this.txtNumero1.TabIndex = 4;
            this.txtNumero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero1_KeyPress);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(154, 99);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(282, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabControlConversions
            // 
            this.TabControlConversions.Controls.Add(this.btnLimpiar);
            this.TabControlConversions.Controls.Add(this.lblValor);
            this.TabControlConversions.Controls.Add(this.lblNumero);
            this.TabControlConversions.Controls.Add(this.cbxConversion);
            this.TabControlConversions.Controls.Add(this.txtNumero);
            this.TabControlConversions.Controls.Add(this.lblConversion);
            this.TabControlConversions.Location = new System.Drawing.Point(4, 59);
            this.TabControlConversions.Name = "TabControlConversions";
            this.TabControlConversions.Padding = new System.Windows.Forms.Padding(3);
            this.TabControlConversions.Size = new System.Drawing.Size(565, 253);
            this.TabControlConversions.TabIndex = 1;
            this.TabControlConversions.Text = "tabPage2";
            this.TabControlConversions.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::ConversionApp.Properties.Resources.Clear2;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(272, 147);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 45);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(36, 90);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 20);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Resultado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(36, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // cbxConversion
            // 
            this.cbxConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConversion.FormattingEnabled = true;
            this.cbxConversion.Items.AddRange(new object[] {
            "Binario - Decimal",
            "Binario - Hexadecimal",
            "Decimal - Binario",
            "Decimal - Hexadecimal",
            "Hexadecimal - Binario",
            "Hexadecimal - Decimal"});
            this.cbxConversion.Location = new System.Drawing.Point(335, 32);
            this.cbxConversion.Name = "cbxConversion";
            this.cbxConversion.Size = new System.Drawing.Size(180, 28);
            this.cbxConversion.TabIndex = 2;
            this.cbxConversion.Text = "Seleccione";
            this.cbxConversion.SelectedIndexChanged += new System.EventHandler(this.cbxConversion_SelectedIndexChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(165, 31);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(155, 26);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblConversion
            // 
            this.lblConversion.Location = new System.Drawing.Point(161, 87);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(354, 26);
            this.lblConversion.TabIndex = 0;
            this.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel.Controls.Add(this.rdbAutor);
            this.Panel.Controls.Add(this.rdbConversions);
            this.Panel.Controls.Add(this.rdbCalculator);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(573, 65);
            this.Panel.TabIndex = 2;
            // 
            // rdbAutor
            // 
            this.rdbAutor.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbAutor.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAutor.FlatAppearance.BorderSize = 0;
            this.rdbAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.rdbAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAutor.ForeColor = System.Drawing.Color.White;
            this.rdbAutor.Location = new System.Drawing.Point(249, 0);
            this.rdbAutor.Name = "rdbAutor";
            this.rdbAutor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbAutor.Size = new System.Drawing.Size(99, 65);
            this.rdbAutor.TabIndex = 2;
            this.rdbAutor.Text = "Autor";
            this.rdbAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbAutor.UseCompatibleTextRendering = true;
            this.rdbAutor.UseMnemonic = false;
            this.rdbAutor.UseVisualStyleBackColor = false;
            this.rdbAutor.Click += new System.EventHandler(this.rdbAutor_CheckedChanged);
            // 
            // rdbConversions
            // 
            this.rdbConversions.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbConversions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbConversions.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbConversions.FlatAppearance.BorderSize = 0;
            this.rdbConversions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.rdbConversions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbConversions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbConversions.ForeColor = System.Drawing.Color.White;
            this.rdbConversions.Location = new System.Drawing.Point(130, 0);
            this.rdbConversions.Name = "rdbConversions";
            this.rdbConversions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbConversions.Size = new System.Drawing.Size(125, 65);
            this.rdbConversions.TabIndex = 1;
            this.rdbConversions.Text = "Conversiones";
            this.rdbConversions.UseCompatibleTextRendering = true;
            this.rdbConversions.UseMnemonic = false;
            this.rdbConversions.UseVisualStyleBackColor = false;
            this.rdbConversions.CheckedChanged += new System.EventHandler(this.rdbConversions_CheckedChanged);
            // 
            // rdbCalculator
            // 
            this.rdbCalculator.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rdbCalculator.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbCalculator.FlatAppearance.BorderSize = 0;
            this.rdbCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.rdbCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.rdbCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCalculator.ForeColor = System.Drawing.Color.White;
            this.rdbCalculator.Location = new System.Drawing.Point(12, 0);
            this.rdbCalculator.Name = "rdbCalculator";
            this.rdbCalculator.Size = new System.Drawing.Size(119, 65);
            this.rdbCalculator.TabIndex = 0;
            this.rdbCalculator.Text = "Calculadora";
            this.rdbCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbCalculator.UseVisualStyleBackColor = true;
            this.rdbCalculator.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(442, 92);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 34);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 316);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversionApp";
            this.TabControl.ResumeLayout(false);
            this.TabControlCalculator.ResumeLayout(false);
            this.TabControlCalculator.PerformLayout();
            this.TabControlConversions.ResumeLayout(false);
            this.TabControlConversions.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabControlCalculator;
        private System.Windows.Forms.TabPage TabControlConversions;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.RadioButton rdbCalculator;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.RadioButton rdbConversions;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cbxOperador;
        private System.Windows.Forms.ComboBox cbxConversion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rdbAutor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnBorrar;
    }
}

