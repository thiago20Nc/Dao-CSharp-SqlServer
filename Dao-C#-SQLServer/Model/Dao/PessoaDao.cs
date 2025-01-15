using Dao_C__SQLServer.Context;
using Dao_CSharp_SQLServer.Model.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dao_CSharp_SQLServer.Model.Dao 
{
    internal class PessoaDao : IPessoaDaoInterface
    {
        public readonly DbContext _context;

        public PessoaDao()
        {
        }

        public PessoaDao(DbContext context) 
        { 
            _context = context;
        }
        
        public void deleteById(int id)
        {
            using (var context = new DBContext())
            {
                try
                {
                    var pessoa = context.pessoas.FirstOrDefault(p => p.Id == id);

                    if (pessoa != null) 
                    {
                        context.pessoas.Remove(pessoa);
                        context.SaveChanges();
                        Console.WriteLine("Pessoa deletada com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao deletar dados: " + e.Message);
                }
            }
        }

        public List<Pessoa> findAll()
        {
            using (var context = new DBContext())
            {
                try
                {
                    var pessoas = context.pessoas.ToList();

                    if (pessoas.Any()) 
                    { 
                        foreach(var pessoa in pessoas)
                        {
                            Console.WriteLine($"Id: {pessoa.Id}, Nome: {pessoa.Nome}, Idade: {pessoa.idade}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não há pessoas cadastradas.");
                    }
                    return pessoas;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao encontrar dados: " + e.Message); 
                    return new List<Pessoa>();
                }
            }
        }

        public void findById(int id)
        {
            using (var context = new DBContext())
            {
                try
                {
                    var pessoa = context.pessoas.FirstOrDefault(p => p.Id == id);

                    if (pessoa != null)
                    {
                            Console.WriteLine($"Pessoa encontrada: " +
                                $"Id: {pessoa.Id}, Nome: {pessoa.Nome}, Idade: {pessoa.idade}");
                    }
                    else
                    {
                        Console.WriteLine("Não há pessoas cadastradas.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao encontrar dados: " + e.Message);
                }
            }
        }

        public void insert(Pessoa obj)
        {
            using(var context = new DBContext()) 
            {
                try
                {
                    context.pessoas.Add(obj);
                    context.SaveChanges();
                    Console.WriteLine("Pessoa inserida com sucesso.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao inserir dados: " + e.Message);
                }
            } 
        }

        public void update(Pessoa obj)
        {
            using (var context = new DBContext())
            {
                try
                {
                    var pessoa = context.pessoas.FirstOrDefault(p => p.Id == obj.Id);

                    if (pessoa != null) 
                    {
                        pessoa.Nome = obj.Nome;
                        pessoa.idade = obj.idade; 

                        context.pessoas.Update(pessoa);
                        context.SaveChanges();
                        Console.WriteLine("Pessoa atualizada com sucesso.");
                    } 
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao atualizar dados: " + e.Message);
                }
            }
        }
    }
}
