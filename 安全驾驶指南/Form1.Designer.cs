namespace 安全驾驶指南
{
    partial class SafeDrivingGuideForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDe = new System.Windows.Forms.TextBox();
            this.textBoxEn = new System.Windows.Forms.TextBox();
            this.btnEnCode = new System.Windows.Forms.Button();
            this.btnDeCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDe
            // 
            this.textBoxDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDe.Location = new System.Drawing.Point(12, 12);
            this.textBoxDe.Multiline = true;
            this.textBoxDe.Name = "textBoxDe";
            this.textBoxDe.Size = new System.Drawing.Size(240, 320);
            this.textBoxDe.TabIndex = 0;
            // 
            // textBoxEn
            // 
            this.textBoxEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEn.Location = new System.Drawing.Point(339, 12);
            this.textBoxEn.Multiline = true;
            this.textBoxEn.Name = "textBoxEn";
            this.textBoxEn.Size = new System.Drawing.Size(240, 320);
            this.textBoxEn.TabIndex = 1;
            // 
            // btnEnCode
            // 
            this.btnEnCode.Location = new System.Drawing.Point(258, 106);
            this.btnEnCode.Name = "btnEnCode";
            this.btnEnCode.Size = new System.Drawing.Size(75, 23);
            this.btnEnCode.TabIndex = 2;
            this.btnEnCode.Text = "Encode>>";
            this.btnEnCode.UseVisualStyleBackColor = true;
            this.btnEnCode.Click += new System.EventHandler(this.btnEnCode_Click);
            // 
            // btnDeCode
            // 
            this.btnDeCode.Location = new System.Drawing.Point(258, 180);
            this.btnDeCode.Name = "btnDeCode";
            this.btnDeCode.Size = new System.Drawing.Size(75, 23);
            this.btnDeCode.TabIndex = 3;
            this.btnDeCode.Text = "<<Decode";
            this.btnDeCode.UseVisualStyleBackColor = true;
            this.btnDeCode.Click += new System.EventHandler(this.btnDeCode_Click);
            // 
            // SafeDrivingGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.btnDeCode);
            this.Controls.Add(this.btnEnCode);
            this.Controls.Add(this.textBoxEn);
            this.Controls.Add(this.textBoxDe);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 383);
            this.MinimumSize = new System.Drawing.Size(608, 383);
            this.Name = "SafeDrivingGuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安全驾驶指南";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDe;
        private System.Windows.Forms.TextBox textBoxEn;
        private System.Windows.Forms.Button btnEnCode;
        private System.Windows.Forms.Button btnDeCode;
    }
}

