namespace CSEnshu
{
    partial class Form2
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
            this.addStockBox = new System.Windows.Forms.TextBox();
            this.addExecuteButton = new System.Windows.Forms.Button();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(154, 67);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(41, 12);
            this.itemName.TabIndex = 0;
            this.itemName.Text = "商品名";
            // 
            // currentStock
            // 
            this.currentStock.AutoSize = true;
            this.currentStock.Location = new System.Drawing.Point(134, 104);
            this.currentStock.Name = "currentStock";
            this.currentStock.Size = new System.Drawing.Size(41, 12);
            this.currentStock.TabIndex = 0;
            this.currentStock.Text = "現在庫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "個";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "個";
            // 
            // addStockBox
            // 
            this.addStockBox.Location = new System.Drawing.Point(75, 132);
            this.addStockBox.Name = "addStockBox";
            this.addStockBox.Size = new System.Drawing.Size(100, 19);
            this.addStockBox.TabIndex = 1;
            // 
            // addExecuteButton
            // 
            this.addExecuteButton.Location = new System.Drawing.Point(57, 180);
            this.addExecuteButton.Name = "addExecuteButton";
            this.addExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.addExecuteButton.TabIndex = 2;
            this.addExecuteButton.Text = "追加";
            this.addExecuteButton.UseVisualStyleBackColor = true;
            this.addExecuteButton.Click += new System.EventHandler(this.addExecuteButton_Click);
            // 
            // addCancelButton
            // 
            this.addCancelButton.Location = new System.Drawing.Point(202, 179);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addCancelButton.TabIndex = 3;
            this.addCancelButton.Text = "キャンセル";
            this.addCancelButton.UseVisualStyleBackColor = true;
            this.addCancelButton.Click += new System.EventHandler(this.addCancelButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(43, 29);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(74, 12);
            this.errorMessage.TabIndex = 4;
            this.errorMessage.Text = "errorMessage";
            this.errorMessage.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.addCancelButton);
            this.Controls.Add(this.addExecuteButton);
            this.Controls.Add(this.addStockBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentStock);
            this.Controls.Add(this.itemName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label currentStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addStockBox;
        private System.Windows.Forms.Button addExecuteButton;
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.Label errorMessage;
    }
}