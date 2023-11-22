using System;

namespace WORK3
{
    class Program
    {

        //   אדיר אדרי 206991762
        //   אפיק סואיסה 318289196



        /*

        //  תרגיל 1

        public static int reverse(int n)  //  השיטה לוקחת את המספר שהתקבל כפרמטר ומחזירה את ערכו ההפוך באמצעות הפיכה רקורסיבית
        {
            return reverse(n, 0);   //   החזרת השיטה הפרטית עם אינדקס שווה לאפס ומספר שיתקבל כפרמטר

        }
        public static int reverse(int n, int x)  //    שיטה פרטית שתוחזר בשיטה הציבורית
        {
            if (n > 10)      //       אם המספר גדול מעשר
                return (reverse(n / 10, (x + n % 10) * 10));     //     תחזיר רקורסיבית את החישוב ההפוך של המספר בשיטה
            else
                return x + n;        //   אחרת תחזיר את התוצאה הסופית 
        }

        */




        /*

        //    תרגיל 2

        public static bool Order(int[] a)   //  השיטה מקבלת מערך חד ממדי ותחזיר אמת אם המערך ממוין בסדר עולה, ושקר אחרת 
        {
            return Sidra(a, 0);    //   החזרת שיטה פרטית 
        }
        private static bool Sidra(int[] a, int i)  // שיטה פרטית לפונקציית אורדר ,
        {                                          // השיטה תקבל מערך ואינדקס ותרוץ על כל אברי המערך בכדי לבדוק האם ממוין בסדר עולה, במידה וכן תחזיר אמת, שקר אחרת
            if (i == a.Length - 1)    //   תנאי עצירה - אם האינדקס שווה למקום האחרון במערך - תחזיר אמת כי הגעת רקורסיבית עד סוף המערך 
                return true;
            else if (a[i] >= a[i + 1])     //   אחרת אם האינקס הנוכחי גדול או שווה לאינקס הבא אחריו - זה אומר שהסדרה לא ממוינת בסדר עולה ולכן תחזיר שקר
                return false;
            return Sidra(a, i + 1);    //   תחזיר אמת או שקר באמצעות הרקורסיביה על שתי האברים הבאים במערך , וכך הלאה עד להתקלות בתנאי עצירה
        }

        */




        /*

        //  תרגיל 3

        public static int howManyChar(string s, char c)    //   השיטה תקבל מחרוזת ותו , ותחזיר רקורסיבית את כמות הפעמים שהתו מופיע במחרוזת
        {
            if (s.Length == 0)         //    אם אורך המחרוזת שווה לאפס תחזיר אפס
                return 0;
            else if (s[0] == c)        //    אחרת אם המיקום הראשון במחרוזת הנוכחית שווה לתו שהוזן כפרמטר
                return 1 + howManyChar(s.Substring(1), c);    //    תחזיר לי את הפונקציה רקורסיבית על המחרוזת בחיתוך המיקום הראשון שבדקנו כבר עכשיו , ותוסיף 1 לספירה
            else                                              //    אחרת (כלומר המחרוזת לא שווה אפס והמיקום הראשון במחרוזת לא שווה לתו),
                return howManyChar(s.Substring(1), c);        //    אז תחזיר לי את הפונקציה רקורסיבית בחיתוך המיקום הראשון מבלי לספור כלום
        }

        */


        /*
         
  

        //  תרגיל 4

        //   סעיפים א+ב+ד בקובץ וורד


        private static int f(int[] a, int low, int high)
        {
            int res = 0;
            for (int i = low; i <= high; i++)
                res += a[i];
            return res;
        }

        //  what  לפני הורדת הסיבוכיות - O(n^3)


        public static int what(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    int c = f(a, i, j);
                    if (c % 3 == 0)
                        if (j - i + 1 > temp)
                            temp = j - i + 1;
                }
            }
            return temp;
        }



        //   what  אחרי הורדת הסיבוכיות - O(n^2)
        //   (סעיף ג')



        public static int what2(int[] a)
        {
            for (int i = 0, j = a.Length - 1; i != j; i++, j--)
            {
                if (f(a, i, j) % 3 == 0)
                    return j - i + 1;       // אם הטווח מתחלק ב3, אחזיר את האורך המלא
                else if (f(a, i, j - 1) % 3 == 0)
                    return j - i;        // אם הטווח עם האיבר האחרון מתחלק ב3, אחזיר את האורך בהתאם
                else if (f(a, i + 1, j) % 3 == 0)
                    return j - i;         // אם התת-מערך עם האיבר הראשון הוא מתחלק ב3, אחזיר את האורך בהתאם
            }
            return 0;       // אם לא נמצא הטווח המתחלק ב3, אחזיר 0
        }


        */
        


        static void Main(string[] args)
        {

            /*

             //    תרגיל 1

             Console.WriteLine("Enter you number: ");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("Your Upside down number : {0}" , reverse(n));


            */
             


            /*

            //    תרגיל 2

            int[] a = new int[5];
            Console.WriteLine("Enter a new array");
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(Order(a));

            */

            /*

             //  תרגיל 3

             Console.WriteLine("Enter your char");
             char c = char.Parse(Console.ReadLine());
             Console.WriteLine("Enter your string: ");
             string s = Console.ReadLine();
             Console.WriteLine("In this string the char ({0}) appears {1} times",c, howManyChar(s,c));

             */

            /*

            //  תרגיל 4


            int[] a1 = { 1, 2, 3, 4 };
            int[] a2 = { 1, 0, 1, 2, 3, -3 };
            Console.WriteLine("The bigest range of the before function: a1: {0} , a2: {1} ", what(a1), what(a2));
            Console.WriteLine();
            Console.WriteLine("The bigest range of the after function: a1: {0} , a2: {1} ", what2(a1), what2(a2));

            */




        }
    }
}