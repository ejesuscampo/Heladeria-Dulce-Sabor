using System;

namespace Heladeria_Dulce_Sabor
{
    class Program
    {
        void Main(string[] args)
        {
            menu();
        }

        public void menu(){
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            int Op=0;
            do {

                Console.WriteLine("BIENVENIDO A HELADERIA DULCE SABOR :)");
                Console.WriteLine("1. REGISTRAR");
                Console.WriteLine("2. CONSULTAR VENTAS");
                Console.WriteLine("3. ACTUALIZAR");
                Console.WriteLine("4. ELIMINAR");
                Console.WriteLine("5. SALIR");
                Console.Write("DIGITE LA OPCION QUE DESEE: ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1){
                    Console.Clear();
                    registrar();
                } else if(Op == 2){
                    Console.Clear();
                    //consultar();
                } else if(Op == 3){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ACTUALIZAR");
                } else if(Op == 4){
                    Console.Clear();
                    Console.WriteLine("AQUI VA LA OPCION DE ELIMINAR");
                } else {
                    Console.WriteLine("MUCHAS GRACIA. ADIOS :)");
                    Environment.Exit(1);
                }
               
            } while (Op != 5 );

        }

        static private void registrar() {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            String cc;
            String nombre;
            int tipoHelado, toppings;
            double precio;

            Console.Write("DIGITE SU CEDULA: ");
            cc = Console.ReadLine();
            Console.Write("DIGITE SU NOMBRE: ");
            nombre = Console.ReadLine();
            do{
                Console.WriteLine("DIGITE EL TIPO DE HELADO");
            Console.Write("1. CONO      2.VASO :");
            tipoHelado = int.Parse(Console.ReadLine());
            
                if (tipoHelado == 1) {
                    Console.WriteLine("CONO");
                } else if (tipoHelado == 2) {
                    Console.WriteLine("VASO");
            } else {
                    Console.WriteLine("VALOR INCORRECTO");
                }
            } while (tipoHelado!=1 && tipoHelado!=2);
            do{
            Console.WriteLine("DIGITE SUS TOPPINGS");
            Console.Write("1.MANI      2.CHISPAS DE CHOCOLATE    3.CHISPAS DE COLORES :");
            toppings = int.Parse(Console.ReadLine());
            
                if (toppings == 1){
                    Console.WriteLine("MANI");
                }else if (toppings == 2){
                    Console.WriteLine("CHISPAS DE CHOCOLATE");
                }else if(toppings == 3){
                    Console.WriteLine("CHISPAS DE COLORES");
                }else{
                    Console.WriteLine("VALOR INCORRECTO");
                }
            } while (toppings!=1 && toppings!=2 && toppings != 3);
            Console.Write("DIGITE EL PRECIO: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("PRECIONE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Console.Clear();
        }

        /*public void consultar(){
            Console.WriteLine($"Cedula: {cc}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de helado: {tipoHelado}");
            Console.WriteLine($"Toppings: {toppings}");
            Console.WriteLine($"Precio: {precio}");
        }*/
    }
}
