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
           InserirDados();
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
