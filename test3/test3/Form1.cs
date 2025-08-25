using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        // Contact class with Properties
        public class Contact
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }

            public Contact(string name, string phone)
            {
                Name = name;
                PhoneNumber = phone;
            }
        }

        // List to store contacts
        private List<Contact> directory = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configure ListView
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            // Add columns
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Phone Number", 150);
        }

        private void button1_Click(object sender, EventArgs e) // Add Contact
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter both Name and Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add to list
            Contact newContact = new Contact(name, phone);
            directory.Add(newContact);

            // Add to ListView
            ListViewItem item = new ListViewItem(newContact.Name);
            item.SubItems.Add(newContact.PhoneNumber);
            listView1.Items.Add(item);

            // Clear text boxes
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // Delete Contact
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;

                // Remove from list and ListView
                directory.RemoveAt(index);
                listView1.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fill textboxes when selecting an item
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }
    }
}
