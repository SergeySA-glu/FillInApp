namespace FillInApp.GUI
{
    partial class MainForm
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
            this.fillInWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillInWordButton
            // 
            this.fillInWordButton.Location = new System.Drawing.Point(13, 13);
            this.fillInWordButton.Name = "fillInWordButton";
            this.fillInWordButton.Size = new System.Drawing.Size(183, 83);
            this.fillInWordButton.TabIndex = 0;
            this.fillInWordButton.Text = "Заполнить Word шаблон";
            this.fillInWordButton.UseVisualStyleBackColor = true;
            this.fillInWordButton.Click += new System.EventHandler(this.fillInWordButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 239);
            this.Controls.Add(this.fillInWordButton);
            this.Name = "MainForm";
            this.Text = "Заполнение документов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillInWordButton;
    }
}