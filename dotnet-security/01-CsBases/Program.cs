using CsBases;
using CsBases.Services;

WriteLine("Hello, World!");

var laptop = new Product("Laptop", 1200);
var soporte = new ProductService("Soporte Técnico", 300, 30);

WriteLine(laptop.GetDescription());
WriteLine(soporte.GetDescription());