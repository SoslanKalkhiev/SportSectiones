namespace SportSectiones
{
    partial class FormRegistration
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
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            textBoxPhone = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(101, 171);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(137, 62);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 42);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Возраст:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 42);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "Номер:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(40, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(185, 76);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(100, 23);
            textBoxAge.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(340, 76);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 6;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Name = "FormRegistration";
            Text = "FormRegistation";
            Load += FormRegistation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxPhone;
    }
}