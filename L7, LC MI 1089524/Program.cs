using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int NFibonacci;
        bool conversion = false;
        bool npositivo = false;

        
        do 
        {
            Console.WriteLine("Ingrese un número mayor a 0");
            conversion = int.TryParse(Console.ReadLine(), out NFibonacci);
            if (conversion)
            {
                if (NFibonacci > 0)
                {
                    npositivo = true;
                }
            }
        }
        while(!conversion || !npositivo);

        Console.WriteLine("Ejercicio Serie Fibonacci");
        
        int a = 0;
        int b = 1;
        int c = 0;
        int i =2;
        string resultado ="";
        int result;
       
        if (conversion)
        {
            if (NFibonacci>0)
            {
                int.TryParse(resultado, out result);
                result=a;
                Console.WriteLine($"{result}");

                if (NFibonacci > 1)
                {
                    int.TryParse(resultado, out result);
                    result = b;
                    Console.WriteLine($"{result}");

                    while (i<NFibonacci)
                    {
                        int.TryParse(resultado, out result);
                        c=a+b;
                        result = c;
                        a=b;
                        b=c;
                        i++;
                        Console.WriteLine($"{result}");
                    }
                }
                else 
                {
                    Console.WriteLine("Error"+ resultado);
                }
               
            }
        }

        Console.WriteLine("Tarea");
        int N;
        double I=1;
        double res;
        double fin=0;
        Console.WriteLine("Ingrese un número mayor a 0: ");
        N=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Serie A");
        do{
            Console.Write($"1/{I} + ");
            res=1/I;
            fin=fin+res;
            I++;
        }
        while (I<=N);
        Console.WriteLine($"{fin}");
         Console.WriteLine("");
        Console.WriteLine("Serie B");
        double cont= 1;
        double rest;
        double finale=0;

        do{
            Console.Write($"1/2^{cont} + ");
            rest=1/Math.Pow(2, cont);
            finale=finale+rest;
            cont++;
        }
        while (cont<=N);

        Console.WriteLine($"{finale}");
        
        Console.WriteLine("Serie C ");
        int x;
        int A;
        int num;
        double r=0;
        double fl=0;
        int k=0;
        Console.WriteLine("Ingrese un número x: ");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese un número a: ");
        A=Convert.ToInt32(Console.ReadLine());;

        while (k<=N)
        
        do
         {
            r= Math.Pow(x, k) * Math.Pow(A, (N - k));
            fl=fl+r;
            k++;
        }
            while (k<=N);
            Console.WriteLine($"{fl}");
    
        
    }

   
}