﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anime_notebook
{
    public partial class AddRelease : Form
    {
        private readonly int release_id;
        readonly bool edit;

        public AddRelease()
        {
            InitializeComponent();
            edit = false;
        }

        public AddRelease(int release_id, DateTime date, int views, double rating, int anime_id)
        {
            InitializeComponent();
            edit = true;

            dateTimePicker1.Value = date;
            viewsTextBox.Text = views.ToString();
            ratingTextBox.Text = rating.ToString();
            anime_idTextBox.Text = anime_id.ToString();
            this.release_id = release_id;
        }

        private void AddRelease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Release' table. You can move, or remove it, as needed.
            //this.releaseTableAdapter.Fill(this.anime_notebook_dbDataSet.Release);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                releaseTableAdapter.UpdateQuery(
                    date: dateTimePicker1.Value.ToString(),
                    views: Convert.ToInt32(viewsTextBox.Text),
                    rating: Convert.ToDouble(ratingTextBox.Text),
                    anime_id: Convert.ToInt32(anime_idTextBox.Text),
                    release_id: Convert.ToInt32(release_id)
                    );
            }
            else
            {
                releaseTableAdapter.InsertQuery(
                    date: dateTimePicker1.Value.ToString(),
                    views: Convert.ToInt32(viewsTextBox.Text),
                    rating: Convert.ToDouble(ratingTextBox.Text),
                    anime_id: Convert.ToInt32(anime_idTextBox.Text)
                    );
            }
            Close();
        }
    }
}
