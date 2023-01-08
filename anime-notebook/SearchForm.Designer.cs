namespace anime_notebook
{
    partial class SearchForm
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
            this.comboBox_Producer = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anime_notebook_dbDataSet = new anime_notebook.anime_notebook_dbDataSet();
            this.dateTimePicker_AnnounceDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Series_from = new System.Windows.Forms.NumericUpDown();
            this.richTextBox_Annotation = new System.Windows.Forms.RichTextBox();
            this.textBox_Origin = new System.Windows.Forms.TextBox();
            this.textBox_StreamingService = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_Series_to = new System.Windows.Forms.NumericUpDown();
            this.search_button = new System.Windows.Forms.Button();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Studio = new System.Windows.Forms.ComboBox();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.animeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animeTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.AnimeTableAdapter();
            this.animeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.ProducerTableAdapter();
            this.studioTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.StudioTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Producer
            // 
            this.comboBox_Producer.DataSource = this.producerBindingSource;
            this.comboBox_Producer.DisplayMember = "name";
            this.comboBox_Producer.FormattingEnabled = true;
            this.comboBox_Producer.Location = new System.Drawing.Point(150, 247);
            this.comboBox_Producer.Name = "comboBox_Producer";
            this.comboBox_Producer.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Producer.TabIndex = 38;
            this.comboBox_Producer.ValueMember = "producer_id";
            this.comboBox_Producer.TextChanged += new System.EventHandler(this.comboBox_Producer_TextChanged);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // anime_notebook_dbDataSet
            // 
            this.anime_notebook_dbDataSet.DataSetName = "anime_notebook_dbDataSet";
            this.anime_notebook_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker_AnnounceDate
            // 
            this.dateTimePicker_AnnounceDate.Location = new System.Drawing.Point(150, 127);
            this.dateTimePicker_AnnounceDate.Name = "dateTimePicker_AnnounceDate";
            this.dateTimePicker_AnnounceDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_AnnounceDate.TabIndex = 37;
            this.dateTimePicker_AnnounceDate.Value = new System.DateTime(1939, 1, 1, 0, 0, 0, 0);
            // 
            // numericUpDown_Series_from
            // 
            this.numericUpDown_Series_from.Location = new System.Drawing.Point(193, 67);
            this.numericUpDown_Series_from.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Series_from.Name = "numericUpDown_Series_from";
            this.numericUpDown_Series_from.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_Series_from.TabIndex = 36;
            this.numericUpDown_Series_from.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richTextBox_Annotation
            // 
            this.richTextBox_Annotation.Location = new System.Drawing.Point(457, 7);
            this.richTextBox_Annotation.Name = "richTextBox_Annotation";
            this.richTextBox_Annotation.Size = new System.Drawing.Size(315, 230);
            this.richTextBox_Annotation.TabIndex = 35;
            this.richTextBox_Annotation.Text = "";
            this.richTextBox_Annotation.TextChanged += new System.EventHandler(this.richTextBox_Annotation_TextChanged);
            // 
            // textBox_Origin
            // 
            this.textBox_Origin.Location = new System.Drawing.Point(150, 217);
            this.textBox_Origin.Name = "textBox_Origin";
            this.textBox_Origin.Size = new System.Drawing.Size(200, 20);
            this.textBox_Origin.TabIndex = 34;
            this.textBox_Origin.TextChanged += new System.EventHandler(this.textBox_Origin_TextChanged);
            // 
            // textBox_StreamingService
            // 
            this.textBox_StreamingService.Location = new System.Drawing.Point(150, 187);
            this.textBox_StreamingService.Name = "textBox_StreamingService";
            this.textBox_StreamingService.Size = new System.Drawing.Size(200, 20);
            this.textBox_StreamingService.TabIndex = 33;
            this.textBox_StreamingService.TextChanged += new System.EventHandler(this.textBox_StreamingService_TextChanged);
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(150, 97);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(200, 20);
            this.textBox_Type.TabIndex = 32;
            this.textBox_Type.TextChanged += new System.EventHandler(this.textBox_Type_TextChanged);
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(150, 37);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(200, 20);
            this.textBox_Genre.TabIndex = 31;
            this.textBox_Genre.TextChanged += new System.EventHandler(this.textBox_Genre_TextChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(150, 7);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 30;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(10, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Producer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(10, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Stream. service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Announ. date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(368, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Annotation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Series";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(260, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "to";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(146, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "from";
            // 
            // numericUpDown_Series_to
            // 
            this.numericUpDown_Series_to.Location = new System.Drawing.Point(289, 67);
            this.numericUpDown_Series_to.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Series_to.Name = "numericUpDown_Series_to";
            this.numericUpDown_Series_to.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_Series_to.TabIndex = 41;
            this.numericUpDown_Series_to.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.search_button.Location = new System.Drawing.Point(697, 271);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 43;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(150, 153);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_to.TabIndex = 44;
            this.dateTimePicker_to.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            // 
            // comboBox_Studio
            // 
            this.comboBox_Studio.DataSource = this.studioBindingSource;
            this.comboBox_Studio.DisplayMember = "name";
            this.comboBox_Studio.FormattingEnabled = true;
            this.comboBox_Studio.Location = new System.Drawing.Point(150, 274);
            this.comboBox_Studio.Name = "comboBox_Studio";
            this.comboBox_Studio.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Studio.TabIndex = 46;
            this.comboBox_Studio.ValueMember = "producer_id";
            this.comboBox_Studio.SelectedIndexChanged += new System.EventHandler(this.comboBox_Studio_SelectedIndexChanged);
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "Studio";
            this.studioBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(10, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Studio";
            // 
            // animeBindingSource
            // 
            this.animeBindingSource.DataMember = "Anime";
            this.animeBindingSource.DataSource = this.anime_notebook_dbDataSet;
            // 
            // animeTableAdapter
            // 
            this.animeTableAdapter.ClearBeforeFill = true;
            // 
            // animeBindingSource1
            // 
            this.animeBindingSource1.DataMember = "Anime";
            this.animeBindingSource1.DataSource = this.anime_notebook_dbDataSet;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // studioTableAdapter
            // 
            this.studioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 137);
            this.dataGridView1.TabIndex = 47;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 462);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(759, 96);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Studio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.numericUpDown_Series_to);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_Producer);
            this.Controls.Add(this.dateTimePicker_AnnounceDate);
            this.Controls.Add(this.numericUpDown_Series_from);
            this.Controls.Add(this.richTextBox_Annotation);
            this.Controls.Add(this.textBox_Origin);
            this.Controls.Add(this.textBox_StreamingService);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Producer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AnnounceDate;
        private System.Windows.Forms.NumericUpDown numericUpDown_Series_from;
        private System.Windows.Forms.RichTextBox richTextBox_Annotation;
        private System.Windows.Forms.TextBox textBox_Origin;
        private System.Windows.Forms.TextBox textBox_StreamingService;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_Series_to;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.ComboBox comboBox_Studio;
        private System.Windows.Forms.Label label13;
        private anime_notebook_dbDataSet anime_notebook_dbDataSet;
        private System.Windows.Forms.BindingSource animeBindingSource;
        private anime_notebook_dbDataSetTableAdapters.AnimeTableAdapter animeTableAdapter;
        private System.Windows.Forms.BindingSource animeBindingSource1;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private anime_notebook_dbDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private anime_notebook_dbDataSetTableAdapters.StudioTableAdapter studioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}