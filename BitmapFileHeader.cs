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
   internal struct BitmapFileHeader
   {
      internal UInt16 bfType;
      internal UInt32 bfSize;
      internal UInt16 bfReserved1;
      internal UInt16 bfReserved2;
      internal UInt32 bfOffBits;

      /// <summary>
      /// …
      /// </summary>
      internal static uint Size
      {
         get { return (uint)Marshal.SizeOf(typeof(BitmapFileHeader)); }
      }

      /// <summary>
      /// …
      /// </summary>
      internal void Init()
      {
         bfType = (UInt16)((byte)'B' | ((byte)'M' << 8));
         bfOffBits = Size + BitmapInfoHeader.Size;
      }
   }
}
