class Program 
{
    static void Main (string[] args)
    {
        string nombre;

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola " + nombre);

        Console.WriteLine("Parte 2: ej 1");
        int dato1, dato2;
        int sum, rest, mult, división, mod;
        Console.WriteLine("Ingrese un número:");
        dato1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        dato2= Int32.Parse(Console.ReadLine());
         sum= dato1 +dato2;
         Console.WriteLine("El resultado de " + dato1 + " + " +dato2 + " es: " + sum);
         rest= dato1 - dato2;
         Console.WriteLine("El resultado de " + dato1 + " - " +dato2 + " es: " + rest);
         mult= dato1 * dato2;
         Console.WriteLine("El resultado de " + dato1 + " * " +dato2 + " es: " + mult);
         división= dato1 / dato2;
         Console.WriteLine("El resultado de " + dato1 + " / " +dato2 + " es: " + división);
         mod= dato1 % dato2;
         Console.WriteLine("El resultado de " + dato1 + " % " +dato2 + " es: " + mod);

         Console.WriteLine("Ejercicio 2: operaciones booleanas");
         Console.WriteLine(dato1 + "<" + dato2 + "es" + (dato1<dato2));
         Console.WriteLine(dato1 + ">" + dato2 + "es" + (dato1>dato2));
         Console.WriteLine(dato1 + "=" + dato2 + "es" + (dato1==dato2));


        Console.WriteLine ("Parte 3: ej 1");
        int num1, num2, num3;
        int a, b, c, d;
        Console.WriteLine("Ingrese un número: ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        num3 = Int32.Parse(Console.ReadLine());

        a= num1*num2 + num3;
        Console.WriteLine("El resultado es: " + a);
        b= num1*(num2+num3);
        Console.WriteLine("El resultado es: " + b);
        c=((num1)/(num2*num3));
        Console.WriteLine("El resultado es: " + c);
        d= ((3*num1+2*num2)/(num3*num3));
        Console.WriteLine("El resultado es: " + d);

        Console.WriteLine ("Parte 4: ej 1");
        double numa, numb, numc, partea, parteb, operacion, partec, parted, partee;
        Console.WriteLine("Ingrese un número: ");
        numa=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        numb=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        numc=Int32.Parse(Console.ReadLine());
       

        
        partea= ((numb*numb)- (4*numa*numc));
        if (numa != 0 && partea>=0)
        {
            operacion= Math.Sqrt(partea);
            partec= ((-numb)+operacion);
            parteb=((-numb)-operacion);
            parted= ((partec)/(2 * numa));
            partee=((parteb)/(2*numa));
            Console.WriteLine("El resultado A es: " + parted +"," + partee);
        }

        else 
         
        if (partea <= 0)
        {
            Console.WriteLine ("No se puede realizar la operación.");
        }
        if (numa==0)
        {
            Console.WriteLine("No se puede realizar la operación");
        }

        
    }
}

