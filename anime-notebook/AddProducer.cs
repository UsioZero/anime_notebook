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
    public partial class AddProducer : Form
    {
        private readonly int producer_id;
        readonly bool edit;

        public AddProducer()
        {
            InitializeComponent();
            edit = false;
        }

        public AddProducer(int producer_id, string name, int age, string gender,
            int experience, int studio_id)
        {
            InitializeComponent();

            edit = true;
            this.producer_id = producer_id;
            nameTextBox.Text = name;
            ageTextBox.Text = age.ToString();
            genderTextBox.Text = gender;
            experienceTextBox.Text = experience.ToString();
            studioTextBox.Text = studio_id.ToString();

        }

        private void AddProducer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            //this.studioTableAdapter.Fill(this.anime_notebook_dbDataSet.Studio);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            //this.studioTableAdapter.Fill(this.anime_notebook_dbDataSet.Studio);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Producer' table. You can move, or remove it, as needed.
            //this.producerTableAdapter.Fill(this.anime_notebook_dbDataSet.Producer);

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                producerTableAdapter.UpdateQuery(
                    name: nameTextBox.Text,
                    age: Convert.ToInt32(ageTextBox.Text),
                    gender: genderTextBox.Text,
                    experience: Convert.ToInt32(experienceTextBox.Text),
                    studio_id: Convert.ToInt32(studioTextBox.Text),
                    producer_id: producer_id
                    );
            }
            else
            {
                producerTableAdapter.InsertQuery(
                    name: nameTextBox.Text,
                    age: Convert.ToInt32(ageTextBox.Text),
                    gender: genderTextBox.Text,
                    experience: Convert.ToInt32(experienceTextBox.Text),
                    studio_id: Convert.ToInt32(studioTextBox.Text)
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
