Example of group by with LINQ and Lambda.

For same work both the syntax are given, LINQ and Lambda.

```csharp
var resultsLinq = from product in products
                  group new { product.QTY } by product.ProductId into prdGroup
                  let qtySum = prdGroup.Sum(t => t.QTY)
                  orderby prdGroup.Key
                  select new { ProdyctId = prdGroup.Key, QtySum = qtySum };
```

```csharp
var resultsLamda = products
    .GroupBy(test => test.ProductId)
    .Select(prdGroup => new { ProdyctId = prdGroup.Key, QtySum = prdGroup.Sum(t => t.QTY) })
    .OrderBy(prdGroup => prdGroup.ProdyctId);
```
