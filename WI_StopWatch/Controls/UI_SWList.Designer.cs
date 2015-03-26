namespace WI_StopWatch
{
    partial class UI_SWList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_SWList));
            this.panButtons = new System.Windows.Forms.Panel();
            this.panDrag = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panControls = new System.Windows.Forms.Panel();
            this.panBorder = new System.Windows.Forms.Panel();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.panDrag);
            this.panButtons.Controls.Add(this.btnClose);
            this.panButtons.Controls.Add(this.btnAdd);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panButtons.Location = new System.Drawing.Point(0, 0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(287, 30);
            this.panButtons.TabIndex = 0;
            // 
            // panDrag
            // 
            this.panDrag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panDrag.BackgroundImage")));
            this.panDrag.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDrag.Location = new System.Drawing.Point(30, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(227, 30);
            this.panDrag.TabIndex = 3;
            this.panDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDrag_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::WI_StopWatch.Properties.Resources.blind2;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(257, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::WI_StopWatch.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panControls
            // 
            this.panControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panControls.Location = new System.Drawing.Point(0, 32);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(289, 221);
            this.panControls.TabIndex = 1;
            // 
            // panBorder
            // 
            this.panBorder.BackColor = System.Drawing.Color.LightGray;
            this.panBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBorder.Location = new System.Drawing.Point(0, 30);
            this.panBorder.Name = "panBorder";
            this.panBorder.Size = new System.Drawing.Size(287, 2);
            this.panBorder.TabIndex = 2;
            // 
            // UI_SWList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panControls);
            this.Controls.Add(this.panBorder);
            this.Controls.Add(this.panButtons);
            this.Name = "UI_SWList";
            this.Size = new System.Drawing.Size(287, 252);
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panDrag;
        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Panel panBorder;
    }
}
