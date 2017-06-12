namespace Convert_ExtensionToTXT
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
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ConvertAll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(84, 148);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(337, 20);
            this.textBox_Path.TabIndex = 0;
            this.textBox_Path.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearField);
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(422, 271);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(111, 23);
            this.button_Submit.TabIndex = 1;
            this.button_Submit.Text = "Change Files";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Current Path Below:  Ex. C:\\Users\\Download\\";
            // 
            // label_ConvertAll
            // 
            this.label_ConvertAll.AutoSize = true;
            this.label_ConvertAll.Location = new System.Drawing.Point(81, 227);
            this.label_ConvertAll.Name = "label_ConvertAll";
            this.label_ConvertAll.Size = new System.Drawing.Size(0, 13);
            this.label_ConvertAll.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mass Any Extension to TXT conversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_ConvertAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ConvertAll;
        private System.Windows.Forms.Label label2;
    }
}

