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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeDrivingGuideForm));
            this.btnEnCode = new System.Windows.Forms.Button();
            this.btnDeCode = new System.Windows.Forms.Button();
            this.richTextBoxEn = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
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
            // richTextBoxEn
            // 
            this.richTextBoxEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxEn.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEn.Location = new System.Drawing.Point(340, 12);
            this.richTextBoxEn.Name = "richTextBoxEn";
            this.richTextBoxEn.Size = new System.Drawing.Size(240, 321);
            this.richTextBoxEn.TabIndex = 4;
            this.richTextBoxEn.Text = "";
            // 
            // richTextBoxDe
            // 
            this.richTextBoxDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDe.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDe.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxDe.Name = "richTextBoxDe";
            this.richTextBoxDe.Size = new System.Drawing.Size(240, 321);
            this.richTextBoxDe.TabIndex = 5;
            this.richTextBoxDe.Text = "";
            // 
            // SafeDrivingGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.richTextBoxDe);
            this.Controls.Add(this.richTextBoxEn);
            this.Controls.Add(this.btnDeCode);
            this.Controls.Add(this.btnEnCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 383);
            this.MinimumSize = new System.Drawing.Size(608, 383);
            this.Name = "SafeDrivingGuideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安全驾驶指南";
            this.Click += new System.EventHandler(this.SafeDrivingGuideForm_Click);
            this.DoubleClick += new System.EventHandler(this.SafeDrivingGuideForm_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnCode;
        private System.Windows.Forms.Button btnDeCode;
        private System.Windows.Forms.RichTextBox richTextBoxEn;
        private System.Windows.Forms.RichTextBox richTextBoxDe;
    }
}

