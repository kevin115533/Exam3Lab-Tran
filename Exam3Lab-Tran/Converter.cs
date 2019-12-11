using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3Lab_Tran
{
    class Converter
    {
        public string encrypt(string message)
        {
            char[] charArray = message.ToCharArray();
            for(int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = encryptLetter(charArray[i]);
            }
            string holder = new string(charArray);
            return holder;

        }

        public string decrypt(string message)
        {
            char[] charArray = message.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = decryptLetter(charArray[i]);
            }
            string holder = new string(charArray);
            return holder;

        }

        public char decryptLetter(char letter)
        {
            char holder = letter;
            if (letter == 'x' || letter == 'X')
            {
                holder = 'a';
            }
            if (letter == 'y' || letter == 'Y')
            {
                holder = 'b';
            }
            if (letter == 'z' || letter == 'Z')
            {
                holder = 'c';
            }
            if (letter == 'e' || letter == 'E')
            {
                holder = 'd';
            }
            if (letter == 'j' || letter == 'J')
            {
                holder = 'f';
            }
            if (letter == 'i' || letter == 'I')
            {
                holder = 'e';
            }
            if (letter == 'l' || letter == 'L')
            {
                holder = 'g';
            }
            if (letter == 'a' || letter == 'A')
            {
                holder = 'H';
            }
            if (letter == 'm' || letter == 'M')
            {
                holder = 'i';
            }
            if (letter == 'b' || letter == 'B')
            {
                holder = 'j';
            }
            if (letter == 'o' || letter == 'O')
            {
                holder = 'k';
            }
            if (letter == 'c' || letter == 'C')
            {
                holder = 'l';
            }
            if (letter == 'd' || letter == 'D')
            {
                holder = 'm';
            }
            if (letter == 'f' || letter == 'F')
            {
                holder = 'n';
            }
            if (letter == 't' || letter == 'T')
            {
                holder = 'o';
            }
            if (letter == 'u' || letter == 'U')
            {
                holder = 'p';
            }
            if (letter == 'v' || letter == 'V')
            {
                holder = 'q';
            }
            if (letter == 'w' || letter == 'W')
            {
                holder = 'r';
            }
            if (letter == 'k' || letter == 'K')
            {
                holder = 's';
            }
            if (letter == 'p' || letter == 'P')
            {
                holder = 't';
            }
            if (letter == 'g' || letter == 'G')
            {
                holder = 'u';
            }
            if (letter == 'q' || letter == 'Q')
            {
                holder = 'v';
            }
            if (letter == 'h' || letter == 'H')
            {
                holder = 'w';
            }
            if (letter == 'n' || letter == 'N')
            {
                holder = 'x';
            }
            if (letter == 'r' || letter == 'R')
            {
                holder = 'y';
            }
            if (letter == 's' || letter == 'S')
            {
                holder = 'z';
            }

            return holder;
        }
        public char encryptLetter(char letter)
        {
            char holder = letter;
            if(letter == 'a'|| letter == 'A'){
                holder = 'x';
            }
            if (letter == 'b' || letter == 'B')
            {
                holder = 'y';
            }
            if (letter == 'c' || letter == 'C')
            {
                holder = 'z';
            }
            if (letter == 'd' || letter == 'D')
            {
                holder = 'e';
            }
            if (letter == 'f' || letter == 'F')
            {
                holder = 'j';
            }
            if (letter == 'e' || letter == 'E')
            {
                holder = 'i';
            }
            if (letter == 'g' || letter == 'G')
            {
                holder = 'l';
            }
            if (letter == 'h' || letter == 'H')
            {
                holder = 'a';
            }
            if (letter == 'I' || letter == 'i')
            {
                holder = 'm';
            }
            if (letter == 'j' || letter == 'J')
            {
                holder = 'b';
            }
            if (letter == 'k' || letter == 'K')
            {
                holder = 'o';
            }
            if (letter == 'l' || letter == 'L')
            {
                holder = 'c';
            }
            if (letter == 'm' || letter == 'M')
            {
                holder = 'd';
            }
            if (letter == 'n' || letter == 'N')
            {
                holder = 'f';
            }
            if (letter == 'o' || letter == 'O')
            {
                holder = 't';
            }
            if (letter == 'p' || letter == 'P')
            {
                holder = 'u';
            }
            if (letter == 'q' || letter == 'Q')
            {
                holder = 'v';
            }
            if (letter == 'r' || letter == 'R')
            {
                holder = 'w';
            }
            if (letter == 's' || letter == 'S')
            {
                holder = 'k';
            }
            if (letter == 't' || letter == 'T')
            {
                holder = 'p';
            }
            if (letter == 'u' || letter == 'U')
            {
                holder = 'g';
            }
            if (letter == 'v' || letter == 'V')
            {
                holder = 'q';
            }
            if (letter == 'w' || letter == 'W')
            {
                holder = 'h';
            }
            if (letter == 'x' || letter == 'X')
            {
                holder = 'n';
            }
            if (letter == 'y' || letter == 'Y')
            {
                holder = 'r';
            }
            if (letter == 'z' || letter == 'Z')
            {
                holder = 's';
            }

            return holder;
        }

    }
}
