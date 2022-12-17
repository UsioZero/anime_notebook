using System;
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
    public partial class AddReviewer : Form
    {
        private readonly int reviewer_id;
        readonly bool edit;

        public AddReviewer()
        {
            InitializeComponent();
            edit = false;
        }

        public AddReviewer(int reviewer_id, string name, string gender, DateTime birth_date, int experience)
        {
            InitializeComponent();
            edit = true;

            this.reviewer_id = reviewer_id;
            nameTextBox.Text = name;
            genderTextBox.Text = gender;
            dateTimePicker1.Value = birth_date;
            experienceTextBox.Text = experience.ToString();
        }

        private void AddReviewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Reviewer' table. You can move, or remove it, as needed.
            //this.reviewerTableAdapter.Fill(this.anime_notebook_dbDataSet.Reviewer);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                reviewerTableAdapter.UpdateQuery(
                    reviewer_id: reviewer_id,
                    name: nameTextBox.Text,
                    gender: genderTextBox.Text,
                    birth_date: dateTimePicker1.Value.ToString(),
                    experience: Convert.ToInt32(experienceTextBox.Text)
                    );
            }
            else
            {
                reviewerTableAdapter.InsertQuery(
                    name: nameTextBox.Text,
                    gender: genderTextBox.Text,
                    birth_date: dateTimePicker1.Value.ToString(),
                    experience: Convert.ToInt32(experienceTextBox.Text)
                );
            }

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
