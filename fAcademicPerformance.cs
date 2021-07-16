using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_student_progress
{
    public partial class fAcademicPerformance : Form
    {
        public Info Info { get; set; }
        public int IdStudent { get; set; }

        public fAcademicPerformance() {
            InitializeComponent();
        }

        private void fAcademicPerformance_Load(object sender, EventArgs e) {
            academicPerformanceTableAdapter.Fill(this.studentPerformanceDataSet.AcademicPerformance);
            prepodavatelTableAdapter.Fill(this.studentPerformanceDataSet.Prepodavatel);
            disciplineTableAdapter.Fill(this.studentPerformanceDataSet.Discipline);
            if (Info != null) {
                cbNameDiscipline.Text = Info.Discipline;
                tbAssessment.Text = Info.Assessment;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (CheckingFields())
                if (Info == null)
                    academicPerformanceTableAdapter.Insert(Convert.ToInt32(cbNameDiscipline.SelectedValue), IdStudent, tbAssessment.Text);
                else
                    academicPerformanceTableAdapter.Update(Convert.ToInt32(cbNameDiscipline.SelectedValue), Info.IdStudent, tbAssessment.Text, Info.IdDiscipline, Info.IdStudent, Info.Assessment);
            Close();
        }

        private bool CheckingFields() {
            if (tbAssessment.Text != "")
                return true;
            else {
                MessageBox.Show("Не указана оценка.", "Успеваемость", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
