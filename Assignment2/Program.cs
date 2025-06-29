namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            Console.WriteLine("Enter a number:");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number entered is " + numb);
            #endregion

            #region Task 2

            /* 
             It will fail to convert the string to int because "Hello" is not a numeric string,
             so the method returns false and the else block will get executed.
            */
            string str = "Hello";
            if (Int32.TryParse(str, out int convNum))
            {
                Console.WriteLine(convNum);
            }
            else
            {
                Console.WriteLine("String can't be converted");
            }

            #endregion

            #region Task 3

            // it will perform the multiplication operation and the result will be stored in a float variable called result


            float n1 = 7.3f;
            float n2 = 8.4f;
            float result = n1 * n2;
            Console.WriteLine("Result: " + result);

            #endregion

            #region Task 4

            string fullStr = "This is Task 4 main string";
            string subStr = fullStr.Substring(8, 18);
            Console.WriteLine(subStr);

            #endregion

            #region Task 5

            /* the variable num2 will get the value of num1 before change which is 50 and it won't change when num1 changes its 
            value to 70 because they are stored separately in memory so modifying num1 after the assignment does not affect num2 */
            int num1 = 50;
            int num2 = num1;
            num1 = 70;
            Console.WriteLine("num1 = " + num1 + " - num2 = " + num2);
            #endregion

            #region Task 6
            // when cat1 changes its value cat2 will also change its value because both variables refer to the same object in memory
            Cat cat1 = new Cat();
            cat1.Breed = "Siamese";
            Cat cat2 = new Cat();
            cat2 = cat1;
            Console.WriteLine(cat1.Breed + " " + cat2.Breed);
            cat1.Breed = "Maine Coon";
            Console.WriteLine(cat1.Breed + " " + cat2.Breed);
            #endregion

            #region Task 7
            string part1 = "How are ";
            string part2 = "you ?";
            string ConcatedStr = string.Concat(part1, part2);
            Console.WriteLine(ConcatedStr);
            #endregion

            #region Task 8
            // 8 - b) A value 1 will be assigned to d.
            int d;
            d = Convert.ToInt32(!(30 < 20));

            #endregion

            #region Task 9
            // 9 - d) 6 1
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            #endregion

            #region Task 10
            // 10 - d) 7 7
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            #endregion
        }
     
    }
    class Cat
    {
        public string Breed { get; set; }

    }
}