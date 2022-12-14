using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace anime_notebook
{
    public partial class EditForm : Form
    {

        private readonly int anime_id;
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            //animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
            producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
            studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
            edit = false;
        }

        public EditForm(int anime_id, string name, string genre, int series, string annotation, string type,
            DateTime announcement_date, string streaming_service,string origin, int producer_id, int studio_id)
        : this()
        {
            // roomsTableAdapter.Fill(hostelDataSet.Rooms);
            producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
            studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);

            edit = true;
            this.anime_id = anime_id;
            textBox_Name.Text = name;
            textBox_Genre.Text = genre;
            numericUpDown_Series.Value = series;
            richTextBox_Annotation.Text = annotation;
            textBox_Type.Text = type;
            dateTimePicker_AnnounceDate.Value = announcement_date;
            textBox_StreamingService.Text = streaming_service;
            textBox_Origin.Text = origin;
            comboBox_Producer.SelectedValue = producer_id;
            comboBox_studio.SelectedValue = studio_id;
        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                animeTableAdapter.UpdateQuery(
                    name: textBox_Name.Text,
                    genre: textBox_Genre.Text,
                    series: Convert.ToInt32(numericUpDown_Series.Value),
                    annotation: richTextBox_Annotation.Text,
                    type: textBox_Type.Text,
                    announcement_date: dateTimePicker_AnnounceDate.Value.ToString(),
                    streaming_service: textBox_StreamingService.Text,
                    origin: textBox_Origin.Text,
                    producer_id: Convert.ToInt32(comboBox_Producer.Text),
                    studio_id: Convert.ToInt32(comboBox_studio.Text),
                    anime_id: anime_id);
            }
            else
            {
                animeTableAdapter.InsertQuery(
                    name: textBox_Name.Text,
                    genre: textBox_Genre.Text,
                    series: Convert.ToInt32(numericUpDown_Series.Value),
                    annotation: richTextBox_Annotation.Text,
                    type: textBox_Type.Text,
                    announcement_date: dateTimePicker_AnnounceDate.Value.ToString(),
                    streaming_service: textBox_StreamingService.Text,
                    origin: textBox_Origin.Text,
                    producer_id: Convert.ToInt32(comboBox_Producer.Text),
                    studio_id: Convert.ToInt32(comboBox_studio.Text));
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            //exit button -border
            button_Ok.TabStop = false;
            button_Ok.FlatStyle = FlatStyle.Flat;
            button_Ok.FlatAppearance.BorderSize = 0;
            button_Ok.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent

            //exit button -border
            button_Cancel.TabStop = false;
            button_Cancel.FlatStyle = FlatStyle.Flat;
            button_Cancel.FlatAppearance.BorderSize = 0;
            button_Cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
        }
    }
}
