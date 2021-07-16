using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_student_progress
{
    public partial class fStudent : Form
    {
        public Info Info { get; set; }
        public fStudent()  {
            InitializeComponent();
        }

        private void fStudent_Load(object sender, EventArgs e) {
            studentTableAdapter.Fill(this.studentPerformanceDataSet.Student);
            studyGroupTableAdapter.Fill(this.studentPerformanceDataSet.StudyGroup);
            if (Info == null)
                dtpBirthday.Value = DateTime.Now;
            else {
                cbGroup.Text = Info.Group;
                tbFIO.Text = Info.FIO;
                tbRecordBook.Text = Info.RecordBook.ToString();
                dtpBirthday.Value = Info.Birthday;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            if (CheckingFields())
                if (Info == null)
                    studentTableAdapter.Insert(tbFIO.Text, Convert.ToInt32(tbRecordBook.Text), dtpBirthday.Value, Convert.ToInt32(cbGroup.SelectedValue));
                else
                    studentTableAdapter.Update(tbFIO.Text, Convert.ToInt32(tbRecordBook.Text), dtpBirthday.Value, Convert.ToInt32(cbGroup.SelectedValue), Info.IdStudent, Info.FIO, Info.RecordBook, Info.Birthday, Info.IdGroup);
            Close();
        }

        private bool CheckingFields() {
            if (tbFIO.Text != "")
                if (tbRecordBook.Text != "")
                    if (!int.TryParse(tbRecordBook.Text, out int n)) {
                        MessageBox.Show("Неправильно указан номер студенческой книжки.", "Студенты", MessageBoxButtons.OK);
                        return false;
                    }
                    else
                        return true;
                else {
                    MessageBox.Show("Не указан номер студенческой книжки.", "Студенты", MessageBoxButtons.OK);
                    return false;
                }
            else {
                MessageBox.Show("Не указаны ФИО студента.", "Студенты", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
