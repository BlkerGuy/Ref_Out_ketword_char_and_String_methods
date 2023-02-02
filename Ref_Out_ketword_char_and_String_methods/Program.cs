using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Ref_Out_ketword_char_and_String_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //-Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm,
            //arrayim dəyişilməli və arrayin içində əvəlki elementləri,
            //əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.(metod geriye dəyər qaytarmır)


            //int[] nums = new int[] { 12, 8, 17 };

            //addValueToArr(ref nums,5);

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            // Task 2
            //-Verilmiş yazıda rəqəm olub olmadığını tapan metod.Göndərilən yazıda rəqəm varsa true yoxdursa false qaytarır.
            //Console.WriteLine(findDigit("Azerbaycan Torpaqlari artiq  azadd1ir!"));

            // Task 3 
            //-Verilmiş yazıdaki sözlərin sayanı tapan metod.
            //Boşluqla bir birindən ayrılmış bütün ifadələri söz kimi qəbul edin.Və hər söz arasında bir boşluq varmış kimi hesab edin.

            string str = "Salam necesen? Hikmet?";

            //Console.WriteLine(str.Length);
            Console.WriteLine(findLengthofSentence(str));

            // Mellim serti basa dusduyum iki sekilde yazmaga calisdim :
        }

        //  Method of Task 1
        //static void addValueToArr(ref int[] numArr, int num)
        //{
        //    int[] newArr = new int[numArr.Length + 1];

        //    for (int i = 0; i < numArr.Length; i++)
        //    {
        //        newArr[i] = numArr[i];
        //    }
        //    newArr[newArr.Length - 1] = num;
        //    numArr = newArr;
        //}

        // Method of Task 2

        //  static bool findDigit(string sentenc)
        //{
        //    for (int i = 0; i < sentenc.Length; i++)
        //    {
        //        if (char.IsDigit(sentenc[i]))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        // Method of Task 3
        static int findLengthofSentence(string sentence)
        {
            //return sentence.Length;

            string words =sentence.Trim();
            string newStr = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsLetter(words[i]))
                {
                    newStr += words[i];
                    newStr += ' ';
                }
            }
            return newStr.Length;
        }


    }
}
