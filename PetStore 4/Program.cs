// See https://aka.ms/new-console-template for more information

using PetStore_4;
using System;
using System.ComponentModel.Design;
using System.Net.Security;
using System.Text.Json;


Console.WriteLine("Press 1 to add a product");

Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");


    CatFood Purina = new CatFood();
    DogLeash Leash = new DogLeash();



    if (userInput == "1")
    {
        Console.WriteLine("1-Cat Food or 2-Dog Leash?");

        userInput = Console.ReadLine();
        if (userInput == "1")
        {
            Console.WriteLine("What is the catfood name");
            userInput = Console.ReadLine();
            Purina.Name = userInput;

            Console.WriteLine("What is the catfood price");
            userInput = Console.ReadLine();
            Purina.Price = decimal.Parse(userInput);

            Console.WriteLine("What is the quantity");
            userInput = Console.ReadLine();
            Purina.Quantity = int.Parse(userInput);

            Console.WriteLine("What is the description");
            userInput = Console.ReadLine();
            Purina.Description = userInput;

            Console.WriteLine("Is it Kitten Food");
            userInput = Console.ReadLine();
            if (userInput == "Yes" | userInput == "yes")
            {
                userInput = "true";


            }
            else
            {
                userInput = "false";
            }
            Purina.KittenFood = bool.Parse(userInput);

            Console.WriteLine("How much does it Weigh?");
            userInput = Console.ReadLine();
            Purina.WeightPounds = Double.Parse(userInput);

            Console.WriteLine(JsonSerializer.Serialize(Purina));


        }
        else
        {
    if (userInput == "2")
    {

                Console.WriteLine("Is it a dog leash?");
                userInput = Console.ReadLine();


                if (userInput == "Yes" | userInput == "yes")
                {
                    userInput = "true";

                    Console.WriteLine("What is the dogleash length?");
                    userInput = Console.ReadLine();
                    Leash.Quantity = int.Parse(userInput);

                    Console.WriteLine("What is the dogleash made of?");
                    userInput = Console.ReadLine();
                    Leash.Description = userInput;

                    Console.WriteLine("What is the dogleash name");
                    userInput = Console.ReadLine();
                    Leash.Name = userInput;

                    Console.WriteLine("What is the dogleash price");
                    userInput = Console.ReadLine();
                    Leash.Price = decimal.Parse(userInput);

                    Console.WriteLine("What is the dogleash quantity");
                    userInput = Console.ReadLine();
                    Leash.Quantity = int.Parse(userInput);

                    Console.WriteLine("What is the description");
                    userInput = Console.ReadLine();
                    Leash.Description = userInput;
                    Console.WriteLine(JsonSerializer.Serialize(Leash));
                    return;

                }
                     if (userInput == "no" | userInput == "No")
                     {
                    userInput = "false";
                
                
                
                
                
                
                
                }

                    Console.WriteLine("What is the dogfood name");
                userInput = Console.ReadLine();
                Leash.Name = userInput;

                Console.WriteLine("What is the dogfood price");
                userInput = Console.ReadLine();
                Leash.Price = decimal.Parse(userInput);

                Console.WriteLine("What is the dogfood quantity");
                userInput = Console.ReadLine();
                Leash.Quantity = int.Parse(userInput);

                Console.WriteLine("What is the description");
                userInput = Console.ReadLine();
                Leash.Description = userInput;
                Console.WriteLine(JsonSerializer.Serialize(Leash));

            }

        }


        userInput = Console.ReadLine();


    }
}


