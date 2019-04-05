namespace WordCounting
{
    partial class MainViev
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
            this.rTxbSourceText = new System.Windows.Forms.RichTextBox();
            this.dgvSeparateList = new System.Windows.Forms.DataGridView();
            this.btnSeparate = new System.Windows.Forms.Button();
            this.txbSeparator = new System.Windows.Forms.TextBox();
            this.lbSeparator = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparateList)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxbSourceText
            // 
            this.rTxbSourceText.Location = new System.Drawing.Point(24, 24);
            this.rTxbSourceText.Name = "rTxbSourceText";
            this.rTxbSourceText.Size = new System.Drawing.Size(427, 395);
            this.rTxbSourceText.TabIndex = 0;
            this.rTxbSourceText.Text = "";
            // 
            // dgvSeparateList
            // 
            this.dgvSeparateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeparateList.Location = new System.Drawing.Point(591, 24);
            this.dgvSeparateList.Name = "dgvSeparateList";
            this.dgvSeparateList.Size = new System.Drawing.Size(327, 395);
            this.dgvSeparateList.TabIndex = 1;
            // 
            // btnSeparate
            // 
            this.btnSeparate.Location = new System.Drawing.Point(474, 221);
            this.btnSeparate.Name = "btnSeparate";
            this.btnSeparate.Size = new System.Drawing.Size(75, 23);
            this.btnSeparate.TabIndex = 2;
            this.btnSeparate.Text = "Separate";
            this.btnSeparate.UseVisualStyleBackColor = true;
            this.btnSeparate.Click += new System.EventHandler(this.btnSeparate_Click);
            // 
            // txbSeparator
            // 
            this.txbSeparator.Location = new System.Drawing.Point(193, 441);
            this.txbSeparator.Name = "txbSeparator";
            this.txbSeparator.Size = new System.Drawing.Size(100, 20);
            this.txbSeparator.TabIndex = 3;
            // 
            // lbSeparator
            // 
            this.lbSeparator.AutoSize = true;
            this.lbSeparator.Location = new System.Drawing.Point(24, 444);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(163, 13);
            this.lbSeparator.TabIndex = 4;
            this.lbSeparator.Text = "Zadaj oddelovače a oddeľ ich * :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set Separator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainViev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.txbSeparator);
            this.Controls.Add(this.btnSeparate);
            this.Controls.Add(this.dgvSeparateList);
            this.Controls.Add(this.rTxbSourceText);
            this.Name = "MainViev";
            this.Text = "Separate Word";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeparateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxbSourceText;
        private System.Windows.Forms.DataGridView dgvSeparateList;
        private System.Windows.Forms.Button btnSeparate;
        private System.Windows.Forms.TextBox txbSeparator;
        private System.Windows.Forms.Label lbSeparator;
        private System.Windows.Forms.Button button2;
    }
}

