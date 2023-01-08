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
    public partial class AddStudio : Form
    {
        private readonly int studio_id;
        readonly bool edit;

        public AddStudio()
        {
            InitializeComponent();
            edit = false;
        }

        public AddStudio(int studio_id, string name, string place)
        {
            InitializeComponent();
            edit = true;

            this.studio_id = studio_id;
            nameTextBox.Text = name;
            placeTextBox.Text = place;
        }

        private void AddStudio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            //this.studioTableAdapter.Fill(this.anime_notebook_dbDataSet.Studio);
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

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                studioTableAdapter.UpdateQuery(
                    studio_id: studio_id,
                    name: nameTextBox.Text,
                    place: placeTextBox.Text
                    );
            }
            else
            {
                studioTableAdapter.InsertQuery(
                    name: nameTextBox.Text,
                    place: placeTextBox.Text
                    );
            }    

            Close();
        }
    }
}
