using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Práce_se_seznamy
{
    public partial class Form1 : Form
    {

        private ArrayList arraylist_barvy;

        public Form1()
        {
            arraylist_barvy = new ArrayList() { "červená", "zelená", "modrá" };

            InitializeComponent();

            /*            //listBox1.DataSource = null;
                        listBox1.DataSource = arraylist_barvy;*/
            update_listbox_barvy();
        }

        private void update_listbox_barvy()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = arraylist_barvy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SeletionMode: One
            //string item1 = (string) listBox1.SelectedItem;
            //string item2 = (string) listBox1.SelectedValue;
            //MessageBox.Show("Zvolená barva je " + (string)listBox1.SelectedItem);

            string item = (string)listBox1.SelectedItem;
            int index_item = listBox1.SelectedIndex;

            MessageBox.Show("Zvolená barva je " + item + " na pozici " + index_item);
/*
            // SelectionMode: Multiple simple
            ListBox.SelectedObjectCollection items = listBox1.SelectedItems;
            IList ilist_items = (IList)items;

            string log = "";
            foreach (string it in ilist_items)
                log += it + "\n";

            MessageBox.Show("Zvolená barva je " + log);
*/
        }

        // Přidání TextBox pro zadávání nové barvy
        // Umístěte TextBox na formulář a pojmenujte ho textBoxNewColor

        private void button2_Click(object sender, EventArgs e)
        {
            string newColor = textBoxNewColor.Text.Trim();
            if (!string.IsNullOrEmpty(newColor))
            {
                if (!arraylist_barvy.Contains(newColor))
                {
                    arraylist_barvy.Add(newColor);
                    update_listbox_barvy();
                }
                else
                {
                    MessageBox.Show("Tato barva již existuje.");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectionMode == SelectionMode.One)
            {
                var selectedItem = listBox1.SelectedItem;
                if (selectedItem != null)
                {
                    arraylist_barvy.Remove(selectedItem);
                    update_listbox_barvy();
                }
            }
            else
            {
                var selectedItems = new ArrayList(listBox1.SelectedItems);
                foreach (var item in selectedItems)
                {
                    arraylist_barvy.Remove(item);
                }
                update_listbox_barvy();
            }
        }

        // Pro výběr a odstranění více položek najednou, změňte SelectionMode ListBoxu
        // listBox1.SelectionMode = SelectionMode.MultiExtended;


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Aktuálně vybráno : " + listBox1.SelectedItem;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
