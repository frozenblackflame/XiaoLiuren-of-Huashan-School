namespace 华山派小六壬
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            留连 = new Button();
            重置 = new Button();
            确认 = new Button();
            小吉 = new Button();
            空亡 = new Button();
            大安 = new Button();
            赤口 = new Button();
            速喜 = new Button();
            随机 = new Button();
            占文 = new TextBox();
            SuspendLayout();
            // 
            // 留连
            // 
            留连.Location = new Point(107, 39);
            留连.Name = "留连";
            留连.Size = new Size(129, 52);
            留连.TabIndex = 0;
            留连.Text = "留连";
            留连.UseVisualStyleBackColor = true;
            留连.Click += Button_Click;
            // 
            // 重置
            // 
            重置.BackColor = Color.FromArgb(224, 224, 224);
            重置.Location = new Point(593, 238);
            重置.Name = "重置";
            重置.Size = new Size(129, 52);
            重置.TabIndex = 1;
            重置.Text = "重置";
            重置.UseVisualStyleBackColor = false;
            重置.Click += 重置_Click;
            // 
            // 确认
            // 
            确认.BackColor = Color.Coral;
            确认.Location = new Point(334, 238);
            确认.Name = "确认";
            确认.Size = new Size(129, 52);
            确认.TabIndex = 2;
            确认.Text = "确认";
            确认.UseVisualStyleBackColor = false;
            确认.Click += 确认_Click;
            // 
            // 小吉
            // 
            小吉.Location = new Point(593, 147);
            小吉.Name = "小吉";
            小吉.Size = new Size(129, 52);
            小吉.TabIndex = 3;
            小吉.Text = "小吉";
            小吉.UseVisualStyleBackColor = true;
            小吉.Click += Button_Click;
            // 
            // 空亡
            // 
            空亡.Location = new Point(334, 147);
            空亡.Name = "空亡";
            空亡.Size = new Size(129, 52);
            空亡.TabIndex = 4;
            空亡.Text = "空亡";
            空亡.UseVisualStyleBackColor = true;
            空亡.Click += Button_Click;
            // 
            // 大安
            // 
            大安.BackColor = Color.White;
            大安.Location = new Point(107, 147);
            大安.Name = "大安";
            大安.Size = new Size(129, 52);
            大安.TabIndex = 5;
            大安.Text = "大安";
            大安.UseVisualStyleBackColor = false;
            大安.Click += Button_Click;
            // 
            // 赤口
            // 
            赤口.BackColor = Color.White;
            赤口.Location = new Point(593, 39);
            赤口.Name = "赤口";
            赤口.Size = new Size(129, 52);
            赤口.TabIndex = 6;
            赤口.Text = "赤口";
            赤口.UseVisualStyleBackColor = false;
            赤口.Click += Button_Click;
            // 
            // 速喜
            // 
            速喜.BackColor = Color.White;
            速喜.Location = new Point(334, 39);
            速喜.Name = "速喜";
            速喜.Size = new Size(129, 52);
            速喜.TabIndex = 7;
            速喜.Text = "速喜";
            速喜.UseVisualStyleBackColor = false;
            速喜.Click += Button_Click;
            // 
            // 随机
            // 
            随机.BackColor = Color.Turquoise;
            随机.Location = new Point(107, 238);
            随机.Name = "随机";
            随机.Size = new Size(129, 52);
            随机.TabIndex = 9;
            随机.Text = "随机";
            随机.UseVisualStyleBackColor = false;
            随机.Click += 随机_Click;
            // 
            // 占文
            // 
            占文.Font = new Font("梦源黑体 SC W20", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            占文.Location = new Point(107, 350);
            占文.Name = "占文";
            占文.Size = new Size(615, 41);
            占文.TabIndex = 10;
            占文.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(占文);
            Controls.Add(随机);
            Controls.Add(速喜);
            Controls.Add(赤口);
            Controls.Add(大安);
            Controls.Add(空亡);
            Controls.Add(小吉);
            Controls.Add(确认);
            Controls.Add(重置);
            Controls.Add(留连);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "华山派小六壬";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button 留连;
        private Button 重置;
        private Button 确认;
        private Button 小吉;
        private Button 空亡;
        private Button 大安;
        private Button 赤口;
        private Button 速喜;
        private Button 随机;
        private TextBox 占文;
    }
}
