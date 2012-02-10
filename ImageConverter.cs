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
         if (!Path.GetExtension(_inputPath).Equals(".png", StringComparison.CurrentCultureIgnoreCase)) {
            throw new Exception("Input file has to be a PNG image.");
         }
         byte[] inputData = File.ReadAllBytes(_inputPath);
      }
   }
}
