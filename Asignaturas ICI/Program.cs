class Program{
    static void Main(string[] args){
        RamosCiencias calculo = new RamosCiencias("Cálculo I", "INF-112", 8, "Stewart: Cálculo de una variable");
        RamosProgramacion progra = new RamosProgramacion("Programación I", "INF-115", 6, "Python");

        // Cálculo

        calculo.Aplicacion();
        calculo.areaDominio();

        // Programación

        progra.areaDominio();
        Console.WriteLine($"Están programando en {progra.GetLenguaje()}");

    }
}