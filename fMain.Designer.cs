
namespace Accounting_for_student_progress
{
    partial class fMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentRecordBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudyGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentPerformanceDataSet = new Accounting_for_student_progress.StudentPerformanceDataSet();
            this.lGeneral = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bdlabel1 = new System.Windows.Forms.Label();
            this.bdlabel2 = new System.Windows.Forms.Label();
            this.bdlabel3 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.bdlabel4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bdlabel5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicPerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddAcadPerf = new System.Windows.Forms.Button();
            this.btnEditAcadPerf = new System.Windows.Forms.Button();
            this.btnDeleteAcadPerf = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовПоГруппамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьОднойГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lSearch = new System.Windows.Forms.Label();
            this.rbFIO = new System.Windows.Forms.RadioButton();
            this.rbGroup = new System.Windows.Forms.RadioButton();
            this.rbSpecialty = new System.Windows.Forms.RadioButton();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studyGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentUspevaemostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.StudentTableAdapter();
            this.studyGroupTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.StudyGroupTableAdapter();
            this.academicPerformanceTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.AcademicPerformanceTableAdapter();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.SpecialtyTableAdapter();
            this.prepodavatelTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.PrepodavatelTableAdapter();
            this.disciplineTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.DisciplineTableAdapter();
            this.formsControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formsControlTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.FormsControlTableAdapter();
            this.idDisciplineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDiscipline = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Lectures = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Practice = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LaboratoryWork = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateDiscipline = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.assessmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicPerformanceBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentUspevaemostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lGeneral, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearch, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 5, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.studentRecordBookDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.idStudyGroupDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 3);
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(224, 464);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО студента";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 150;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentRecordBookDataGridViewTextBoxColumn
            // 
            this.studentRecordBookDataGridViewTextBoxColumn.DataPropertyName = "StudentRecordBook";
            this.studentRecordBookDataGridViewTextBoxColumn.HeaderText = "StudentRecordBook";
            this.studentRecordBookDataGridViewTextBoxColumn.Name = "studentRecordBookDataGridViewTextBoxColumn";
            this.studentRecordBookDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentRecordBookDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Visible = false;
            // 
            // idStudyGroupDataGridViewTextBoxColumn
            // 
            this.idStudyGroupDataGridViewTextBoxColumn.DataPropertyName = "IdStudyGroup";
            this.idStudyGroupDataGridViewTextBoxColumn.HeaderText = "IdStudyGroup";
            this.idStudyGroupDataGridViewTextBoxColumn.Name = "idStudyGroupDataGridViewTextBoxColumn";
            this.idStudyGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudyGroupDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.bindingSource1;
            this.studentBindingSource.Filter = "";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.studentPerformanceDataSet;
            this.bindingSource1.Position = 0;
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "StudentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lGeneral
            // 
            this.lGeneral.AutoSize = true;
            this.lGeneral.Location = new System.Drawing.Point(253, 34);
            this.lGeneral.Name = "lGeneral";
            this.lGeneral.Size = new System.Drawing.Size(35, 13);
            this.lGeneral.TabIndex = 1;
            this.lGeneral.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(253, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 432);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.bdlabel1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bdlabel2, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.bdlabel3, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnAddStudent, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 336);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студенческий номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // bdlabel1
            // 
            this.bdlabel1.AutoSize = true;
            this.bdlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bdlabel1.Location = new System.Drawing.Point(245, 10);
            this.bdlabel1.Name = "bdlabel1";
            this.bdlabel1.Size = new System.Drawing.Size(35, 13);
            this.bdlabel1.TabIndex = 3;
            this.bdlabel1.Text = "label4";
            // 
            // bdlabel2
            // 
            this.bdlabel2.AutoSize = true;
            this.bdlabel2.Location = new System.Drawing.Point(245, 91);
            this.bdlabel2.Name = "bdlabel2";
            this.bdlabel2.Size = new System.Drawing.Size(35, 13);
            this.bdlabel2.TabIndex = 4;
            this.bdlabel2.Text = "label5";
            // 
            // bdlabel3
            // 
            this.bdlabel3.AutoSize = true;
            this.bdlabel3.Location = new System.Drawing.Point(245, 172);
            this.bdlabel3.Name = "bdlabel3";
            this.bdlabel3.Size = new System.Drawing.Size(35, 13);
            this.bdlabel3.TabIndex = 5;
            this.bdlabel3.Text = "label6";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudent.Location = new System.Drawing.Point(83, 277);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnEditStudent, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteStudent, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(242, 253);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(444, 71);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditStudent.Location = new System.Drawing.Point(71, 24);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 0;
            this.btnEditStudent.Text = "Изменить";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteStudent.Location = new System.Drawing.Point(298, 24);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Удалить";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Группа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.bdlabel4, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.bdlabel5, 3, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(698, 336);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(242, 253);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(444, 71);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Группа";
            // 
            // bdlabel4
            // 
            this.bdlabel4.AutoSize = true;
            this.bdlabel4.Location = new System.Drawing.Point(245, 10);
            this.bdlabel4.Name = "bdlabel4";
            this.bdlabel4.Size = new System.Drawing.Size(35, 13);
            this.bdlabel4.TabIndex = 2;
            this.bdlabel4.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Специальность";
            // 
            // bdlabel5
            // 
            this.bdlabel5.AutoSize = true;
            this.bdlabel5.Location = new System.Drawing.Point(245, 91);
            this.bdlabel5.Name = "bdlabel5";
            this.bdlabel5.Size = new System.Drawing.Size(35, 13);
            this.bdlabel5.TabIndex = 4;
            this.bdlabel5.Text = "label6";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(634, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Успеваемость";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnAddAcadPerf, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnEditAcadPerf, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnDeleteAcadPerf, 2, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(628, 400);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDisciplineDataGridViewTextBoxColumn1,
            this.idStudentDataGridViewTextBoxColumn1,
            this.NameDiscipline,
            this.Lectures,
            this.Practice,
            this.LaboratoryWork,
            this.Semester,
            this.DateDiscipline,
            this.assessmentDataGridViewTextBoxColumn});
            this.tableLayoutPanel7.SetColumnSpan(this.dataGridView2, 3);
            this.dataGridView2.DataSource = this.academicPerformanceBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(628, 320);
            this.dataGridView2.TabIndex = 0;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.studentPerformanceDataSet;
            this.disciplineBindingSource.Filter = "";
            // 
            // academicPerformanceBindingSource
            // 
            this.academicPerformanceBindingSource.DataMember = "AcademicPerformance";
            this.academicPerformanceBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // btnAddAcadPerf
            // 
            this.btnAddAcadPerf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddAcadPerf.Location = new System.Drawing.Point(67, 348);
            this.btnAddAcadPerf.Name = "btnAddAcadPerf";
            this.btnAddAcadPerf.Size = new System.Drawing.Size(75, 23);
            this.btnAddAcadPerf.TabIndex = 1;
            this.btnAddAcadPerf.Text = "Добавить";
            this.btnAddAcadPerf.UseVisualStyleBackColor = true;
            this.btnAddAcadPerf.Click += new System.EventHandler(this.btnAddAcadPerf_Click);
            // 
            // btnEditAcadPerf
            // 
            this.btnEditAcadPerf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditAcadPerf.Location = new System.Drawing.Point(276, 348);
            this.btnEditAcadPerf.Name = "btnEditAcadPerf";
            this.btnEditAcadPerf.Size = new System.Drawing.Size(75, 23);
            this.btnEditAcadPerf.TabIndex = 2;
            this.btnEditAcadPerf.Text = "Изменить";
            this.btnEditAcadPerf.UseVisualStyleBackColor = true;
            this.btnEditAcadPerf.Click += new System.EventHandler(this.btnEditAcadPerf_Click);
            // 
            // btnDeleteAcadPerf
            // 
            this.btnDeleteAcadPerf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAcadPerf.Location = new System.Drawing.Point(485, 348);
            this.btnDeleteAcadPerf.Name = "btnDeleteAcadPerf";
            this.btnDeleteAcadPerf.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAcadPerf.TabIndex = 3;
            this.btnDeleteAcadPerf.Text = "Удалить";
            this.btnDeleteAcadPerf.UseVisualStyleBackColor = true;
            this.btnDeleteAcadPerf.Click += new System.EventHandler(this.btnDeleteAcadPerf_Click);
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 7);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группыToolStripMenuItem,
            this.специальностиToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.дисциплиныToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // группыToolStripMenuItem
            // 
            this.группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            this.группыToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.группыToolStripMenuItem.Text = "Группы";
            this.группыToolStripMenuItem.Click += new System.EventHandler(this.группыToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСтудентовПоГруппамToolStripMenuItem,
            this.успеваемостьОднойГруппыToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // списокСтудентовПоГруппамToolStripMenuItem
            // 
            this.списокСтудентовПоГруппамToolStripMenuItem.Name = "списокСтудентовПоГруппамToolStripMenuItem";
            this.списокСтудентовПоГруппамToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.списокСтудентовПоГруппамToolStripMenuItem.Text = "Список студентов по группам";
            this.списокСтудентовПоГруппамToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовПоГруппамToolStripMenuItem_Click);
            // 
            // успеваемостьОднойГруппыToolStripMenuItem
            // 
            this.успеваемостьОднойГруппыToolStripMenuItem.Name = "успеваемостьОднойГруппыToolStripMenuItem";
            this.успеваемостьОднойГруппыToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.успеваемостьОднойГруппыToolStripMenuItem.Text = "Успеваемость одной группы";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(908, 34);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(190, 20);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.lSearch, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rbFIO, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.rbGroup, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.rbSpecialty, 0, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(908, 66);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33445F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33443F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(190, 438);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSearch.Location = new System.Drawing.Point(3, 0);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(184, 14);
            this.lSearch.TabIndex = 0;
            this.lSearch.Text = "Поиск";
            // 
            // rbFIO
            // 
            this.rbFIO.AutoSize = true;
            this.rbFIO.Checked = true;
            this.rbFIO.Location = new System.Drawing.Point(3, 27);
            this.rbFIO.Name = "rbFIO";
            this.rbFIO.Size = new System.Drawing.Size(67, 17);
            this.rbFIO.TabIndex = 2;
            this.rbFIO.TabStop = true;
            this.rbFIO.Text = "по ФИО";
            this.rbFIO.UseVisualStyleBackColor = true;
            this.rbFIO.CheckedChanged += new System.EventHandler(this.rbFIO_CheckedChanged);
            // 
            // rbGroup
            // 
            this.rbGroup.AutoSize = true;
            this.rbGroup.Location = new System.Drawing.Point(3, 165);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(74, 17);
            this.rbGroup.TabIndex = 3;
            this.rbGroup.Text = "по группе";
            this.rbGroup.UseVisualStyleBackColor = true;
            this.rbGroup.CheckedChanged += new System.EventHandler(this.rbGroup_CheckedChanged);
            // 
            // rbSpecialty
            // 
            this.rbSpecialty.AutoSize = true;
            this.rbSpecialty.Location = new System.Drawing.Point(3, 302);
            this.rbSpecialty.Name = "rbSpecialty";
            this.rbSpecialty.Size = new System.Drawing.Size(117, 17);
            this.rbSpecialty.TabIndex = 4;
            this.rbSpecialty.Text = "по специальности";
            this.rbSpecialty.UseVisualStyleBackColor = true;
            this.rbSpecialty.CheckedChanged += new System.EventHandler(this.rbSpecialty_CheckedChanged);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.studyGroupBindingSource;
            // 
            // studyGroupBindingSource
            // 
            this.studyGroupBindingSource.DataMember = "StudyGroup";
            this.studyGroupBindingSource.DataSource = this.bindingSource1;
            // 
            // studentUspevaemostBindingSource
            // 
            this.studentUspevaemostBindingSource.DataMember = "StudentUspevaemost";
            this.studentUspevaemostBindingSource.DataSource = this.studentBindingSource;
            // 
            // prepodavatelBindingSource
            // 
            this.prepodavatelBindingSource.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studyGroupTableAdapter
            // 
            this.studyGroupTableAdapter.ClearBeforeFill = true;
            // 
            // academicPerformanceTableAdapter
            // 
            this.academicPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "Specialty";
            this.specialtyBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // prepodavatelTableAdapter
            // 
            this.prepodavatelTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // formsControlBindingSource
            // 
            this.formsControlBindingSource.DataMember = "FormsControl";
            this.formsControlBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // formsControlTableAdapter
            // 
            this.formsControlTableAdapter.ClearBeforeFill = true;
            // 
            // idDisciplineDataGridViewTextBoxColumn1
            // 
            this.idDisciplineDataGridViewTextBoxColumn1.DataPropertyName = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn1.HeaderText = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn1.Name = "idDisciplineDataGridViewTextBoxColumn1";
            this.idDisciplineDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDisciplineDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idStudentDataGridViewTextBoxColumn1
            // 
            this.idStudentDataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn1.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn1.Name = "idStudentDataGridViewTextBoxColumn1";
            this.idStudentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // NameDiscipline
            // 
            this.NameDiscipline.DataPropertyName = "IdDiscipline";
            this.NameDiscipline.DataSource = this.disciplineBindingSource;
            this.NameDiscipline.DisplayMember = "NameDiscipline";
            this.NameDiscipline.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.NameDiscipline.HeaderText = "Название дисциплины";
            this.NameDiscipline.Name = "NameDiscipline";
            this.NameDiscipline.ReadOnly = true;
            this.NameDiscipline.ValueMember = "IdDiscipline";
            this.NameDiscipline.Width = 150;
            // 
            // Lectures
            // 
            this.Lectures.DataPropertyName = "IdDiscipline";
            this.Lectures.DataSource = this.disciplineBindingSource;
            this.Lectures.DisplayMember = "Lectures";
            this.Lectures.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Lectures.HeaderText = "Часы лекций";
            this.Lectures.Name = "Lectures";
            this.Lectures.ReadOnly = true;
            this.Lectures.ValueMember = "IdDiscipline";
            this.Lectures.Width = 50;
            // 
            // Practice
            // 
            this.Practice.DataPropertyName = "IdDiscipline";
            this.Practice.DataSource = this.disciplineBindingSource;
            this.Practice.DisplayMember = "Practice";
            this.Practice.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Practice.HeaderText = "Часы практики";
            this.Practice.Name = "Practice";
            this.Practice.ReadOnly = true;
            this.Practice.ValueMember = "IdDiscipline";
            this.Practice.Width = 70;
            // 
            // LaboratoryWork
            // 
            this.LaboratoryWork.DataPropertyName = "IdDiscipline";
            this.LaboratoryWork.DataSource = this.disciplineBindingSource;
            this.LaboratoryWork.DisplayMember = "LaboratoryWork";
            this.LaboratoryWork.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.LaboratoryWork.HeaderText = "Часы лабораторных работ";
            this.LaboratoryWork.Name = "LaboratoryWork";
            this.LaboratoryWork.ReadOnly = true;
            this.LaboratoryWork.ValueMember = "IdDiscipline";
            this.LaboratoryWork.Width = 80;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "IdDiscipline";
            this.Semester.DataSource = this.disciplineBindingSource;
            this.Semester.DisplayMember = "Semester";
            this.Semester.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Semester.HeaderText = "Семестр";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.ValueMember = "IdDiscipline";
            this.Semester.Width = 65;
            // 
            // DateDiscipline
            // 
            this.DateDiscipline.DataPropertyName = "IdDiscipline";
            this.DateDiscipline.DataSource = this.disciplineBindingSource;
            this.DateDiscipline.DisplayMember = "DateDiscipline";
            this.DateDiscipline.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DateDiscipline.HeaderText = "Дата сдачи";
            this.DateDiscipline.Name = "DateDiscipline";
            this.DateDiscipline.ReadOnly = true;
            this.DateDiscipline.ValueMember = "IdDiscipline";
            this.DateDiscipline.Width = 70;
            // 
            // assessmentDataGridViewTextBoxColumn
            // 
            this.assessmentDataGridViewTextBoxColumn.DataPropertyName = "Assessment";
            this.assessmentDataGridViewTextBoxColumn.HeaderText = "Оценка/зачёт";
            this.assessmentDataGridViewTextBoxColumn.Name = "assessmentDataGridViewTextBoxColumn";
            this.assessmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Успеваемость студентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicPerformanceBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentUspevaemostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formsControlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private StudentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentPerformanceDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label lGeneral;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bdlabel1;
        private System.Windows.Forms.Label bdlabel2;
        private System.Windows.Forms.Label bdlabel3;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bdlabel4;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource studyGroupBindingSource;
        private StudentPerformanceDataSetTableAdapters.StudyGroupTableAdapter studyGroupTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bdlabel5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.RadioButton rbFIO;
        private System.Windows.Forms.RadioButton rbGroup;
        private System.Windows.Forms.RadioButton rbSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentUspevaemostBindingSource;
        private StudentPerformanceDataSetTableAdapters.AcademicPerformanceTableAdapter academicPerformanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRecordBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudyGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem группыToolStripMenuItem;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private StudentPerformanceDataSetTableAdapters.SpecialtyTableAdapter specialtyTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовПоГруппамToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource academicPerformanceBindingSource;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource;
        private StudentPerformanceDataSetTableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private StudentPerformanceDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnAddAcadPerf;
        private System.Windows.Forms.Button btnEditAcadPerf;
        private System.Windows.Forms.Button btnDeleteAcadPerf;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьОднойГруппыToolStripMenuItem;
        private System.Windows.Forms.BindingSource formsControlBindingSource;
        private StudentPerformanceDataSetTableAdapters.FormsControlTableAdapter formsControlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn NameDiscipline;
        private System.Windows.Forms.DataGridViewComboBoxColumn Lectures;
        private System.Windows.Forms.DataGridViewComboBoxColumn Practice;
        private System.Windows.Forms.DataGridViewComboBoxColumn LaboratoryWork;
        private System.Windows.Forms.DataGridViewComboBoxColumn Semester;
        private System.Windows.Forms.DataGridViewComboBoxColumn DateDiscipline;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentDataGridViewTextBoxColumn;
    }
}

