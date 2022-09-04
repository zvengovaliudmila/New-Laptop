#nullable disable


   Console.WriteLine("Введите длину массива:");
   bool isNumber = int.TryParse(Console.ReadLine(), out int length);

   if(!isNumber || length <= 0)
   {
       Console.WriteLine("Неправильный ввод");
       throw new Exception("Неправильный ввод!");
   }

   FillArray(length);
   
   int[] FillArray(int length)
   {
      int[]array = new int [length];
      string input = Console.ReadLine();
      string[] inputArray = input.Split(",");

      for( int i = 0; i < inputArray.Length; i++)
      {
         Console.Write($"{inputArray[i]}");
      }

      return array;
   }
   










   


