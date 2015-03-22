namespace WI_StopWatch
{
    partial class UIStopWatch
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panTitleContainer = new System.Windows.Forms.Panel();
            this.panContentContainer = new System.Windows.Forms.Panel();
            this.laTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.laCaption = new System.Windows.Forms.Label();
            this.panTitleContainer.SuspendLayout();
            this.panContentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitleContainer
            // 
            this.panTitleContainer.Controls.Add(this.laCaption);
            this.panTitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleContainer.Location = new System.Drawing.Point(0, 0);
            this.panTitleContainer.Name = "panTitleContainer";
            this.panTitleContainer.Size = new System.Drawing.Size(204, 30);
            this.panTitleContainer.TabIndex = 0;
            // 
            // panContentContainer
            // 
            this.panContentContainer.Controls.Add(this.laTime);
            this.panContentContainer.Controls.Add(this.btnStart);
            this.panContentContainer.Controls.Add(this.btnReset);
            this.panContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContentContainer.Location = new System.Drawing.Point(0, 30);
            this.panContentContainer.Name = "panContentContainer";
            this.panContentContainer.Size = new System.Drawing.Size(204, 30);
            this.panContentContainer.TabIndex = 1;
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laTime.Location = new System.Drawing.Point(33, 3);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(80, 24);
            this.laTime.TabIndex = 3;
            this.laTime.Text = "00:00:00";
            this.laTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.Location = new System.Drawing.Point(144, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(30, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "s";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.Location = new System.Drawing.Point(174, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(30, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "r";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // laCaption
            // 
            this.laCaption.AutoSize = true;
            this.laCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laCaption.Location = new System.Drawing.Point(3, 3);
            this.laCaption.Name = "laCaption";
            this.laCaption.Size = new System.Drawing.Size(25, 24);
            this.laCaption.TabIndex = 0;
            this.laCaption.Text = "...";
            // 
            // UIStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panContentContainer);
            this.Controls.Add(this.panTitleContainer);
            this.Name = "UIStopWatch";
            this.Size = new System.Drawing.Size(204, 60);
            this.panTitleContainer.ResumeLayout(false);
            this.panTitleContainer.PerformLayout();
            this.panContentContainer.ResumeLayout(false);
            this.panContentContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitleContainer;
        private System.Windows.Forms.Panel panContentContainer;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label laCaption;
    }
}
