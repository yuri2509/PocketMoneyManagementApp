namespace PocketMoneyManagementApp
{
    partial class MenuForm
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
            this.MoneyManagemenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoneyManagemenButton
            // 
            this.MoneyManagemenButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoneyManagemenButton.Location = new System.Drawing.Point(0, 0);
            this.MoneyManagemenButton.Name = "MoneyManagemenButton";
            this.MoneyManagemenButton.Size = new System.Drawing.Size(260, 61);
            this.MoneyManagemenButton.TabIndex = 0;
            this.MoneyManagemenButton.Text = "今月の命";
            this.MoneyManagemenButton.UseVisualStyleBackColor = true;
            this.MoneyManagemenButton.Click += new System.EventHandler(this.MoneyManagemenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.Location = new System.Drawing.Point(0, 61);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(260, 61);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 293);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MoneyManagemenButton);
            this.Name = "MenuForm";
            this.Text = "メニュー画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MoneyManagemenButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

