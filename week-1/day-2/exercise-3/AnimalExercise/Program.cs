namespace AnimalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Animal objects, add Dog and Cat instances, and call their methods
            List<Animal> animals = new List<Animal>();

            Dog dog = new Dog
            {
                Name = "Coco",
                Age = 1
            };

            Cat cat = new Cat
            {
                Name = "JoJo",
                Age = 3
            };

            animals.Add(dog);
            animals.Add(cat);

            foreach (Animal animal in animals)
            {
                animal.MakeSound();

                if (animal is IMovable movable)
                {
                    movable.Move();
                }

                Console.WriteLine();
            }
        }
    }
}