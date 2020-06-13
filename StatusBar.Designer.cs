namespace WnFormsMemory
{
    partial class StatusBar
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
            this.progressBarCardRevealed = new System.Windows.Forms.ProgressBar();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.newGameButton = new System.Windows.Forms.Button();
            this.timeLeftNumberLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.buttonCardManager = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarCardRevealed
            // 
            this.progressBarCardRevealed.Location = new System.Drawing.Point(229, 116);
            this.progressBarCardRevealed.Name = "progressBarCardRevealed";
            this.progressBarCardRevealed.Size = new System.Drawing.Size(176, 23);
            this.progressBarCardRevealed.TabIndex = 12;
            // 
            // progressBarTimeLeft
            // 
            this.progressBarTimeLeft.Location = new System.Drawing.Point(229, 65);
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            this.progressBarTimeLeft.Size = new System.Drawing.Size(176, 23);
            this.progressBarTimeLeft.TabIndex = 11;
            this.progressBarTimeLeft.Value = 100;
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newGameButton.Location = new System.Drawing.Point(113, 203);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(208, 42);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // timeLeftNumberLabel
            // 
            this.timeLeftNumberLabel.AutoSize = true;
            this.timeLeftNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLeftNumberLabel.Location = new System.Drawing.Point(297, 16);
            this.timeLeftNumberLabel.Name = "timeLeftNumberLabel";
            this.timeLeftNumberLabel.Size = new System.Drawing.Size(42, 46);
            this.timeLeftNumberLabel.TabIndex = 9;
            this.timeLeftNumberLabel.Text = "0";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLeftLabel.Location = new System.Drawing.Point(20, 42);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(185, 46);
            this.timeLeftLabel.TabIndex = 7;
            this.timeLeftLabel.Text = "TimeLeft:";
            // 
            // buttonCardManager
            // 
            this.buttonCardManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCardManager.Location = new System.Drawing.Point(113, 251);
            this.buttonCardManager.Name = "buttonCardManager";
            this.buttonCardManager.Size = new System.Drawing.Size(208, 62);
            this.buttonCardManager.TabIndex = 13;
            this.buttonCardManager.Text = "CardManager";
            this.buttonCardManager.UseVisualStyleBackColor = true;
            this.buttonCardManager.Click += new System.EventHandler(this.buttonCardManager_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProgress.Location = new System.Drawing.Point(20, 103);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(180, 46);
            this.labelProgress.TabIndex = 14;
            this.labelProgress.Text = "Progress";
            // 
            // StatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 351);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonCardManager);
            this.Controls.Add(this.progressBarCardRevealed);
            this.Controls.Add(this.progressBarTimeLeft);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.timeLeftNumberLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StatusBar";
            this.ShowInTaskbar = false;
            this.Text = "StatusBar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusBar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarCardRevealed;
        private System.Windows.Forms.ProgressBar progressBarTimeLeft;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label timeLeftNumberLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Button buttonCardManager;
        private System.Windows.Forms.Label labelProgress;
    }
}