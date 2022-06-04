using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TrianguloMob
{
    class Triangulo
    {

        public double[] lado;
        public double perimetro, area;
        public string tipo;

        public Triangulo()
        {
            lado = new double[3];
            lado[0] = 0;
            lado[1] = 0;
            lado[2] = 0;
            perimetro = 0;
            area = 0;
            tipo = "";
        }

        public Triangulo(double[] lado)
        {
            lado = new double[3];
            this.lado[0] = 0;
            this.lado[1] = 0;
            this.lado[2] = 0;
            perimetro = 0;
            area = 0;
            tipo = "";
        }

        public bool isTriangle()
        {
            if (lado[0] < (lado[1] + lado[2]) && lado[1] < (lado[0] + lado[2]) && lado[2] < (lado[0] + lado[1]))
            {
                classificar();
                return true;
            }
            return false;
        }
        private double calcularPerimetro()
        {
            perimetro = lado[0] + lado[1] + lado[3];
            return perimetro;
        }

        private void classificar()
        {
            if (lado[0] == lado[1] && lado[1] == lado[2])
            {
                tipo = "equilátero";
            }
            else if (lado[0] != lado[1] && lado[1] != lado[2])
            {
                tipo = "escaleno";
            }
            else
            {
                tipo = "isósceles";
            }
        }

        public double calcularArea()
        {
            double sp = calcularPerimetro() / 2;
            area = Math.Sqrt(sp * (sp - lado[0]) * (sp - lado[1]) * (sp - lado[2]));
            return area;
        }


    }

}