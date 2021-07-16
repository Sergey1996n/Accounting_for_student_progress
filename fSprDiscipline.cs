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
    public partial class fSprDiscipline : Form
    {
        public fSprDiscipline() {
            InitializeComponent();
        }

        private void fSprDiscipline_Load(object sender, EventArgs e) {
            prepodavatelTableAdapter.Fill(this.studentPerformanceDataSet.Prepodavatel);
            formsControlTableAdapter.Fill(this.studentPerformanceDataSet.FormsControl);
            disciplineTableAdapter.Fill(this.studentPerformanceDataSet.Discipline);
        }

        private void fSprDiscipline_FormClosing(object sender, FormClosingEventArgs e) {
            disciplineTableAdapter.Update(studentPerformanceDataSet);

        }
    }
}
