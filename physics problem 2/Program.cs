using physics_problem_2;

double mass = 15; // Expressed in kilograms
double aceleration = 8; // It is expressed in meters per second squared

double _force = force.Calculateforce(mass, aceleration);

Console.WriteLine("The force required to move the object is: "+ _force);// This is where the strength is printed
Console.ReadLine();
