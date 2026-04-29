namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbSpread = new System.Windows.Forms.TrackBar();
            this.cbWind = new System.Windows.Forms.CheckBox();
            this.cbBlackHole = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(12, 12);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(776, 364);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(12, 382);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(207, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(225, 396);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 16);
            this.lblDirection.TabIndex = 2;
            // 
            // tbSpread
            // 
            this.tbSpread.Location = new System.Drawing.Point(248, 382);
            this.tbSpread.Maximum = 360;
            this.tbSpread.Name = "tbSpread";
            this.tbSpread.Size = new System.Drawing.Size(163, 56);
            this.tbSpread.TabIndex = 3;
            this.tbSpread.Scroll += new System.EventHandler(this.tbSpread_Scroll);
            // 
            // cbWind
            // 
            this.cbWind.AutoSize = true;
            this.cbWind.Checked = true;
            this.cbWind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWind.Location = new System.Drawing.Point(471, 396);
            this.cbWind.Name = "cbWind";
            this.cbWind.Size = new System.Drawing.Size(69, 20);
            this.cbWind.TabIndex = 4;
            this.cbWind.Text = "Ветер";
            this.cbWind.UseVisualStyleBackColor = true;
            this.cbWind.CheckedChanged += new System.EventHandler(this.cbWind_CheckedChanged);
            // 
            // cbBlackHole
            // 
            this.cbBlackHole.AutoSize = true;
            this.cbBlackHole.Checked = true;
            this.cbBlackHole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlackHole.Location = new System.Drawing.Point(606, 396);
            this.cbBlackHole.Name = "cbBlackHole";
            this.cbBlackHole.Size = new System.Drawing.Size(113, 20);
            this.cbBlackHole.TabIndex = 5;
            this.cbBlackHole.Text = "Черная дыра";
            this.cbBlackHole.UseVisualStyleBackColor = true;
            this.cbBlackHole.CheckedChanged += new System.EventHandler(this.cbBlackHole_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBlackHole);
            this.Controls.Add(this.cbWind);
            this.Controls.Add(this.tbSpread);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbSpread;
        private System.Windows.Forms.CheckBox cbWind;
        private System.Windows.Forms.CheckBox cbBlackHole;
    }
}

