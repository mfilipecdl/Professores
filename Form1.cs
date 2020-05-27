using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Professores
{
    public partial class Form1 : Form
    {
        //List<Professor> professores = new List<Professor>();
        IGestProf gp;
        public Form1()
        {
            InitializeComponent();
            gp = new GestProf("DBProfessores.mdf");
        }

        private void TxtIDProfessor_TextChanged(object sender, EventArgs e)
        {
            string IDPro = TxtIDProfessor.Text;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Professor prof0 = new Professor(100, "Rita", "Lisboa", new DateTime(1980,10,25), 123456789, 12458796321, 1, 4500);
            Professor prof1 = new Professor(116, "Rita", "Lisboa", new DateTime(1980,10,25), 123456789, 12458796321, 1, 4500);
            Professor prof2 = new ProfessorContratado(111, "Ana", "Lisboa", new DateTime(1985,10,25), 123456789, 12458796321, 2000, true);
            //MessageBox.Show(gp.InserirProfessor(prof0).ToString());
            MessageBox.Show(gp.InserirProfessor(prof1).ToString());
            //MessageBox.Show(gp.InserirProfessor(prof2).ToString());
        }

        private void RadProfissionalizado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkContratado_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkContratado.Checked)
            {
                RadNãoProfissinalizado.Enabled = true ;
                RadProfissionalizado.Enabled = true;
            }
            else
            {
                RadNãoProfissinalizado.Enabled = false;
                RadProfissionalizado.Enabled = false; 
            }
        }
    }
}
