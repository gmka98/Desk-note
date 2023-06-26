﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk_Note
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text;

            table.Rows.Add(title, message);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        { //check if the selected row exist

            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // select the first element of the row
                int rowIndex = selectedRow.Index;

                string newTitle = txtTitle.Text;
                string newMessage = txtMessage.Text;

                table.Rows[rowIndex]["Title"] = newTitle;
                table.Rows[rowIndex]["Message"] = newMessage;

                txtTitle.Clear();
                txtMessage.Clear();

            }

        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();

        }
        private void bttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
