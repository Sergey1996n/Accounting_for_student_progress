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
    public partial class fSprTeacher : Form
    {
        public fSprTeacher() {
            InitializeComponent();
        }

        private void fSprTeacher_Load(object sender, EventArgs e) {
            prepodavatelTableAdapter.Fill(this.studentPerformanceDataSet.Prepodavatel);
        }

        private void fSprTeacher_FormClosing(object sender, FormClosingEventArgs e) {
            prepodavatelTableAdapter.Update(studentPerformanceDataSet);
        }
    }
}
