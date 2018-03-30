using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntroductionToWindowsFormsApplication
{
    public partial class ComboBoxExample : Form
    {
        public ComboBoxExample()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NewItemTextBox.Text != "")
            {
                SportsComboBox.Items.Add(NewItemTextBox.Text);
            }

            NewItemTextBox.Clear();
            NewItemTextBox.Focus();
        }

        private void CountItemsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toatal Items : " + SportsComboBox.Items.Count);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            //when you have object
            //SportsComboBox.Items.Remove(SportsComboBox.SelectedItem);

            //when you have index
            if (SportsComboBox.Text != "")
            {
                SportsComboBox.Items.RemoveAt(SportsComboBox.SelectedIndex);
            }
        }

        private void ClearAllItemsButton_Click(object sender, EventArgs e)
        {
            SportsComboBox.Items.Clear();
        }

        private void SortItemsButton_Click(object sender, EventArgs e)
        {
            SportsComboBox.Sorted = true;
        }
    }
}
