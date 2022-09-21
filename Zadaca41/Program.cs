Console.WriteLine("введите количеств чисел");
int m = Convert.ToInt32(Console.ReadLine());
int []array = new int[m];
int count = 0;
for(int i = 0; i<array.Length;i++)
{
    array[i]= Convert.ToInt32(Console.ReadLine());
    if(array[i]>0)
    {
        count+=1;
    }
}
Console.WriteLine($"кличество положительных чисел = {count}");