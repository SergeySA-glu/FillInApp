namespace FillInApp
{
    partial class WordOfficeWrapperForm
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.uploadButton = new System.Windows.Forms.Button();
            this.SendMailButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.bookmarksTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.uploadButton);
            this.buttonPanel.Controls.Add(this.SendMailButton);
            this.buttonPanel.Controls.Add(this.downloadButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 421);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(800, 29);
            this.buttonPanel.TabIndex = 1;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(160, 3);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(150, 23);
            this.uploadButton.TabIndex = 2;
            this.uploadButton.Text = "Сохранить документ";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // SendMailButton
            // 
            this.SendMailButton.Location = new System.Drawing.Point(316, 3);
            this.SendMailButton.Name = "SendMailButton";
            this.SendMailButton.Size = new System.Drawing.Size(150, 23);
            this.SendMailButton.TabIndex = 1;
            this.SendMailButton.Text = "Отправить на почту";
            this.SendMailButton.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(4, 4);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(150, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Загрузить шаблон";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // bookmarksTable
            // 
            this.bookmarksTable.AutoScroll = true;
            this.bookmarksTable.ColumnCount = 2;
            this.bookmarksTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bookmarksTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bookmarksTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarksTable.Location = new System.Drawing.Point(0, 0);
            this.bookmarksTable.Name = "bookmarksTable";
            this.bookmarksTable.Size = new System.Drawing.Size(800, 421);
            this.bookmarksTable.TabIndex = 2;
            this.bookmarksTable.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.BookmarksTable_ControlRemoved);
            // 
            // WordOfficeWrapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarksTable);
            this.Controls.Add(this.buttonPanel);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "WordOfficeWrapperForm";
            this.Text = "Заполнение Word шаблона";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordOfficeWrapperForm_FormClosed);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button SendMailButton;
        private System.Windows.Forms.TableLayoutPanel bookmarksTable;
    }
}

