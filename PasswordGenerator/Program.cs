using System;

namespace PasswordGenerator // Note: actual namespace depends on the project name.
{
    public class Program
    {

        //Create a function that adds a vowel twice if there is a vowel in the given word
        static string AddVowels(string word)
        {
            string newWord = "";
            for (int i = 0; i < word.Length; i++) //Loop through word
            {
                if (word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U') //If letter is equal to i, o, u...
                {
                    newWord += word[i]; //Add the vowel twice
                    newWord += word[i];
                }
                else
                {
                    newWord += word[i]; //Don't add the vowel twice
                }
            }
            return newWord; //Return the new word
        }

        static void Main(string[] args)
        {
            Console.Write("How many passwords would you like?: "); //Prompt user to enter the amount of passwords          
            int no_of_passwords = Convert.ToInt32(Console.ReadLine()); //Read the amount of passwords
            string[] password_list = new string[no_of_passwords]; //Create an array to store the passwords

            for (int i = 0; i < no_of_passwords; i++) //Loop through the amount of passwords
            {
                Console.Write("\nEnter password: "); //Prompt user to enter the passwords and repeat till the given amount is met
                password_list[i] = Console.ReadLine(); //Save input to the list
            }

            //For every password entered, remove the letters a, e and t. Replace every space with S&a
            for (int i = 0; i < no_of_passwords; i++) //Loop through the list of passwords
            {
                password_list[i] = password_list[i].Replace("a", ""); //Remove the letter a
                password_list[i] = password_list[i].Replace("e", ""); //Remove the letter e
                password_list[i] = password_list[i].Replace("t", ""); //Remove the letter t
                password_list[i] = password_list[i].Replace(" ", "S&a"); //Replace the space with S&a
            }

            Console.WriteLine("\nYour passwords are: "); //Print the passwords
            foreach (string password in password_list) //Loop through the list
            {
                string result = AddVowels(password); //Add the vowels
                Console.WriteLine(result); //Print the result
            }
        }
    }
}