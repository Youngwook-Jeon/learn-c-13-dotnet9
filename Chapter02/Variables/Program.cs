object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");
// int length1 = name.Length; // This gives a compile error!
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

dynamic something;
something = new[] { 3, 5, 7 };
something = 12;
something = "Lucas";
Console.WriteLine($"The length of something is {something.Length}");
Console.WriteLine($"something is a {something.GetType()}");

var population = 67_000_000;
var weight = 1.88; 
var price = 4.99M; 
var fruit = "Apples";
var letter = 'Z';
var happy = true;

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {
    default(DateTime)}");
Console.WriteLine($"default(string) = { // default(string) is null
    default(string) ?? "<NULL>"}");