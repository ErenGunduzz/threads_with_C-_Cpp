namespace task1
{
    partial class PrimeNums
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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "textBox1";
            textBox1.Location = new Point(43, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(43, 391);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(121, 304);
            listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "textBox2";
            textBox2.Location = new Point(232, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 3;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(232, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(121, 304);
            listBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(232, 391);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PrimeNums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 459);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "PrimeNums";
            Text = "PrimeNums";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox2;
        private ListBox listBox2;
        private Button button2;
    }
}
