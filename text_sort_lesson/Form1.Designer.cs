namespace text_sort_lesson
{
    partial class IndexerForm
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.checkSorting = new System.Windows.Forms.CheckBox();
            this.checkSortingDesc = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(12, 43);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonIndex.TabIndex = 1;
            this.buttonIndex.Text = "Begin";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.buttonIndex_Click);
            // 
            // checkSorting
            // 
            this.checkSorting.AutoSize = true;
            this.checkSorting.Checked = true;
            this.checkSorting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSorting.Location = new System.Drawing.Point(94, 43);
            this.checkSorting.Name = "checkSorting";
            this.checkSorting.Size = new System.Drawing.Size(86, 17);
            this.checkSorting.TabIndex = 2;
            this.checkSorting.Text = "Order by A-Z";
            this.checkSorting.UseVisualStyleBackColor = true;
            this.checkSorting.CheckedChanged += new System.EventHandler(this.checkSorting_CheckedChanged);
            // 
            // checkSortingDesc
            // 
            this.checkSortingDesc.AutoSize = true;
            this.checkSortingDesc.Location = new System.Drawing.Point(186, 43);
            this.checkSortingDesc.Name = "checkSortingDesc";
            this.checkSortingDesc.Size = new System.Drawing.Size(86, 17);
            this.checkSortingDesc.TabIndex = 3;
            this.checkSortingDesc.Text = "Order by Z-A";
            this.checkSortingDesc.UseVisualStyleBackColor = true;
            this.checkSortingDesc.CheckedChanged += new System.EventHandler(this.checkSortingDesc_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(313, 78);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(94, 13);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(294, 20);
            this.textPath.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IndexerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 110);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkSortingDesc);
            this.Controls.Add(this.checkSorting);
            this.Controls.Add(this.buttonIndex);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "IndexerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.CheckBox checkSorting;
        private System.Windows.Forms.CheckBox checkSortingDesc;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

