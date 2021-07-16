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
    public partial class fSprSpecialty : Form
    {
        public fSprSpecialty() {
            InitializeComponent();
        }

        private void fSprSpecialty_Load(object sender, EventArgs e) {
            specialtyTableAdapter.Fill(this.studentPerformanceDataSet.Specialty);

        }

        private void fSprSpecialty_FormClosing(object sender, FormClosingEventArgs e) {
            specialtyTableAdapter.Update(studentPerformanceDataSet);
        }
    }
}
