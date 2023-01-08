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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //exit button -border
            button_ok.TabStop = false;
            button_ok.FlatStyle = FlatStyle.Flat;
            button_ok.FlatAppearance.BorderSize = 0;
            button_ok.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //exit button -border
            button_cancel.TabStop = false;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
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
