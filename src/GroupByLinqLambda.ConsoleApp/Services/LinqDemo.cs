using GroupByLinqLambda.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupByLinqLambda.ConsoleApp.Services
{
    internal class LinqDemo
    {
        public static void ShowProducts(IList<Product> products)
        {
            var resultsLinq = from product in products
                              group new { product.QTY } by product.ProductId into prdGroup
                              let qtySum = prdGroup.Sum(t => t.QTY)
                              orderby prdGroup.Key
                              select new { ProdyctId = prdGroup.Key, QtySum = qtySum };

            Console.WriteLine("Linq result: ");
            foreach (var resultLinq in resultsLinq)
            {
                Console.WriteLine($"Product id: {resultLinq.ProdyctId} Qty sum: {resultLinq.QtySum}");
            }
            Console.WriteLine("\n");
        }
    }
}
