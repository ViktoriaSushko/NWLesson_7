namespace NWLesson_7
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            btnHTTPClientRec = new Button();
            btnUkrNet = new Button();
            btnWebClientRec = new Button();
            btnReceive = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(486, 129);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(486, 143);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 308);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(486, 174);
            textBox3.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(36, 499);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(479, 224);
            listBox1.TabIndex = 3;
            // 
            // btnHTTPClientRec
            // 
            btnHTTPClientRec.Location = new Point(599, 36);
            btnHTTPClientRec.Name = "btnHTTPClientRec";
            btnHTTPClientRec.Size = new Size(142, 53);
            btnHTTPClientRec.TabIndex = 4;
            btnHTTPClientRec.Text = "Receive HTTPClient";
            btnHTTPClientRec.UseVisualStyleBackColor = true;
            btnHTTPClientRec.Click += btnHTTPClientRec_Click;
            // 
            // btnUkrNet
            // 
            btnUkrNet.Location = new Point(599, 168);
            btnUkrNet.Name = "btnUkrNet";
            btnUkrNet.Size = new Size(142, 53);
            btnUkrNet.TabIndex = 5;
            btnUkrNet.Text = "Receive ukr.net";
            btnUkrNet.UseVisualStyleBackColor = true;
            btnUkrNet.Click += btnUkrNet_Click;
            // 
            // btnWebClientRec
            // 
            btnWebClientRec.Location = new Point(599, 319);
            btnWebClientRec.Name = "btnWebClientRec";
            btnWebClientRec.Size = new Size(142, 53);
            btnWebClientRec.TabIndex = 6;
            btnWebClientRec.Text = "Receive webClient";
            btnWebClientRec.UseVisualStyleBackColor = true;
            btnWebClientRec.Click += btnWebClientRec_Click;
            // 
            // btnReceive
            // 
            btnReceive.Location = new Point(599, 499);
            btnReceive.Name = "btnReceive";
            btnReceive.Size = new Size(142, 53);
            btnReceive.TabIndex = 7;
            btnReceive.Text = "Receive";
            btnReceive.UseVisualStyleBackColor = true;
            btnReceive.Click += btnReceive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 725);
            Controls.Add(btnReceive);
            Controls.Add(btnWebClientRec);
            Controls.Add(btnUkrNet);
            Controls.Add(btnHTTPClientRec);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ListBox listBox1;
        private Button btnHTTPClientRec;
        private Button btnUkrNet;
        private Button btnWebClientRec;
        private Button btnReceive;
    }
}
