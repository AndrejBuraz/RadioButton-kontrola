﻿namespace RadioButtonKontrola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonVlastiti = new System.Windows.Forms.RadioButton();
            this.radioButtonAutobus = new System.Windows.Forms.RadioButton();
            this.radioButtonAvion = new System.Windows.Forms.RadioButton();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVlastiti);
            this.groupBox1.Controls.Add(this.radioButtonAutobus);
            this.groupBox1.Controls.Add(this.radioButtonAvion);
            this.groupBox1.Location = new System.Drawing.Point(54, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // radioButtonVlastiti
            // 
            this.radioButtonVlastiti.AutoSize = true;
            this.radioButtonVlastiti.Location = new System.Drawing.Point(10, 74);
            this.radioButtonVlastiti.Name = "radioButtonVlastiti";
            this.radioButtonVlastiti.Size = new System.Drawing.Size(104, 19);
            this.radioButtonVlastiti.TabIndex = 2;
            this.radioButtonVlastiti.TabStop = true;
            this.radioButtonVlastiti.Text = "Vlastiti prijevoz";
            this.radioButtonVlastiti.UseVisualStyleBackColor = true;
            this.radioButtonVlastiti.CheckedChanged += new System.EventHandler(this.radioButtonVlastiti_CheckedChanged);
            // 
            // radioButtonAutobus
            // 
            this.radioButtonAutobus.AutoSize = true;
            this.radioButtonAutobus.Location = new System.Drawing.Point(10, 49);
            this.radioButtonAutobus.Name = "radioButtonAutobus";
            this.radioButtonAutobus.Size = new System.Drawing.Size(70, 19);
            this.radioButtonAutobus.TabIndex = 1;
            this.radioButtonAutobus.TabStop = true;
            this.radioButtonAutobus.Text = "Autobus";
            this.radioButtonAutobus.UseVisualStyleBackColor = true;
            this.radioButtonAutobus.CheckedChanged += new System.EventHandler(this.radioButtonAutobus_CheckedChanged);
            // 
            // radioButtonAvion
            // 
            this.radioButtonAvion.AutoSize = true;
            this.radioButtonAvion.Location = new System.Drawing.Point(10, 24);
            this.radioButtonAvion.Name = "radioButtonAvion";
            this.radioButtonAvion.Size = new System.Drawing.Size(56, 19);
            this.radioButtonAvion.TabIndex = 0;
            this.radioButtonAvion.TabStop = true;
            this.radioButtonAvion.Text = "Avion";
            this.radioButtonAvion.UseVisualStyleBackColor = true;
            this.radioButtonAvion.CheckedChanged += new System.EventHandler(this.radioButtonAvion_CheckedChanged);
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(95, 155);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.buttonRezerviraj.TabIndex = 1;
            this.buttonRezerviraj.Text = "Rezerviraj";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 50);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 302);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonVlastiti;
        private RadioButton radioButtonAutobus;
        private RadioButton radioButtonAvion;
        private Button buttonRezerviraj;
        private TextBox textBox1;
    }
}