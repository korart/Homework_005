namespace WinFormsApp
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
			button1 = new Button();
			listBox1 = new ListBox();
			button2 = new Button();
			groupBox1 = new GroupBox();
			textBox1 = new TextBox();
			numericUpDown1 = new NumericUpDown();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(35, 475);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(86, 31);
			button1.TabIndex = 0;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.Location = new Point(21, 21);
			listBox1.Margin = new Padding(3, 4, 3, 4);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(244, 444);
			listBox1.TabIndex = 1;
			// 
			// button2
			// 
			button2.Location = new Point(162, 475);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(86, 31);
			button2.TabIndex = 2;
			button2.Text = "Del";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Location = new Point(24, 529);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(238, 127);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "New emp";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(11, 68);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(212, 27);
			textBox1.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(11, 29);
			numericUpDown1.Margin = new Padding(3, 4, 3, 4);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(213, 27);
			numericUpDown1.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(289, 680);
			Controls.Add(groupBox1);
			Controls.Add(button2);
			Controls.Add(listBox1);
			Controls.Add(button1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
        private ListBox listBox1;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}
