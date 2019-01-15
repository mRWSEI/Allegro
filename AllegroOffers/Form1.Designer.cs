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
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.dataGridViewAllegro = new System.Windows.Forms.DataGridView();
            this.labelCenaOd = new System.Windows.Forms.Label();
            this.labelCenaDo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllegro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRequest
            // 
            this.btnSearchRequest.Location = new System.Drawing.Point(713, 67);
            this.btnSearchRequest.Name = "btnSearchRequest";
            this.btnSearchRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRequest.TabIndex = 0;
            this.btnSearchRequest.Text = "Wyszukaj";
            this.btnSearchRequest.UseVisualStyleBackColor = true;
            this.btnSearchRequest.Click += new System.EventHandler(this.btnSearchRequest_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(627, 16);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(161, 20);
            this.textBoxProductName.TabIndex = 2;
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
            // dataGridViewDB
            // 
            this.dataGridViewDB.AllowUserToAddRows = false;
            this.dataGridViewDB.AllowUserToDeleteRows = false;
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(12, 196);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.Size = new System.Drawing.Size(506, 229);
            this.dataGridViewDB.TabIndex = 6;
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.Location = new System.Drawing.Point(592, 41);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(82, 20);
            this.textBoxPriceFrom.TabIndex = 7;
            this.textBoxPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.Location = new System.Drawing.Point(708, 41);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(80, 20);
            this.textBoxPriceTo.TabIndex = 8;
            this.textBoxPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // dataGridViewAllegro
            // 
            this.dataGridViewAllegro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllegro.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewAllegro.Name = "dataGridViewAllegro";
            this.dataGridViewAllegro.Size = new System.Drawing.Size(506, 171);
            this.dataGridViewAllegro.TabIndex = 9;
            // 
            // labelCenaOd
            // 
            this.labelCenaOd.AutoSize = true;
            this.labelCenaOd.Location = new System.Drawing.Point(535, 45);
            this.labelCenaOd.Name = "labelCenaOd";
            this.labelCenaOd.Size = new System.Drawing.Size(50, 13);
            this.labelCenaOd.TabIndex = 10;
            this.labelCenaOd.Text = "Cena od:";
            // 
            // labelCenaDo
            // 
            this.labelCenaDo.AutoSize = true;
            this.labelCenaDo.Location = new System.Drawing.Point(680, 44);
            this.labelCenaDo.Name = "labelCenaDo";
            this.labelCenaDo.Size = new System.Drawing.Size(22, 13);
            this.labelCenaDo.TabIndex = 11;
            this.labelCenaDo.Text = "do:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCenaDo);
            this.Controls.Add(this.labelCenaOd);
            this.Controls.Add(this.dataGridViewAllegro);
            this.Controls.Add(this.textBoxPriceTo);
            this.Controls.Add(this.textBoxPriceFrom);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.btnSearchRequest);
            this.Name = "Form1";
            this.Text = "RSS Feed aukcje Allegro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllegro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRequest;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.DataGridView dataGridViewAllegro;
        private System.Windows.Forms.Label labelCenaOd;
        private System.Windows.Forms.Label labelCenaDo;
    }
}

