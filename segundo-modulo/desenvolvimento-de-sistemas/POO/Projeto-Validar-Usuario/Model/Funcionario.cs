using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarUsuario.Model
{
    abstract class Funcionario : Usuario
    {
        private double salarioBase;

        public void setSalarioBase(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }
        public double getSalarioBase()
        {
            return salarioBase;
        }



    }
}
