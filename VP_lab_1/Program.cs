int[] customers = new int[] { 10, 20, 15, 35, 12, 33, 5 };
int n = 3;
Console.Write("Очередь: ");
foreach (var count in customers) Console.Write($"{count} ");
Console.WriteLine();
Console.WriteLine($"Работающих касс: {n}");
HW1.QueueTime(customers, n);
public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int sum = 0;
        if (n == 1) {
            foreach (var count in customers)
            {
                sum += count;
            }
        }
        else
        {
            int m = customers.Length;
            int[] cash = new int[n];
            for(int i = 0; i < n; i++)
            {
                cash[i] = 0;
            }
            for(int i = 0; i < m; i++)
            {
               int min_time = 0;
               for(int j = 1; j < n; j++)
                {
                    if (cash[min_time] > cash[j]) min_time = j;
                }
                cash[min_time] += customers[i];
            }
            sum = cash[0];
            for(int i = 1; i < n; i++)
            {
                if (sum < cash[i]) sum = cash[i];
            }
        }
        Console.WriteLine($"Суммарное время: {sum}");
        return sum;
    }
}