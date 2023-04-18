using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_polimorfismo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            FTRIANGULO triangulo  = new FTRIANGULO();
            triangulo.Area(10,10);

             Frectangulo frectangulo= new Frectangulo();
            frectangulo.Area(10,10);

            FTRAPECIO tRAPECIO= new FTRAPECIO();
            tRAPECIO.area2(10,10,10);
        }
    }
    interface IMedidas 
    {
        void area2(int BaseMayor, int Basemenor, int ALTURA);
       


    }
    public class FTRIANGULO
    {
        public void Area(int Base, int altura)
        {
            Console.WriteLine("El area del cuadrado es;"+(Base*altura/2));
        }
    }
    public class Frectangulo :FTRIANGULO
    {
        public void Area(int Base, int altura)
        {
            Console.WriteLine("El area del RECTANGULO es;" + (Base * altura));
        }
    }
    public class FTRAPECIO : IMedidas
    {
        public void area2(int BaseMayor, int Basemenor, int ALTURA)
        {
             Console.WriteLine("la area del Trapecio es:" + (BaseMayor * Basemenor * ALTURA / 2));
        }
    }

}
