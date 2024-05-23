using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100.0));
        }
        public override string ToString()
        {
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
