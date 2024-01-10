namespace 华山派小六壬
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            支付宝 = new PictureBox();
            微信 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)支付宝).BeginInit();
            ((System.ComponentModel.ISupportInitialize)微信).BeginInit();
            SuspendLayout();
            // 
            // 支付宝
            // 
            支付宝.Image = (Image)resources.GetObject("支付宝.Image");
            支付宝.Location = new Point(92, 124);
            支付宝.Name = "支付宝";
            支付宝.Size = new Size(232, 314);
            支付宝.SizeMode = PictureBoxSizeMode.StretchImage;
            支付宝.TabIndex = 0;
            支付宝.TabStop = false;
            // 
            // 微信
            // 
            微信.Image = (Image)resources.GetObject("微信.Image");
            微信.Location = new Point(483, 124);
            微信.Name = "微信";
            微信.Size = new Size(250, 314);
            微信.SizeMode = PictureBoxSizeMode.StretchImage;
            微信.TabIndex = 1;
            微信.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("梦源黑体 SC W20", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(188, 34);
            label1.Name = "label1";
            label1.Size = new Size(439, 44);
            label1.TabIndex = 2;
            label1.Text = "你的支持与鼓励是我前进的动力";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(微信);
            Controls.Add(支付宝);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "捐赠";
            ((System.ComponentModel.ISupportInitialize)支付宝).EndInit();
            ((System.ComponentModel.ISupportInitialize)微信).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox 支付宝;
        private PictureBox 微信;
        private Label label1;
    }
}