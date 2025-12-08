static int[] FindErrorNums(int[] nums)
{
  long n = nums.Length;

  long somaReal = 0;
  long somaQuadradosReal = 0;

  foreach (int num in nums)
  {
    somaReal += num;
    somaQuadradosReal += (long)num * num;
  }

  long somaEsperada = n * (n + 1) / 2;

  long somaQuadradosEsperada = n * (n + 1) * (2 * n + 1) / 6;

  long diferencaSoma = somaReal - somaEsperada;

  long diferencaQuadrados = somaQuadradosReal - somaQuadradosEsperada;

  long somaDeAmbos = diferencaQuadrados / diferencaSoma;

  int duplicado = (int)((diferencaSoma + somaDeAmbos) / 2);
  int faltando = (int)((somaDeAmbos - diferencaSoma) / 2);

  return [duplicado, faltando];
}

int[] resultado = FindErrorNums([2,2]);
Console.WriteLine($"[{string.Join(", ", resultado)}]");