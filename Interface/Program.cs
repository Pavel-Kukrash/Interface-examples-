using Interface;


Person person = new Person();
IMovable car = new Car();

person.Move();
car.Move();

IAction baseAction = new BaseAction();
baseAction.Move();

HeroAction action1 = new HeroAction();
action1.Stop(); // Stop action in BaseAction

IAction action2 = new HeroAction();
action2.Stop(); // Stop action in HeroAction

BaseAction action3 = new HeroAction();

action3.Pause(); // BaseAction
action2.Pause(); // HeroAction

HeroAction action4 = new HeroAction();

action4.Pause(); // HeroAction

// <T>

IUser<int> user1 = new User<int>(123);
IUser<string> user2 = new User<string>("456");

Console.WriteLine(user1.Id);
Console.WriteLine(user2.Id);

// IClonable

var tom1 = new Person("Tom", 32);
var bob1 = tom1;
bob1.Name = "Bob";
Console.WriteLine(tom1.Name); // Bob


var tom2 = new Person("Tom", 32);
var bob2 = (Person)tom2.Clone();
bob2.Name = "Bob";
Console.WriteLine(tom2.Name); // Tom

// Simple Array.Sort

int[] numbers = new int[] { 41, 22, 63, 4, 15, 6, 77 };
Array.Sort(numbers);

Array.ForEach(numbers, n => Console.Write($"{n} "));

Console.WriteLine();

// IComparable (sort on the base of Age)

var people = new Person[5]
{
new Person("Tom", 37),
new Person("Bob", 41),
new Person("Sam", 25),
new Person("Alice", 42),
new Person("Kate", 28)
};

Array.Sort(people);
PrintPeople(people);

// Sam    25
// Kate   28
// Tom    37
// Bob    41
// Alice  42

Console.WriteLine();

// Icomparer (sort on the base of Age)

Array.Sort(people, new PeopleComparer());
PrintPeople(people);


static void PrintPeople(Person[] people)
{
    foreach (var person in people)
    {
        Console.WriteLine(person.Name + "\t" + person.Age);
    }
}


Console.ReadKey();