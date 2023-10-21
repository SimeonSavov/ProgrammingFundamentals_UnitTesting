int n = int.Parse(Console.ReadLine()); // Count of the product from the console

List<string> products = new List<string>(); // products

for (int index = 1; index <= n; index++)
{
    string product = Console.ReadLine(); // Current product
    products.Add(product); // Add the current product to the List
}

// Full List with products
// Ascending Order by name from A to Z
products.Sort();

int number = 1; // Current number of the product
foreach (string product in products)
{
    Console.WriteLine($"{number}.{product}");
    number++;
}