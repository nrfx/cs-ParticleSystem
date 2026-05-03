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
            this.btnWindUp = new System.Windows.Forms.Button();
            this.btnWindLeft = new System.Windows.Forms.Button();
            this.btnWindDown = new System.Windows.Forms.Button();
            this.btnWindRight = new System.Windows.Forms.Button();
            this.btnWindReset = new System.Windows.Forms.Button();
            this.lblRatio = new System.Windows.Forms.Label();
            this.lblSpread = new System.Windows.Forms.Label();
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
            this.tbSpread.Location = new System.Drawing.Point(233, 382);
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
            this.cbWind.Location = new System.Drawing.Point(551, 395);
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
            this.cbBlackHole.Location = new System.Drawing.Point(402, 395);
            this.cbBlackHole.Name = "cbBlackHole";
            this.cbBlackHole.Size = new System.Drawing.Size(113, 20);
            this.cbBlackHole.TabIndex = 5;
            this.cbBlackHole.Text = "Черная дыра";
            this.cbBlackHole.UseVisualStyleBackColor = true;
            this.cbBlackHole.CheckedChanged += new System.EventHandler(this.cbBlackHole_CheckedChanged);
            // 
            // btnWindUp
            // 
            this.btnWindUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWindUp.Location = new System.Drawing.Point(722, 381);
            this.btnWindUp.Name = "btnWindUp";
            this.btnWindUp.Size = new System.Drawing.Size(32, 34);
            this.btnWindUp.TabIndex = 6;
            this.btnWindUp.Text = "🔼";
            this.btnWindUp.UseVisualStyleBackColor = true;
            this.btnWindUp.Click += new System.EventHandler(this.btnWindUp_Click);
            // 
            // btnWindLeft
            // 
            this.btnWindLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWindLeft.Location = new System.Drawing.Point(684, 421);
            this.btnWindLeft.Name = "btnWindLeft";
            this.btnWindLeft.Size = new System.Drawing.Size(32, 34);
            this.btnWindLeft.TabIndex = 7;
            this.btnWindLeft.Text = "◀️";
            this.btnWindLeft.UseVisualStyleBackColor = true;
            this.btnWindLeft.Click += new System.EventHandler(this.btnWindLeft_Click);
            // 
            // btnWindDown
            // 
            this.btnWindDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWindDown.Location = new System.Drawing.Point(722, 421);
            this.btnWindDown.Name = "btnWindDown";
            this.btnWindDown.Size = new System.Drawing.Size(32, 34);
            this.btnWindDown.TabIndex = 8;
            this.btnWindDown.Text = "🔽";
            this.btnWindDown.UseVisualStyleBackColor = true;
            this.btnWindDown.Click += new System.EventHandler(this.btnWindDown_Click);
            // 
            // btnWindRight
            // 
            this.btnWindRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWindRight.Location = new System.Drawing.Point(760, 421);
            this.btnWindRight.Name = "btnWindRight";
            this.btnWindRight.Size = new System.Drawing.Size(32, 34);
            this.btnWindRight.TabIndex = 9;
            this.btnWindRight.Text = "▶️";
            this.btnWindRight.UseVisualStyleBackColor = true;
            this.btnWindRight.Click += new System.EventHandler(this.btnWindRight_Click);
            // 
            // btnWindReset
            // 
            this.btnWindReset.Location = new System.Drawing.Point(551, 422);
            this.btnWindReset.Name = "btnWindReset";
            this.btnWindReset.Size = new System.Drawing.Size(113, 34);
            this.btnWindReset.TabIndex = 10;
            this.btnWindReset.Text = "Reset Wind";
            this.btnWindReset.UseVisualStyleBackColor = true;
            this.btnWindReset.Click += new System.EventHandler(this.btnWindReset_Click);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(59, 422);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(97, 16);
            this.lblRatio.TabIndex = 11;
            this.lblRatio.Text = "Направление";
            // 
            // lblSpread
            // 
            this.lblSpread.AutoSize = true;
            this.lblSpread.Location = new System.Drawing.Point(286, 422);
            this.lblSpread.Name = "lblSpread";
            this.lblSpread.Size = new System.Drawing.Size(63, 16);
            this.lblSpread.TabIndex = 12;
            this.lblSpread.Text = "Разброс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.lblSpread);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.btnWindReset);
            this.Controls.Add(this.btnWindRight);
            this.Controls.Add(this.btnWindDown);
            this.Controls.Add(this.btnWindLeft);
            this.Controls.Add(this.btnWindUp);
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
        private System.Windows.Forms.Button btnWindUp;
        private System.Windows.Forms.Button btnWindLeft;
        private System.Windows.Forms.Button btnWindDown;
        private System.Windows.Forms.Button btnWindRight;
        private System.Windows.Forms.Button btnWindReset;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Label lblSpread;
    }
}

