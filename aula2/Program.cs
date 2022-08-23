using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaração de instanciação de objeto
            Cliente cli = new Cliente();
            Produto prod = new Produto();
            Pedido ped = new Pedido();

            Console.Write("Nome: ");
            cli.setNome(Console.ReadLine());
            Console.Write("CPF: ");
            cli.setCpf(Console.ReadLine());
            Console.Write("Endereço: ");
            cli.setEndereco(Console.ReadLine());
            Console.Write("Idade: ");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descrição do produto: ");
            prod.setDescricao(Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());
            Console.Write("Número do pedido: ");
            ped.setNumero(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Quantidade de itens: ");
            ped.setQuantidade(Convert.ToInt32(Console.ReadLine()));
            ped.setTotal(ped.getQuantidade() * prod.getValor());
            Console.WriteLine("Nome: " + cli.getNome() + "\nCPF: " + cli.getCpf() + "\nEndereço: " +
                cli.getEndereco() + "\nIdade: " + cli.getIdade() + "\nCódigo = " + prod.getCodigo() + 
                "\nDescrição = " + prod.getDescricao() + "\nValor = " + prod.getValor().ToString("C") + 
                "\nCategoria = " + prod.getCategoria());

            Console.WriteLine("Pedido Nº" + ped.getNumero() + "\n" + ped.getQuantidade() + " itens" +
                "\nTotal " + (ped.getTotal().ToString("C")));

            Console.ReadKey();
        }
    }
}
