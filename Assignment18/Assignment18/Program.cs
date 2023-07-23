using Assignment18;

var products1 = new List<Product>()
{
    new Product() { Id = 1, Name = "Kakali", Price = 12, ShopId = 1},
    new Product() { Id = 2, Name = "Mzesumzira", Price = 12, ShopId = 1 },
    new Product() { Id = 3, Name = "Dzexvi", Price = 20, ShopId = 2 },
    new Product() { Id = 4, Name = "Ananasi", Price = 3, ShopId = 6 },
    new Product() { Id = 5, Name = "Banani", Price = 2, ShopId = 1 },
    new Product() { Id = 6, Name = "Pomidori", Price = 2, ShopId = 2 },
    new Product() { Id = 7, Name = "Kitri", Price = 3, ShopId = 1 },
    new Product() { Id = 8, Name = "Zeti", Price = 12, ShopId = 4 },
    new Product() { Id = 9, Name = "Mafini", Price = 20, ShopId = 6 },
    new Product() { Id = 10, Name = "Mawoni", Price = 5, ShopId = 3 },
    new Product() { Id = 10, Name = "Mawoni", Price = 5, ShopId = 3 },
    new Product() { Id = 10, Name = "Mawoni", Price = 5, ShopId = 3 },
};
var products2 = new List<Product>()
{
    new Product() { Id = 11, Name = "Msxali", Price = 12, ShopId = 6 },
    new Product() { Id = 11, Name = "Msxali", Price = 12, ShopId = 6 },
    new Product() { Id = 11, Name = "Msxali", Price = 12, ShopId = 6 },
    new Product() { Id = 11, Name = "Msxali", Price = 12, ShopId = 6 },
    new Product() { Id = 12, Name = "puri", Price = 1, ShopId = 1 },
    new Product() { Id = 13, Name = "Dzexvi", Price = 20, ShopId = 2 },
    new Product() { Id = 14, Name = "Ananasi", Price = 3, ShopId = 1 },
    new Product() { Id = 15, Name = "Banani", Price = 2, ShopId = 6 },
    new Product() { Id = 16, Name = "Pomidori", Price = 2, ShopId = 1 },
    new Product() { Id = 17, Name = "Fortoxali", Price = 3, ShopId = 2 },
    new Product() { Id = 18, Name = "Maionezi", Price = 8, ShopId = 4 },
    new Product() { Id = 19, Name = "Mafini", Price = 20, ShopId = 1 }
};
var shop1 = new List<Shop>()
{
    new Shop() { Id = 1, Name = "OriNabiji" },
    new Shop() { Id = 2, Name = "Spari" },
    new Shop() { Id = 3, Name = "Magniti" }
};
var shop2 = new List<Shop>()
{
    new Shop() { Id = 4, Name = "SamiNabiji" },
    new Shop() { Id = 2, Name = "Spari" },
    new Shop() { Id = 6, Name = "Fresko" }
};


//ProductUnionMethod();
//ProducUnionQuery();
//ProductJoinShopMethod();
//ProductJoinShopQuery();
//ProductGrouJoinMethod();
//ProductGrouJoinQuery();
//ProductGroupByMethod();
//ProductGroupByQuery();
//ProductGroupByMultipleMethod();
//ProductGroupByMultipleQuery();
//ProductGroupAgregateMethod(); 
//ProductGroupAgregateQuery();

void ProductUnionMethod()
{
    var result = products1.Union(products2, new ProductComparer());
    // or
    result = products1.UnionBy(products2, x => x.Name);

    foreach (var product in result)
    {
        Console.WriteLine(product.Id + "\t" + product.Name + " : " + product.Price);
    }
}

void ProducUnionQuery()
{
    var result = (from prod1 in products1 select prod1).Concat(from prod2 in products2 select prod2).DistinctBy(x => x.Name);

    foreach (var product in result)
    {
        Console.WriteLine(product.Id + "\t" + product.Name + " : " + product.Price);
    }
}

void ProductJoinShopMethod()
{
    var result = products1.Join(shop1, p => p.ShopId, s=> s.Id, (p, s) => new {shopName = s.Name, prodName = p.Name} );
    foreach (var item in result)
    {
        Console.WriteLine(item.shopName + "\n\t " + item.prodName );
    }
}

void ProductJoinShopQuery()
{
    var result = from prod in products2 
                               join shop in shop2 on prod.ShopId equals shop.Id
                               select new { shopName = shop.Name, prodName = prod.Name };
    foreach (var item in result)
    {
        Console.WriteLine(item.shopName + "\n\t" + item.prodName);
    }
}

void ProductGrouJoinMethod()
{
    var result = shop2.GroupJoin(products2,
        shop => shop.Id,
        product => product.ShopId,
        (shop, shopProducts) => new
        {
            Shop = shop,
            Products = shopProducts.ToList(),
        });

    foreach (var item in result)
    {
        Console.WriteLine(item.Shop.Name);
        foreach (var product in item.Products)
        {
            Console.WriteLine("\t"+ product.Name);
        }
    }

}
void ProductGrouJoinQuery()
{
    var result = from shop in shop2
                 join product in products2
                 on shop.Id equals product.ShopId into shopProducts
                 select new
                 {
                     Shop = shop,
                     Product = shopProducts.ToList(),
                 };

    foreach (var item in result)
    {
        Console.WriteLine(item.Shop.Name);
        foreach (var product in item.Product)
        {
            Console.WriteLine("\t" + product.Name);
        }
    }
}

void ProductGroupByMethod()
{
    var result = products1.GroupBy(x => x.Price);

    foreach (var price in result)
    {
        Console.WriteLine(price.Key);
        foreach (var product in price)
        {
            Console.WriteLine("\t" + product.Name );

        }
    }
}

void ProductGroupByQuery()
{
    var result = from product in products2 
                 group product by product.Price
                 into group1
                 select group1;

    foreach (var price in result)
    {
        Console.WriteLine(price.Key);
        foreach (var product in price)
        {
            Console.WriteLine("\t" + product.Name);

        }
    }
}

void ProductGroupByMultipleMethod()
{
    var result = products1.GroupBy(x => new { x.Price, x.Name });

    foreach (var condit in result)
    {
        Console.WriteLine(condit.Key.Price + " and " + condit.Key.Name);
        foreach (var product in condit)
        {
            Console.WriteLine("\t" + product.Name);

        }
    }
}

void ProductGroupByMultipleQuery()
{
    var result = from product in products2
                 group product by new { product.Price, product.Name }
                 into group1
                 select group1;

    foreach (var condit in result)
    {
        Console.WriteLine(condit.Key.Price + " and " + condit.Key.Name);
        foreach (var product in condit)
        {
            Console.WriteLine("\t" + product.Name);

        }
    }
}

void ProductGroupAgregateMethod()
{
    var result = products1.GroupBy(x => new { x.Price },
            (key, group) => new
            {
                Name = string.Join(", ", group.Select(x=> x.Name)),
                TotalPrice = group.Sum(product => product.Price),
            });
    foreach (var pr in result)
    {
        Console.WriteLine(pr.TotalPrice+ " - " + pr.Name);
    }
}

void ProductGroupAgregateQuery()
{
    var result = from prod in products1 
                 group prod by new { prod.Price } into group1
                 select new
                 {
                     Name = string.Join(", ", group1.Select(x=> x.Name)),
                     TotalPrice = group1.Sum(product => product.Price),
                 };
    foreach (var pr in result)
    {
        Console.WriteLine(pr.TotalPrice + " - " + pr.Name);
    }
}