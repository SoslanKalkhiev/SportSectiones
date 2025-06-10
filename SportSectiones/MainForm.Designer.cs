namespace SportSectiones
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxSections = new ListBox();
            buttonCheck = new Button();
            SuspendLayout();
            // 
            // listBoxSections
            // 
            listBoxSections.FormattingEnabled = true;
            listBoxSections.ItemHeight = 15;
            listBoxSections.Location = new Point(41, 48);
            listBoxSections.Name = "listBoxSections";
            listBoxSections.Size = new Size(230, 274);
            listBoxSections.TabIndex = 0;
            listBoxSections.SelectedIndexChanged += listBoxSections_SelectedIndexChanged;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(319, 277);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(76, 45);
            buttonCheck.TabIndex = 1;
            buttonCheck.Text = "Проверка";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 414);
            Controls.Add(buttonCheck);
            Controls.Add(listBoxSections);
            Name = "MainForm";
            Text = "Секции";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxSections;
        private Button buttonCheck;
    }
}
