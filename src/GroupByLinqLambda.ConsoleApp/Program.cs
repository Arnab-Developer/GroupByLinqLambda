using GroupByLinqLambda.ConsoleApp.Models;
using GroupByLinqLambda.ConsoleApp.Services;
using System.Collections.Generic;

IList<Product> products = new List<Product>
{
    new Product { ProductId = 1, QTY = 10 },
    new Product { ProductId = 1, QTY = 20 },
    new Product { ProductId = 1, QTY = 30 },
    new Product { ProductId = 2, QTY = 40 },
    new Product { ProductId = 2, QTY = 50 },
    new Product { ProductId = 3, QTY = 5 },
    new Product { ProductId = 3, QTY = 10 },
    new Product { ProductId = 4, QTY = 66 },
    new Product { ProductId = 4, QTY = 3 }
};

LinqDemo.ShowProducts(products);
LambdaDemo.ShowProducts(products);