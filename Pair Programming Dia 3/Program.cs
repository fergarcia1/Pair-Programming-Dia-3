using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Dia_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) Ejercicio 1: ");
            Console.WriteLine("(2) Ejercicio 2: ");
            int option = Int32.Parse(Console.ReadLine());
            try
            {
                switch (option)
                {
                    //Implementar dos clases que llamemos en este caso Suma y Resta.
                    //Cada clase tiene como atributo valor1, valor2  y resultado.
                    //En este caso , las propiedades a definir son Valor1, Valor2 y Resultado,
                    //el método Operar (que en el caso de la clase "Suma" suma los dos Valores y
                    //en el caso de la clase "Resta" hace la diferencia entre Valor1 y Valor2.
                    case 1:
                        Suma sum = new Suma();
                        Resta res = new Resta();
                        sum.Valor1 = 5;
                        sum.Valor2 = 5;

                        res.Valor1 = 4;
                        res.Valor1 = 3;

                        int a = sum.operar();
                        Console.WriteLine(a);

                        int b = res.operar();
                        Console.WriteLine(b);
                        Console.ReadKey();
                        break;
                    case 2:
                        Vaca vaca = new Vaca();
                        vaca.CantPatas = 4;
                        vaca.Color = "Blanco y Negro";
                        vaca.Nombre = "Vaca";
                        vaca.Pelaje = true;

                        vaca.comer();
                        vaca.movimiento();
                        vaca.comunicacion();
                        vaca.huir();
                        Console.ReadKey();
                        Console.Clear();

                        Oveja oveja = new Oveja();
                        oveja.CantPatas = 4;
                        oveja.Color = "Blanco";
                        oveja.Nombre = "Oveja";
                        oveja.Pelaje = true;

                        oveja.comer();
                        oveja.movimiento();
                        oveja.comunicacion();
                        oveja.huir();
                        Console.ReadKey();
                        Console.Clear();

                        Tigre tigre = new Tigre();
                        tigre.CantPatas = 4;
                        tigre.Color = "Naranja";
                        tigre.Nombre = "Tigre";
                        tigre.Pelaje = true;
                        tigre.Alimentacion = "Depredador";

                        tigre.comer();
                        tigre.movimiento();
                        tigre.comunicacion();
                        tigre.cazar();
                        Console.ReadKey();
                        Console.Clear();

                        Buitre buitre = new Buitre();
                        buitre.CantPatas = 2;
                        buitre.Color = "Negro";
                        buitre.Nombre = "Buitre";
                        buitre.Pelaje = false;
                        tigre.Alimentacion = "Carroñero";

                        buitre.comer();
                        buitre.movimiento();
                        buitre.comunicacion();
                        buitre.cazar();
                        Console.ReadKey();
                        Console.Clear();

                        Cangrejo cangrejo = new Cangrejo();
                        cangrejo.CantPatas = 8;
                        cangrejo.Color = "Marron";
                        cangrejo.Nombre = "Cangrejo";
                        cangrejo.Pelaje = false;

                        cangrejo.comer();
                        cangrejo.movimiento();
                        cangrejo.comunicacion();
                        cangrejo.huir();
                        cangrejo.cazar();
                        Console.ReadKey();
                        Console.Clear();

                        Humano humano = new Humano();
                        humano.CantPatas = 2;
                        humano.Color = "Color piel";
                        humano.Nombre = "Humano";
                        humano.Pelaje = true;

                        humano.comer();
                        humano.movimiento();
                        humano.comunicacion();
                        humano.huir();
                        humano.cazar();
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Se ha introducido un dato incorrecto");
            }
           
        }
    }
    class Operacion
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;

        protected void operar()  { }
        public void mostrar() { }
    }

    class Suma : Operacion
    {
        public int Valor1 { get => valor1; set => valor1 = value; }
        public int Valor2 { get => valor2; set => valor2 = value; }

        public Suma()
        {
        }

        public Suma(int valor1, int valor2, int resultado)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            this.resultado = resultado;
        }

        public int operar()
        {
            this.resultado = this.Valor1 + this.Valor2;
            return resultado;
        }
    }
    class Resta : Operacion
    {
        public int Valor1 { get => valor1; set => valor1 = value; }
        public int Valor2 { get => valor2; set => valor2 = value; }

        public Resta()
        {
        }
        public Resta(int valor1, int valor2, int resultado)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            this.resultado = resultado;
        }
        
        public int operar()
        {
            this.resultado = this.Valor1 - this.Valor2;
            return resultado;
        }
    }

    class Animal
    {
        protected string nombre;
        protected int cantDePatas;
        protected string color;
        protected bool pelaje;

       public string Nombre { get; set; }
       public string Color { get; set; }
       public int CantPatas { get; set; }
       public bool Pelaje { get; set; }
       

        protected void comer() { }
        protected void movimiento() { }
        protected void comunicacion() { }

    }
    class Omnivoro : Animal
    {
        protected string tipo; //aereo acuatico terrestre

        public string Tipo { get; set; }
        public void huir()
        {
            Console.WriteLine("Huyo cuando debo");
        }

        public void cazar()
        {
            Console.WriteLine("Cazo cuando puedo");
        }
    }
    class Carnivoro : Animal
    {
        protected string tipo; //aereo, acuatico, terrestre
        protected string alimentacion; //depredador, carroñero

        public string Alimentacion { get; set; }
        public string Tipo { get; set; }

        public void cazar()
        {
            Console.WriteLine("Corro a mi presa");
        }
    }
    class Herbivoro : Animal
    {
        protected string tipo; //aereo acuatico terrestre

        public string Tipo { get; set; }
        public void huir()
        {
            Console.WriteLine("Corro cuando me cazan");
        }
    }

    class Vaca : Herbivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy una vaca y como pasto...");
        }
        public void movimiento()
        {
            Console.WriteLine("Soy una vaca y camino...");
        }
        public void comunicacion()
        {
            Console.WriteLine("Muu...");
        }
    }
    class Oveja : Herbivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy una oveja y tambien como pasto...");
        }

        public void movimiento()
        {
            Console.WriteLine("Soy una oveja y camino...");
        }

        public void comunicacion()
        {
            Console.WriteLine("Beehehe...");
        }
    }

    class Tigre : Carnivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy un tigre y cazo mi comida");
        }

        public void movimiento()
        {
            Console.WriteLine("Soy un tigre y camino/corro...");
        }
        public void comunicacion()
        {
            Console.WriteLine("Grr...");
        }
    }
    class Buitre: Carnivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy un buitre y como carroña...");
        }
        public void movimiento()
        {
            Console.WriteLine("Soy un buitre y vuelo...");
        }
        public void comunicacion()
        {
            Console.WriteLine("????...");
        }
    }

    class Cangrejo : Omnivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy un cangrejo y como cualquier cosa...");
        }
        public void movimiento()
        {
            Console.WriteLine("Soy un cangrejo y camino de costado...");
        }
        public void comunicacion()
        {
            Console.WriteLine("????...");
        }
    }
    class Humano : Omnivoro
    {
        public void comer()
        {
            Console.WriteLine("Soy un humano y como cualquier cosa...");
        }
        public void movimiento()
        {
            Console.WriteLine("Soy una humano y camino/corro y ando en auto...");
        }
        public void comunicacion()
        {
            Console.WriteLine("Hola!...");
        }
    }
}
