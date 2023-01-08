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
    public partial class Resettlement : Form
    {
        public Resettlement()
        {
            InitializeComponent();
        }

        private void producerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.producerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anime_notebook_dbDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Anime' table. You can move, or remove it, as needed.
            this.animeTableAdapter.Fill(this.anime_notebook_dbDataSet.Anime);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.anime_notebook_dbDataSet.Producer);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //exit button -border
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if (MessageBox.Show(
                "Вы действительно хотите подтвердить изменения?",
                "Изменение данных",
                MessageBoxButtons.YesNo) 
                == DialogResult.Yes) 
            { 
                producerBindingSource.EndEdit();
                producerTableAdapter.UpdateQuery(
                    name: nameTextBox.Text,
                    age: Convert.ToInt32(ageTextBox.Text),
                    gender: genderTextBox.Text,
                    experience: Convert.ToInt32(experienceTextBox.Text),
                    studio_id: Convert.ToInt32(studio_idTextBox.Text),
                    producer_id: Convert.ToInt32(producer_idTextBox.Text)
                    );
            } 
        }
    }
}
