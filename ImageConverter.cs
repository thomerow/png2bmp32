using System;
using System.Collections.Generic;
using System.IO;

namespace png2bmp32
{
   class ImageConverter
   {
      internal static void Convert(string _inputPath, string _outputPath)
      {
#if DEBUG
         Console.WriteLine("Input path: \"{0}\", output path: \"{1}\"", _inputPath, _outputPath);
#endif
         byte[] inputData = File.ReadAllBytes(_inputPath);

         if (!IsPNG(inputData)) throw new Exception(Properties.Resource.strNoPNGData);
      }

      private static bool IsPNG(byte[] inputData)
      {
         throw new NotImplementedException();
      }
   }
}
