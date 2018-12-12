namespace CSEnshu
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(124, 9);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(35, 12);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "label1";
            this.resultText.Visible = false;
            this.resultText.Click += new System.EventHandler(this.resultText_Click);
            // 
            // searchResult
            // 
            this.searchResult.FormattingEnabled = true;
            this.searchResult.ItemHeight = 12;
            this.searchResult.Location = new System.Drawing.Point(124, 100);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(397, 172);
            this.searchResult.TabIndex = 1;
            this.searchResult.SelectedIndexChanged += new System.EventHandler(this.searchResult_SelectedIndexChanged);
            // 
            // itemSearchBox
            // 
            this.itemSearchBox.Location = new System.Drawing.Point(124, 54);
            this.itemSearchBox.Name = "itemSearchBox";
            this.itemSearchBox.Size = new System.Drawing.Size(239, 19);
            this.itemSearchBox.TabIndex = 2;
            this.itemSearchBox.TextChanged += new System.EventHandler(this.itemSearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(385, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(84, 278);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "注文";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // addStockButton
            // 
            this.addStockButton.Location = new System.Drawing.Point(406, 254);
            this.addStockButton.Name = "addStockButton";
            this.addStockButton.Size = new System.Drawing.Size(75, 23);
            this.addStockButton.TabIndex = 5;
            this.addStockButton.Text = "在庫追加";
            this.addStockButton.UseVisualStyleBackColor = true;
            this.addStockButton.Click += new System.EventHandler(this.addStockButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStockButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.itemSearchBox);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.resultText);
            this.Name = "Main";
            this.Text = "商品選択";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label resultText;
        internal System.Windows.Forms.ListBox searchResult;
        internal System.Windows.Forms.TextBox itemSearchBox;
        internal System.Windows.Forms.Button searchButton;
        internal System.Windows.Forms.Button orderButton;
        internal System.Windows.Forms.Button addStockButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

