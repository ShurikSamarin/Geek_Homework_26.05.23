// See https://aka.ms/new-console-template for more information
Console.WriteLine("If you want to stop, press Spacebar");
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    if (char.Parse(value)== ' ') 
    {
        Console.WriteLine("You stopped"); 
        int result_ = 0;
        return result_;
    }
    int result = Convert.ToInt32(value);
    return result;
}
int number = 1;
int i = 0;
while (number !=0)
{
number = Prompt("Input number");
if (number>0) {
    i++;
    }
else {
    break;
}
}
Console.WriteLine($"Quantity of numbers>0 = {i}");

Console.Clear();
int[]array = NewArray();
int count = Count(array);
Console.WriteLine($"Quantity of numbers>0: {count}");
Console.WriteLine(String.Join(' ',array));
int[] NewArray(){
    Console.Write("Input numbers by SpaceBar");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}
int Count(int[] arr){
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]>0){
            count ++;
        }
    }
    return count;
}

