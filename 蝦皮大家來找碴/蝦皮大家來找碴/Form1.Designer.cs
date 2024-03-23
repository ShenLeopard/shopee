namespace 蝦皮大家來找碴
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            captureButton = new Button();
            differenceButton = new Button();
            label1 = new Label();
            pictureALabel = new Label();
            pictureBLabel = new Label();
            captureSwitchLabel = new Label();
            pictureBoxA = new PictureBox();
            pictureBoxB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).BeginInit();
            SuspendLayout();
            // 
            // captureButton
            // 
            captureButton.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            captureButton.Location = new Point(23, 28);
            captureButton.Margin = new Padding(4);
            captureButton.Name = "captureButton";
            captureButton.Size = new Size(134, 49);
            captureButton.TabIndex = 0;
            captureButton.Text = "擷取畫面";
            captureButton.UseVisualStyleBackColor = true;
            captureButton.Click += CaptureButton_Click;
            // 
            // differenceButton
            // 
            differenceButton.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point);
            differenceButton.Location = new Point(203, 28);
            differenceButton.Margin = new Padding(4);
            differenceButton.Name = "differenceButton";
            differenceButton.Size = new Size(134, 49);
            differenceButton.TabIndex = 0;
            differenceButton.Text = "顯示差異圖片";
            differenceButton.UseVisualStyleBackColor = true;
            differenceButton.Click += DifferenceButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 8;
            // 
            // pictureALabel
            // 
            pictureALabel.AutoSize = true;
            pictureALabel.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pictureALabel.Location = new Point(30, 126);
            pictureALabel.Margin = new Padding(4, 0, 4, 0);
            pictureALabel.Name = "pictureALabel";
            pictureALabel.Size = new Size(69, 27);
            pictureALabel.TabIndex = 4;
            pictureALabel.Text = "圖片A";
            // 
            // pictureBLabel
            // 
            pictureBLabel.AutoSize = true;
            pictureBLabel.Font = new Font("微軟正黑體", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pictureBLabel.Location = new Point(346, 126);
            pictureBLabel.Margin = new Padding(4, 0, 4, 0);
            pictureBLabel.Name = "pictureBLabel";
            pictureBLabel.Size = new Size(67, 27);
            pictureBLabel.TabIndex = 4;
            pictureBLabel.Text = "圖片B";
            // 
            // captureSwitchLabel
            // 
            captureSwitchLabel.Location = new Point(0, 0);
            captureSwitchLabel.Name = "captureSwitchLabel";
            captureSwitchLabel.Size = new Size(88, 23);
            captureSwitchLabel.TabIndex = 2;
            // 
            // pictureBoxA
            // 
            pictureBoxA.Location = new Point(35, 222);
            pictureBoxA.Name = "pictureBoxA";
            pictureBoxA.Size = new Size(220, 197);
            pictureBoxA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxA.TabIndex = 0;
            pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            pictureBoxB.Location = new Point(352, 222);
            pictureBoxB.Name = "pictureBoxB";
            pictureBoxB.Size = new Size(219, 197);
            pictureBoxB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxB.TabIndex = 1;
            pictureBoxB.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 521);
            Controls.Add(pictureBoxA);
            Controls.Add(pictureBoxB);
            Controls.Add(captureSwitchLabel);
            Controls.Add(pictureALabel);
            Controls.Add(pictureBLabel);
            Controls.Add(label1);
            Controls.Add(captureButton);
            Controls.Add(differenceButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "大家來找碴";
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pictureALabel;
        private System.Windows.Forms.Label pictureBLabel;
        private System.Windows.Forms.Label captureSwitchLabel;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
    }

}
