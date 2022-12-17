namespace anime_notebook
{
    partial class AddStudio
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label placeLabel;
            this.anime_notebook_dbDataSet = new anime_notebook.anime_notebook_dbDataSet();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studioTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.StudioTableAdapter();
            this.tableAdapterManager = new anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            placeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // anime_notebook_dbDataSet
            // 
            this.anime_notebook_dbDataSet.DataSetName = "anime_notebook_dbDataSet";
            this.anime_notebook_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "Studio";
            this.studioBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // studioTableAdapter
            // 
            this.studioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProducerTableAdapter = null;
            this.tableAdapterManager.ReleaseTableAdapter = null;
            this.tableAdapterManager.ReviewerTableAdapter = null;
            this.tableAdapterManager.ReviewTableAdapter = null;
            this.tableAdapterManager.StudioTableAdapter = this.studioTableAdapter;
            this.tableAdapterManager.UpdateOrder = anime_notebook.anime_notebook_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studioBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(67, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.Location = new System.Drawing.Point(12, 35);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(36, 13);
            placeLabel.TabIndex = 5;
            placeLabel.Text = "place:";
            // 
            // placeTextBox
            // 
            this.placeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studioBindingSource, "place", true));
            this.placeTextBox.Location = new System.Drawing.Point(67, 32);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(165, 20);
            this.placeTextBox.TabIndex = 6;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(12, 58);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(157, 58);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AddStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 95);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.placeTextBox);
            this.Name = "AddStudio";
            this.Text = "AddStudio";
            this.Load += new System.EventHandler(this.AddStudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private anime_notebook_dbDataSet anime_notebook_dbDataSet;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private anime_notebook_dbDataSetTableAdapters.StudioTableAdapter studioTableAdapter;
        private anime_notebook_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
    }
}