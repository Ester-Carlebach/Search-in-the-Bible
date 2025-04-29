namespace GUI_UI_PL
{
    partial class Browse
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
            button1 = new Button();
            perek = new TextBox();
            book = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(328, 103);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 0;
            button1.Text = "חיפוש";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // perek
            // 
            perek.Location = new Point(318, 70);
            perek.Name = "perek";
            perek.PlaceholderText = "שם פרק";
            perek.Size = new Size(125, 27);
            perek.TabIndex = 1;
            // 
            // book
            // 
            book.Location = new Point(318, 37);
            book.Name = "book";
            book.PlaceholderText = "שם ספר";
            book.Size = new Size(125, 27);
            book.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 177);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(650, 313);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Browse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 534);
            Controls.Add(textBox1);
            Controls.Add(book);
            Controls.Add(perek);
            Controls.Add(button1);
            Name = "Browse";
            Text = "Browse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox perek;
        private TextBox book;
        private TextBox textBox1;
    }
}