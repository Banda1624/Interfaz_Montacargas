namespace Interfaz_Montacargas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Min2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.Min = new FontAwesome.Sharp.IconPictureBox();
            this.iconSubir = new FontAwesome.Sharp.IconPictureBox();
            this.iconBajar = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbAlert = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AltoTotal = new FontAwesome.Sharp.IconPictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txbxOut = new System.Windows.Forms.TextBox();
            this.bttStart = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSubir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltoTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.Min2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.iconPictureBox5);
            this.panel1.Controls.Add(this.Min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Min2
            // 
            this.Min2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Min2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Min2.IconColor = System.Drawing.SystemColors.ControlText;
            this.Min2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Min2.Location = new System.Drawing.Point(647, 0);
            this.Min2.Name = "Min2";
            this.Min2.Size = new System.Drawing.Size(32, 33);
            this.Min2.TabIndex = 3;
            this.Min2.TabStop = false;
            this.Min2.MouseHover += new System.EventHandler(this.Min2_MouseHover);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(679, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 33);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseHover += new System.EventHandler(this.iconPictureBox1_MouseHover);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.Location = new System.Drawing.Point(679, 0);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 33);
            this.iconPictureBox5.TabIndex = 2;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            this.iconPictureBox5.MouseLeave += new System.EventHandler(this.iconPictureBox5_MouseLeave);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.Min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.Min.IconColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Min.Location = new System.Drawing.Point(647, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(32, 33);
            this.Min.TabIndex = 1;
            this.Min.TabStop = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            this.Min.MouseLeave += new System.EventHandler(this.Min_MouseLeave);
            // 
            // iconSubir
            // 
            this.iconSubir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.iconSubir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSubir.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconSubir.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSubir.IconSize = 49;
            this.iconSubir.Location = new System.Drawing.Point(231, 74);
            this.iconSubir.Name = "iconSubir";
            this.iconSubir.Size = new System.Drawing.Size(49, 49);
            this.iconSubir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconSubir.TabIndex = 1;
            this.iconSubir.TabStop = false;
            // 
            // iconBajar
            // 
            this.iconBajar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.iconBajar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconBajar.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.iconBajar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconBajar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBajar.IconSize = 49;
            this.iconBajar.Location = new System.Drawing.Point(231, 149);
            this.iconBajar.Name = "iconBajar";
            this.iconBajar.Size = new System.Drawing.Size(49, 49);
            this.iconBajar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconBajar.TabIndex = 2;
            this.iconBajar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LbAlert
            // 
            this.LbAlert.AutoSize = true;
            this.LbAlert.Location = new System.Drawing.Point(455, 142);
            this.LbAlert.Name = "LbAlert";
            this.LbAlert.Size = new System.Drawing.Size(119, 13);
            this.LbAlert.TabIndex = 12;
            this.LbAlert.Text = "Peso Maximo Superado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Presencia de Humo en la Cabina";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(413, 246);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "La Puerta está Obstruida";
            // 
            // AltoTotal
            // 
            this.AltoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.AltoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.AltoTotal.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.AltoTotal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(0)))));
            this.AltoTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AltoTotal.IconSize = 45;
            this.AltoTotal.Location = new System.Drawing.Point(231, 246);
            this.AltoTotal.Name = "AltoTotal";
            this.AltoTotal.Size = new System.Drawing.Size(47, 45);
            this.AltoTotal.TabIndex = 17;
            this.AltoTotal.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alto Total";
            // 
            // txbxOut
            // 
            this.txbxOut.Location = new System.Drawing.Point(12, 142);
            this.txbxOut.Name = "txbxOut";
            this.txbxOut.Size = new System.Drawing.Size(161, 20);
            this.txbxOut.TabIndex = 19;
            // 
            // bttStart
            // 
            this.bttStart.Location = new System.Drawing.Point(26, 87);
            this.bttStart.Name = "bttStart";
            this.bttStart.Size = new System.Drawing.Size(75, 23);
            this.bttStart.TabIndex = 20;
            this.bttStart.Text = "Start Port";
            this.bttStart.UseVisualStyleBackColor = true;
            this.bttStart.Click += new System.EventHandler(this.bttStart_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 56);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Peso en gramos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(711, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.bttStart);
            this.Controls.Add(this.txbxOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AltoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbAlert);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iconBajar);
            this.Controls.Add(this.iconSubir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSubir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AltoTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox Min;
        private FontAwesome.Sharp.IconPictureBox iconSubir;
        private FontAwesome.Sharp.IconPictureBox iconBajar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox Min2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbAlert;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox AltoTotal;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxOut;
        private System.Windows.Forms.Button bttStart;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

