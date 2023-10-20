using System;

class NumeroNatural{
    // Atributos
    private int valor;

    // Constructores

    public NumeroNatural(){
        Console.WriteLine("OH, se ha creado un número natural. :D");
    }

    public NumeroNatural(int a){
        if(NumeroValido(a) == true){
            this.valor = a;
        }else{
            this.valor = 1;
        }
        Console.WriteLine($"Oh se ha creado un número natural de valor {this.valor}");
    }

    public NumeroNatural(int a, int b){
        if(NumeroValido(a+b) == true){
            this.valor = a+b;
        }else{
            this.valor = 1;
        }
        Console.WriteLine($"Oh se ha creado un número natural de valor {this.valor}");
    }

    // Para ahorrar código
    public bool NumeroValido(int num){
        if(num <= 0){
            Console.WriteLine("Número no válido");
            return false;
        }
        return true;
    }

    // Métodos
    public int GetValor(){
        return this.valor;
    }

    public void SetValor(int num){
        if(NumeroValido(num) == false) return;
        this.valor = num;
    }

    public void Suma(int num){
        if(NumeroValido(num) == false) return;
        this.valor = this.valor + num;
    }

    public void Resta(int num){
        if(NumeroValido(num) == false) return;
        if(num > this.valor){
            Console.WriteLine("No puedes restar, porque un número más grande.");
            return;
        }
        this.valor = this.valor - num;
    }

    public void Multiplicar(int num){
        if(NumeroValido(num) == false) return;
        this.valor = this.valor * num;
    }

    public bool EsPar(){
        if(this.valor % 2 == 0){
            return true;
        }
        else{
            return false;
        }
    }

    public bool Collatz(){
        int resultado = this.valor;
        while(resultado != 1){
            // Si el numero es par: num / 2
            // Si el numero es impar: 3 * num + 1
            if(resultado % 2 == 0){
                resultado = resultado/2;
            }else{
                resultado = (3 * resultado) + 1;
            }
        }
        return true;
    }
}