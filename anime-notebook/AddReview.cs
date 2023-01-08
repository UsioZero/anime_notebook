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
    public partial class AddReview : Form
    {
        private readonly int review_id;
        readonly bool edit;

        public AddReview()
        {
            InitializeComponent();
            edit = false;
        }

        public AddReview(int review_id, double rating, int reviewer_id, int release_id)
        {
            InitializeComponent();
            edit = true;

            this.review_id = review_id;
            ratingTextBox.Text = rating.ToString();
            reviewer_idTextBox.Text = reviewer_id.ToString();
            release_idTextBox.Text = release_id.ToString();
        }

        private void AddReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Review' table. You can move, or remove it, as needed.
            //this.reviewTableAdapter.Fill(this.anime_notebook_dbDataSet.Review);
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
                reviewTableAdapter.UpdateQuery(
                    rating: Convert.ToDouble(ratingTextBox.Text),
                    reviewer_id: Convert.ToInt32(reviewer_idTextBox.Text),
                    release_id: Convert.ToInt32(release_idTextBox.Text),
                    review_id: review_id
                    );
            }
            else
            {
                reviewTableAdapter.InsertQuery(
                    rating: Convert.ToDouble(ratingTextBox.Text),
                    reviewer_id: Convert.ToInt32(reviewer_idTextBox.Text),
                    release_id: Convert.ToInt32(release_idTextBox.Text)
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
