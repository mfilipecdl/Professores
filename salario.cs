using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professores
{
    class Salario
    {
        private int idSalario;
        private int idProfessor;
        private double sBase=0.11;
        private double impostos;
        private DateTime data;
        private static double txSS=0.11;
        private static double txADSE = 0.03;
        private static double sr = 21 * 4.77;

        public static double [,] salariosTaxas = new double[,] { { 1350, 0.15 },{ 1500, 0.16 },{ 1700, 0.176 },{ 1900,.2},{ 2100,.224},
        { 2400,.24 },{ 2700,.275},{ 3000,.287},{ 3300,.315},{ 3700,.33},{ 4000,.335} };
        public static double ADSE = 0.03;
        public static double TSS = 0.11;
        public static double SA = 4.77;
        public static int SALARIO = 0;
        public static int TIRS = 1;
        public static double DIAS = 21;

        public Salario(int idSalario, int idProfessor,double sBase,double impostos, DateTime data)
        {
            this.idSalario = idSalario;
            this.idProfessor = idProfessor;
            this.sBase = sBase;
            this.impostos = impostos;
            this.data = data;
        }

        public int IdSalario
        {
            get
            {
                return idSalario;
            }
            set
            {
                idSalario = value;
            }
        }
        public int IdProfessor
        {
            get{
                return idProfessor;
            }
            set
            {
                idProfessor = value;
            }
        }
        public double SBase
        {
            get
            {
                return sBase;
            }
            set
            {
                sBase = value;
            }
        }
        public double Impostos
        {
            get
            {
                return impostos;
            }
            set
            {
                impostos = value;
            }
        }
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }        
    }
}
