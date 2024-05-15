class Personaje
{
    int x=0;
    int y=0;

    public int Getx()
    {
        return x;
    }
    public int Gety()
    {
        return y;
    }
    public Personaje(int x, int y)
    {
        this.x=x;
        this.y=y;
    }

   public void MoverArriba(int cantidad)
    {
        y+= cantidad;
    }

   public void MoverAbajo(int cantidad)
    {
        y-= cantidad;
    }

   public void MoverhacialaDerecha (int cantidad)
    {
        x+= cantidad;
    }

    public void MoverhacialaIzquierda (int cantidad)
    {
        x-= cantidad;
    }
    
}