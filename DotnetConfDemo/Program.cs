using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetConfDemo.Data;
using DotnetConfDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetConfDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            //paging is performed directly on server
            using var context = new SalesContext();
            var products = context.Products.Skip(0).Take(10).ToList();
            products.ForEach(WriteLine);
        }


        private static void WriteLine(Product product)
        {
            Console.WriteLine($"product {product.Name}");
        }
    }
}
