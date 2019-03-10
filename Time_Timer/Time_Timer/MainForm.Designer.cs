namespace Time_Timer
{
    partial class Time_Timer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time_Timer));
            this.pic_clock = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_clock
            // 
            this.pic_clock.Image = global::Time_Timer.Properties.Resources.시계;
            this.pic_clock.Location = new System.Drawing.Point(12, 12);
            this.pic_clock.Name = "pic_clock";
            this.pic_clock.Size = new System.Drawing.Size(300, 300);
            this.pic_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_clock.TabIndex = 0;
            this.pic_clock.TabStop = false;
            this.pic_clock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_clock_MouseMove);
            this.pic_clock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_clock_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "0 : 00 : 00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_clock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Time_Timer";
            this.Text = "Time Timer";
            ((System.ComponentModel.ISupportInitialize)(this.pic_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_clock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

