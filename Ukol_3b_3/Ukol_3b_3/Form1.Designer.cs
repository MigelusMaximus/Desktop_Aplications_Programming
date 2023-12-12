namespace Ukol_3b_3
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
            groupBox = new GroupBox();
            checkBoxSubject5 = new CheckBox();
            checkBoxSubject4 = new CheckBox();
            checkBoxSubject3 = new CheckBox();
            checkBoxSubject2 = new CheckBox();
            checkBoxSubject1 = new CheckBox();
            selectedSubjectsTextBox = new TextBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(checkBoxSubject5);
            groupBox.Controls.Add(checkBoxSubject4);
            groupBox.Controls.Add(checkBoxSubject3);
            groupBox.Controls.Add(checkBoxSubject2);
            groupBox.Controls.Add(checkBoxSubject1);
            groupBox.Location = new Point(65, 38);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(115, 162);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "groupBox";
            // 
            // checkBoxSubject5
            // 
            checkBoxSubject5.AutoSize = true;
            checkBoxSubject5.Location = new Point(6, 122);
            checkBoxSubject5.Name = "checkBoxSubject5";
            checkBoxSubject5.Size = new Size(64, 19);
            checkBoxSubject5.TabIndex = 4;
            checkBoxSubject5.Text = "Telesna";
            checkBoxSubject5.UseVisualStyleBackColor = true;
            checkBoxSubject5.CheckedChanged += checkBoxSubject5_CheckedChanged;
            // 
            // checkBoxSubject4
            // 
            checkBoxSubject4.AutoSize = true;
            checkBoxSubject4.Location = new Point(6, 97);
            checkBoxSubject4.Name = "checkBoxSubject4";
            checkBoxSubject4.Size = new Size(77, 19);
            checkBoxSubject4.TabIndex = 3;
            checkBoxSubject4.Text = "Geografia";
            checkBoxSubject4.UseVisualStyleBackColor = true;
            checkBoxSubject4.CheckedChanged += checkBoxSubject4_CheckedChanged;
            // 
            // checkBoxSubject3
            // 
            checkBoxSubject3.AutoSize = true;
            checkBoxSubject3.Location = new Point(6, 72);
            checkBoxSubject3.Name = "checkBoxSubject3";
            checkBoxSubject3.Size = new Size(74, 19);
            checkBoxSubject3.TabIndex = 2;
            checkBoxSubject3.Text = "Nemcina";
            checkBoxSubject3.UseVisualStyleBackColor = true;
            checkBoxSubject3.CheckedChanged += checkBoxSubject3_CheckedChanged;
            // 
            // checkBoxSubject2
            // 
            checkBoxSubject2.AutoSize = true;
            checkBoxSubject2.Location = new Point(6, 47);
            checkBoxSubject2.Name = "checkBoxSubject2";
            checkBoxSubject2.Size = new Size(69, 19);
            checkBoxSubject2.TabIndex = 1;
            checkBoxSubject2.Text = "Biologia";
            checkBoxSubject2.UseVisualStyleBackColor = true;
            checkBoxSubject2.CheckedChanged += checkBoxSubject2_CheckedChanged;
            // 
            // checkBoxSubject1
            // 
            checkBoxSubject1.AutoSize = true;
            checkBoxSubject1.Location = new Point(6, 22);
            checkBoxSubject1.Name = "checkBoxSubject1";
            checkBoxSubject1.Size = new Size(87, 19);
            checkBoxSubject1.TabIndex = 0;
            checkBoxSubject1.Text = "Informatika";
            checkBoxSubject1.UseVisualStyleBackColor = true;
            checkBoxSubject1.CheckedChanged += checkBoxSubject1_CheckedChanged;
            // 
            // selectedSubjectsTextBox
            // 
            selectedSubjectsTextBox.Location = new Point(47, 216);
            selectedSubjectsTextBox.Name = "selectedSubjectsTextBox";
            selectedSubjectsTextBox.ReadOnly = true;
            selectedSubjectsTextBox.Size = new Size(529, 23);
            selectedSubjectsTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(selectedSubjectsTextBox);
            Controls.Add(groupBox);
            Name = "Form1";
            Text = "Ukol_3b_3";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private CheckBox checkBoxSubject1;
        private CheckBox checkBoxSubject2;
        private CheckBox checkBoxSubject3;
        private CheckBox checkBoxSubject4;
        private CheckBox checkBoxSubject5;
        private TextBox selectedSubjectsTextBox;
    }
}