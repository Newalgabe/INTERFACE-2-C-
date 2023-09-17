// task 1
//public interface ICalc
//{
//    int Less(int valueToCompare);
//    int Greater(int valueToCompare);
//}

//public class MyArray : ICalc
//{
//    private int[] elements;

//    public MyArray(int[] array)
//    {
//        elements = array;
//    }

//    public int Less(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int element in elements)
//        {
//            if (element < valueToCompare)
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//    public int Greater(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int element in elements)
//        {
//            if (element > valueToCompare)
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//    public void DisplayResults(int valueToCompare)
//    {
//        Console.WriteLine($"Number of elements less than {valueToCompare}: {Less(valueToCompare)}");
//        Console.WriteLine($"Number of elements greater than {valueToCompare}: {Greater(valueToCompare)}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 1, 2, 3, 4, 5 };
//        MyArray array = new MyArray(myArray);

//        int valueToCompare = 3;
//        array.DisplayResults(valueToCompare);
//    }
//}



// task 2
//public interface IOutput2
//{
//    void ShowEven();
//    void ShowOdd();
//}

//public class MyArray : IOutput2
//{
//    private int[] elements;

//    public MyArray(int[] array)
//    {
//        elements = array;
//    }

//    public void ShowEven()
//    {
//        Console.WriteLine("Even elements:");
//        foreach (int element in elements)
//        {
//            if (element % 2 == 0)
//                Console.Write($"{element} ");
//        }
//        Console.WriteLine();
//    }

//    public void ShowOdd()
//    {
//        Console.WriteLine("Odd elements:");
//        foreach (int element in elements)
//        {
//            if (element % 2 != 0)
//                Console.Write($"{element} ");
//        }
//        Console.WriteLine();
//    }

//    public void DisplayEvenOdd()
//    {
//        ShowEven();
//        ShowOdd();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 1, 2, 3, 4, 5 };
//        MyArray array = new MyArray(myArray);

//        array.DisplayEvenOdd();
//    }
//}



// task 3
//public interface ICalc2
//{
//    int CountDistinct();
//    int EqualToValue(int valueToCompare);
//}

//public class MyArray : ICalc2
//{
//    private int[] elements;

//    public MyArray(int[] array)
//    {
//        elements = array;
//    }

//    public int CountDistinct()
//    {
//        int distinctCount = 0;
//        for (int i = 0; i < elements.Length; i++)
//        {
//            bool isDistinct = true;
//            for (int j = 0; j < i; j++)
//            {
//                if (elements[i] == elements[j])
//                {
//                    isDistinct = false;
//                    break;
//                }
//            }
//            if (isDistinct)
//            {
//                distinctCount++;
//            }
//        }
//        return distinctCount;
//    }

//    public int EqualToValue(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int element in elements)
//        {
//            if (element == valueToCompare)
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//    public void DisplayResults(int valueToCompare)
//    {
//        Console.WriteLine($"Number of distinct elements: {CountDistinct()}");
//        Console.WriteLine($"Number of elements equal to {valueToCompare}: {EqualToValue(valueToCompare)}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 1, 2, 3, 4, 2, 3, 5 };
//        MyArray array = new MyArray(myArray);

//        int valueToCompare = 3;
//        array.DisplayResults(valueToCompare);
//    }
//}