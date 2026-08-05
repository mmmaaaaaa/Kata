namespace _39_Product_of_Array_Items;

public class Solution
{
    public static int Product(int[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }
        if (values.Length == 0)
        {
            throw new InvalidOperationException();
        }
        return values.Aggregate(1, (acc, val) => acc * val);
    }
}