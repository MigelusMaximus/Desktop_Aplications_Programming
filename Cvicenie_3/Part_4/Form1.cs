namespace Cviceni_3_part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateCitation()
        {
            string author = textBoxAuthor.Text;
            string name = textBoxName.Text;
            string year = textBoxYear.Text;
            string isbn = textBoxISBN.Text;
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (checkBoxFormat.Checked && !string.IsNullOrEmpty(author))
            {
                // Keep only the initial of the first name
                string[] names = author.Split(' ');
                if (names.Length > 0)
                {
                    author = $"{names[0][0]}. {string.Join(" ", names, 1, names.Length - 1)}";
                }
            }

            labelCitation.Text = $"{author}, {name}, {year}, {isbn} [online].[cit.{currentDate}]";


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateCitation();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateCitation();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateCitation();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateCitation();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCitation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}