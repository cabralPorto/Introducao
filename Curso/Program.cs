using System;
using System.Collections.Generic;
using System.Linq;
using CursoEFCore.Domain;
using CursoEFCore.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
           //InserirDados();
           InserirDadosEmMassa();
        }

        private static void InserirDadosEmMassa()
        {   
            var produto = new Produto
            {
                 Descricao = "Produto Teste",
                 CodigoBarras = "010203040506",
                 Valor =90000m,
                 TipoProduto = TipoProduto.MercadoriaParaRevenda,
                 Ativo = true
            };
           
           var cliente = new Cliente
            {
                Nome = "Ronaldo",
                Telefone = "02122232425",
                Cep = "11710040",
                Estado = "SP",
                Cidade = "Praia Grande"

            }; 
            var listaClientes = new []
            {
                new Cliente
                {
                Nome = "Ana Julia",
                Telefone = "9897969594",
                Cep = "11710040",
                Estado = "SP",
                Cidade = "Praia Grande"

                },
                new Cliente
                {
                Nome = "Beatriz",
                Telefone = "02122232425",
                Cep = "11710040",
                Estado = "SP",
                Cidade = "Praia Grande",
                    
                },

            };
            using var db = new Data.ApplicationContext();
           // db.AddRange(produto, cliente);
              db.Clientes.AddRange(listaClientes);
             
            var registros = db.SaveChanges();
             Console.WriteLine($"Total Registros (S): {registros}");
        }         
        private static void InserirDados()
        {
            var produto = new Produto
            {
                 Descricao = "Teste Produto",
                 CodigoBarras = "11121212191",
                 Valor =100m,
                 TipoProduto = TipoProduto.MercadoriaParaRevenda,
                 Ativo = true
            };
            using var db = new Data.ApplicationContext();
            //db.Produtos.Add(produto);
            //db.Set<Produto>.Add(produto);
            //db.Entry(produto).State = EntityState.Added;
            db.Add(produto);

            var registros = db.SaveChanges();
            Console.WriteLine($"Total Registros (S): {registros}");

        }
    }
}
