namespace Ukol_4b
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
            groupBox1 = new GroupBox();
            btnAddPoint = new Button();
            label2 = new Label();
            btnSortPoints = new Button();
            label1 = new Label();
            listBoxPoints = new ListBox();
            txtY = new TextBox();
            txtX = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddPoint);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSortPoints);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxPoints);
            groupBox1.Controls.Add(txtY);
            groupBox1.Controls.Add(txtX);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnAddPoint
            // 
            btnAddPoint.Location = new Point(89, 181);
            btnAddPoint.Name = "btnAddPoint";
            btnAddPoint.Size = new Size(75, 23);
            btnAddPoint.TabIndex = 4;
            btnAddPoint.Text = "Add Point";
            btnAddPoint.UseVisualStyleBackColor = true;
            btnAddPoint.Click += btnAddPoint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Y:";
            // 
            // btnSortPoints
            // 
            btnSortPoints.Location = new Point(219, 181);
            btnSortPoints.Name = "btnSortPoints";
            btnSortPoints.Size = new Size(75, 23);
            btnSortPoints.TabIndex = 5;
            btnSortPoints.Text = "Sort Points";
            btnSortPoints.UseVisualStyleBackColor = true;
            btnSortPoints.Click += btnSortPoints_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 47);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "X:";
            label1.Click += label1_Click;
            // 
            // listBoxPoints
            // 
            listBoxPoints.FormattingEnabled = true;
            listBoxPoints.ItemHeight = 15;
            listBoxPoints.Location = new Point(219, 22);
            listBoxPoints.Name = "listBoxPoints";
            listBoxPoints.Size = new Size(255, 94);
            listBoxPoints.TabIndex = 6;
            // 
            // txtY
            // 
            txtY.Location = new Point(43, 81);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 3;
            txtY.Text = "hodnota Y";
            // 
            // txtX
            // 
            txtX.Location = new Point(43, 39);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 1;
            txtX.Text = "hodnota X";
            txtX.TextChanged += txtX_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 248);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Ukol_4b";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtX;
        private Label label2;
        private TextBox txtY;
        private Button btnAddPoint;
        private Button btnSortPoints;
        private ListBox listBoxPoints;
    }
}