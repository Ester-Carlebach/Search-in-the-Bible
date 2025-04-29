namespace GUI_UI_PL
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
            l1 = new ListBox();
            wordToSearch = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(249, 95);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 0;
            button1.Text = "חפש";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // l1
            // 
            l1.FormattingEnabled = true;
            l1.ItemHeight = 20;
            l1.Location = new Point(12, 157);
            l1.Name = "l1";
            l1.Size = new Size(577, 344);
            l1.TabIndex = 3;
            l1.SelectedIndexChanged += l1_SelectedIndexChanged;
            // 
            // wordToSearch
            // 
            wordToSearch.Location = new Point(249, 27);
            wordToSearch.Name = "wordToSearch";
            wordToSearch.PlaceholderText = "הכנס מילה לחיפוש";
            wordToSearch.Size = new Size(131, 27);
            wordToSearch.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 74);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "הכנס שם ספר בו תרצה לחפש";
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 5;
            textBox1.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(31, 27);
            button2.Name = "button2";
            button2.Size = new Size(171, 29);
            button2.TabIndex = 6;
            button2.Text = "לחיפוש ע\"פ ספר";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 522);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 27);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 545);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(wordToSearch);
            Controls.Add(l1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button button1;
        private ListBox l1;
        private TextBox wordToSearch;
        private TextBox textBox1;
        private Button button2;
        private PageSetupDialog pageSetupDialog1;
        private TextBox textBox2;
    }
}