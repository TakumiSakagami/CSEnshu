namespace CSEnshu
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultText = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.ListBox();
            this.itemSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.addStockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(82, 9);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(35, 12);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "label1";
            this.resultText.Visible = false;
            // 
            // searchResult
            // 
            this.searchResult.FormattingEnabled = true;
            this.searchResult.ItemHeight = 12;
            this.searchResult.Location = new System.Drawing.Point(135, 59);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(239, 172);
            this.searchResult.TabIndex = 1;
            this.searchResult.SelectedIndexChanged += new System.EventHandler(this.searchResult_SelectedIndexChanged);
            // 
            // itemSearchBox
            // 
            this.itemSearchBox.Location = new System.Drawing.Point(135, 34);
            this.itemSearchBox.Name = "itemSearchBox";
            this.itemSearchBox.Size = new System.Drawing.Size(239, 19);
            this.itemSearchBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(406, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(84, 255);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "注文";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(385, 254);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(75, 23);
            this.addStockButton.TabIndex = 5;
            this.addStockButton.Text = "在庫追加";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.itemSearchBox);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.resultText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.ListBox searchResult;
        private System.Windows.Forms.TextBox itemSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button addStockButton;
    }
}

