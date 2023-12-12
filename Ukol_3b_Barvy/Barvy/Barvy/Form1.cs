using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Barvy
{

    public partial class Form1 : Form
    {
        private List<Barva> colors = new List<Barva>();
        public class Barva
        {
            public string Nazev { get; private set; }
            public byte R { get; private set; }
            public byte G { get; private set; }
            public byte B { get; private set; }

            public Barva(string nazev, byte r, byte g, byte b)
            {
                Nazev = nazev;
                R = r;
                G = g;
                B = b;
            }

            public override string ToString()
            {

                return $"{Nazev} (#{R:X2}{G:X2}{B:X2})";
            }
            public double GetIntensity()
            {
                // Calculate the intensity using the formula (R + G + B) / 3
                double intensity = (R + G + B) / 3.0;
                return intensity;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Get input values
            string colorName = colorNameTextBox.Text;
            byte r, g, b;

            if (byte.TryParse(rTextBox.Text, out r) &&
                byte.TryParse(gTextBox.Text, out g) &&
                byte.TryParse(bTextBox.Text, out b))
            {
                // Check for duplicate RGB values
                if (!colors.Exists(color => color.R == r && color.G == g && color.B == b))
                {
                    // Create a new Barva instance and add it to the list
                    Barva newColor = new Barva(colorName, r, g, b);
                    colors.Add(newColor);

                    // Add the color to the ListBox
                    colorsListBox.Items.Add(newColor.ToString());

                    // Clear input fields
                    colorNameTextBox.Clear();
                    rTextBox.Clear();
                    gTextBox.Clear();
                    bTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Color with the same RGB values already exists.");
                }
            }
            else
            {
                MessageBox.Show("Invalid RGB values. Please enter valid byte values (0-255).");
            }
        }

        private void removeColorButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the colorsListBox
            if (colorsListBox.SelectedIndex >= 0)
            {
                // Get the index of the selected item
                int selectedIndex = colorsListBox.SelectedIndex;

                // Remove the selected color from the colors list
                colors.RemoveAt(selectedIndex);

                // Remove the selected item from the colorsListBox
                colorsListBox.Items.RemoveAt(selectedIndex);
            }
            else
            {
                // Display a message if no color is selected
                MessageBox.Show("Please select a color to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void displayColorInfoButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the colorsListBox
            if (colorsListBox.SelectedIndex >= 0)
            {
                // Get the selected color based on the selected index
                int selectedIndex = colorsListBox.SelectedIndex;
                Barva selectedColor = colors[selectedIndex];

                // Build a message with color information
                string message = $"Color Name: {selectedColor.Nazev}\n" +
                                 $"RGB Values: R={selectedColor.R}, G={selectedColor.G}, B={selectedColor.B}\n" +
                                 $"Intensity: {selectedColor.GetIntensity()}";

                // Display the color information in a message box
                MessageBox.Show(message, "Color Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display a message if no color is selected
                MessageBox.Show("Please select a color to display its information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sortColorsButton_Click(object sender, EventArgs e)
        {
            // Always sort in ascending order
            colors.Sort((color1, color2) => color1.GetIntensity().CompareTo(color2.GetIntensity()));

            // Clear the ListBox and add the sorted colors
            colorsListBox.Items.Clear();
            foreach (Barva color in colors)
            {
                colorsListBox.Items.Add(color.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}