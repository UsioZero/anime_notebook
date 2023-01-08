namespace anime_notebook
{
    partial class AddRelease
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label viewsLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label anime_idLabel;
            this.anime_notebook_dbDataSet = new anime_notebook.anime_notebook_dbDataSet();
            this.releaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.releaseTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.ReleaseTableAdapter();
            this.tableAdapterManager = new anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager();
            this.viewsTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.anime_idTextBox = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateLabel = new System.Windows.Forms.Label();
            viewsLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            anime_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(29, 20);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "date:";
            // 
            // viewsLabel
            // 
            viewsLabel.AutoSize = true;
            viewsLabel.Location = new System.Drawing.Point(29, 46);
            viewsLabel.Name = "viewsLabel";
            viewsLabel.Size = new System.Drawing.Size(37, 13);
            viewsLabel.TabIndex = 5;
            viewsLabel.Text = "views:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(29, 72);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(36, 13);
            ratingLabel.TabIndex = 7;
            ratingLabel.Text = "rating:";
            // 
            // anime_idLabel
            // 
            anime_idLabel.AutoSize = true;
            anime_idLabel.Location = new System.Drawing.Point(29, 98);
            anime_idLabel.Name = "anime_idLabel";
            anime_idLabel.Size = new System.Drawing.Size(49, 13);
            anime_idLabel.TabIndex = 9;
            anime_idLabel.Text = "anime id:";
            // 
            // anime_notebook_dbDataSet
            // 
            this.anime_notebook_dbDataSet.DataSetName = "anime_notebook_dbDataSet";
            this.anime_notebook_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // releaseBindingSource
            // 
            this.releaseBindingSource.DataMember = "Release";
            this.releaseBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // releaseTableAdapter
            // 
            this.releaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ReleaseTableAdapter = this.releaseTableAdapter;
            this.tableAdapterManager.ReviewerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.StudioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // viewsTextBox
            // 
            this.viewsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.releaseBindingSource, "views", true));
            this.viewsTextBox.Location = new System.Drawing.Point(90, 43);
            this.viewsTextBox.Name = "viewsTextBox";
            this.viewsTextBox.Size = new System.Drawing.Size(200, 20);
            this.viewsTextBox.TabIndex = 6;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.releaseBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(90, 69);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(200, 20);
            this.ratingTextBox.TabIndex = 8;
            // 
            // anime_idTextBox
            // 
            this.anime_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.releaseBindingSource, "anime_id", true));
            this.anime_idTextBox.Location = new System.Drawing.Point(90, 95);
            this.anime_idTextBox.Name = "anime_idTextBox";
            this.anime_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.anime_idTextBox.TabIndex = 10;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ok.Location = new System.Drawing.Point(12, 121);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancel.Location = new System.Drawing.Point(215, 121);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // AddRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 164);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(dateLabel);
            this.Controls.Add(viewsLabel);
            this.Controls.Add(this.viewsTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(anime_idLabel);
            this.Controls.Add(this.anime_idTextBox);
            this.Name = "AddRelease";
            this.Text = "Release";
            this.Load += new System.EventHandler(this.AddRelease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private anime_notebook_dbDataSet anime_notebook_dbDataSet;
        private System.Windows.Forms.BindingSource releaseBindingSource;
        private anime_notebook_dbDataSetTableAdapters.ReleaseTableAdapter releaseTableAdapter;
        private anime_notebook_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox viewsTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox anime_idTextBox;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}