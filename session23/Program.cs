using Newtonsoft.Json;
using session23;

Product product = new Product();

product.Name = "Apple";
product.ExpirationDate = new DateTime(2008, 12, 28);
product.Price = 3.99M;
product.Sizes = new string[] { "Small", "Medium", "Large" };

string output = JsonConvert.SerializeObject(product);

Console.WriteLine(output);
//{
//  "Name": "Apple",
//  "ExpiryDate": "2008-12-28T00:00:00",
//  "Price": 3.99,
//  "Sizes": [
//    "Small",
//    "Medium",
//    "Large"
//  ]
//}

Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);

Console.WriteLine("Objeto deserializado");
Console.WriteLine(deserializedProduct.Name);
