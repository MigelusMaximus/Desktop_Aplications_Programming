namespace Ukol_3b_4
{
    partial class Form1
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
            label1 = new Label();
            comboBoxSubjects = new ComboBox();
            textBoxSelectedSubject = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 74);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Vyber Predmet";
            label1.Click += label1_Click;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(55, 102);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(121, 23);
            comboBoxSubjects.TabIndex = 1;
            comboBoxSubjects.SelectedIndexChanged += comboBoxSubjects_SelectedIndexChanged;
            // 
            // textBoxSelectedSubject
            // 
            textBoxSelectedSubject.Location = new Point(64, 234);
            textBoxSelectedSubject.Name = "textBoxSelectedSubject";
            textBoxSelectedSubject.ReadOnly = true;
            textBoxSelectedSubject.Size = new Size(100, 23);
            textBoxSelectedSubject.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 348);
            Controls.Add(textBoxSelectedSubject);
            Controls.Add(comboBoxSubjects);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ukol_3b_Subjects";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxSubjects;
        private TextBox textBoxSelectedSubject;
    }
}