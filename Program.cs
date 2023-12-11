// See https://aka.ms/new-console-template for more information

var newData = 5f;

Console.WriteLine("Hello, World!{0}",newData);


System.Console.WriteLine("Enter four numbers separated by comma ,");
string inputNumbers = System.Console.ReadLine();
string[] strings = inputNumbers.Split(',');
var numbersArray = new int[strings.Length];

for (int i = 0; i < strings.Length; i++)
{
    numbersArray[i] = Convert.ToInt32(strings[i]);
}
var operation = new PerformOperation();

for (int i = 0; i < 6; i++)
{
    int result = operation.PerformOperationForNumbers(i,numbersArray[0] , numbersArray[1],numbersArray[2]);
    System.Console.WriteLine("result is {0}" , result);
    if(result == numbersArray[numbersArray.Length-1])
    {
        System.Console.WriteLine("Yes");
        break;
    }
    else
    {
        if (i == 5)
        {
            System.Console.WriteLine("No");

        }
        continue;
    }
}




