using System;
using Aula05.Ex3.Models;
namespace Aula05.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola bem vindo a lojinha");

            //Instanciar um produto, o perecivel, o livro e um eletronico
            var produto = new Produto(1, "Papel");
            var livro = new Livro(2, "Seja fo%#£ com Python", "André")
            {
                Preco = 100
            };
            var eletronico = new Eletronico(3, "Iphone",true)
            {
                Preco = 5000,
                Garantia = true
            };
            
            //Utiliza o construtor do object, há varias opções na literatura. (ano, mes, dia)
            var perecivel = new Perecivel(4, "Arroz", new DateTime(2022,12,25));

            //Chamar o método para calcular o desconto

            Console.WriteLine($"O desconto minimo do livro é de {livro.CalcularDesconto()}");
            Console.WriteLine($"O valor do desconto do livro é de {livro.CalcularDesconto(20)}");
            Console.WriteLine($"O valor do desconto com cupom é de {livro.CalcularDesconto("fiap10")}");



            //Chamar o método para calcular o valor de garantia

            Console.WriteLine($"A garantia só para eletronicos é de {eletronico.CalcularGarantia()}");
        }
    }
}
