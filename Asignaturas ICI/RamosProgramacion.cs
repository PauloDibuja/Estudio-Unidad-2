using System;

class RamosProgramacion : Asignaturas{
    // Atributos
    private string lenguajeProgra;

    // Constructor

    public RamosProgramacion(string nombre, string codigo, int creditos, string lenguajeProgra) : base(nombre, codigo, creditos)
    {
        this.lenguajeProgra = lenguajeProgra;
    }

    public string GetLenguaje(){
        return this.lenguajeProgra;
    }

    public override void areaDominio(){
        Console.WriteLine("Area de dominio: " + this.lenguajeProgra);
    }
}