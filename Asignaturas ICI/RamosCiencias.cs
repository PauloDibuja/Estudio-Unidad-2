using System;

class RamosCiencias : Asignaturas{
    private string libroRecomendado;

    // Constructor
    public RamosCiencias(string nombre, string codigo, int creditos, string libroRecomendado) : base(nombre, codigo, creditos) {
        this.libroRecomendado = libroRecomendado;
    }

    public void Aplicacion(){
        Console.WriteLine("Aplicación de la asignatura: " + GetNombre() + " con libro: " + this.libroRecomendado);
    }

    public override void areaDominio(){
        Console.WriteLine("Área de la asignatura: " + GetNombre() + ": Ciencias Básicas");
    }
}