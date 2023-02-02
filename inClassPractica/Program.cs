using System;

namespace inClassPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(whiteSpaceIndex(" Hikmet"));
            //Console.WriteLine(charCount("Hikmet"));
            //int[] numArr = new int[] { 2,4,10};
            //Console.WriteLine(findArr(numArr,1));

            //Console.WriteLine(PositivMinus(-5));
            //string newStr = "Salam necesen, Abbas?";
            //rmStrSpace(ref newStr);
            //Console.WriteLine(newStr);






            Console.WriteLine(char.IsDigit('2'));

            Console.WriteLine(char.IsLetter('c'));

            Console.WriteLine(char.IsLetter('4'));

            Console.WriteLine(char.IsLetterOrDigit('@'));

            Console.WriteLine("Hikmet".ToLower());
            Console.WriteLine("Hikmet".ToUpper());


            string word = "Hikmet";

            var newWord = word.ToUpper();
            newWord = word.ToLower();

            Console.WriteLine(newWord);

            Console.WriteLine(newWord.Contains("km"));

            Console.WriteLine(newWord.IndexOf('m'));
            Console.WriteLine(newWord.LastIndexOf('m'));
            Console.WriteLine(newWord.IndexOf("tem"));


            word = "   salamm Hikmett  ";
            Console.WriteLine(word.TrimStart());
            Console.WriteLine(word.TrimEnd());
            Console.WriteLine(word.Trim());

            var index = word.IndexOf("necesen");
            var word2 = word.Substring(index, 4);

            word2 = word.Replace("salam", "hello");

            Console.WriteLine("baslayirmi? " + word.StartsWith("Hello P"));
            Console.WriteLine("bitirmi? " + word.EndsWith("up!"));


            word = "Hello P138 group!";
            var arr = word.Split(" ");

            string[] names = { "Hikmet", "Abbas", "Tofiq" };
            var result = String.Join(" - ", names);

        }

        //static int whiteSpaceIndex(string word)
        //{
        //    //int index = 0;
        //    for (int i = 0; i <word.Length; i++)
        //    {
        //        if (word[i]==' ')
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //static int charCount(string word)
        //{
        //    int count = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        return count += word.Length;
        //    }
        //    return 0;
        //}

        //static int[] findArr(int[] nums,int arrLength)
        //{
        //    int[] newArr = new int[nums.Length + 1];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        newArr[i] += nums[i];
        //        if (newArr[i]==nums[i])
        //        {
        //          newArr[arrLength.Le] = 25;
        //            Console.WriteLine(newArr[3]);
        //        }
        //    }
        //    return newArr;////   DUZELT BUNU <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        //}

        //static void rmStrSpace(ref string word)
        //{
        //    string newStr = "";
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            newStr += word[i];
        //        }
        //    }
        //    word = newStr;
        //}

        //static int PositivMinus(int nums)
        //{
        //     return   nums *= -1;
        //}
    }
}
