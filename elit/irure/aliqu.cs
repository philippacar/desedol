// Create a Repository object with some TestClass objects
Repository<TestClass> repo = new Repository<TestClass>();
repo.Add(new TestClass("Alice", 25));
repo.Add(new TestClass("Bob", 30));
repo.Add(new TestClass("Charlie", 35));

// Call the static void method Items with the repo object as an argument
Items(repo);

// Define the static void method Items
public static void Items(Repository<TestClass> repo)
{
    // Loop through the items in the repo object and print their properties
    foreach (var item in repo.GetAll())
    {
        Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
    }
}
