static int[] SmallerNumbersThanCurrent(int[] nums) {
  int[] resultado = new int[nums.Length];

  for (int i = 0; i < nums.Length; i++)
  {
      int count = 0;
      for (int j = 0; j < nums.Length ; j++)
      {
          if (j != i && nums[j] < nums[i])
          {
              count++;
          }
      }
      resultado[i] = count;
  }
  
  return resultado;
}

int [] resultado = SmallerNumbersThanCurrent([6,5,4,8]);
Console.WriteLine($"[{string.Join(", ", resultado)}]");