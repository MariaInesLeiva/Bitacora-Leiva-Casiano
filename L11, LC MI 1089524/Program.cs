using System.Net;

class Program 
{
    static void Main(string[] args)
    { 
        string opcion;

        Personaje personaje=new Personaje(0,0);
      do {
        Console.WriteLine("Menú de opciones");
        Console.WriteLine("a. Sube");
        Console.WriteLine("b. Baja");
        Console.WriteLine("c. Izquierda");
        Console.WriteLine("d. Derecha");
        Console.WriteLine("e. Salir");
        Console.WriteLine("Ingrese la opción");

        opcion=Console.ReadLine();

    
        switch(opcion)
        {
            case "a":
             
             personaje.MoverArriba(LeerCantidad("arriba"));
             break;

            case "b":
             personaje.MoverAbajo(LeerCantidad("abajo"));
             break;

            case "c":
             personaje.MoverhacialaIzquierda(LeerCantidad("izquierda"));
             break;

            case "d":
             personaje.MoverhacialaDerecha(LeerCantidad("derecha"));
             break;

            case "e":
             Console.WriteLine("Coordenadas finales del personaje:"+personaje.Getx() +", "+personaje.Gety());
             break;

        
        }} while(opcion!="e");
        
    }
    
    static int LeerCantidad(string direccion)
    {
        Console.WriteLine("Ingrese la cantidad a moverse hacia (dirección):");
        int cantidad = int.Parse(Console.ReadLine());
        return cantidad;
    }
}