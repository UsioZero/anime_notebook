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
                producerTableAdapter.Update(anime_notebook_dbDataSet); 
                animeTableAdapter.Update(anime_notebook_dbDataSet); 
            } 
        }
    }
}
