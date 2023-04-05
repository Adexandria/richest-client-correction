
//2.Write a method that solves the following

//You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer
//has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
//A customer's wealth is the amount of money they have in all their bank accounts.
// The richest customer is the customer that has the maximum wealth.


//declar the accounts
// store the wealth 
//run for loop
//store the sum
//run for loop
//add sum to the second account
//find the greatest sum


// MULTYDIAMENSION
int i, j;
int l,v;Console.ReadLine();
int[,] Input = new int[2, 3];

for (i = 0; i < 2; i++)
{
    for (j = 0; j < 3; j++)
    {
        Console.WriteLine("ENTER THE AMMOUNT FOR EACH ACCOUNTS: ");
        Input[i, j] = int.Parse(Console.ReadLine());
    }
}
GetRich(Input);



static int GetRich(int[,] Input)
{
    int maxW = 0;

    for (int i = 0; i < Input.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Input.GetLength(1); j++)
        {
            sum = sum + Input[i, j];
            maxW = Math.Max(maxW, sum);
        }
    }
    Console.WriteLine("THE NET WORTH OF THE WEALTHIEST CUSTOMER : {0}", maxW);
    return maxW;
}




//JAGGED ARRAY
//Console.WriteLine("Hello, World!");

// declaring the array
//int[][] account = new int[2][];

// assiging elements to the arrays
//account[0] = new int[3] { 9, 9, 9 };
//account[1] = new int[3] {4, 5, 6 };


//RichestCustomer(account);
//  static int RichestCustomer(int[][] account)
//{

//int Wealth = 0;

//using for loop to iterate through the first arrays
//for (int i = 0; i < account.Length; i++)
//{

//int sum = 0;

//using for loop to iterate through the inner arrays
//  for ( int j = 0; j < account[i].Length; j++)
//  {
//calculating the sum of all the array elements
//    sum = sum + account[i][j];
// }
//checking for the maximum number
// Wealth = Math.Max(Wealth, sum);
// }
//returning in the maximum 
//Console.WriteLine(Wealth);
//  return Wealth;
//}








//int[][] accounts = new int[2][];

//accounts[0] = new int[3] { 1, 2, 3 };
//accounts[1] = new int[3] { 3, 4, 5 };

//for ( int i = 0; i < accounts.Length; i++)
//{
//  int sum = 0;
//  int[] inneracc = accounts[i];

// for (int j =0; j < inneracc.Length; j++)
//{
//  int sum += accounts[i][j];
//Console.WriteLine(inneracc[j]);
// }
//Console.WriteLine();
//}

//static int Richest(int[][] accounts)
//{
//    int wealth = 0;
//    for (int i = 0; i < accounts.Length; i++)
//    {
//       int sum = 0;
//       for (int j = 0; j < accounts[i].Length; j++)
//       {
//           sum = sum + accounts[i][j];
//       }
//       wealth = Math.Max(wealth, sum);
//   }
//   return wealth;
//}