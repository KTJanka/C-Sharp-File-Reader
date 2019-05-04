namespace FileReaderKyleJanka
{
    partial class fileReader
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
            this.enterFileTxt = new System.Windows.Forms.TextBox();
            this.displayList = new System.Windows.Forms.ListBox();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterFileTxt
            // 
            this.enterFileTxt.Location = new System.Drawing.Point(101, 60);
            this.enterFileTxt.Name = "enterFileTxt";
            this.enterFileTxt.Size = new System.Drawing.Size(340, 22);
            this.enterFileTxt.TabIndex = 0;
            // 
            // displayList
            // 
            this.displayList.FormattingEnabled = true;
            this.displayList.ItemHeight = 16;
            this.displayList.Location = new System.Drawing.Point(101, 138);
            this.displayList.Name = "displayList";
            this.displayList.Size = new System.Drawing.Size(340, 260);
            this.displayList.TabIndex = 1;
            // 
            // readFileBtn
            // 
            this.readFileBtn.Location = new System.Drawing.Point(468, 59);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(141, 23);
            this.readFileBtn.TabIndex = 2;
            this.readFileBtn.Text = "Read File";
            this.readFileBtn.UseVisualStyleBackColor = true;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter file path:";
            // 
            // fileReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.displayList);
            this.Controls.Add(this.enterFileTxt);
            this.Name = "fileReader";
            this.Text = "File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterFileTxt;
        private System.Windows.Forms.ListBox displayList;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Label label1;
    }
}

