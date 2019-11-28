namespace CALC
{
    partial class CalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.CalcButton = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.zBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xOutput = new System.Windows.Forms.TextBox();
            this.zOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.zlabel = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.zInput = new System.Windows.Forms.TextBox();
            this.xInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.CalcButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.ForeColor = System.Drawing.Color.White;
            this.CalcButton.Location = new System.Drawing.Point(264, 246);
            this.CalcButton.Margin = new System.Windows.Forms.Padding(1);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(82, 42);
            this.CalcButton.TabIndex = 4;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xBox
            // 
            this.xBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xBox.ForeColor = System.Drawing.Color.Black;
            this.xBox.Location = new System.Drawing.Point(145, 38);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(100, 22);
            this.xBox.TabIndex = 5;
            // 
            // zBox
            // 
            this.zBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zBox.ForeColor = System.Drawing.Color.Black;
            this.zBox.Location = new System.Drawing.Point(145, 64);
            this.zBox.Name = "zBox";
            this.zBox.Size = new System.Drawing.Size(100, 22);
            this.zBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "X Center";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Z Center";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // angleBox
            // 
            this.angleBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.angleBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleBox.ForeColor = System.Drawing.Color.Black;
            this.angleBox.Location = new System.Drawing.Point(145, 193);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 22);
            this.angleBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rotation Angle";
            // 
            // xOutput
            // 
            this.xOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xOutput.ForeColor = System.Drawing.Color.Black;
            this.xOutput.Location = new System.Drawing.Point(145, 243);
            this.xOutput.Name = "xOutput";
            this.xOutput.Size = new System.Drawing.Size(100, 22);
            this.xOutput.TabIndex = 7;
            // 
            // zOutput
            // 
            this.zOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zOutput.ForeColor = System.Drawing.Color.Black;
            this.zOutput.Location = new System.Drawing.Point(145, 269);
            this.zOutput.Name = "zOutput";
            this.zOutput.Size = new System.Drawing.Size(100, 22);
            this.zOutput.TabIndex = 8;
            this.zOutput.TextChanged += new System.EventHandler(this.zOutput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rotated X Location";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(22, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Rotated Z Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Machine COR File:";
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pathBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.ForeColor = System.Drawing.Color.Black;
            this.pathBox.Location = new System.Drawing.Point(145, 6);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(254, 22);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "C:\\Users\\Public\\Documents\\XZ.TXT";
            // 
            // zlabel
            // 
            this.zlabel.AutoSize = true;
            this.zlabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.zlabel.Location = new System.Drawing.Point(71, 148);
            this.zlabel.Name = "zlabel";
            this.zlabel.Size = new System.Drawing.Size(68, 16);
            this.zlabel.TabIndex = 15;
            this.zlabel.Text = "Z Location";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.xlabel.Location = new System.Drawing.Point(71, 125);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(68, 16);
            this.xlabel.TabIndex = 14;
            this.xlabel.Text = "X Location";
            // 
            // zInput
            // 
            this.zInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zInput.ForeColor = System.Drawing.Color.Black;
            this.zInput.Location = new System.Drawing.Point(145, 148);
            this.zInput.Name = "zInput";
            this.zInput.Size = new System.Drawing.Size(100, 22);
            this.zInput.TabIndex = 2;
            // 
            // xInput
            // 
            this.xInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xInput.ForeColor = System.Drawing.Color.Black;
            this.xInput.Location = new System.Drawing.Point(145, 122);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(100, 22);
            this.xInput.TabIndex = 1;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(411, 312);
            this.Controls.Add(this.zlabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.zInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zOutput);
            this.Controls.Add(this.xOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.CalcButton);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CalcForm";
            this.Text = "Tomb Calc";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox zBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xOutput;
        private System.Windows.Forms.TextBox zOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label zlabel;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.TextBox zInput;
        private System.Windows.Forms.TextBox xInput;
    }
}

