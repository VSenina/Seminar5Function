// задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// найдите сумму отрицательных и положительных элементов

 int[] CreateRandomArray ( int size, int minValue, int maxValue)
{
  int[] newArray = new int[size];
  for ( int i = 0; i < size; i++)
  {
    newArray[i] = new Random ().Next (minValue, maxValue +1);
  }

  return newArray;

}

void ShowArray ( int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine (array[i] + " ");
}
Console.WriteLine ();
}

void FindSum ( int[] array)
{
  int SumPos = 0;
  int SumNeg = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] >=0 ) SumPos += array[i];
    else SumNeg += array[i];
  }
  Console.WriteLine ($"Sum of Positive digits is -> {SumPos}, Sum of negative digits is -> {SumNeg}");
  }

  Console.WriteLine ("Input array size: ");
  int size = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine ("Input minimal value of array elements:");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine ("Input maximal value of array elements:");
  int maxValue = Convert.ToInt32(Console.ReadLine());

  int[] myarray = CreateRandomArray ( size, minValue, maxValue);
  ShowArray ( myarray);
  FindSum ( myarray);
