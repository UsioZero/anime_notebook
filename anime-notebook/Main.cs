using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.MessageBox;

namespace anime_notebook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private bool edit = true;

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
            bindingNavigator2.BindingSource = studioBindingSource;
            dataGridView2.DataSource = studioBindingSource;
            bindingNavigator2.BindingSource = animeBindingSource;
            dataGridView2.DataSource = animeBindingSource;
            label1.Text = "Anime";

        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = studioBindingSource;
            dataGridView2.DataSource = studioBindingSource;
            label1.Text = "Studio";
        }

        private void producerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = producerBindingSource;
            dataGridView2.DataSource = producerBindingSource;
            label1.Text = "Producer";
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = animeBindingSource;
            dataGridView2.DataSource = animeBindingSource;
            label1.Text = "Anime";
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
            if (!edit) return;

            var edt = new EditForm();

            edt.ShowDialog();
            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
            anime_notebook_dbDataSet.AcceptChanges();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;

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
            producer_id: Convert.ToInt32(row[9].ToString()));

            edt.ShowDialog();
            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
            anime_notebook_dbDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!edit) return;

            animeTableAdapter.DeleteQuery(
            Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value));

            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
            anime_notebook_dbDataSet.AcceptChanges();

        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = releaseBindingSource;
            dataGridView2.DataSource = releaseBindingSource;
            label1.Text = "Release";
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = reviewBindingSource;
            dataGridView2.DataSource = reviewBindingSource;
            label1.Text = "Review";
        }

        private void reviewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator2.BindingSource = reviewerBindingSource;
            dataGridView2.DataSource = reviewerBindingSource;
            label1.Text = "Reviewer";
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
            if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //do no stuff
            }
        }
    }
}
