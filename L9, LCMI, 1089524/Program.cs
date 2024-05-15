using System;

class Automovil
{
    private int modelo;
    private double precio;
    private string marca;
    private bool disponible;
    private double tipoCambioDolar;
    private double descuentoAplicado;
    public Automovil()
    {
        modelo = 2019;
        precio = 10000.00;
        marca = "";
        disponible = false;
        tipoCambioDolar = 7.50;
        descuentoAplicado = 0.00;
    }
    public void IngresarDatos()
    {
        Console.WriteLine("Ingrese el modelo del automóvil:");
        modelo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el precio del automóvil en quetzales:");
        precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la marca del automóvil:");
        marca = Console.ReadLine();
        Console.WriteLine("Ingrese el tipo de cambio de dólar a quetzales:");
        tipoCambioDolar = Convert.ToDouble(Console.ReadLine());
    }
    public void MostrarDatos()
    {
        Console.WriteLine("Datos del automóvil:");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Precio en quetzales {precio}: ");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Disponibilidad: {disponible}");
        Console.WriteLine($"Cambio de dólar a quetzales: {tipoCambioDolar}");
        Console.WriteLine($"Descuento aplicado: {descuentoAplicado}");
    }
    public void CambiarDisponibilidad()
{
    Console.WriteLine($"¿Desea cambiar disponibilidad a true/false? (Disponibilidad actual: {disponible})");
    string respuesta = Console.ReadLine().ToLower(); 
    if (respuesta == "true")
    {
        disponible = true;
        Console.WriteLine("Se ha cambiado la disponibilidad correctamente");
    }
    else if (respuesta == "false")
    {
        disponible = false;
        Console.WriteLine("Se ha cambiado la disponibilidad correctamente");
    }
    else
    {
        Console.WriteLine("No se ha realizado ningún cambio en la disponibilidad debido a que su respuesta no es válida");
    }
}
    public void AplicarDescuento()
    {
        Console.WriteLine("Ingrese el monto del descuento a aplicar:");
        double descuento = Convert.ToDouble(Console.ReadLine());
        if (descuento >= 0 && descuento <= precio)
        {
            precio -= descuento;
            descuentoAplicado = descuento;
            Console.WriteLine("El descuento se ha aplicado correctamente");
        }
        else
        {
            Console.WriteLine("No se ha aplicado ningún descuento debido a que el descuento no es válido");
        }
    }
class Program
{
    static void Main(string[] args)
    {
        Automovil objAutomovil = new Automovil();
        objAutomovil.IngresarDatos();
        objAutomovil.MostrarDatos();
        objAutomovil.CambiarDisponibilidad();
        objAutomovil.MostrarDatos();
        objAutomovil.AplicarDescuento();
        objAutomovil.MostrarDatos();
    }
}
}