using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anime_notebook
{
    public partial class RequestForm : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-VUJIJGT;Initial Catalog=anime_notebook_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public RequestForm(string tableName)
        {
            InitializeComponent();

            label1.Text = tableName;
            makeRequest(tableName);
        }

        private void makeRequest(string tableName)
        {
            string select;

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();

            switch (tableName)
            {
                case "Release":
                    select = "SELECT TOP 10 Anime.name, Producer.name, genre, Release.date, views, rating, Studio.Name, series FROM Anime, Producer, Release, Studio WHERE Anime.producer_id = Producer.producer_id AND Anime.anime_id = Release.anime_id AND Anime.studio_id = Studio.studio_id ORDER BY views DESC";
                    break;
                case "Reviewer":
                    select = "SELECT name, birth_date, experience, COUNT(Review.review_id) AS reviews FROM Reviewer, Review WHERE Reviewer.reviewer_id = Review.reviewer_id GROUP BY name, birth_date, experience";
                    break;
                case "Studio":
                    select = "select Studio.name as Studio, AA.aa as Anime, BB.bb as Producer from (select studio.studio_id as id, count(Anime.anime_id) as aa from studio left join anime on anime.studio_id = studio.studio_id group by studio.studio_id) AA, (select studio.studio_id as id, count(producer.producer_id) as bb from studio LEFT JOIN producer ON producer.studio_id = studio.studio_id group by studio.studio_id ) BB, Studio where AA.id = BB.id and AA.id = Studio.studio_id";
                    break;
                case "Anime":
                    select = "SELECT Anime.name, Producer.name, announcement_date, genre, Studio.name, series FROM Anime, Producer, Studio WHERE Anime.studio_id = Studio.studio_id AND Anime.producer_id = Producer.producer_id AND Anime.anime_id NOT IN (SELECT anime_id FROM Release)";
                    break;
                default:
                    sqlcon.Close();
                    return;
            }

            SqlDataAdapter oda = new SqlDataAdapter(select, sqlcon);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Height = 15 + (dataGridView1.Rows.Count + 2) * 20;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);
        }
    }
}
