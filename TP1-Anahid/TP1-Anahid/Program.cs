using System;

class TrabajoFinal
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("¡Te damos la Bienvenida a la Aerolinea! \nPor favor, confirmanos tu nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("¿Cuál es tu DNI? ");
        int dni = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuántos años tenes? ");
        int anios = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuál es tu destino? ");
        string destino = Console.ReadLine();

        Console.WriteLine("¿En que clase de vuelo vas a viajar? (Económica: 1, Ejecutiva: 2, Primera Clase: 3)");
        int claseVuelo = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Posees equipaje de mano? (Sí: 1, No: 0),");
        int equipajeMano = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Tenes el equipaje en bodega facturado? (Sí: 1, No: 0)");
        int equipajeFacturado = int.Parse(Console.ReadLine());

        Console.WriteLine("¿Viajas con un perro de servicio? (Sí: 1, No: 0)");
        int perroServicio = int.Parse(Console.ReadLine());

        int dniAdulto = 0, servicioMenor = 0, cantEquipajeMano = 0, pesoEquipaje = 0, precioAdicional = 0;

        //tarjeta de embarque
        Random rnd = new Random();
        int numeroAleatorio = rnd.Next(10000, 99000 + 1);
        char letraAleatoria1 = (char)rnd.Next('A', ('Z' + 1));
        char letraAleatoria2 = (char)rnd.Next('A', ('Z' + 1));

        string tarjeta = letraAleatoria1 + "" + letraAleatoria2 + "" + numeroAleatorio;

        //2
        if (anios >= 2 && anios < 5)
        {
            Console.WriteLine(nombre + " tiene entre 2 y 5 años no cumplidos, debe viajar con un mayor de 18 años, brindanos el DNI: ");
            dniAdulto = int.Parse(Console.ReadLine());
        }

        //3
        if (anios >= 5 && anios <= 11)
        {
            Console.WriteLine(nombre + " puede viajar solo utilizando el Servicio de Menor No Acompañado, ¿Queres solicitarlo? (Si: 1 o No: 0)");
            servicioMenor = int.Parse(Console.ReadLine());

            if (servicioMenor == 0)
            {
                Console.WriteLine("Confirmanos el DNI de quien acompaña a " + nombre);
                dniAdulto = int.Parse(Console.ReadLine());
            }
        }

        //4

        if (equipajeMano == 1)
        {
            Console.WriteLine("¿Cuantos equipajes de mano llevas con vos?");
            cantEquipajeMano = int.Parse(Console.ReadLine());
            if (cantEquipajeMano > 3)
            {
                Console.WriteLine("¡Excedes la cantidad permitida!");
                Console.WriteLine("\n");
            }

        }

        //5

        if (equipajeFacturado == 0)
        {
            Console.WriteLine("Todavia no facturaste tu equipaje, vamos a hacerlo, ¿Cuanto es el peso total?");
            pesoEquipaje = int.Parse(Console.ReadLine());

            if (claseVuelo == 1)
            {
                if (pesoEquipaje > 5)
                {
                    precioAdicional = (pesoEquipaje - 5) * 10;
                    Console.WriteLine("Excediste el peso máximo en clase Económica, debes abonar $" + precioAdicional);
                    Console.WriteLine("\n");
                }
            }

            if (claseVuelo == 2)
            {
                if (pesoEquipaje > 10)
                {
                    precioAdicional = (pesoEquipaje - 10) * 10;
                    Console.WriteLine("Excediste el peso máximo en clase Ejecutiva, debes abonar $" + precioAdicional);
                    Console.WriteLine("\n");
                }
            }

            if (claseVuelo == 3)
            {
                if (pesoEquipaje > 20)
                {
                    precioAdicional = (pesoEquipaje - 20) * 10;
                    Console.WriteLine("Excediste el peso máximo en Primera Clase, debes abonar $" + precioAdicional);
                    Console.WriteLine("\n");
                }
            }

        }

        //6 

        if (perroServicio == 1)
        {
            Console.WriteLine("Recorda que el perro debe estar identificado con su chaleco o distintivo de servicio y traer un accesorio o correa para asegurarlo con el cinturón de seguridad. ");
            Console.WriteLine("\n");
        }

        //7

        Console.WriteLine("Nombre del pasajero: " + nombre + ", \nDNI: " + dni + ", \nEdad: " + anios +
            ", \nDestino: " + destino + ", \nClase de vuelo: " + claseVuelo + ", \nTarjeta de embarque: " + tarjeta + ", \nFecha y hora: " + DateTime.Now);

        if ((anios >= 2 && anios < 5) || ((anios >= 5 && anios <= 11) && (servicioMenor == 0)))
        {
            Console.WriteLine("DNI adulto acompañante: " + dniAdulto);
        }

        if (precioAdicional > 0)
        {
            Console.WriteLine("El valor adicional de las valijas es de: " + precioAdicional);
        }

        Console.WriteLine("\n");

        Console.WriteLine("¡Que tengas buen viaje a " + destino + "!");


        Console.ReadKey();

    }
}
