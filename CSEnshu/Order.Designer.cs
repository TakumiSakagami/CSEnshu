namespace CSEnshu
{
    partial class Order
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
            this.itemName = new System.Windows.Forms.Label();
            this.currentStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.ListBox();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.orderExecuteButton = new System.Windows.Forms.Button();
            this.orderCanselButton = new System.Windows.Forms.Button();
            this.orderBox = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(155, 55);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(41, 12);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "商品名";
            // 
            // currentStock
            // 
            this.currentStock.AutoSize = true;
            this.currentStock.Location = new System.Drawing.Point(155, 82);
            this.currentStock.Name = "currentStock";
            this.currentStock.Size = new System.Drawing.Size(41, 12);
            this.currentStock.TabIndex = 0;
            this.currentStock.Text = "現在庫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "個";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "個";
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.Location = new System.Drawing.Point(104, 179);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.Size = new System.Drawing.Size(194, 19);
            this.customerSearchBox.TabIndex = 1;
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.ItemHeight = 12;
            this.customerBox.Location = new System.Drawing.Point(104, 204);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(194, 136);
            this.customerBox.TabIndex = 2;
            this.customerBox.SelectedIndexChanged += new System.EventHandler(this.customerBox_SelectedIndexChanged);
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(304, 175);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 3;
            this.customerSearchButton.Text = "検索";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // orderExecuteButton
            // 
            this.orderExecuteButton.Location = new System.Drawing.Point(59, 359);
            this.orderExecuteButton.Name = "orderExecuteButton";
            this.orderExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.orderExecuteButton.TabIndex = 4;
            this.orderExecuteButton.Text = "注文";
            this.orderExecuteButton.UseVisualStyleBackColor = true;
            this.orderExecuteButton.Click += new System.EventHandler(this.orderExecuteButton_Click);
            // 
            // orderCanselButton
            // 
            this.orderCanselButton.Location = new System.Drawing.Point(277, 359);
            this.orderCanselButton.Name = "orderCanselButton";
            this.orderCanselButton.Size = new System.Drawing.Size(75, 23);
            this.orderCanselButton.TabIndex = 5;
            this.orderCanselButton.Text = "キャンセル";
            this.orderCanselButton.UseVisualStyleBackColor = true;
            this.orderCanselButton.Click += new System.EventHandler(this.orderCanselButton_Click);
            // 
            // orderBox
            // 
            this.orderBox.Location = new System.Drawing.Point(96, 105);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(100, 19);
            this.orderBox.TabIndex = 6;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(61, 25);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(74, 12);
            this.errorMessage.TabIndex = 7;
            this.errorMessage.Text = "errorMessage";
            this.errorMessage.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.orderCanselButton);
            this.Controls.Add(this.orderExecuteButton);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.customerSearchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentStock);
            this.Controls.Add(this.itemName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label currentStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerSearchBox;
        private System.Windows.Forms.ListBox customerBox;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.Button orderExecuteButton;
        private System.Windows.Forms.Button orderCanselButton;
        private System.Windows.Forms.TextBox orderBox;
        private System.Windows.Forms.Label errorMessage;
    }
}