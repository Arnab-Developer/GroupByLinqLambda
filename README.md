# Group By in LINQ and Lambda

Example of group by with LINQ and Lambda in C#.

For same work both the syntaxes are given, LINQ and Lambda.

```csharp
// Using LINQ
var resultsLinq = from product in products
                  group new { product.QTY } by product.ProductId into prdGroup
                  let qtySum = prdGroup.Sum(t => t.QTY)
                  orderby prdGroup.Key
                  select new { ProdyctId = prdGroup.Key, QtySum = qtySum };
                  
// Using Lambda                  
var resultsLamda = products
    .GroupBy(test => test.ProductId)
    .Select(prdGroup => new { ProdyctId = prdGroup.Key, QtySum = prdGroup.Sum(t => t.QTY) })
    .OrderBy(prdGroup => prdGroup.ProdyctId);
```
