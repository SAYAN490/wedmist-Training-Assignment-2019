//Trademark SAYAN BANERJEE
using System;

namespace Assignment
{
    class Program
    {
        //QUESTION NUMBER 1 and 2.
        public static void kthDigit(int a)
        {
            Console.WriteLine("Enter a number:");
            string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int o=a;
            int i=0;
            int remainder=0;
            
            while(i<o)
            {
                remainder=number%10;
                number=number/10;
                i++;
            }
           Console.WriteLine("your kth digit is:"+remainder);
        }
        //QUESTION NUMBER 3.
        public static void lastDigit()
        {
            Console.WriteLine("Enter a number:");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            Console.WriteLine("Your result is:"+(number%10)) ;
        }
        //QUESTION NUMBER 4.
        public static void sumOfDigits()
        {
            Console.WriteLine("Enter a number:");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int i,sum=0;
            
            while(number>0)
            {
                i=number%10;
                sum=sum+i;
                number=number/10;
            }
             Console.WriteLine("Your result is:"+sum);

        }
        //QUESTION NUMBER 5.
        public static void Sumofproductofconsecutive()
        {
                               
            Console.WriteLine("\nEnter a number");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
        
            int result = 0;
            while (number >= 10)
            {
                int remainder = number % 100;
                int remainder1 = remainder % 10;
                remainder = remainder - remainder1;
                int multiplication = remainder1 * ((remainder % 100) / 10);
                result = result + multiplication;
                number = number / 10;
            }
            if (result == 0)
                Console.WriteLine("Number you entered is of one digit.");
            else
                Console.WriteLine("your answer is: "+ result);
        }
        //QUESTION NUMBER 6.
        public static void Sumofproductofcorresponding()
        {
            
            int number1;
            int number2;
            
            Console.WriteLine("\nenter two numbers :");
             string num1=Console.ReadLine();
              string num2=Console.ReadLine();
             
             number1=Convert.ToInt32(num1);
             number2=Convert.ToInt32(num2);

            
            
            int result=0;
            while (number1 != 0 || number2 !=0)
            {
                result = result+((number1 % 10) * (number2 % 10));
                number1 = number1 / 10;
                number2 = number2 / 10;
            }
            Console.WriteLine("your answer is: " +result);
        }
        //QUESTION NUMBER 7.
        public static void Positionalvalues()
        {
            
            Console.WriteLine("\nEnter a number");
            string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            Console.WriteLine("The required positional values are as follows:");
            int spare = 1;
            while (number != 0)
            {
                Console.WriteLine((number%10)*spare);
                number = number / 10;
                spare = spare * 10;
            }
        }
        //QUESTION NUMBER 8,9,10.
        public static void sumOfEvenDigits()
        {
            Console.WriteLine("Enter a number:");
            string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int sum = 0;
            int remainder;
            int count=0;
            int x=number.ToString().Length;
            
            while (number > 0)
		    {
			    remainder = number % 10;
			    if (remainder % 2 == 0)
                {
        	        sum = sum + remainder;
                    count++;
                }
			    number = number / 10;
		    }
 
           
            Console.WriteLine("Sum of all even number " +  " = "+ sum);
            Console.WriteLine("Total number of digits are: "+x);
            Console.WriteLine("Total number of Even digits: "+count);
 
            
        }
        //QUESTION NUMBER 11.
        public static void lastEvenDigit()
        {
            Console.WriteLine("Enter a number:");
            int sum=0;
            string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int rem;
            int count=0;
            
            
            while (number > 0)
		    {
			    rem = number % 10;
			    if (rem % 2 == 0)
                {
        	        sum = sum + rem;
                    count++;
                    if(count==1)
                    {
                        Console.WriteLine("last even digit is: "+rem);
                    }
                }
			    number = number / 10;
		    }
        }
       //QUESTION NUMBER 12.
        public static void Beforelastevendigit()
        {
            
            Console.WriteLine("\nEnter a number");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            int digit = -1;
            while (number != 0)
            {                
                if ((number%10) % 2 == 0)
                {
                    break;
                }
                number = number / 10;
            }

            if (number == 0)
            {
                Console.WriteLine("There is no even digits all are odd digits.");

            }
            else
            {
                number = number / 10;
                digit = number % 10;
                if (number==0)
                {
                    Console.WriteLine("There is no digit before the first digit.");
                }
            
            else
                Console.WriteLine("Required digit before the last even number is: "+ digit);
            }    
        
        }
        //QUESTION NUMBER 13.
        public static void Afterlastevendigit()
        {
             
            Console.WriteLine("\nEnter a number:");
            string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            int digit = -1;
            while (number != 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    if (digit != -1)
                    {
                        Console.WriteLine("The required digit after last even digit is : ", digit);
                        digit = -2;
                    }
                    else
                    {
                        Console.WriteLine("There is no digit after the last digit.");
                    }
                    break;
                }
                digit = number % 10;
                number = number / 10;
            }
            if (digit > -1)
            {
                Console.WriteLine("there is no even digits present.");
            }
        }

        //QUESTION NUMBER 14.
        public static void lastMultipleOfThree()
        {
            Console.WriteLine("Enter a number:");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int rem;
            int count=0;
            
            
            while (number > 0)
		    {
			    rem = number % 10;
			    if (rem % 3 == 0)
                {
        	        
                    count++;
                    if(count==1)
                    {
                        Console.WriteLine("last multiple of three is: "+rem);
                    }
                }
			    number = number / 10;
		    }
        }

        //QUESTION NUMBER 15.
        public static void secondLastEvenDigit()
        {
            Console.WriteLine("Enter a number:");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            int rem;
            int count=0;
            
            
            while (number > 0)
		    {
			    rem = number % 10;
			    if (rem % 2 == 0)
                {
                    
                    count++;
                    if(count==2)
                    {
                        Console.WriteLine("Second last even digit is: "+rem);
                    }
                }
			    number = number / 10;
		    }
        }



        //QUESTION NUMBER 16.
        public static void Lastodddigit()
        {
            
            Console.WriteLine("\nEnter a number");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            int variable;
            int spare = variable = number;
            int multiplication = 1;
            while (spare != 0)
            {
                int remainder = spare % 10;
                if ((remainder % 2)!=0)
                {
                    break;
                }
                number = number - ((remainder * multiplication)/2);
                multiplication *= 10;
                spare = spare / 10;
            }
            if (number == variable / 2)
            {
                Console.WriteLine("No odd numbers are present");
            }
            else
            {
                Console.WriteLine("your result is: "+number*3);
            }
        } 
        //QUESTION NUMBER 17.
        public static void Sumconsecutivedigits()
        {
            Console.WriteLine("\nEnter a number");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);
            
            int result = 0;
            while (number >= 10)
            {
                int remainder = number % 100;
                result = result + remainder;
                number = number / 10;
            }
            if (result == 0)
                Console.WriteLine("Number you entered is of only one digit");
            else
                Console.WriteLine("your answer is: "+result);
        }
        //QUESTION NUMBER 18.
        public static void Sumexchangingconsecutivedigits()
        {
            Console.WriteLine("\nEnter a number");
             string num=Console.ReadLine();
            int number=Convert.ToInt32(num);            
            int result = 0;
            while (number >= 10)
            {
                int remainder = number % 100;

                //inverting the remainder
                int remainder1 = remainder % 10;
                remainder = remainder - remainder1;
                remainder = remainder1 * 10 + (remainder % 100)/10;
            
                result = result + remainder;
                number = number / 10;
            }
            if (result == 0)
                Console.WriteLine("Number you entered is of one  digit.");
            else
                Console.WriteLine("your answer is :"+result);

        }

        
        
      
        static void Main(string[] args)
        {
            int ch;
            String inputch;
            Console.WriteLine("-------------part-1 of assignment contains 18 Questions---------------- \n");
            Console.Write("Enter the serial number of question you want (0 to exit): ");
             inputch= Console.ReadLine();
            Console.WriteLine();
            ch = Convert.ToInt32(inputch);
            while (ch != 0)
            {
                switch (ch)
                {
                    case 1:
                        
                        kthDigit(3);
                        break;
                    case 2:
                        kthDigit(4);

                        break;
                    case 3:
                        lastDigit();
                        break;
                    case 4:
                        sumOfDigits();
                        break;
                    case 5:
                        Sumofproductofconsecutive();
                        break;
                    case 6:
                        Sumofproductofcorresponding();
                        break;
                    case 7:
                        Positionalvalues();
                        break;
                    case 8:
                        sumOfEvenDigits();
                        break;
                    case 9:
                        sumOfEvenDigits();
                        break;
                    case 10:
                        sumOfEvenDigits();
                        break;
                    case 11:
                        lastEvenDigit();
                        break;
                    case 12:
                        Beforelastevendigit();
                        break;
                    case 13:
                        Afterlastevendigit();
                        break;
                    case 14:
                        lastMultipleOfThree();
                        break;
                    case 15:
                        secondLastEvenDigit();
                        break;
                    case 16:
                        Lastodddigit();
                        break;
                    case 17:
                       Sumconsecutivedigits();
                        break;
                    case 18:
                        Sumexchangingconsecutivedigits();
                        break;
                    default:
                        Console.WriteLine("Invalid ch");
                        break;
                }
                Console.Write("\n\nenter the serial number of question you want (0 to exit): ");
                inputch = Console.ReadLine();
                Console.WriteLine();
                ch = Convert.ToInt32(inputch);
            }    
            Console.Write("Code submitted by SAYAN BANERJEE for wedmist training");   
        }
    }
        
    
}
