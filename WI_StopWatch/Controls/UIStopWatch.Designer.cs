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
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panContentContainer = new System.Windows.Forms.Panel();
            this.laTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panBorder = new System.Windows.Forms.Panel();
            this.panTitleContainer.SuspendLayout();
            this.panContentContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitleContainer
            // 
            this.panTitleContainer.Controls.Add(this.tbCaption);
            this.panTitleContainer.Controls.Add(this.btnEdit);
            this.panTitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitleContainer.Location = new System.Drawing.Point(0, 0);
            this.panTitleContainer.Name = "panTitleContainer";
            this.panTitleContainer.Size = new System.Drawing.Size(204, 30);
            this.panTitleContainer.TabIndex = 0;
            // 
            // tbCaption
            // 
            this.tbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCaption.Location = new System.Drawing.Point(2, 2);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(170, 23);
            this.tbCaption.TabIndex = 0;
            this.tbCaption.Enter += new System.EventHandler(this.tbCaption_Enter);
            this.tbCaption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCaption_KeyDown);
            this.tbCaption.Leave += new System.EventHandler(this.tbCaption_Leave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WI_StopWatch.Properties.Resources.pencil125;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(174, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panContentContainer
            // 
            this.panContentContainer.Controls.Add(this.laTime);
            this.panContentContainer.Controls.Add(this.btnStart);
            this.panContentContainer.Controls.Add(this.btnReset);
            this.panContentContainer.Controls.Add(this.btnRemove);
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
            this.laTime.Location = new System.Drawing.Point(3, 3);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(80, 24);
            this.laTime.TabIndex = 3;
            this.laTime.Text = "00:00:00";
            this.laTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::WI_StopWatch.Properties.Resources.play128;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(120, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(28, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::WI_StopWatch.Properties.Resources.clockwise11;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(148, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(28, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::WI_StopWatch.Properties.Resources.delete;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(176, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(28, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panBorder
            // 
            this.panBorder.BackColor = System.Drawing.Color.LightGray;
            this.panBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBorder.Location = new System.Drawing.Point(0, 60);
            this.panBorder.Name = "panBorder";
            this.panBorder.Size = new System.Drawing.Size(204, 2);
            this.panBorder.TabIndex = 3;
            // 
            // UIStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panContentContainer);
            this.Controls.Add(this.panBorder);
            this.Controls.Add(this.panTitleContainer);
            this.Name = "UIStopWatch";
            this.Size = new System.Drawing.Size(204, 62);
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
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbCaption;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panBorder;
    }
}
