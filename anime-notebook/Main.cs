using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.MessageBox;
using System.Data.SqlClient;

namespace anime_notebook
{
    public partial class Main : Form
    {
        public Main(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        const string ConnectionString = @"Data Source=DESKTOP-VUJIJGT;Initial Catalog=anime_notebook_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly string login;
        private bool isPredict = false;

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Reviewer' table. You can move, or remove it, as needed.
            this.reviewerTableAdapter.Fill(this.anime_notebook_dbDataSet.Reviewer);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter.Fill(this.anime_notebook_dbDataSet.Review);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Release' table. You can move, or remove it, as needed.
            this.releaseTableAdapter.Fill(this.anime_notebook_dbDataSet.Release);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Anime' table. You can move, or remove it, as needed.
            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Producer' table. You can move, or remove it, as needed.
            producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
            dataGridView2.AutoGenerateColumns = true;

            //set anime 
            //bindingNavigator2.BindingSource = studioBindingSource;
            //dataGridView2.DataSource = studioBindingSource;
            //bindingNavigator2.BindingSource = animeBindingSource;
            //dataGridView2.DataSource = animeBindingSource;
            //label1.Text = "Anime";

            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1990,1,1);
            return origin.AddHours(timestamp);
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1990, 1, 1);
            TimeSpan diff = date - origin;
            return Math.Floor(diff.TotalHours);
        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = studioBindingSource;
            dataGridView2.DataSource = studioBindingSource;
            label1.Text = "Studio";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = producerBindingSource;
            dataGridView2.DataSource = producerBindingSource;
            label1.Text = "Producer";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = animeBindingSource;
            dataGridView2.DataSource = animeBindingSource;
            label1.Text = "Anime";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            studioTableAdapter.Update(anime_notebook_dbDataSet);
            producerTableAdapter.Update(anime_notebook_dbDataSet);
            animeTableAdapter.Update(anime_notebook_dbDataSet);
        }

        private void resettlemenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new Resettlement(); 
            rs.ShowDialog();
            studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
            producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Anime")
            {
                var edt = new EditForm();
                edt.ShowDialog();
                animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Producer")
            {
                var edt = new AddProducer();
                edt.ShowDialog();
                producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Release")
            {
                var edt = new AddRelease();
                edt.ShowDialog();
                releaseTableAdapter.Fill(anime_notebook_dbDataSet.Release);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Review")
            {
                var edt = new AddReview();
                edt.ShowDialog();
                reviewTableAdapter.Fill(anime_notebook_dbDataSet.Review);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Reviewer")
            {
                var edt = new AddReviewer();
                edt.ShowDialog();
                reviewerTableAdapter.Fill(anime_notebook_dbDataSet.Reviewer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Studio")
            {
                var edt = new AddStudio();
                edt.ShowDialog();
                studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
                anime_notebook_dbDataSet.AcceptChanges();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
 

            if (label1.Text == "Anime")
            {
                var an = new anime_notebook_dbDataSet.AnimeDataTable();
                animeTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new EditForm(
                anime_id: Convert.ToInt32(row[0]),
                name: row[1].ToString(),
                genre: row[2].ToString(),
                series: Convert.ToInt32(row[3].ToString()),
                annotation: row[4].ToString(),
                type: row[5].ToString(),
                announcement_date: Convert.ToDateTime(row[6]),
                streaming_service: row[7].ToString(),
                origin: row[8].ToString(),
                producer_id: Convert.ToInt32(row[9].ToString()),
                studio_id: Convert.ToInt32(row[10].ToString()));

                edt.ShowDialog();
                animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Producer")
            {
                var an = new anime_notebook_dbDataSet.ProducerDataTable();
                producerTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new AddProducer(
                    producer_id: Convert.ToInt32(row[0].ToString()),
                    name: row[1].ToString(),
                    age: Convert.ToInt32(row[2].ToString()),
                    gender: row[3].ToString(),
                    experience: Convert.ToInt32(row[4].ToString()),
                    studio_id: Convert.ToInt32(row[5].ToString()));

                edt.ShowDialog();
                producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Release")
            {
                var an = new anime_notebook_dbDataSet.ReleaseDataTable();
                releaseTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new AddRelease(
                    release_id: Convert.ToInt32(row[0].ToString()),
                    date: Convert.ToDateTime(row[1]),
                    views: Convert.ToInt32(row[2].ToString()),
                    rating: Convert.ToDouble(row[3].ToString()),
                    anime_id: Convert.ToInt32(row[4].ToString())
                    );

                edt.ShowDialog();
                releaseTableAdapter.Fill(anime_notebook_dbDataSet.Release);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Review")
            {
                var an = new anime_notebook_dbDataSet.ReviewDataTable();
                reviewTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new AddReview(
                    review_id: Convert.ToInt32(row[0].ToString()),
                    rating: Convert.ToDouble(row[1].ToString()),
                    reviewer_id: Convert.ToInt32(row[2].ToString()),
                    release_id: Convert.ToInt32(row[3].ToString())
                    );

                edt.ShowDialog();
                reviewTableAdapter.Fill(anime_notebook_dbDataSet.Review);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Reviewer")
            {
                var an = new anime_notebook_dbDataSet.ReviewerDataTable();
                reviewerTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new AddReviewer(
                    reviewer_id: Convert.ToInt32(row[0]),
                    name: row[1].ToString(),
                    gender: row[2].ToString(),
                    birth_date: Convert.ToDateTime(row[3]),
                    experience: Convert.ToInt32(row[4])
                    );

                edt.ShowDialog();
                reviewerTableAdapter.Fill(anime_notebook_dbDataSet.Reviewer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Studio")
            {
                var an = new anime_notebook_dbDataSet.StudioDataTable();
                studioTableAdapter.FillBy(an,
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));
                object[] row = an.Rows[0].ItemArray;

                var edt = new AddStudio(
                    studio_id: Convert.ToInt32(row[0]),
                    name: row[1].ToString(),
                    place: row[2].ToString()
                    );

                edt.ShowDialog();
                studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
                anime_notebook_dbDataSet.AcceptChanges();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Anime")
            {
                animeTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Producer")
            {
                producerTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Release")
            {
                releaseTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                releaseTableAdapter.Fill(anime_notebook_dbDataSet.Release);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Review")
            {
                reviewTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                reviewTableAdapter.Fill(anime_notebook_dbDataSet.Review);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Reviewer")
            {
                reviewerTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                reviewerTableAdapter.Fill(anime_notebook_dbDataSet.Reviewer);
                anime_notebook_dbDataSet.AcceptChanges();
            }
            if (label1.Text == "Studio")
            {
                studioTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
                anime_notebook_dbDataSet.AcceptChanges();
            }

        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = releaseBindingSource;
            dataGridView2.DataSource = releaseBindingSource;
            label1.Text = "Release";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = reviewBindingSource;
            dataGridView2.DataSource = reviewBindingSource;
            label1.Text = "Review";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void reviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = reviewerBindingSource;
            dataGridView2.DataSource = reviewerBindingSource;
            label1.Text = "Reviewer";
            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                comboBox1.Items.Add(dataGridView2.Columns[i].HeaderText.ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void reviewerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rq = new RequestForm("Reviewer");
            rq.Show();
        }

        private void releaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rq = new RequestForm("Release");
            rq.Show();

        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rq = new RequestForm("Studio");
            rq.Show();
        }

        private void animeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var rq = new RequestForm("Anime");
            rq.Show();
        }

        private void animeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var rp = new SearchForm();
            rp.Show();
        }

        private void paymantHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream($"../../reports/report_payment_history.pdf", FileMode.Create));
            writer.PageEvent = new PDFFooter();
            doc.Open();
            Paragraph p1 = new Paragraph(str: "Your payment history!",
                FontFactory.GetFont("Times New Roman", 28, BaseColor.BLACK));
            p1.Alignment = Element.ALIGN_CENTER;
            doc.Add(p1);

            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string select = $"SELECT * FROM User1";
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            sqlcon.Close();

            string str = $"\nEmail: {dataSet.Tables[0].Rows[0][1]}\n";
            str += $"Login: {dataSet.Tables[0].Rows[0][2]}\n";
            str += $"Props: {dataSet.Tables[0].Rows[0][4]}\n";
            str += "Cost per month: 5$\n";
            str += $"Subscription date: {dataSet.Tables[0].Rows[0][5].ToString().Substring(0, dataSet.Tables[0].Rows[0][5].ToString().Length - 9)}\n";
            str += $"Subscription duration: {dataSet.Tables[0].Rows[0][6]} month";

            p1 = new Paragraph(
                str: str,
                font: FontFactory.GetFont("Times New Roman", 14, BaseColor.BLACK)
                );
            doc.Add(p1);

            doc.Close();

            if (MessageBox.Show("Payment History Has Been Successfully Saved To Your Computer!", "", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.No)
            {
                //do no stuff
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && comboBox1.SelectedItem != null)
            {
                if (label1.Text == "Anime") 
                { 
                    if(comboBox1.SelectedItem == "studio_id" 
                        || comboBox1.SelectedItem == "anime_id"
                        || comboBox1.SelectedItem == "series"
                        || comboBox1.SelectedItem == "producer_id")
                    {
                        animeBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                    }
                    else
                    animeBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'"); 
                }
                if (label1.Text == "Producer")
                {
                    if (comboBox1.SelectedItem == "studio_id"
                        || comboBox1.SelectedItem == "age"
                        || comboBox1.SelectedItem == "experience"
                        || comboBox1.SelectedItem == "producer_id")
                    {
                        producerBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                    }
                    else
                        producerBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'");
                }
                if (label1.Text == "Release") 
                {
                    if (comboBox1.SelectedItem == "release_id"
                        || comboBox1.SelectedItem == "views"
                        || comboBox1.SelectedItem == "rating"
                        || comboBox1.SelectedItem == "anime_id")
                    {
                        releaseBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                    }
                    else
                        releaseBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'"); 
                }
                if (label1.Text == "Review") 
                {
                    reviewBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                }
                if (label1.Text == "Reviewer")
                {
                    if (comboBox1.SelectedItem == "reviewer_id"
                        || comboBox1.SelectedItem == "experience")
                    {
                        reviewerBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                    }
                    else
                        reviewerBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'");
                }
                if (label1.Text == "Studio")
                {
                    if (comboBox1.SelectedItem == "studio_id")
                    {
                        studioBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} = {textBox1.Text}");
                    }
                    else
                        studioBindingSource.Filter = string.Format($"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'");
                }
            }
            else
            {
                animeBindingSource.RemoveFilter();
                producerBindingSource.RemoveFilter();
                releaseBindingSource.RemoveFilter();
                reviewBindingSource.RemoveFilter();
                reviewerBindingSource.RemoveFilter();
                studioBindingSource.RemoveFilter();
            }
        }

        private void makeAnimePredictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Anime")
            {
                // Not released
                if (!isPredict)
                {
                    SqlConnection sqlcon = new SqlConnection(ConnectionString);
                    sqlcon.Open();
                    SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM Anime WHERE anime_id NOT IN (SELECT anime_id FROM RELEASE)", sqlcon);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView2.DataSource = dt;
                    sqlcon.Close();

                    var an = new anime_notebook_dbDataSet.AnimeDataTable();
                    try
                    {
                        //Selected row
                        animeTableAdapter.FillBy(an,
                            Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                        object[] row = an.Rows[0].ItemArray;
                    }
                    catch
                    {
                        if (MessageBox.Show("Select An Anime!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                        {

                        }
                    }
                }
                else
                {
                    var an = new anime_notebook_dbDataSet.AnimeDataTable();

                    //Selected row
                    animeTableAdapter.FillBy(an,
                        Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

                    object[] row = an.Rows[0].ItemArray;

                    SqlConnection sqlcon = new SqlConnection(ConnectionString);
                    sqlcon.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        $"SELECT Anime.announcement_date, Release.date FROM Anime, Release WHERE Anime.anime_id = Release.anime_id"
                        , sqlcon);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    sqlcon.Close();

                    DateTime[] dateTimes1 = new DateTime[dataSet.Tables[0].Rows.Count];
                    DateTime[] dateTimes2 = new DateTime[dataSet.Tables[0].Rows.Count];
                    double[] longs1 = new double[dataSet.Tables[0].Rows.Count];
                    double[] longs2 = new double[dataSet.Tables[0].Rows.Count];
                    double x = 0;
                    double x2 = 0;
                    double x3 = 0;
                    double x4 = 0;
                    DateTime leftDate;
                    DateTime rightDate;

                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        dateTimes1[i] = Convert.ToDateTime(dataSet.Tables[0].Rows[i][0].ToString());
                        longs1[i] = ConvertToUnixTimestamp(dateTimes1[i]);

                        dateTimes2[i] = Convert.ToDateTime(dataSet.Tables[0].Rows[i][1].ToString());
                        longs2[i] = ConvertToUnixTimestamp(dateTimes2[i]);
                    }

                    for (int i = 0; i < longs1.Length; i++)
                    {
                        x += longs1[i] + longs2[i];
                    }
                    x /= 2 * longs1.Length;

                    for (int i = 0; i < longs1.Length; i++)
                    {
                        x2 += (longs1[i] - x) * (longs1[i] - x) + (longs2[i] - x) * (longs2[i] - x);
                    }
                    x2 /= 2 * longs1.Length;
                    DateTime a = Convert.ToDateTime((row[6]));

                    x3 = ConvertToUnixTimestamp(a);
                    x4 = ConvertToUnixTimestamp(a) + Math.Sqrt(x2) * 0.2;

                    leftDate = ConvertFromUnixTimestamp(x3);
                    rightDate = ConvertFromUnixTimestamp(x4);
                        if (MessageBox.Show($"Anime will be from {leftDate} to {rightDate}", "done", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.No)
                        {

                        }
                    }
                    isPredict = !isPredict;
                }
            else
            {
                if (MessageBox.Show("Wrong Table!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                {

                }
            }
        }
    }
}
