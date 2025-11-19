public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname ="Yuna Shrestha";
    }

    public int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        return total;
    }
}