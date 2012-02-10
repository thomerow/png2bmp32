using System;
using System.Collections.Generic;

namespace png2bmp32
{
   class Program
   {
      static void Main(string[] args)
      {
         Png2Bmp32 png2bmp32 = new Png2Bmp32(args);
         png2bmp32.Run();
      }
   }
}
