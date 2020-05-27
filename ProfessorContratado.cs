using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Professores
{
    
    public class ProfessorContratado:Professor
    {
        private bool profissionalizado;
        private const string TIPO = "CONTRATADO";

        public ProfessorContratado(int idProfessor, string nome,string morada,DateTime dataNasc,int nib,
            long ss, short tempoServico,bool profissionalizado)
        :base(idProfessor,nome,morada,dataNasc,nib,ss, profissionalizado ? (byte)1 : (byte)0, tempoServico)
        {
            this.profissionalizado=profissionalizado;
        }
        public bool Profissionalizado
        {
            get { return profissionalizado; }
            set { profissionalizado = value;}
        }
        public override string ToString()
        {
            return IdProfessor + " " + Nome;
        }
        public override double CalcularSalario(int mes)
        {
            double sbruto = Salario.salariosTaxas[escalao, Salario.SALARIO];
            double tirs = Salario.salariosTaxas[escalao, Salario.TIRS];

            double taxas = tirs + Salario.TSS;
            double subAlim = Salario.SA * Salario.DIAS;

            if (mes == 7)
                return sbruto * (1 - taxas) * 2;
            if (mes == 11)
                return sbruto * (1 - taxas) * 2 + subAlim;
            return sbruto * (1 - taxas) + subAlim;
        }

        public override SqlCommand InsertIntoProfessor()
        {
            string insert = "INSERT INTO idprofessor,nome,morada,datanasc,nib,ss,escalao,temposervico,profissionalizado,tipo";
            insert += "VALUES(@idprofessor,@nome@,@morada,@dataNasc,@nib,@ss,@escalao,@temposervico,@profissionalizado,@tipo)";
            SqlCommand cmd = new SqlCommand(insert);
            cmd.Parameters.AddWithValue("@idprofessor", idProfessor);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("dataNasc", datanascimento);
            cmd.Parameters.AddWithValue("@nib", nib);
            cmd.Parameters.AddWithValue("@ss", ss);
            cmd.Parameters.AddWithValue("@escalao", escalao);
            cmd.Parameters.AddWithValue("@temposervico", temposervico);
            cmd.Parameters.AddWithValue("@profissionalizado", profissionalizado);
            cmd.Parameters.AddWithValue("@tipo", TIPO);
            return cmd;
        }
    }
}
