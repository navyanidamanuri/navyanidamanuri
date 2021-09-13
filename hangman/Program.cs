
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    //main method
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hangman");
            List<string> listOfWords = new List<string>();
            listOfWords.Add("table");
            listOfWords.Add("pen");
            listOfWords.Add("laptop");
            listOfWords.Add("knife");
            Random ran = new Random();
            string name = listOfWords[ran.Next(0, listOfWords.Count() - 1)];
            Console.WriteLine("start gessing");
            gess(name);
                }
        //gess method
        public static void gess(string name)
        {
            char[] characterArray = name.ToCharArray();
            string underLine = "";
            string wrongGess = "";
            string inputCharacters = "";
             
            for (int i = 0; i < name.Length; i++)
            {
                underLine = underLine + "_ ";
            }
           char[] underLineCharacterArray = underLine.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                if (inputCharacters.IndexOf(input) != -1)
                {
                    i--;
  
                }
                else
                    inputCharacters = inputCharacters + input;
                
                if (name.IndexOf(input) != -1)
                    {
                        for (int j = 0; j < characterArray.Length; j++)
                        {
                            if (input[0] == characterArray[j])
                            {
                                underLineCharacterArray[j * 2] = input[0];
                            }
                        }
                        Console.WriteLine(underLineCharacterArray);
                        int count = 0;
                        for (int l = 0; l < underLineCharacterArray.Length; l++)
                        {
                            if (underLineCharacterArray[l] == '_')
                            {
                                count++;
                                break;
                            }
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Good Job! You have found all the characters!");
                            break;
                        }
                    }
                    else
                    {
                    if (wrongGess.IndexOf(input) == -1)
                       
                        wrongGess = wrongGess + input;
                         Console.WriteLine(wrongGess);
                    }
                if (i == 9)
                {
                    for (int l = 0; l < underLineCharacterArray.Length; l++)
                    {
                        if (underLineCharacterArray[l] == '_')
                        {
                            Console.WriteLine("You Lost");
                            break;
                        }
                    }
                }
                    
                }
            Console.ReadLine();
        }

    }
}
   