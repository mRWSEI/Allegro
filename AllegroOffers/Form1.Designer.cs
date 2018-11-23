namespace AllegroOffers
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
            if(disposing && (components != null))
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
            this.btnSearchRequest = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBoxAuctions = new System.Windows.Forms.ListBox();
            this.listBoxDB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchRequest
            // 
            this.btnSearchRequest.Location = new System.Drawing.Point(527, 82);
            this.btnSearchRequest.Name = "btnSearchRequest";
            this.btnSearchRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRequest.TabIndex = 0;
            this.btnSearchRequest.Text = "Wyszukaj";
            this.btnSearchRequest.UseVisualStyleBackColor = true;
            this.btnSearchRequest.Click += new System.EventHandler(this.btnSearchRequest_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(627, 16);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // listBoxAuctions
            // 
            this.listBoxAuctions.FormattingEnabled = true;
            this.listBoxAuctions.Location = new System.Drawing.Point(12, 12);
            this.listBoxAuctions.Name = "listBoxAuctions";
            this.listBoxAuctions.Size = new System.Drawing.Size(506, 160);
            this.listBoxAuctions.TabIndex = 3;
            // 
            // listBoxDB
            // 
            this.listBoxDB.FormattingEnabled = true;
            this.listBoxDB.Location = new System.Drawing.Point(12, 178);
            this.listBoxDB.Name = "listBoxDB";
            this.listBoxDB.Size = new System.Drawing.Size(506, 186);
            this.listBoxDB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa przedmiotu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDB);
            this.Controls.Add(this.listBoxAuctions);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.btnSearchRequest);
            this.Name = "Form1";
            this.Text = "RSS Feed aukcje Allegro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRequest;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBoxAuctions;
        private System.Windows.Forms.ListBox listBoxDB;
        private System.Windows.Forms.Label label1;
    }
}

