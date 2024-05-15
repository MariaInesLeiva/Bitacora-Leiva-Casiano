class Program
{ 
    static void Main(string[] args)
    {
        int numeroMes;
        string entradaMes;
        string mesCadena;

        Console.WriteLine("Ingrese un número del 1 al 12 para mostrar el nombre del mes");
        entradaMes = Console.ReadLine();

        if(int.TryParse(entradaMes, out numeroMes))
        {
            Console.WriteLine($"Se convirtió ' {entradaMes}' a ' {numeroMes}' ");
        }
        else 
        { 
            Console.WriteLine("Error:  Ingrese un número del 1 al 12");
        }
        
        Console.WriteLine(numeroMes);
 
        switch(numeroMes)
        {
            case 1:
             mesCadena = "Enero";
             break;

            case 2:
             mesCadena = "Febrero";
             break;

            case 3:
             mesCadena = "Marzo";
             break;

            case 4:
             mesCadena = "Abril";
             break;

            case 5:
             mesCadena = "Mayo";
             break;

            case 6:
             mesCadena = "Junio";
             break;

            case 7:
             mesCadena = "Julio";
             break;

            case 8:
             mesCadena = "Agosto";
             break;

            case 9:
             mesCadena = "Septiembre";
             break;

            case 10:
             mesCadena = "Octubre";
             break;

            case 11:
             mesCadena = "Noviembre";
             break;

            case 12:
             mesCadena = "Diciembre";
             break;

            default:
             mesCadena = "";
             Console.WriteLine("Error: Debe ingresar números del 1 al 12");
             break;
            
        }

        Console.WriteLine($"Mes: '{mesCadena}'");

        Console.WriteLine("Ejercicio 2");
        int na, nb, nc;
        Console.WriteLine("Ingrese 3 números mayores a 0: ");
        int.TryParse(Console.ReadLine(), out na);
        int.TryParse(Console.ReadLine(), out nb);
        int.TryParse(Console.ReadLine(), out nc);

        if (na<=0)
        { 
            Console.WriteLine("El número 1 debe ser mayor a 0");
        }

        if (nb<=0)
        { 
            Console.WriteLine("El número 2 debe ser mayor a 0");
        }

        if (nc<=0)
        { 
            Console.WriteLine("El número 3 debe ser mayor a 0");
        }
        if (na>nb)
        { 
            if (na>nc)
            {
                Console.WriteLine($"Resultado: El número '{na}' es mayor a '{nb}' y '{nc}'");
            }
            else if (na==nc)
            {
                Console.WriteLine($"Resultado: El número '{na}' es igual a '{nc}'");
            }
            else
            {
                if (na<nc)
                {
                    Console.WriteLine($"Resultado: El número mayor es '{nc}'");
                }
            }
        }
        else if (na==nb)
        {
            if (na>nc)
            {
                Console.WriteLine($"Resultado: Los números '{na}' y '{nb}' son iguales");
            }
            else if (na==nc)
            {
                Console.WriteLine("Resultado: Todos los números son iguales");
            }
            else if (na<nc)
            { 
                Console.WriteLine($"Resultado: El número '{nc}' es mayor a los números '{na}' y '{nb}'");
            }
        }
        else 
        {
            if (nb>nc)
            {
                Console.WriteLine($"Resultado: El número '{nb}' es mayor a los número '{na}' y '{nc}'");
            }
            else if (nb==nc)
            { 
                Console.WriteLine($"Resultado: Los números '{nb}' y '{nc}' son iguales");
            } 
    
            else if (nb<nc) 
            {
                Console.WriteLine($"Resultado: El número '{nc}' es mayor a los números '{na}' y '{nb}'");
            }
            
    
        }

        Console.WriteLine("Tarea 7");
        int numdia, numaño, nummes;
        string mes, dia, signo, año;
        Console.WriteLine("¿Cuál es el día de su nacimiento?");
        dia=Console.ReadLine();
        Console.WriteLine("¿Cuál es el mes de su nacimiento en números?");
        mes=Console.ReadLine();
        Console.WriteLine("¿Cuál es el año de su nacimiento?");
        año=Console.ReadLine();

        if (int.TryParse(dia, out numdia))
        {
            Console.WriteLine($"Se convirtió '{dia}' a '{numdia}'");
        }
        if (int.TryParse(mes, out nummes))
        {
            Console.WriteLine($"Se convirtió '{mes}' a '{nummes}'");
        }
        if (int.TryParse(año, out numaño))
        {
            Console.WriteLine($"Se convirtió '{año}' a '{numaño}'");
        }


        switch (nummes)
        {
            case 1:
            if (numdia > 20)
            {
                signo = "Acuario";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Capricornio";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 2:
            if (numdia > 18)
            {
                signo = "Picis";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Acuario";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 3:
            if (numdia > 20)
            {
                signo = "Aries";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Picis";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 4:
            if (numdia > 19)
            {
                signo = "Tauro";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Aries";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 5:
            if (numdia > 20)
            {
                signo = "Géminis";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Tauro";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 6:
            if (numdia > 20)
            {
                signo = "Cancer";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Geminis";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 7:
            if (numdia > 22)
            {
                signo = "Leo";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Cancer";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 8:
            if (numdia > 22)
            {
                signo = "Virgo";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Leo";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 9:
            if (numdia > 20)
            {
                signo = "Libra";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Virgo";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 10:
            if (numdia > 20)
            {
                signo = "Escorpio";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Libra";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 11:
            if (numdia > 21)
            {
                signo = "Sagitario";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Escorpio";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

            case 12:
            if (numdia > 21)
            {
                signo = "Capricornio";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            else
            {
                signo = "Sagitario";
                Console.WriteLine($"Su signo zodiacal es '{signo}'");
            }
            break;

        }
        
    }
}