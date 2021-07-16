using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;


namespace Accounting_for_student_progress
{
    public partial class fMain : Form
    {
        private readonly Info info;
        public fMain() {
            InitializeComponent();
            info = new Info(dataGridView1, dataGridView2, tbSearch);
        }

        private void Form1_Load(object sender, EventArgs e) {
            formsControlTableAdapter.Fill(this.studentPerformanceDataSet.FormsControl);
            studentTableAdapter.Fill(this.studentPerformanceDataSet.Student);
            studyGroupTableAdapter.Fill(this.studentPerformanceDataSet.StudyGroup);
            specialtyTableAdapter.Fill(this.studentPerformanceDataSet.Specialty);
            academicPerformanceTableAdapter.Fill(this.studentPerformanceDataSet.AcademicPerformance);
            prepodavatelTableAdapter.Fill(this.studentPerformanceDataSet.Prepodavatel);
            disciplineTableAdapter.Fill(this.studentPerformanceDataSet.Discipline);
            idDisciplineDataGridViewTextBoxColumn1.Visible = false;
            foreach (StudentPerformanceDataSet.StudyGroupRow studyGroup in studentPerformanceDataSet.StudyGroup.Rows) {
                ToolStripMenuItem toolStrip = new ToolStripMenuItem {
                    Name = studyGroup.NameStudyGroup,
                    Size = new Size(80, 20),
                    Text = studyGroup.NameStudyGroup,
                    Tag = studyGroup.IdStudyGroup
                };
                toolStrip.Click += new System.EventHandler(ToolStrip_Click);
                успеваемостьОднойГруппыToolStripMenuItem.DropDownItems.Add(toolStrip);
            }
            disciplineBindingSource.Filter = info.DisciplineFilter;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e) {
            lGeneral.Text = info.FIO;
            bdlabel1.Text = info.FIO;
            bdlabel2.Text = info.RecordBook != int.MinValue ? info.RecordBook.ToString() : "";
            bdlabel3.Text = info.Birthday != DateTime.MinValue ? info.Birthday.ToLongDateString() : "";
            bdlabel4.Text = info.Group;
            bdlabel5.Text = info.Specialty;
            academicPerformanceBindingSource.Filter = $"IdStudent = {info.IdStudent}";
            disciplineBindingSource.Filter = info.DisciplineFilter;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e) {
            if (tbSearch.Text != "") {
                if (rbFIO.Checked)
                    studentBindingSource.Filter = info.QueryFIO;
                else if (rbGroup.Checked)
                    studentBindingSource.Filter = info.QueryGroup;
                else if (rbSpecialty.Checked)
                    studentBindingSource.Filter = info.QuerySpecialty;
            }
            else
                studentBindingSource.Filter = "";
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            fStudent fStudent = new fStudent();
            fStudent.Text = "Добавить данные студента";
            fStudent.ShowDialog();
            studentTableAdapter.Fill(studentPerformanceDataSet.Student);
        }

        private void btnEditStudent_Click(object sender, EventArgs e) {
            fStudent fStudent = new fStudent() {
                Text = "Изменить данные студента",
                Info = info };
            fStudent.ShowDialog();
            studentTableAdapter.Fill(studentPerformanceDataSet.Student);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
            "Удалить эту запись?",
            "Студенты",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
           (MessageBoxOptions)0x40000);
            if (result == DialogResult.Yes) {
                studentTableAdapter.Delete(info.IdStudent, info.FIO, info.RecordBook, info.Birthday, info.IdGroup);
                studentTableAdapter.Fill(studentPerformanceDataSet.Student);
                MessageBox.Show("Данные удалены.", "Студенты", MessageBoxButtons.OK);
            }
        }

        private void btnAddAcadPerf_Click(object sender, EventArgs e) {
            fAcademicPerformance fAcademic = new fAcademicPerformance() {
                Text = "Добавить успеваемость студента",
                IdStudent = info.IdStudent };
            fAcademic.ShowDialog();
            disciplineBindingSource.Filter = info.DisciplineFilter;
            academicPerformanceTableAdapter.Fill(studentPerformanceDataSet.AcademicPerformance);
            disciplineTableAdapter.Fill(studentPerformanceDataSet.Discipline);
        }

        private void btnEditAcadPerf_Click(object sender, EventArgs e) {
            fAcademicPerformance fAcademic = new fAcademicPerformance() {
                Text = "Изменить успеваемость студента",
                Info = info };
            fAcademic.ShowDialog();
            disciplineBindingSource.Filter = info.DisciplineFilter;
            academicPerformanceTableAdapter.Fill(studentPerformanceDataSet.AcademicPerformance);
            disciplineTableAdapter.Fill(studentPerformanceDataSet.Discipline);
        }

        private void btnDeleteAcadPerf_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
            "Удалить эту запись?",
            "Успеваемость",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
           (MessageBoxOptions)0x40000);
            if (result == DialogResult.Yes) {
                academicPerformanceTableAdapter.Delete(info.IdDiscipline, info.IdStudent);
                academicPerformanceTableAdapter.Fill(studentPerformanceDataSet.AcademicPerformance);
                MessageBox.Show("Данные удалены.", "Успеваемость", MessageBoxButtons.OK);
            }
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e) {
            fSprStudyGroup fSprStudyGroup = new fSprStudyGroup();
            fSprStudyGroup.ShowDialog();
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e) {
            fSprSpecialty fSprSpecialty = new fSprSpecialty();
            fSprSpecialty.ShowDialog();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e) {
            fSprTeacher fSprTeacher = new fSprTeacher();
            fSprTeacher.ShowDialog();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e) {
            fSprDiscipline fSprDiscipline = new fSprDiscipline();
            fSprDiscipline.ShowDialog();
        }

        private void списокСтудентовПоГруппамToolStripMenuItem_Click(object sender, EventArgs e) {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; 
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            var studyGroupEnum = studentPerformanceDataSet.StudyGroup.AsEnumerable();
            studyGroupEnum = studyGroupEnum.OrderBy(n => n["NameStudyGroup"]);
            foreach (StudentPerformanceDataSet.StudyGroupRow studyGroup in studyGroupEnum) {
                Word.Paragraph oPara1;
                oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = studyGroup.NameStudyGroup;
                oPara1.Range.Font.Bold = 1;
                oPara1.Range.Font.Size = 20;
                oPara1.Range.Font.Name = "Times New Roman";
                oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oPara1.Format.SpaceAfter = 15;    
                oPara1.Range.InsertParagraphAfter();
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                Word.Table oTable;
                oTable = oDoc.Tables.Add(wrdRng, 1, 4, ref oMissing, ref oMissing);
                oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);
                oTable.Range.ParagraphFormat.SpaceAfter = 0;
                oTable.Range.Font.Size = 14;
                oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                oTable.Cell(1, 1).Range.Text = "№";
                oTable.Cell(1, 2).Range.Text = "ФИО студента";
                oTable.Cell(1, 3).Range.Text = "Номер студенческой книжки";
                oTable.Cell(1, 4).Range.Text = "Дата рождения";
                oTable.Rows[1].Range.Font.Bold = 1;
                int i = 1;
                foreach (StudentPerformanceDataSet.StudentRow student in studentPerformanceDataSet.Student.Rows) {
                    if (studyGroup.IdStudyGroup == student.IdStudyGroup) {
                        oTable.Rows.Add(ref oMissing);
                        oTable.Rows[i + 1].Range.Font.Bold = 0;
                        oTable.Cell(i + 1, 1).Range.Text = i.ToString();
                        oTable.Cell(i + 1, 2).Range.Text = student.FIO;
                        oTable.Cell(i + 1, 3).Range.Text = student.StudentRecordBook.ToString();
                        oTable.Cell(i + 1, 4).Range.Text = student.Birthday.ToShortDateString();
                        i++;
                    }
                }
                Word.Paragraph oScore;
                oScore = oDoc.Content.Paragraphs.Add(ref oMissing);
                oScore.Range.Text = "Студентов в группе - " + (i - 1);
                oScore.Range.Font.Bold = 1;
                oScore.Range.Font.Size = 14;
                oScore.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                oScore.Format.SpaceAfter = 24;   
                oScore.Range.InsertParagraphAfter();
            }
            Word.Paragraph oEnd;
            oEnd = oDoc.Content.Paragraphs.Add(ref oMissing);
            oEnd.Range.Text = "Всего студентов " + studentPerformanceDataSet.Student.Count;
            oEnd.Range.Font.Bold = 1;
            oEnd.Range.Font.Size = 16;
            oEnd.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oEnd.Range.InsertParagraphAfter();
            oWord.Application.ActiveDocument.SaveAs("Список студентов.docx");
            oWord.Visible = true;
        }
        private void ToolStrip_Click(object sender, EventArgs e) {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Успеваемость " + (sender as ToolStripMenuItem).Name;
            oPara1.Range.Font.Bold = 1;
            oPara1.Range.Font.Size = 20;
            oPara1.Range.Font.Name = "Times New Roman";
            oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPara1.Format.SpaceAfter = 0;
            oPara1.Range.InsertParagraphAfter();
            foreach (StudentPerformanceDataSet.StudentRow student in studentPerformanceDataSet.Student.Rows) {
                if (student.IdStudyGroup == Convert.ToInt32((sender as ToolStripMenuItem).Tag)) {
                    Word.Paragraph oFIO;
                    oFIO = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oFIO.Range.Text = student.FIO;
                    oFIO.Range.Font.Size = 16;
                    oFIO.Range.Font.Name = "Times New Roman";
                    oFIO.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oFIO.Format.SpaceAfter = 10;
                    oFIO.Range.InsertParagraphBefore();
                    Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    Word.Table oTable;
                    oTable = oDoc.Tables.Add(wrdRng, 1, 7, ref oMissing, ref oMissing);
                    oTable.Range.ParagraphFormat.SpaceAfter = 0;
                    oTable.Range.Font.Size = 14;
                    oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);
                    oTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    oTable.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    oTable.Cell(1, 1).Range.Text = "№";
                    oTable.Cell(1, 2).Range.Text = "Дисциплина";
                    oTable.Cell(1, 3).Range.Text = "Семестр";
                    oTable.Cell(1, 4).Range.Text = "Преподаватель";
                    oTable.Cell(1, 5).Range.Text = "Форма контроля";
                    oTable.Cell(1, 6).Range.Text = "Дата";
                    oTable.Cell(1, 7).Range.Text = "Оценка";
                    int i = 1;
                    foreach (StudentPerformanceDataSet.AcademicPerformanceRow academicPerformance in studentPerformanceDataSet.AcademicPerformance.Rows) {
                        if (student.IdStudent == academicPerformance.IdStudent) {
                            oTable.Rows.Add(ref oMissing);
                            oTable.Rows[i + 1].Range.Font.Bold = 0;
                            oTable.Cell(i + 1, 1).Range.Text = i.ToString();
                            foreach (StudentPerformanceDataSet.DisciplineRow discipline in studentPerformanceDataSet.Discipline.Rows)
                                if (discipline.IdDiscipline == academicPerformance.IdDiscipline) {
                                    oTable.Cell(i + 1, 2).Range.Text = discipline.NameDiscipline;
                                    oTable.Cell(i + 1, 3).Range.Text = discipline.Semester.ToString();
                                    foreach (StudentPerformanceDataSet.PrepodavatelRow teacher in studentPerformanceDataSet.Prepodavatel.Rows)
                                        if (discipline.IdTeacher == teacher.IdTeacher)
                                            oTable.Cell(i + 1, 4).Range.Text = teacher.FIO;
                                    foreach (StudentPerformanceDataSet.FormsControlRow formsControl in studentPerformanceDataSet.FormsControl.Rows)
                                        if (discipline.IdForm == formsControl.IdForm)
                                            oTable.Cell(i + 1, 5).Range.Text = formsControl.FormControl;
                                    oTable.Cell(i + 1, 6).Range.Text = discipline.DateDiscipline.ToShortDateString();
                                    oTable.Cell(i + 1, 7).Range.Text = academicPerformance.Assessment;
                                }
                            i++;
                        }
                    }
                }
            }
            oWord.Application.ActiveDocument.SaveAs("Успеваемость " + (sender as ToolStripMenuItem).Name + " студентов.docx");
            oWord.Visible = true;
        }

        private void rbFIO_CheckedChanged(object sender, EventArgs e) {
            tbSearch_TextChanged(this, null);
        }

        private void rbGroup_CheckedChanged(object sender, EventArgs e) {
            tbSearch_TextChanged(this, null);
        }

        private void rbSpecialty_CheckedChanged(object sender, EventArgs e) {
            tbSearch_TextChanged(this, null);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}