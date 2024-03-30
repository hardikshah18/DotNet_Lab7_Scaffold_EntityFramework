using Week11.Models.Entities;


var dbContext = new MMABooksContext();

var customers = dbContext.Customers;

Console.WriteLine("Customer Names:\n");

foreach (var customer in customers)

{

    Console.WriteLine(customer.Name);

}