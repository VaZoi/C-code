using System;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ") // Check if there's an actual animal entry
                {
                    bool ageComplete = true;
                    bool descriptionComplete = true;

                    // Check if age is incomplete
                    if (ourAnimals[i, 2].Contains("?"))
                    {
                        ageComplete = false;
                        bool validEntry = false;

                        // Prompt user to enter the age
                        do
                        {
                            Console.WriteLine($"The age for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is unknown.");
                            Console.WriteLine("Please enter the correct age for this animal or enter ? if still unknown:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                string newAge = readResult;
                                if (newAge != "?")
                                {
                                    validEntry = int.TryParse(newAge, out _);
                                }
                                else
                                {
                                    validEntry = true;
                                }

                                if (validEntry)
                                {
                                    ourAnimals[i, 2] = "Age: " + newAge;
                                    ageComplete = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Please enter a valid number or ?.");
                                }
                            }
                        } while (!validEntry);
                    }

                    // Check if physical description is incomplete
                    if (string.IsNullOrEmpty(ourAnimals[i, 4].Replace("Physical description: ", "")) || ourAnimals[i, 4].Contains("tbd"))
                    {
                        descriptionComplete = false;

                        // Prompt user to enter the physical description
                        Console.WriteLine($"The physical description for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is incomplete.");
                        Console.WriteLine("Please enter a complete physical description (size, color, gender, weight, housebroken):");
                        readResult = Console.ReadLine();
                        if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                        {
                            ourAnimals[i, 4] = "Physical description: " + readResult.ToLower();
                            descriptionComplete = true;
                        }
                        else
                        {
                            Console.WriteLine("No valid description entered. Description remains incomplete.");
                        }
                    }

                    // Feedback to the user
                    if (ageComplete && descriptionComplete)
                    {
                        Console.WriteLine($"Information for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is now complete.");
                    }
                }
            }
            Console.WriteLine("All animal ages and physical descriptions have been reviewed.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        case "4":
            // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ") // Check if there's an actual animal entry
                {
                    bool nicknameComplete = true;
                    bool personalityComplete = true;

                    // Check if nickname is incomplete
                    if (string.IsNullOrEmpty(ourAnimals[i, 3].Replace("Nickname: ", "")) || ourAnimals[i, 3].Contains("tbd"))
                    {
                        nicknameComplete = false;

                        // Prompt user to enter the nickname
                        Console.WriteLine($"The nickname for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is incomplete.");
                        Console.WriteLine("Please enter a nickname for this animal:");
                        readResult = Console.ReadLine();
                        if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                        {
                            ourAnimals[i, 3] = "Nickname: " + readResult.ToLower();
                            nicknameComplete = true;
                        }
                        else
                        {
                            Console.WriteLine("No valid nickname entered. Nickname remains incomplete.");
                        }
                    }

                    // Check if personality description is incomplete
                    if (string.IsNullOrEmpty(ourAnimals[i, 5].Replace("Personality: ", "")) || ourAnimals[i, 5].Contains("tbd"))
                    {
                        personalityComplete = false;

                        // Prompt user to enter the personality description
                        Console.WriteLine($"The personality description for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is incomplete.");
                        Console.WriteLine("Please enter a description of the pet's personality (likes or dislikes, tricks, energy level):");
                        readResult = Console.ReadLine();
                        if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                        {
                            ourAnimals[i, 5] = "Personality: " + readResult.ToLower();
                            personalityComplete = true;
                        }
                        else
                        {
                            Console.WriteLine("No valid personality description entered. Description remains incomplete.");
                        }
                    }

                    // Feedback to the user
                    if (nicknameComplete && personalityComplete)
                    {
                        Console.WriteLine($"Information for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}) is now complete.");
                    }
                }
            }
            Console.WriteLine("All animal nicknames and personality descriptions have been reviewed.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        case "5":
            // Edit an animal’s age
            Console.WriteLine("Please enter the ID of the animal whose age you want to edit (e.g., d1, c3):");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                string selectedID = readResult.ToLower();
                bool idFound = false;

                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0] == "ID #: " + selectedID)
                    {
                        idFound = true;
                        bool validEntry = false;
                        do
                        {
                            Console.WriteLine($"Current age for {selectedID} is: {ourAnimals[i, 2].Replace("Age: ", "")}");
                            Console.WriteLine("Enter the new age for the animal or enter ? if unknown:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                string newAge = readResult;
                                if (newAge != "?")
                                {
                                    validEntry = int.TryParse(newAge, out _);
                                }
                                else
                                {
                                    validEntry = true;
                                }

                                if (validEntry)
                                {
                                    ourAnimals[i, 2] = "Age: " + newAge;
                                    Console.WriteLine($"The age for {selectedID} has been updated to: {newAge}");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid age entry. Please enter a valid number or ?.");
                                }
                            }
                        } while (!validEntry);
                        break;
                    }
                }

                if (!idFound)
                {
                    Console.WriteLine("No animal found with the provided ID.");
                }

                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;

        case "6":
            // Edit an animal’s personality description
            Console.WriteLine("Enter the ID of the animal whose personality description you want to edit (e.g., d1, c3):");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                string inputID = readResult.ToLower();
                bool found = false;

                // Search for the animal by ID
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 0].ToLower().Contains(inputID))
                    {
                        found = true;

                        // Display the current personality description
                        Console.WriteLine($"Current personality description for {ourAnimals[i, 0]} ({ourAnimals[i, 1]}):");
                        Console.WriteLine(ourAnimals[i, 5].Replace("Personality: ", ""));

                        // Prompt for new personality description
                        Console.WriteLine("Enter the new personality description:");
                        readResult = Console.ReadLine();

                        if (readResult != null && !string.IsNullOrWhiteSpace(readResult))
                        {
                            ourAnimals[i, 5] = "Personality: " + readResult.ToLower();
                            Console.WriteLine($"Personality description for {ourAnimals[i, 0]} has been updated.");
                        }
                        else
                        {
                            Console.WriteLine("No valid description entered. Update aborted.");
                        }
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"No animal found with ID {inputID}. Please try again.");
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("Enter a characteristic to search for among cats (e.g., 'friendly', 'white', '2 years old'):");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                string searchCharacteristic = readResult.ToLower();
                bool foundCat = false;

                // Search through the array for cats that match the characteristic
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1].ToLower().Contains("cat")) // Ensure it's a cat
                    {
                        // Check if any of the cat's details match the characteristic
                        bool matches = ourAnimals[i, 2].ToLower().Contains(searchCharacteristic) || // Age
                                       ourAnimals[i, 4].ToLower().Contains(searchCharacteristic) || // Physical Description
                                       ourAnimals[i, 5].ToLower().Contains(searchCharacteristic);   // Personality Description

                        if (matches)
                        {
                            foundCat = true;
                            Console.WriteLine("\nMatching cat found:");
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                }

                if (!foundCat)
                {
                    Console.WriteLine("No cats found with the specified characteristic.");
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("Enter a characteristic to search for among dogs (e.g., 'friendly', 'brown', '4 years old'):");
            readResult = Console.ReadLine();

            if (readResult != null)
            {
                string searchCharacteristic = readResult.ToLower();
                bool foundDog = false;

                // Search through the array for dogs that match the characteristic
                for (int i = 0; i < maxPets; i++)
                {
                    if (ourAnimals[i, 1].ToLower().Contains("dog")) // Ensure it's a dog
                    {
                        // Check if any of the dog's details match the characteristic
                        bool matches = ourAnimals[i, 2].ToLower().Contains(searchCharacteristic) || // Age
                                       ourAnimals[i, 4].ToLower().Contains(searchCharacteristic) || // Physical Description
                                       ourAnimals[i, 5].ToLower().Contains(searchCharacteristic);   // Personality Description

                        if (matches)
                        {
                            foundDog = true;
                            Console.WriteLine("\nMatching dog found:");
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                }

                if (!foundDog)
                {
                    Console.WriteLine("No dogs found with the specified characteristic.");
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        default:
            break;
    }

} while (menuSelection != "exit");
