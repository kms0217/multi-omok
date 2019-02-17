namespace Client
{
    partial class MenuForm
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
            this.singlePlay = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.multiPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singlePlay
            // 
            this.singlePlay.Location = new System.Drawing.Point(371, 117);
            this.singlePlay.Name = "singlePlay";
            this.singlePlay.Size = new System.Drawing.Size(138, 73);
            this.singlePlay.TabIndex = 0;
            this.singlePlay.Text = "혼자하기";
            this.singlePlay.UseVisualStyleBackColor = true;
            this.singlePlay.Click += new System.EventHandler(this.singlePlay_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(371, 274);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(138, 73);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "종료하기";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // multiPlayButton
            // 
            this.multiPlayButton.Location = new System.Drawing.Point(371, 196);
            this.multiPlayButton.Name = "multiPlayButton";
            this.multiPlayButton.Size = new System.Drawing.Size(138, 73);
            this.multiPlayButton.TabIndex = 2;
            this.multiPlayButton.Text = "함께하기";
            this.multiPlayButton.UseVisualStyleBackColor = true;
            this.multiPlayButton.Click += new System.EventHandler(this.multiPlayButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.multiPlayButton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.singlePlay);
            this.Name = "MenuForm";
            this.Text = "Omok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singlePlay;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button multiPlayButton;
    }
}

