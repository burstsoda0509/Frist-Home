namespace Tesseract_OCR
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOCR = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.resultMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(25, 32);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(405, 213);
            this.txtResult.TabIndex = 0;
            // 
            // btnOCR
            // 
            this.btnOCR.Location = new System.Drawing.Point(299, 257);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(131, 54);
            this.btnOCR.TabIndex = 1;
            this.btnOCR.Text = "OCR";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "轉換結果:";
            // 
            // resultMsg
            // 
            this.resultMsg.AutoSize = true;
            this.resultMsg.Location = new System.Drawing.Point(26, 257);
            this.resultMsg.Name = "resultMsg";
            this.resultMsg.Size = new System.Drawing.Size(25, 12);
            this.resultMsg.TabIndex = 3;
            this.resultMsg.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 319);
            this.Controls.Add(this.resultMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOCR);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "OCR圖像辨識轉字串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultMsg;
    }
}

