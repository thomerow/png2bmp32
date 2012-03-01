using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace png2bmp32
{
   /// <summary>
   /// …
   /// </summary>
   [StructLayout(LayoutKind.Sequential, Pack = 1)]
   internal struct BitmapInfoHeader
   {
      internal UInt32 biSize;
      internal Int32 biWidth;
      internal Int32 biHeight;
      internal UInt16 biPlanes;
      internal UInt16 biBitCount;
      internal UInt32 biCompression;
      internal UInt32 biSizeImage;
      internal Int32 biXPelsPerMeter;
      internal Int32 biYPelsPerMeter;
      internal UInt32 biClrUsed;
      internal UInt32 biClrImportant;

      /// <summary>
      /// …
      /// </summary>
      internal static uint Size
      {
         get { return (uint)Marshal.SizeOf(typeof(BitmapInfoHeader)); }
      }

      /// <summary>
      /// …
      /// </summary>
      internal void Init()
      {
         biSize = Size;
      }
   }
}
