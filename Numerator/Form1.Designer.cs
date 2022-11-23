namespace Numerator
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PocetniBrojValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ZadnjibrojValue = new System.Windows.Forms.NumericUpDown();
            this.NumberNumerator = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetniBrojValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadnjibrojValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNumerator)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(428, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Vise vrednosti";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj numeratora";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 183);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PocetniBrojValue);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Step);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ZadnjibrojValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numerator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PocetniBrojValue
            // 
            this.PocetniBrojValue.Location = new System.Drawing.Point(130, 16);
            this.PocetniBrojValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.PocetniBrojValue.Name = "PocetniBrojValue";
            this.PocetniBrojValue.Size = new System.Drawing.Size(120, 22);
            this.PocetniBrojValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prvi broj";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Korak";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(130, 86);
            this.Step.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(120, 22);
            this.Step.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Poslednji broj";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZadnjibrojValue
            // 
            this.ZadnjibrojValue.Location = new System.Drawing.Point(130, 54);
            this.ZadnjibrojValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.ZadnjibrojValue.Name = "ZadnjibrojValue";
            this.ZadnjibrojValue.Size = new System.Drawing.Size(120, 22);
            this.ZadnjibrojValue.TabIndex = 3;
            // 
            // NumberNumerator
            // 
            this.NumberNumerator.Location = new System.Drawing.Point(553, 62);
            this.NumberNumerator.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumberNumerator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberNumerator.Name = "NumberNumerator";
            this.NumberNumerator.Size = new System.Drawing.Size(120, 20);
            this.NumberNumerator.TabIndex = 9;
            this.NumberNumerator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pokreni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(294, 233);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 448);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberNumerator);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PocetniBrojValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadnjibrojValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberNumerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown NumberNumerator;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown PocetniBrojValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Step;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ZadnjibrojValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label output;
    }
}

