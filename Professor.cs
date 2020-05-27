using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Professores
{
   public class Professor
    {
        protected int idProfessor;
        protected string nome;
        protected string morada;
        protected DateTime datanascimento;
        protected int nib;
        protected long ss;
        protected byte escalao;
        protected short temposervico;
        private const string TIPO = "QUADRO";
        

        public Professor(int idProfessor, string nome, string morada,  DateTime datanascimento, int nib, long ss,
            byte escalao, short temposervico)
        {
            this.idProfessor = idProfessor;
            this.nome = nome;
            this.morada = morada;
            this.datanascimento = datanascimento;
            this.nib = nib;
            this.ss = ss;
            this.escalao = (escalao>=0&&escalao<=10?escalao:(byte)0);
            this.temposervico = temposervico;
        }

        public int IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Morada {
            get { return morada; }
            set { morada = value; }
        }
        public DateTime Datanascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }
        public int Nib
        {
            get { return nib; }
            set { nib = value; }
        }
        public long Ss
        {
            get { return ss; }
            set { ss = value; }
        }
        public byte Escalao
        {
            get { return escalao; }
            set { escalao = value; }
        }
        public short TempoServico
        {
            get { return temposervico; }
            set { temposervico = value; }
        }
        
        public virtual double CalcularSalario (int mes)
        {
            double sbruto = Salario.salariosTaxas[escalao, Salario.SALARIO];
            double tirs = Salario.salariosTaxas[escalao, Salario.TIRS];
           
            double taxas=tirs + Salario.TSS + Salario.ADSE;
            double subAlim = Salario.SA * Salario.DIAS;

            if (mes == 7)
                return sbruto * (1 - taxas) * 2;
            if(mes==11)
                return sbruto * (1 - taxas) * 2+subAlim;
            return sbruto * (1 - taxas) + subAlim;
        }
        public virtual SqlCommand InsertIntoProfessor()
        {
            string insert = "INSERT INTO Professores (idprofessor,nome,morada,datanascimento,nib,ss,escalao,temposervico,profissionalizado,tipo)";
            insert += "VALUES(@idprofessor,@nome,@morada,@datanascimento,@nib,@ss,@escalao,@temposervico,@profissionalizado,@tipo)";
            SqlCommand cmd = new SqlCommand(insert);
            cmd.Parameters.AddWithValue("@idprofessor", idProfessor);
            cmd.Parameters.AddWithValue("@nome", nome); 
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@datanascimento", datanascimento);
            cmd.Parameters.AddWithValue("@nib", nib);
            cmd.Parameters.AddWithValue("@ss", ss);
            cmd.Parameters.AddWithValue("@escalao", escalao);
            cmd.Parameters.AddWithValue("@temposervico", temposervico);
            cmd.Parameters.AddWithValue("@profissionalizado", 1);
            cmd.Parameters.AddWithValue("@tipo", TIPO);
            return cmd;
        }
        public override string ToString()
        {
            return IdProfessor + " " + Nome;
        }
    }
    }

