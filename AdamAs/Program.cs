using AdamAs.Client;

using AdamAs.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdamAs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.init();


            //int life = 10;

            //string comp_selection = SozlukClient.GetKelime().Result.madde;

            //int kelime_uzunluk = comp_selection.Length;

            ////ekranda - lerin gözükmesi için kod
            //char[] gameArray = new char[kelime_uzunluk];
            //for (int i = 0; i < kelime_uzunluk; i++)
            //{
            //    gameArray[i] = '-';
            //    Console.Write(gameArray[i] + " ");
            //}

            //while (life >= 0)
            //{
            //    Console.WriteLine(" ");

            //    Console.WriteLine("Bir adet harf girin: ");

            //    string userInput = Console.ReadLine();
            //    bool is_word_true = false;

            //    for (int i = 0; i < kelime_uzunluk; i++)
            //    {
            //        if (comp_selection[i] == userInput[0])
            //        {
            //            gameArray[i] = userInput[0];
            //            is_word_true = true;
            //        }
            //    }

            //    Console.Clear();

            //    if (!is_word_true)
            //    {
            //        Console.WriteLine("yanlış giriş yaptınız. " + life + " kadar hakkınız kaldı");
            //        life--;
            //    }
            //    Console.WriteLine(gameArray);
            //}


        }
    }
}
