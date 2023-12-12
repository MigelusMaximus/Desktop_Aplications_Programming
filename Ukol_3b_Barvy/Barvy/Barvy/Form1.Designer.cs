namespace Barvy
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
            colorsListBox = new ListBox();
            colorNameTextBox = new TextBox();
            addButton = new Button();
            removeColorButton = new Button();
            displayColorInfoButton = new Button();
            sortColorsButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bTextBox = new TextBox();
            gTextBox = new TextBox();
            rTextBox = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // colorsListBox
            // 
            colorsListBox.FormattingEnabled = true;
            colorsListBox.ItemHeight = 15;
            colorsListBox.Location = new Point(29, 139);
            colorsListBox.Name = "colorsListBox";
            colorsListBox.Size = new Size(120, 169);
            colorsListBox.TabIndex = 0;
            // 
            // colorNameTextBox
            // 
            colorNameTextBox.Location = new Point(272, 179);
            colorNameTextBox.Name = "colorNameTextBox";
            colorNameTextBox.Size = new Size(100, 23);
            colorNameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(29, 354);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeColorButton
            // 
            removeColorButton.Location = new Point(120, 354);
            removeColorButton.Name = "removeColorButton";
            removeColorButton.Size = new Size(75, 23);
            removeColorButton.TabIndex = 3;
            removeColorButton.Text = "Remove";
            removeColorButton.UseVisualStyleBackColor = true;
            removeColorButton.Click += removeColorButton_Click;
            // 
            // displayColorInfoButton
            // 
            displayColorInfoButton.Location = new Point(201, 354);
            displayColorInfoButton.Name = "displayColorInfoButton";
            displayColorInfoButton.Size = new Size(75, 23);
            displayColorInfoButton.TabIndex = 4;
            displayColorInfoButton.Text = " Details";
            displayColorInfoButton.UseVisualStyleBackColor = true;
            displayColorInfoButton.Click += displayColorInfoButton_Click;
            // 
            // sortColorsButton
            // 
            sortColorsButton.Location = new Point(297, 354);
            sortColorsButton.Name = "sortColorsButton";
            sortColorsButton.Size = new Size(75, 23);
            sortColorsButton.TabIndex = 5;
            sortColorsButton.Text = "Sort colors";
            sortColorsButton.UseVisualStyleBackColor = true;
            sortColorsButton.Click += sortColorsButton_Click;
            // 
            // bTextBox
            // 
            bTextBox.Location = new Point(272, 285);
            bTextBox.Name = "bTextBox";
            bTextBox.Size = new Size(100, 23);
            bTextBox.TabIndex = 6;
            // 
            // gTextBox
            // 
            gTextBox.Location = new Point(272, 256);
            gTextBox.Name = "gTextBox";
            gTextBox.Size = new Size(100, 23);
            gTextBox.TabIndex = 7;
            // 
            // rTextBox
            // 
            rTextBox.Location = new Point(272, 227);
            rTextBox.Name = "rTextBox";
            rTextBox.Size = new Size(100, 23);
            rTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(803, 259);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(rTextBox);
            Controls.Add(gTextBox);
            Controls.Add(bTextBox);
            Controls.Add(sortColorsButton);
            Controls.Add(displayColorInfoButton);
            Controls.Add(removeColorButton);
            Controls.Add(addButton);
            Controls.Add(colorNameTextBox);
            Controls.Add(colorsListBox);
            Name = "Form1";
            Text = "Ukol_3b_Colors";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox colorsListBox;
        private TextBox colorNameTextBox;
        private Button addButton;
        private Button removeColorButton;
        private Button displayColorInfoButton;
        private Button sortColorsButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox bTextBox;
        private TextBox gTextBox;
        private TextBox rTextBox;
        private ComboBox comboBox1;
    }
}