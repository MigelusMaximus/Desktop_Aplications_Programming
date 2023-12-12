using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ukol_3b_3
{
    public partial class Form1 : Form
    {
        // Create a list to store selected subjects
        private List<string> selectedSubjects = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxSubject1_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBoxSubject1.Checked)
            {
                // Add the subject to the selected subjects list
                selectedSubjects.Add("Informatika");
            }
            else
            {
                // Remove the subject from the selected subjects list
                selectedSubjects.Remove("Informatika");
            }

            // Update the TextBox to display the selected subjects
            UpdateSelectedSubjectsTextBox();
        }
        private void checkBoxSubject2_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBoxSubject2.Checked)
            {
                // Add the subject to the selected subjects list
                selectedSubjects.Add("Biologia");
            }
            else
            {
                // Remove the subject from the selected subjects list
                selectedSubjects.Remove("Biologia");
            }

            // Update the TextBox to display the selected subjects
            UpdateSelectedSubjectsTextBox();
        }


        private void UpdateSelectedSubjectsTextBox()
        {
            // Sort the selected subjects alphabetically
            selectedSubjects.Sort();

            // Update the TextBox to display the selected subjects separated by semicolons
            selectedSubjectsTextBox.Text = string.Join("; ", selectedSubjects);
        }

        private void checkBoxSubject4_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBoxSubject4.Checked)
            {
                // Add the subject to the selected subjects list
                selectedSubjects.Add("Geografia");
            }
            else
            {
                // Remove the subject from the selected subjects list
                selectedSubjects.Remove("Geografia");
            }

            // Update the TextBox to display the selected subjects
            UpdateSelectedSubjectsTextBox();
        }

        private void checkBoxSubject3_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBoxSubject3.Checked)
            {
                // Add the subject to the selected subjects list
                selectedSubjects.Add("Nemcina"); // Replace with the actual subject name
            }
            else
            {
                // Remove the subject from the selected subjects list
                selectedSubjects.Remove("Nemcina"); // Replace with the actual subject name
            }

            // Update the TextBox to display the selected subjects
            UpdateSelectedSubjectsTextBox();

        }

        private void checkBoxSubject5_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the checkbox is checked
            if (checkBoxSubject5.Checked)
            {
                // Add the subject to the selected subjects list
                selectedSubjects.Add("Telesna"); // Replace with the actual subject name
            }
            else
            {
                // Remove the subject from the selected subjects list
                selectedSubjects.Remove("Telesna"); // Replace with the actual subject name
            }

            // Update the TextBox to display the selected subjects
            UpdateSelectedSubjectsTextBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
