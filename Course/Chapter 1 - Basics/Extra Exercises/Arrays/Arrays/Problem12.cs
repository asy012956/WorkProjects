using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Problem12
    {
        public void CreateArrayOfAllLetters()
        {

            //Write a program that creates an array containing all letters from the alphabet (A-Z).
            //Read a word from the console and print the index of each of its letters in the array.

            int alphabetSize = 26;
            int index = 0;
            char[] alphabet = new char[alphabetSize]; // A B C D E F G H I J K L M N O P Q R S T U V W X Y Z

            //alphabet = new char[] { 'A', 'B', 'C'};

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(65 + i);
            }

            string word = Console.ReadLine(); // PEAR

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i]; //P

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (letter == alphabet[j])
                    {
                        Console.Write(j + " ");
                    }
                }
            }


            for(int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] - 65 + " ");
            }


        }
    }
}
