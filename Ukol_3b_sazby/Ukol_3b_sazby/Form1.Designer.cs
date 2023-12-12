namespace Ukol_3b_sazby
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
            taxRateComboBox = new ComboBox();
            selectedTaxRateLabel = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // taxRateComboBox
            // 
            taxRateComboBox.FormattingEnabled = true;
            taxRateComboBox.Location = new Point(69, 79);
            taxRateComboBox.Name = "taxRateComboBox";
            taxRateComboBox.Size = new Size(121, 23);
            taxRateComboBox.TabIndex = 0;
            taxRateComboBox.SelectedIndexChanged += taxRateComboBox_SelectedIndexChanged;
            // 
            // selectedTaxRateLabel
            // 
            selectedTaxRateLabel.AutoSize = true;
            selectedTaxRateLabel.Location = new Point(84, 155);
            selectedTaxRateLabel.Name = "selectedTaxRateLabel";
            selectedTaxRateLabel.Size = new Size(83, 15);
            selectedTaxRateLabel.TabIndex = 1;
            selectedTaxRateLabel.Text = "Vybrana Sazba";
            selectedTaxRateLabel.Click += selectedTaxRateLabel_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(92, 176);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Vyber";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 273);
            Controls.Add(confirmButton);
            Controls.Add(selectedTaxRateLabel);
            Controls.Add(taxRateComboBox);
            Name = "Form1";
            Text = "Ukol_3b_sazby";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox taxRateComboBox;
        private Label selectedTaxRateLabel;
        private Button confirmButton;
    }
}