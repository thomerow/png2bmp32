using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace png2bmp32
{
   class ImageTools
   {
      internal static bool IsPNG(byte[] imageData)
      {
         const UInt32 uPNGHead = 0x474e5089;

         return ((imageData.Length >= 4) && (BitConverter.ToUInt32(imageData, 0) == uPNGHead));
      }
   }
}
