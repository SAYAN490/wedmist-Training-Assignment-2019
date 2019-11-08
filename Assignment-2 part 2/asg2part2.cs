//Trademark SAYAN BANERJEE
using System;
namespace Assignment
{
    class Program
    {
        public static void SmallestElementinArray()
        {
            
			int small   = 0;
			
			int[] arr   = new int[15]; // array declaration

			Console.WriteLine("Enter array elements : ");
			//reading array ...
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Element[" + (i + 1) + "]: ");
				arr[i] = int.Parse(Console.ReadLine());
			}

			 
			
			small = arr[0];
			for (int i = 1; i < arr.Length; i++)
			{
				
				if (small > arr[i])
					small = arr[i];
			}

			
			Console.WriteLine("Smallest element of the array is : " + small);
        }
        public static  void LargestElementinArray()
        {
            
            int large = 0;
			
            int[] arr = new int[15]; //array declaration
			
			//reading array ... 
            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            
			large = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
				
                if ( arr[i]>large)
                    large = arr[i];
            }
			
            Console.WriteLine("Largest element of the array : " + large);
        }
        public static void TotalEvenNumberinArray()
        {
             
        int num, evennum=0;
 
        //Read size and elements of the array...
        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[num];

        Console.WriteLine("Enter "+num+" elements in the array: ");  
        for(int i=0; i<num; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());            
        }
        // logic...
        for (int i = 0; i < num; i++)
        {
            
            if (arr[i] % 2 == 0)
            {
                evennum++;
            }
            else
            {
                //nothing ...
            }
        }
 
        Console.WriteLine("Total even  numbers: "+evennum);
        
        }


        public static void TotalOccurenceofElement()
        {
            int i=0,count=0,key=0,num1=0;
            Console.WriteLine("Enter size of the array: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            int[] arr1   = new int[num1];
                        
            //Read numbers into array
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < num1; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter key to find its occurence : ");
            key = int.Parse(Console.ReadLine());

            for (i = 0; i < num1; i++)
            {
                if (key == arr1[i])
                {
                    count++;
                }
            }

            Console.WriteLine("Total occurrence of the  "+key + " is : "+count);
            
            Console.WriteLine();
        }

        public static void Palindrome()
        {
            int num=0,rem=0,rev=0,temp=0;    
            Console.Write("Enter the Number: ");   
            num = int.Parse(Console.ReadLine());  
            temp=num;      
            while(num>0)      
            {      
            rem=num%10;      
            rev=(rev*10)+rem;      
            num=num/10;      
            }      
            if(temp==rev)      
            Console.Write("Number is Palindrome.");      
            else      
            Console.Write("Number is not Palindrome");  
        }
        public static void MergeTwoArrays()
        {
        int s1=0,s2=0,s3=0;
        int i, j, k;
        
        
        Console.Write("\n\nThis code Merges two arrays of same size sorted in ascending order.\n");
        Console.Write("------------------------------------------------------------\n");	
        // Array1 creation and input...
        Console.Write("Input the number of elements to be stored in the first array :");
        s1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[s1]; 	   
    
        Console.Write("Input {0} elements in the array :\n",s1);
        for(i=0;i<s1;i++)
            {
            Console.Write("element - {0} : ",i);
            arr1[i] = Convert.ToInt32(Console.ReadLine()); 		  
            }


        Console.Write("Input the number of elements to be stored in the second array :");
        s2 = Convert.ToInt32(Console.ReadLine()); 
        int[] arr2 = new int[s2];	   
    
        Console.Write("Input {0} elements in the array :\n",s2);
        for(i=0;i<s2;i++)
                {
            Console.Write("element - {0} : ",i);
            arr2[i] = Convert.ToInt32(Console.ReadLine()); 		  
            }

        
        s3 = s1 + s2;
        int[] arr3 = new int[s3];
        
    //----------------- inserting in the third array------------------------------------
        for(i=0;i<s1; i++)
            {
                arr3[i] = arr1[i];
            }
        for(j=0;j<s2; j++)
            {
                arr3[i] = arr2[j];
                i++; 
            }
    //----------------- sort the array in ascending order ---------------------------
    for(i=0;i<s3; i++)
            {
            for(k=0;k<s3-1;k++)
                {
            
                    if(arr3[k]>=arr3[k+1])
                    {
                    j=arr3[k+1];  //reusing j...
                    arr3[k+1]=arr3[k];
                    arr3[k]=j;
                    }  
                }
            }                      
    //--------------- Prints the merged array ------------------------------------
        Console.Write("\nThe merged array in ascending order is :\n");
        for(i=0; i<s3; i++)
        {
            Console.Write("{0} ", arr3[i]);
        }
        Console.Write("\n\n");
            }

            
        public static void SumofMatrices()
        {
             int m, n,i,j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
 
            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            int[,] C = new int[10, 10];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            Console.Write("\nSum Matrix :");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(C[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
        public static void MultiplicationofMatrix()
        {
             int i, j,m,n;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] b = new int[m, n];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
        }
        public static void TransposeofMatrix()
        {
            int m, n, i, j;
            Console.Write("Enter  Order of the Matrix : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The Matrix Elements : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose Matrix : ");
 
           for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[j, i] + "\t");
 
                }
                Console.WriteLine();
            }
            Console.Read();
        }
         static void Main(string[] args)
        {
            int choice;
            String inputChoice;
            Console.WriteLine("-------------part-2 of assignment containing 13 Questions---------------- \n");
            Console.Write("enter the serial number of question (19-31) you want (0 to exit): ");
            inputChoice= Console.ReadLine();
            Console.WriteLine();
            choice = Convert.ToInt32(inputChoice);
            while (choice != 0)
            {
                switch (choice)
                {
                    case 19:
                        
                         SmallestElementinArray();
                        break;
                    case 20:
                        LargestElementinArray();

                        break;
                    case 21:
                        TotalEvenNumberinArray();
                        break;
                    case 22:
                        TotalOccurenceofElement();
                        break;
                    case 23:
                        Palindrome();
                        break;
                    case 24:
                         MergeTwoArrays();
                        break;
                    case 25:
                        SumofMatrices();
                        break;
                    case 26:
                        MultiplicationofMatrix();
                        break;
                    case 27:
                         TransposeofMatrix();
                        break;
                    case 28:
                        
                        break;
                    case 29:
                        
                        break;
                    case 30:
                        
                        break;
                    case 31:
                       
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.Write("\n\nenter the serial number of question (19-31) you want (0 to exit): ");
                inputChoice = Console.ReadLine();
                Console.WriteLine();
                choice = Convert.ToInt32(inputChoice);
            }
            Console.Write("Code submitted by SAYAN BANERJEE for wedmist training");          
    }
}
}