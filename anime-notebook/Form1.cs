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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Anime' table. You can move, or remove it, as needed.
            this.animeTableAdapter.Fill(this.anime_notebook_dbDataSet.Anime);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.anime_notebook_dbDataSet.Producer);
            // TODO: This line of code loads data into the 'anime_notebook_dbDataSet.Studio' table. You can move, or remove it, as needed.
            this.studioTableAdapter.Fill(this.anime_notebook_dbDataSet.Studio);
            dataGridView2.AutoGenerateColumns = true;

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
            var rs = new Form2(); 
            rs.ShowDialog();
            studioTableAdapter.Fill(anime_notebook_dbDataSet.Studio);
            producerTableAdapter.Fill(anime_notebook_dbDataSet.Producer);
            animeTableAdapter.Fill(anime_notebook_dbDataSet.Anime);
        }
    }
}
