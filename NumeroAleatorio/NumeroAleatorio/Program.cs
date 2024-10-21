// Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.

Random aleatorio = new();
int numeroSecreto = aleatorio.Next(1, 101);

void jogoNumero(int numeroSecreto)
{
    do
    {
        Console.Write("Digite um número entre 1 e 100: ");
        int chute = int.Parse(Console.ReadLine());

        if (chute == numeroSecreto)
        {
            Console.WriteLine("Parabéns! Você acertou o número.");
            break;
        }
        else if (chute < numeroSecreto)
        {
            Console.WriteLine("O número é maior.");
        }
        else
        {
            Console.WriteLine("O número é menor.");
        }

    } while (true);
}

jogoNumero(numeroSecreto);




