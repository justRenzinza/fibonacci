using System;

class Program
{
    static void Main(){
        Console.Write("Digite um número para a verificação: ");
        
        int numeroDigitado = int.Parse(Console.ReadLine());

        if (fibonacci(numeroDigitado)){
            Console.WriteLine($"O número {numeroDigitado} pertece a sequência de fibonacci.");
        }
        else{
            Console.WriteLine($"O número {numeroDigitado} não pertence a sequência de fibonacci.");
        }
    }


    static bool fibonacci(int numeroDigitado){
        // aqui temos que inicializar com 0 e 1 pois esses são os primeiros números da sequência de fibonacci
        int primeiroNumero = 0, segundoNumero = 1;

        while (primeiroNumero <= numeroDigitado){
            // esse if funciona como um "tratamento de erro" para quando a pessoa digitar 0
            if (primeiroNumero == numeroDigitado){
                return true;
            }

            // lógica da sequência de fibonacci
            int temporario = primeiroNumero;
            primeiroNumero = segundoNumero;
            segundoNumero = temporario + segundoNumero;
        }

        return false;
    }
}