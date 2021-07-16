
namespace Accounting_for_student_progress
{
    partial class fSprDiscipline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSprDiscipline));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentPerformanceDataSet = new Accounting_for_student_progress.StudentPerformanceDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disciplineTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.DisciplineTableAdapter();
            this.formsControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formsControlTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.FormsControlTableAdapter();
            this.prepodavatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavatelTableAdapter = new Accounting_for_student_progress.StudentPerformanceDataSetTableAdapters.PrepodavatelTableAdapter();
            this.idDisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.practiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratoryWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTeacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdForm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DateDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formsControlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDisciplineDataGridViewTextBoxColumn,
            this.nameDisciplineDataGridViewTextBoxColumn,
            this.lecturesDataGridViewTextBoxColumn,
            this.practiceDataGridViewTextBoxColumn,
            this.laboratoryWorkDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.IdTeacher,
            this.IdForm,
            this.DateDiscipline});
            this.dataGridView1.DataSource = this.disciplineBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(720, 425);
            this.dataGridView1.TabIndex = 8;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.studentPerformanceDataSet;
            this.disciplineBindingSource.Sort = "NameDiscipline ASC";
            // 
            // studentPerformanceDataSet
            // 
            this.studentPerformanceDataSet.DataSetName = "StudentPerformanceDataSet";
            this.studentPerformanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.disciplineBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 425);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(720, 25);
            this.bindingNavigator1.TabIndex = 7;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // prepodavatelBindingSource
            // 
            this.prepodavatelBindingSource.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource.DataSource = this.studentPerformanceDataSet;
            // 
            // prepodavatelTableAdapter
            // 
            this.prepodavatelTableAdapter.ClearBeforeFill = true;
            // 
            // idDisciplineDataGridViewTextBoxColumn
            // 
            this.idDisciplineDataGridViewTextBoxColumn.DataPropertyName = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn.HeaderText = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn.Name = "idDisciplineDataGridViewTextBoxColumn";
            this.idDisciplineDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDisciplineDataGridViewTextBoxColumn
            // 
            this.nameDisciplineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDisciplineDataGridViewTextBoxColumn.DataPropertyName = "NameDiscipline";
            this.nameDisciplineDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.nameDisciplineDataGridViewTextBoxColumn.Name = "nameDisciplineDataGridViewTextBoxColumn";
            this.nameDisciplineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lecturesDataGridViewTextBoxColumn
            // 
            this.lecturesDataGridViewTextBoxColumn.DataPropertyName = "Lectures";
            this.lecturesDataGridViewTextBoxColumn.HeaderText = "Часы лекций";
            this.lecturesDataGridViewTextBoxColumn.Name = "lecturesDataGridViewTextBoxColumn";
            this.lecturesDataGridViewTextBoxColumn.Width = 50;
            // 
            // practiceDataGridViewTextBoxColumn
            // 
            this.practiceDataGridViewTextBoxColumn.DataPropertyName = "Practice";
            this.practiceDataGridViewTextBoxColumn.HeaderText = "Часы практики";
            this.practiceDataGridViewTextBoxColumn.Name = "practiceDataGridViewTextBoxColumn";
            this.practiceDataGridViewTextBoxColumn.Width = 70;
            // 
            // laboratoryWorkDataGridViewTextBoxColumn
            // 
            this.laboratoryWorkDataGridViewTextBoxColumn.DataPropertyName = "LaboratoryWork";
            this.laboratoryWorkDataGridViewTextBoxColumn.HeaderText = "Часы лабораторных работ";
            this.laboratoryWorkDataGridViewTextBoxColumn.Name = "laboratoryWorkDataGridViewTextBoxColumn";
            this.laboratoryWorkDataGridViewTextBoxColumn.Width = 87;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 60;
            // 
            // IdTeacher
            // 
            this.IdTeacher.DataPropertyName = "IdTeacher";
            this.IdTeacher.DataSource = this.prepodavatelBindingSource;
            this.IdTeacher.DisplayMember = "FIO";
            this.IdTeacher.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdTeacher.HeaderText = "Преподаватель";
            this.IdTeacher.Name = "IdTeacher";
            this.IdTeacher.ValueMember = "IdTeacher";
            this.IdTeacher.Width = 130;
            // 
            // IdForm
            // 
            this.IdForm.DataPropertyName = "IdForm";
            this.IdForm.DataSource = this.formsControlBindingSource;
            this.IdForm.DisplayMember = "FormControl";
            this.IdForm.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdForm.HeaderText = "Форма контоля";
            this.IdForm.Name = "IdForm";
            this.IdForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdForm.ValueMember = "IdForm";
            this.IdForm.Width = 60;
            // 
            // DateDiscipline
            // 
            this.DateDiscipline.DataPropertyName = "DateDiscipline";
            this.DateDiscipline.HeaderText = "Дата сдачи";
            this.DateDiscipline.Name = "DateDiscipline";
            this.DateDiscipline.Width = 70;
            // 
            // fSprDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSprDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дисциплины";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fSprDiscipline_FormClosing);
            this.Load += new System.EventHandler(this.fSprDiscipline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPerformanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formsControlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private StudentPerformanceDataSet studentPerformanceDataSet;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private StudentPerformanceDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource formsControlBindingSource;
        private StudentPerformanceDataSetTableAdapters.FormsControlTableAdapter formsControlTableAdapter;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource;
        private StudentPerformanceDataSetTableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn practiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoryWorkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdTeacher;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDiscipline;
    }
}