using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Professores
{
    public class GestProf:IGestProf
    { 
        private string dbname;

        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
    
        public GestProf(string dbname)
        {
            this.dbname = dbname;
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename="+Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\"+dbname+ ";Integrated Security = True");
        }
    
        public bool InserirProfessor(Professor professor)
        {
            cn.Open();
            SqlCommand cmd = professor.InsertIntoProfessor();
            cmd.Connection = cn;
            int rows = cmd.ExecuteNonQuery();
            cn.Close();
            return rows>0;
            
        }
    }
}
