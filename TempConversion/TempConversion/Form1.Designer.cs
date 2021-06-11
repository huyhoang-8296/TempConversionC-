
namespace TempConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.Celsius = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_farenheight = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_farenheight = new System.Windows.Forms.Button();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farenheight";
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Celsius.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Celsius.Location = new System.Drawing.Point(45, 135);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(59, 21);
            this.Celsius.TabIndex = 1;
            this.Celsius.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(52, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_farenheight
            // 
            this.txt_farenheight.Location = new System.Drawing.Point(214, 45);
            this.txt_farenheight.Name = "txt_farenheight";
            this.txt_farenheight.Size = new System.Drawing.Size(100, 23);
            this.txt_farenheight.TabIndex = 3;
            this.txt_farenheight.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(214, 133);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(100, 23);
            this.txt_celsius.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Location = new System.Drawing.Point(214, 226);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(100, 23);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_farenheight
            // 
            this.btn_farenheight.Location = new System.Drawing.Point(409, 47);
            this.btn_farenheight.Name = "btn_farenheight";
            this.btn_farenheight.Size = new System.Drawing.Size(75, 23);
            this.btn_farenheight.TabIndex = 6;
            this.btn_farenheight.Text = "Convert";
            this.btn_farenheight.UseVisualStyleBackColor = true;
            this.btn_farenheight.Click += new System.EventHandler(this.btn_farenheight_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.Location = new System.Drawing.Point(409, 132);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(75, 23);
            this.btn_celsius.TabIndex = 7;
            this.btn_celsius.Text = "Convert";
            this.btn_celsius.UseVisualStyleBackColor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click_1);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Location = new System.Drawing.Point(409, 225);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(75, 23);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 334);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.btn_farenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_farenheight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Celsius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_farenheight;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_farenheight;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

