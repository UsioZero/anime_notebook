using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;
using Org.BouncyCastle.Ocsp;
using System.Runtime.Remoting.Lifetime;

namespace anime_notebook
{
    public partial class SearchForm : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-VUJIJGT;Initial Catalog=anime_notebook_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private bool isNameChanged = false;
        private bool isGenreChanged = false;
        private bool isStreamChanged = false;
        private bool isTypeChanged = false;
        private bool isOriginChanged = false;
        private bool isProducerChanged = false;
        private bool isStudioChanged = false;
        private bool isAnnotationChanged = false;

        private string name = "";
        private string genre = "";
        private string series = "";
        private string type = "";
        private string date = "";
        private string stream = "";
        private string origin = "";
        private string producer = "";
        private string studio = "";
        private string annotation = "";

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            this.studioTableAdapter.Fill(this.anime_notebook_dbDataSet.Studio);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.anime_notebook_dbDataSet.Producer);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Anime' table. You can move, or remove it, as needed.
            this.animeTableAdapter.Fill(this.anime_notebook_dbDataSet.Anime);

            comboBox_Producer.SelectedItem = null;
            comboBox_Studio.SelectedItem = null;
            isProducerChanged = false;
            isStudioChanged = false;
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            isNameChanged = true;
        }

        private void textBox_Genre_TextChanged(object sender, EventArgs e)
        {
            isGenreChanged = true;
        }

        private void textBox_Type_TextChanged(object sender, EventArgs e)
        {
            isTypeChanged = true;
        }

        private void textBox_StreamingService_TextChanged(object sender, EventArgs e)
        {
            isStreamChanged = true;
        }

        private void textBox_Origin_TextChanged(object sender, EventArgs e)
        {
            isOriginChanged = true;
        }

        private void comboBox_Producer_TextChanged(object sender, EventArgs e)
        {
            isProducerChanged = true;
        }

        private void comboBox_Studio_SelectedIndexChanged(object sender, EventArgs e)
        {
            isStudioChanged = true;
        }

        private void richTextBox_Annotation_TextChanged(object sender, EventArgs e)
        {
            isAnnotationChanged = true;
        }


        private void search_button_Click(object sender, EventArgs e)
        {
            string select = "SELECT Anime.name, Producer.name, genre, Release.date, views, rating, Studio.Name, series, annotation FROM Anime, Producer, Studio, Release WHERE Anime.producer_id = Producer.producer_id AND Anime.anime_id = Release.anime_id AND Anime.studio_id = Studio.studio_id AND ";

            if (isNameChanged && !String.IsNullOrEmpty(textBox_Name.Text))
            {
                name = $"Anime.name LIKE '%{textBox_Name.Text}%' AND ";
            }
            if (isGenreChanged && !String.IsNullOrEmpty(textBox_Genre.Text))
            {
                genre = $"genre LIKE '%{textBox_Genre.Text}%' AND ";
            }
            series = $"series BETWEEN {numericUpDown_Series_from.Value} AND {numericUpDown_Series_to.Value} AND ";
            date = $"Release.date BETWEEN '{dateTimePicker_AnnounceDate.Value}' AND '{dateTimePicker_to.Value}' AND ";
            if (isStreamChanged && !String.IsNullOrEmpty(textBox_StreamingService.Text))
            {
                stream = $"streaming_service LIKE '%{textBox_StreamingService.Text}%' AND ";
            }
            if (isOriginChanged && !String.IsNullOrEmpty(textBox_Origin.Text))
            {
                origin = $"origin LIKE '%{textBox_Origin.Text}%' AND ";
            }
            if (isTypeChanged && !String.IsNullOrEmpty(textBox_Type.Text))
            {
                type = $"type LIKE '%{textBox_Type.Text}%' AND ";
            }
            if (isProducerChanged)
            {
                producer = $"Producer.name = '{comboBox_Producer.Text}' AND ";
            }
            if (isStudioChanged)
            {
                studio = $"Studio.name = '{comboBox_Studio.Text}' AND ";
            }
            if (isAnnotationChanged && !String.IsNullOrEmpty(richTextBox_Annotation.Text))
            {
                annotation = $"annotation LIKE '%{richTextBox_Annotation.Text}%' AND ";
            }

            select += name + genre + series + date + stream + origin + type + producer + studio + annotation;

            name = "";
            genre = "";
            series = "";
            type = "";
            date = "";
            stream = "";
            origin = "";
            producer = "";
            studio = "";
            annotation = "";

            while (true)
            {
                if (select[select.Length - 1] == ' ')
                {
                    select = select.Substring(0, select.Length - 1);
                }
                else if (select.Substring(select.Length - 3, 3) == "AND")
                {
                    select = select.Substring(0, select.Length - 3);
                }
                else break;
            }

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();
            SqlDataAdapter oda = new SqlDataAdapter(select, sqlcon);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Height = 15 + (dataGridView1.Rows.Count + 2) * 20;

            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"../../reports/report_anime.pdf", FileMode.Create));
            writer.PageEvent = new PDFFooter();
            doc.Open();

            Paragraph p1 = new Paragraph(str: "Anime you have found!",
                FontFactory.GetFont("Times New Roman", 28, BaseColor.BLACK));
            p1.Alignment = Element.ALIGN_CENTER;

            doc.Add(p1);

            DataSet dataSet = new DataSet();
            oda.Fill(dataSet);
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                string str = $"Anime {i+1}:\n";
                str += $"       Anime name - {dataSet.Tables[0].Rows[i][0]}\n";
                str += $"       Producer name - {dataSet.Tables[0].Rows[i][1]}\n";
                str += $"       Genre - {dataSet.Tables[0].Rows[i][2]}\n";
                str += $"       Release date - {dataSet.Tables[0].Rows[i][3]}\n";
                str += $"       Views - {dataSet.Tables[0].Rows[i][4]}m\n";
                str += $"       Rating - {dataSet.Tables[0].Rows[i][5]}\n";
                str += $"       Studio name - {dataSet.Tables[0].Rows[i][6]}\n";
                str += $"       Series - {dataSet.Tables[0].Rows[i][7]}\n";
                str += $"       Annotation - {dataSet.Tables[0].Rows[i][8]}\n";

                p1 = new Paragraph(
                    str: str,
                    font: FontFactory.GetFont("Times New Roman", 14, BaseColor.BLACK)
                    );
                doc.Add(p1);
            }

            doc.Close();
        }
    }
}
