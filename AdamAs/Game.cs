using AdamAs.Client;
using AdamAs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAs
{
    //enter a basınca patlıyor! düzenlenmeli
    //bazı kelimelerde parantez mevcut. API kontrol edilmeli veya parse işlemi yapılmalı

    public class Game
    {
        private int life;
        
        private Root Kelime;
        private char[] WordToLetter;

        public void init()
        {
            life = 10;
            WordToLetter =  this.generateWord();
            renderWord();
            Console.SetCursorPosition(100, 0);
            Console.WriteLine("Can : " + life);
            while (this.life >= 1)
            {
               

                try
                {
                    Console.WriteLine(" ");
                    //Console.WriteLine("Kelime :  " + Kelime.madde);
                    Console.WriteLine("Bir adet harf girin: ");
                    char userInput = Console.ReadLine()[0];

                    if (!checkUserInput(userInput))
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.life--;
                        Console.WriteLine("Yanlış Karakter Girdiniz! " + life + " Kadar Hakkınız Kaldı!");
                        Console.ReadKey();
                    }


                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(WordToLetter);

                    CheckIfGameFinished();
                }
                catch (Exception)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(WordToLetter);
                    CheckIfGameFinished();
                }
               

            }
            Console.WriteLine("Doğru kelime : " + Kelime.madde);
            Console.WriteLine("kelime Tanımı : " + Kelime.anlamlarListe.First().anlam);
            Console.ReadKey();
        }

        private void CheckIfGameFinished()
        {
            if (!WordToLetter.Contains('-'))
            {
                WordToLetter = this.generateWord();
                this.renderWord();
            }
        }

        private bool checkUserInput(char userInput)
        {
            bool isLetterTrue = false;

            for (int i = 0; i < Kelime.madde.Length; i++)
            {
                if (userInput == Kelime.madde[i])
                {
                    WordToLetter[i] = userInput;
                    isLetterTrue = true;
                }
            }

            return isLetterTrue;
        }

        private void renderWord()
        {
            for (int i = 0; i < WordToLetter.Length; i++)
            {
                Console.Write(WordToLetter[i] + " ");
            }
        }

        private char[] generateWord()
        {
            Kelime = SozlukClient.GetKelime().Result;
            
            if (Kelime == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bir Hata oluştu! Lütfen internet bağlantınızı Kontrol ediniz!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            char[] GameChar= new char[Kelime.madde.Length];
            for (int i = 0; i < Kelime.madde.Length; i++)
            {
                if (Kelime.madde[i] != ' ')
                {
                    GameChar[i] = '-';
                }
                else
                {
                    GameChar[i] = ' ';
                }
               
            }
            return GameChar;
        }
    }
}
