static IList<string> BuildArray(int[] target, int n) {
  List<string> resultado = new List<string>();

  int targetIndex = 0;

  for (int i = 1; i <= n; i++)
  {
      if (targetIndex >= target.Length)
      { 
          break;
      }

      resultado.Add("Push");

      if (target[targetIndex] == i)
      {
          targetIndex++;
      }
      else
      {
          resultado.Add("Pop");
      }
  }

  return resultado;
}
