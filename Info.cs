using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_for_student_progress
{
    public class Info
    {
        private readonly DataGridView dataGridView;
        private readonly DataGridView dataGridView1;
        private readonly TextBox textBox;
        private readonly string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Uspevaemost_studentov.mdb";

        public Info(DataGridView dataGridView, DataGridView dataGridView1, TextBox textBox) {
            this.dataGridView = dataGridView;
            this.dataGridView1 = dataGridView1;
            this.textBox = textBox;
        }
        public int IdStudent => dataGridView.CurrentRow != null ? Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value) : int.MinValue;
        public string FIO => dataGridView.CurrentRow != null ? dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[1].Value.ToString() : "";
        public int RecordBook => dataGridView.CurrentRow != null ? Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[2].Value) : int.MinValue;
        public DateTime Birthday => dataGridView.CurrentRow != null ? Convert.ToDateTime(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[3].Value) : DateTime.MinValue;
        public string Group => dataGridView.CurrentRow != null ? QueryScalar($"SELECT StudyGroup.NameStudyGroup FROM Student, StudyGroup WHERE StudyGroup.IdStudyGroup = {dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value}") : "";
        public int IdGroup => dataGridView.CurrentRow != null ? Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value) : int.MinValue;
        public string Specialty => dataGridView.CurrentRow != null ? QueryScalar($"SELECT Specialty.NameSpecialty FROM Student, StudyGroup, Specialty WHERE Specialty.IdSpecialty = StudyGroup.IdSpecialty AND StudyGroup.IdStudyGroup = {dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[4].Value}") : "";
        public int IdDiscipline => dataGridView1.CurrentRow != null ? Convert.ToInt32(QueryScalar($"SELECT IdDiscipline From Student, AcademicPerformance WHERE AcademicPerformance.IdStudent = {dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value} and AcademicPerformance.IdDiscipline = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value}")) /*Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value)*/ : int.MinValue;
        public string DisciplineFilter => dataGridView.CurrentRow != null ? QueryReader($"SELECT IdDiscipline FROM AcademicPerformance WHERE IdStudent like '{dataGridView.Rows[dataGridView.CurrentRow.Index].Cells[0].Value}'", "IdDiscipline", 17) : "";
        public string Discipline => dataGridView1.CurrentRow != null ? QueryScalar($"SELECT NameDiscipline FROM Discipline WHERE IdDiscipline = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value}") : "";
        public string Teacher => dataGridView1.CurrentRow != null ? QueryScalar($"SELECT Prepodavatel.FIO FROM AcademicPerformance, Prepodavatel WHERE Prepodavatel.IdTeacher = {dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value}") : "";
        public string Assessment => dataGridView1.CurrentRow != null ? dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString(): "";
        public DateTime Date => dataGridView1.CurrentRow != null ? Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value) : DateTime.MinValue;
        public string QueryFIO => $"FIO like '%{textBox.Text}%'";
        public string QueryGroup => QueryReader($"SELECT IdStudyGroup FROM StudyGroup WHERE NameStudyGroup like '%{textBox.Text}%'", "IdStudyGroup", 17);
        public string QuerySpecialty => QueryReader($"SELECT IdStudyGroup FROM StudyGroup, Specialty WHERE Specialty.IdSpecialty = StudyGroup.IdSpecialty and NameSpecialty like '%{textBox.Text}%'", "IdStudyGroup", 17);
        private string QueryScalar(string queryString) {
            using (OleDbConnection connection = new OleDbConnection(connectionString)) {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                return command.ExecuteScalar().ToString();
            }
        }

        private string QueryReader(string queryString, string column, int number) {
            using (OleDbConnection connection = new OleDbConnection(connectionString)) {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                string queryGroup = $"{column} = ";
                while (reader.Read())
                    queryGroup += reader.GetInt32(0) + $" or {column} = ";
                return queryGroup == $"{column} = " ? $"{column} = 0" : queryGroup.Remove(queryGroup.Length - number - 1, number);
            }
        }
    }
}
