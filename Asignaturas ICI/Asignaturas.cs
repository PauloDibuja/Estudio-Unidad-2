using System;

abstract class Asignaturas{
    // Atributos
    private string nombre;
    private string codigo;
    private int creditos;

    // Constructores

    public Asignaturas(string nombre, string codigo, int creditos){
        this.nombre = nombre;
        this.codigo = codigo;
        this.creditos = creditos;
    }

    public string GetNombre(){
        return this.nombre;
    }

    public string GetCodigo(){
        return this.codigo;
    }

    public abstract void areaDominio();
}