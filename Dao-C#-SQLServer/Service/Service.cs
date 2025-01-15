using Dao_CSharp_SQLServer.Model.Dao;
using Dao_CSharp_SQLServer.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_CSharp_SQLServer.Service
{
    internal class Service
    {
        PessoaDao pessoaDao = DaoFactory.createPessoaDao();

        public void insertPessoa()
        {
            Console.WriteLine("---INSERIR---");
            Console.Write("Insira o nome da Pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Insira a idade da Pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            Pessoa pessoa = new Pessoa(nome, idade);
            pessoaDao.insert(pessoa);
        }

        public void findAllPessoa()
        {
            Console.WriteLine("---LISTAR---");
            pessoaDao.findAll();
        }

        public void findByIdPessoa()
        {
            Console.WriteLine("---ENCONTRAR POR ID---");
            Console.Write("Insira o id que deseja encontrar: ");
            int id = int.Parse(Console.ReadLine());
            pessoaDao.findById(id);
        }

        public void deleteByIdPessoa()
        {
            Console.WriteLine("---REMOVER---");
            Console.Write("Insira o id que deseja remover: ");
            int id = int.Parse(Console.ReadLine());
            pessoaDao.deleteById(id);
        }

        public void updatePessoa()
        {
            Console.WriteLine("---ATUALIZAR---");
            Console.Write("Digite o ID da pessoa que deseja atualizar: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Atualize o nome da Pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Atualize a idade da Pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa { Id = id, Nome = nome, idade = idade };

            pessoaDao.update(pessoa);
        }
    }
}
