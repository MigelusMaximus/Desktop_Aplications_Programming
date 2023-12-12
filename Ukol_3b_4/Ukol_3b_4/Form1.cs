namespace Ukol_3b_4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the offered subjects
            string[] subjects = { "Informatika", "Biologia", "Telesna", "Nemcina" };

            // Populate the combo box with subjects
            comboBoxSubjects.Items.AddRange(subjects);
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected subject from the ComboBox
            string selectedSubject = comboBoxSubjects.SelectedItem?.ToString();

            // Update the TextBox with the selected subject
            textBoxSelectedSubject.Text = selectedSubject;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}