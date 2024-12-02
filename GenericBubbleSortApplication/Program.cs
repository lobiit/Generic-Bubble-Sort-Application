// object[] arr = new Object[]
// {
//     2, 5, 1, 4, 6, 3, 1, 10, 9, 8, 7
// };


using System.Diagnostics.CodeAnalysis;

Employee[] arr = new Employee[]
{
    new Employee{Id = 3, Name = "Jane"},
    new Employee{Id = 2, Name = "Mary"},
    new Employee{Id = 1, Name = "John"},
    new Employee{Id = 8, Name = "Ann"},
    new Employee{Id = 7, Name = "Cindy"}
};
SortArray<Employee> sort = new SortArray<Employee>();
sort.BubbleSort(arr);

Console.WriteLine($"Sorted array:");

foreach (var item in arr)
{
    Console.WriteLine(item);
}


public class Employee: IComparable<Employee>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CompareTo([AllowNull]Employee other)
    {
        return this.Id.CompareTo(other.Id);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}
public class SortArray<T> where T : IComparable<T>
{
    public void BubbleSort(T[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j].CompareTo(arr[j + 1]) > 0)
                {
                    Swap(arr, j);
                }
            }
        }
    }

    private void Swap(T[] arr, int j)
    {
        T temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j+1] = temp;
    }
}