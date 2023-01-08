namespace anime_notebook
{
    partial class AddReview
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
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label reviewer_idLabel;
            System.Windows.Forms.Label release_idLabel;
            this.anime_notebook_dbDataSet = new anime_notebook.anime_notebook_dbDataSet();
            this.reviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reviewTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.ReviewTableAdapter();
            this.tableAdapterManager = new anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.reviewer_idTextBox = new System.Windows.Forms.TextBox();
            this.release_idTextBox = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            ratingLabel = new System.Windows.Forms.Label();
            reviewer_idLabel = new System.Windows.Forms.Label();
            release_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(12, 12);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(36, 13);
            ratingLabel.TabIndex = 3;
            ratingLabel.Text = "rating:";
            // 
            // reviewer_idLabel
            // 
            reviewer_idLabel.AutoSize = true;
            reviewer_idLabel.Location = new System.Drawing.Point(12, 38);
            reviewer_idLabel.Name = "reviewer_idLabel";
            reviewer_idLabel.Size = new System.Drawing.Size(61, 13);
            reviewer_idLabel.TabIndex = 5;
            reviewer_idLabel.Text = "reviewer id:";
            // 
            // release_idLabel
            // 
            release_idLabel.AutoSize = true;
            release_idLabel.Location = new System.Drawing.Point(12, 64);
            release_idLabel.Name = "release_idLabel";
            release_idLabel.Size = new System.Drawing.Size(55, 13);
            release_idLabel.TabIndex = 7;
            release_idLabel.Text = "release id:";
            // 
            // anime_notebook_dbDataSet
            // 
            this.anime_notebook_dbDataSet.DataSetName = "anime_notebook_dbDataSet";
            this.anime_notebook_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reviewBindingSource
            // 
            this.reviewBindingSource.DataMember = "Review";
            this.reviewBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // reviewTableAdapter
            // 
            this.reviewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ReleaseTableAdapter = null;
            this.tableAdapterManager.ReviewerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = this.reviewTableAdapter;
            this.tableAdapterManager.StudioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(79, 9);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ratingTextBox.TabIndex = 4;
            // 
            // reviewer_idTextBox
            // 
            this.reviewer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "reviewer_id", true));
            this.reviewer_idTextBox.Location = new System.Drawing.Point(79, 35);
            this.reviewer_idTextBox.Name = "reviewer_idTextBox";
            this.reviewer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.reviewer_idTextBox.TabIndex = 6;
            // 
            // release_idTextBox
            // 
            this.release_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reviewBindingSource, "release_id", true));
            this.release_idTextBox.Location = new System.Drawing.Point(79, 61);
            this.release_idTextBox.Name = "release_idTextBox";
            this.release_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.release_idTextBox.TabIndex = 8;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ok.Location = new System.Drawing.Point(12, 124);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 9;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancel.Location = new System.Drawing.Point(123, 124);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 159);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(reviewer_idLabel);
            this.Controls.Add(this.reviewer_idTextBox);
            this.Controls.Add(release_idLabel);
            this.Controls.Add(this.release_idTextBox);
            this.Name = "AddReview";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.AddReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private anime_notebook_dbDataSet anime_notebook_dbDataSet;
        private System.Windows.Forms.BindingSource reviewBindingSource;
        private anime_notebook_dbDataSetTableAdapters.ReviewTableAdapter reviewTableAdapter;
        private anime_notebook_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox reviewer_idTextBox;
        private System.Windows.Forms.TextBox release_idTextBox;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}