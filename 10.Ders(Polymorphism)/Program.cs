

using _10.Ders_Polymorphism_.Classes;

//Chocolate chocolate = new Chocolate();
//chocolate.DisplayInfo();

//// Coffe ve Pizza classlarinda  gelen displayInfo metodu Product amma Chocolate icerisinde ozune mexsus olsun
//Coffee coffee = new Coffee();
//coffee.DisplayInfo();

//Pizza pizza =  new Pizza(); 
//pizza.DisplayInfo();


//Americano americano = new Americano();
//americano.Id = 1;
//americano.Size = 20;

//americano.DisplayInfo();


// Polymorphism özlüyündə bir tipdən bir classın bir neçə tipdə olan class-larda obyekt yarada bilməsi
// Polymorphism sözünü mənası çox şəkillilik demekdir

Product chocolate = new Chocolate();
Product pizza = new Pizza();
Product coffee = new Coffee();
Product americano = new Americano();

pizza.DisplayInfo();
chocolate.DisplayInfo();


//Product[] products = 
//    [
//        new Chocolate { Name = "Alpen Gold" },
//        new Pizza { Name = "Pepperoni" },
//        new Coffee { Name = "Latte" },
//        new Americano { Name = "Americano" }
//    ];

//foreach (Product product in products)
//{
//    Console.WriteLine(product.Name);
//}


DisplayMessageAndName(new Chocolate { Name = "Albeni" });
DisplayMessageAndName(new Pizza { Name = "Qarisiq" });
//void DisplayMessageAndIdChocolate(Chocolate chocolate)
//{
//    Console.WriteLine(chocolate.Name);
//    chocolate.DisplayInfo();
//}

//void DisplayMessageAndIdCoffe(Coffee coffee)
//{
//    Console.WriteLine(coffee.Name);
//    coffee.DisplayInfo();
//}

void DisplayMessageAndName(Product product)//product = new Chocolate { Name = "Albeni" }
{
    Console.WriteLine(product.Name);
    product.DisplayInfo();
}