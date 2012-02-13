using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace png2bmp32
{
   [StructLayout(LayoutKind.Sequential, Pack = 1)]
   public struct BitmapFileHeader
   {
      public UInt16 bfType;
      public UInt32 bfSize;
      public UInt16 bfReserved1;
      public UInt16 bfReserved2;
      public UInt32 bfOffBits;

      internal static uint Size
      {
         get { return (uint)Marshal.SizeOf(typeof(BitmapFileHeader)); }
      }

      internal void Init()
      {
         bfType = (UInt16)((byte)'B' | ((byte)'M' << 8));
         bfOffBits = Size + BitmapInfoHeader.Size;
      }
   }
}
