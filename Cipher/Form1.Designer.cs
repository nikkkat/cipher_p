namespace Cipher
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
            keyTextBox = new TextBox();
            plainTextBox = new TextBox();
            cipherTextBox = new TextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(91, 43);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(197, 23);
            keyTextBox.TabIndex = 0;
            // 
            // plainTextBox
            // 
            plainTextBox.Location = new Point(91, 117);
            plainTextBox.Multiline = true;
            plainTextBox.Name = "plainTextBox";
            plainTextBox.Size = new Size(197, 72);
            plainTextBox.TabIndex = 1;
            // 
            // cipherTextBox
            // 
            cipherTextBox.Location = new Point(91, 222);
            cipherTextBox.Multiline = true;
            cipherTextBox.Name = "cipherTextBox";
            cipherTextBox.Size = new Size(197, 72);
            cipherTextBox.TabIndex = 2;
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(387, 195);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(75, 23);
            encryptButton.TabIndex = 3;
            encryptButton.Text = "encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Location = new Point(561, 195);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(75, 23);
            decryptButton.TabIndex = 4;
            decryptButton.Text = "decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "ключ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 6;
            label2.Text = "исходный текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 204);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "шифротекст";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 286);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 126);
            textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(cipherTextBox);
            Controls.Add(plainTextBox);
            Controls.Add(keyTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox keyTextBox;
        private TextBox plainTextBox;
        private TextBox cipherTextBox;
        private Button encryptButton;
        private Button decryptButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
