namespace _19._02_visual_app
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this._19_02DataSet = new _19._02_visual_app._19_02DataSet();
            this.учёныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учёныеTableAdapter = new _19._02_visual_app._19_02DataSetTableAdapters.учёныеTableAdapter();
            this.idУчёныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учёнаястепеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idОрганизацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idКонференцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idДокладDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конференцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.конференцииTableAdapter = new _19._02_visual_app._19_02DataSetTableAdapters.конференцииTableAdapter();
            this.idКонференцииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местопроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idДокладDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организацияTableAdapter = new _19._02_visual_app._19_02DataSetTableAdapters.организацияTableAdapter();
            this.idОрганизацияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.докладBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.докладTableAdapter = new _19._02_visual_app._19_02DataSetTableAdapters.ДокладTableAdapter();
            this.idДокладDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типучастияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темадокладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.публикацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19_02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.конференцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.докладBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idУчёныеDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.учёнаястепеньDataGridViewTextBoxColumn,
            this.idОрганизацияDataGridViewTextBoxColumn,
            this.idКонференцииDataGridViewTextBoxColumn,
            this.idДокладDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учёныеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idОрганизацияDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn1,
            this.адресDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.организацияBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(463, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 178);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idКонференцииDataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.местопроведенияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.idДокладDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.конференцииBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(13, 364);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(545, 184);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idДокладDataGridViewTextBoxColumn2,
            this.типучастияDataGridViewTextBoxColumn,
            this.темадокладаDataGridViewTextBoxColumn,
            this.публикацияDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.докладBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(13, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(444, 178);
            this.dataGridView4.TabIndex = 3;
            // 
            // _19_02DataSet
            // 
            this._19_02DataSet.DataSetName = "_19_02DataSet";
            this._19_02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учёныеBindingSource
            // 
            this.учёныеBindingSource.DataMember = "учёные";
            this.учёныеBindingSource.DataSource = this._19_02DataSet;
            // 
            // учёныеTableAdapter
            // 
            this.учёныеTableAdapter.ClearBeforeFill = true;
            // 
            // idУчёныеDataGridViewTextBoxColumn
            // 
            this.idУчёныеDataGridViewTextBoxColumn.DataPropertyName = "idУчёные";
            this.idУчёныеDataGridViewTextBoxColumn.HeaderText = "idУчёные";
            this.idУчёныеDataGridViewTextBoxColumn.Name = "idУчёныеDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // учёнаястепеньDataGridViewTextBoxColumn
            // 
            this.учёнаястепеньDataGridViewTextBoxColumn.DataPropertyName = "Учёная_степень";
            this.учёнаястепеньDataGridViewTextBoxColumn.HeaderText = "Учёная_степень";
            this.учёнаястепеньDataGridViewTextBoxColumn.Name = "учёнаястепеньDataGridViewTextBoxColumn";
            // 
            // idОрганизацияDataGridViewTextBoxColumn
            // 
            this.idОрганизацияDataGridViewTextBoxColumn.DataPropertyName = "idОрганизация";
            this.idОрганизацияDataGridViewTextBoxColumn.HeaderText = "idОрганизация";
            this.idОрганизацияDataGridViewTextBoxColumn.Name = "idОрганизацияDataGridViewTextBoxColumn";
            // 
            // idКонференцииDataGridViewTextBoxColumn
            // 
            this.idКонференцииDataGridViewTextBoxColumn.DataPropertyName = "idКонференции";
            this.idКонференцииDataGridViewTextBoxColumn.HeaderText = "idКонференции";
            this.idКонференцииDataGridViewTextBoxColumn.Name = "idКонференцииDataGridViewTextBoxColumn";
            // 
            // idДокладDataGridViewTextBoxColumn
            // 
            this.idДокладDataGridViewTextBoxColumn.DataPropertyName = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn.HeaderText = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn.Name = "idДокладDataGridViewTextBoxColumn";
            // 
            // конференцииBindingSource
            // 
            this.конференцииBindingSource.DataMember = "конференции";
            this.конференцииBindingSource.DataSource = this._19_02DataSet;
            // 
            // конференцииTableAdapter
            // 
            this.конференцииTableAdapter.ClearBeforeFill = true;
            // 
            // idКонференцииDataGridViewTextBoxColumn1
            // 
            this.idКонференцииDataGridViewTextBoxColumn1.DataPropertyName = "idКонференции";
            this.idКонференцииDataGridViewTextBoxColumn1.HeaderText = "idКонференции";
            this.idКонференцииDataGridViewTextBoxColumn1.Name = "idКонференцииDataGridViewTextBoxColumn1";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // местопроведенияDataGridViewTextBoxColumn
            // 
            this.местопроведенияDataGridViewTextBoxColumn.DataPropertyName = "Место_проведения";
            this.местопроведенияDataGridViewTextBoxColumn.HeaderText = "Место_проведения";
            this.местопроведенияDataGridViewTextBoxColumn.Name = "местопроведенияDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // idДокладDataGridViewTextBoxColumn1
            // 
            this.idДокладDataGridViewTextBoxColumn1.DataPropertyName = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn1.HeaderText = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn1.Name = "idДокладDataGridViewTextBoxColumn1";
            // 
            // организацияBindingSource
            // 
            this.организацияBindingSource.DataMember = "организация";
            this.организацияBindingSource.DataSource = this._19_02DataSet;
            // 
            // организацияTableAdapter
            // 
            this.организацияTableAdapter.ClearBeforeFill = true;
            // 
            // idОрганизацияDataGridViewTextBoxColumn1
            // 
            this.idОрганизацияDataGridViewTextBoxColumn1.DataPropertyName = "idОрганизация";
            this.idОрганизацияDataGridViewTextBoxColumn1.HeaderText = "idОрганизация";
            this.idОрганизацияDataGridViewTextBoxColumn1.Name = "idОрганизацияDataGridViewTextBoxColumn1";
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // докладBindingSource
            // 
            this.докладBindingSource.DataMember = "Доклад";
            this.докладBindingSource.DataSource = this._19_02DataSet;
            // 
            // докладTableAdapter
            // 
            this.докладTableAdapter.ClearBeforeFill = true;
            // 
            // idДокладDataGridViewTextBoxColumn2
            // 
            this.idДокладDataGridViewTextBoxColumn2.DataPropertyName = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn2.HeaderText = "idДоклад";
            this.idДокладDataGridViewTextBoxColumn2.Name = "idДокладDataGridViewTextBoxColumn2";
            // 
            // типучастияDataGridViewTextBoxColumn
            // 
            this.типучастияDataGridViewTextBoxColumn.DataPropertyName = "Тип_участия";
            this.типучастияDataGridViewTextBoxColumn.HeaderText = "Тип_участия";
            this.типучастияDataGridViewTextBoxColumn.Name = "типучастияDataGridViewTextBoxColumn";
            // 
            // темадокладаDataGridViewTextBoxColumn
            // 
            this.темадокладаDataGridViewTextBoxColumn.DataPropertyName = "Тема_доклада";
            this.темадокладаDataGridViewTextBoxColumn.HeaderText = "Тема_доклада";
            this.темадокладаDataGridViewTextBoxColumn.Name = "темадокладаDataGridViewTextBoxColumn";
            // 
            // публикацияDataGridViewTextBoxColumn
            // 
            this.публикацияDataGridViewTextBoxColumn.DataPropertyName = "Публикация";
            this.публикацияDataGridViewTextBoxColumn.HeaderText = "Публикация";
            this.публикацияDataGridViewTextBoxColumn.Name = "публикацияDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Перейти к запросам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Выйти из приложения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Научные конференции";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19_02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.конференцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.докладBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private _19_02DataSet _19_02DataSet;
        private System.Windows.Forms.BindingSource учёныеBindingSource;
        private _19_02DataSetTableAdapters.учёныеTableAdapter учёныеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idУчёныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учёнаястепеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idОрганизацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКонференцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДокладDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource конференцииBindingSource;
        private _19_02DataSetTableAdapters.конференцииTableAdapter конференцииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idКонференцииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местопроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДокладDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource организацияBindingSource;
        private _19_02DataSetTableAdapters.организацияTableAdapter организацияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idОрганизацияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource докладBindingSource;
        private _19_02DataSetTableAdapters.ДокладTableAdapter докладTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idДокладDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn типучастияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темадокладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn публикацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

