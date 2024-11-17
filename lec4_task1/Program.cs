namespace lec4_task1
{
    internal class Program
    {



        #region task1 lecture 4 


        static void Main(string[] args)
        {


           
            // lecture 4
            // task 1



            //////////  declarate variable   ////////////////////////////////////////////////

            double num1, num2 , Add , Mult , Sub ,Div;
            //float calc;

            Console.WriteLine("this program to make  *  / + -  for two number  ");
            Console.WriteLine("Enter Number 1 ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number 2 ");
            num2 = Convert.ToDouble(Console.ReadLine());
           
            ///////    calling by value    /////////////////////////////////////////////
            Add = add(num1, num2);
            Mult = mult(num1, num2);
            Sub = sub(num1, num2);
            Div = div(num1, num2);


            /////////   print value    /////////////////////////////////////////////
            Console.WriteLine($"\n this is add operation \n {num1}+{num2} = {Add}");
            Console.WriteLine($"\n this is mult operation \n {num1}*{num2} = {Mult}");
            Console.WriteLine($"\n this is sub  operation \n {num1}-{num2} = {Sub}");

            if (num2 != 0)
            {
                Console.WriteLine($"\n this is div  operation \n {num1}/{num2} = {Div}");
            }
            else {

                Console.WriteLine($"\n this is div  operation   {num1}/{num2}  not accepted \n  ");
            }

        }



        ////////////////////////// define functions /////////////////////////////////////////////////////////
        static double add(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }

        static double mult(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }


        static double sub(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }


        static double div(double number1, double number2)
        {
           

            if (number2 != 0)
            {
                double result = number1 / number2;
                return result;
            }
            else 
            {
               
                return 0;
            }
            
           
        }


    }

    #endregion
}

