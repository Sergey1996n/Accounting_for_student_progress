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
    public partial class fSprStudyGroup : Form
    {
        public Info Info { get; set; }
        public fSprStudyGroup() {
            InitializeComponent();
        }
        private void fStudyGroup_Load(object sender, EventArgs e) {
            studyGroupTableAdapter.Fill(this.studentPerformanceDataSet.StudyGroup);
            specialtyTableAdapter.Fill(this.studentPerformanceDataSet.Specialty);
        }

        private void fSprStudyGroup_FormClosing(object sender, FormClosingEventArgs e) {
            studyGroupTableAdapter.Update(studentPerformanceDataSet);
        }
    }
}
