using GroupByLinqLambda.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupByLinqLambda.ConsoleApp.Services
{
    internal class LambdaDemo
    {
        public static void ShowProducts(IList<Product> products)
        {
            var resultsLamda = products
                .GroupBy(test => test.ProductId)
                .Select(prdGroup => new { ProdyctId = prdGroup.Key, QtySum = prdGroup.Sum(t => t.QTY) })
                .OrderBy(prdGroup => prdGroup.ProdyctId);

            Console.WriteLine("Lambda result: ");
            foreach (var resultLamda in resultsLamda)
            {
                Console.WriteLine($"Product id: {resultLamda.ProdyctId} Qty sum: {resultLamda.QtySum}");
            }
            Console.WriteLine("\n");
        }
    }
}
