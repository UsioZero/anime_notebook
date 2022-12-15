namespace anime_notebook
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.textBox_StreamingService = new System.Windows.Forms.TextBox();
            this.textBox_Origin = new System.Windows.Forms.TextBox();
            this.richTextBox_Annotation = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_Series = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_AnnounceDate = new System.Windows.Forms.DateTimePicker();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Producer = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.anime_notebook_dbDataSet = new anime_notebook.anime_notebook_dbDataSet();
            this.producerTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.ProducerTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.animeTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.AnimeTableAdapter();
            this.comboBox_studio = new System.Windows.Forms.ComboBox();
            this.studioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.studioTableAdapter = new anime_notebook.anime_notebook_dbDataSetTableAdapters.StudioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Series";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(370, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Annotation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Announ. date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stream. service";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Origin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Producer";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(152, 9);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 9;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(152, 39);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(200, 20);
            this.textBox_Genre.TabIndex = 10;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(152, 99);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(200, 20);
            this.textBox_Type.TabIndex = 11;
            // 
            // textBox_StreamingService
            // 
            this.textBox_StreamingService.Location = new System.Drawing.Point(152, 159);
            this.textBox_StreamingService.Name = "textBox_StreamingService";
            this.textBox_StreamingService.Size = new System.Drawing.Size(200, 20);
            this.textBox_StreamingService.TabIndex = 12;
            // 
            // textBox_Origin
            // 
            this.textBox_Origin.Location = new System.Drawing.Point(152, 189);
            this.textBox_Origin.Name = "textBox_Origin";
            this.textBox_Origin.Size = new System.Drawing.Size(200, 20);
            this.textBox_Origin.TabIndex = 13;
            // 
            // richTextBox_Annotation
            // 
            this.richTextBox_Annotation.Location = new System.Drawing.Point(459, 9);
            this.richTextBox_Annotation.Name = "richTextBox_Annotation";
            this.richTextBox_Annotation.Size = new System.Drawing.Size(315, 230);
            this.richTextBox_Annotation.TabIndex = 14;
            this.richTextBox_Annotation.Text = "";
            // 
            // numericUpDown_Series
            // 
            this.numericUpDown_Series.Location = new System.Drawing.Point(152, 69);
            this.numericUpDown_Series.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Series.Name = "numericUpDown_Series";
            this.numericUpDown_Series.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Series.TabIndex = 15;
            // 
            // dateTimePicker_AnnounceDate
            // 
            this.dateTimePicker_AnnounceDate.Location = new System.Drawing.Point(152, 129);
            this.dateTimePicker_AnnounceDate.Name = "dateTimePicker_AnnounceDate";
            this.dateTimePicker_AnnounceDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_AnnounceDate.TabIndex = 17;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(16, 327);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(336, 23);
            this.button_Ok.TabIndex = 18;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(438, 327);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(336, 23);
            this.button_Cancel.TabIndex = 19;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Producer
            // 
            this.comboBox_Producer.DataSource = this.producerBindingSource;
            this.comboBox_Producer.DisplayMember = "producer_id";
            this.comboBox_Producer.FormattingEnabled = true;
            this.comboBox_Producer.Location = new System.Drawing.Point(152, 219);
            this.comboBox_Producer.Name = "comboBox_Producer";
            this.comboBox_Producer.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Producer.TabIndex = 20;
            this.comboBox_Producer.ValueMember = "producer_id";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.anime_notebook_dbDataSet;
            this.bindingSource1.Position = 0;
            // 
            // anime_notebook_dbDataSet
            // 
            this.anime_notebook_dbDataSet.DataSetName = "anime_notebook_dbDataSet";
            this.anime_notebook_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Anime";
            this.bindingSource2.DataSource = this.anime_notebook_dbDataSet;
            // 
            // animeTableAdapter
            // 
            this.animeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_studio
            // 
            this.comboBox_studio.DataSource = this.studioBindingSource;
            this.comboBox_studio.DisplayMember = "studio_id";
            this.comboBox_studio.FormattingEnabled = true;
            this.comboBox_studio.Location = new System.Drawing.Point(152, 246);
            this.comboBox_studio.Name = "comboBox_studio";
            this.comboBox_studio.Size = new System.Drawing.Size(200, 21);
            this.comboBox_studio.TabIndex = 22;
            this.comboBox_studio.ValueMember = "producer_id";
            // 
            // studioBindingSource
            // 
            this.studioBindingSource.DataMember = "Studio";
            this.studioBindingSource.DataSource = this.bindingSource1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Studio";
            // 
            // studioTableAdapter
            // 
            this.studioTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.comboBox_studio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_Producer);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.dateTimePicker_AnnounceDate);
            this.Controls.Add(this.numericUpDown_Series);
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
            this.Name = "EditForm";
            this.Text = "Add Or Erdit";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anime_notebook_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_StreamingService;
        private System.Windows.Forms.TextBox textBox_Origin;
        private System.Windows.Forms.RichTextBox richTextBox_Annotation;
        private System.Windows.Forms.NumericUpDown numericUpDown_Series;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AnnounceDate;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Producer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private anime_notebook_dbDataSet anime_notebook_dbDataSet;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private anime_notebook_dbDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private anime_notebook_dbDataSetTableAdapters.AnimeTableAdapter animeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_studio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource studioBindingSource;
        private anime_notebook_dbDataSetTableAdapters.StudioTableAdapter studioTableAdapter;
    }
}