using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace png2bmp32
{
   /// <summary>
   /// …
   /// </summary>
   class Png2Bmp32
   {
      private string[] _args;
      private string _inputPath = "";
      private string _inputDir = "";

      /// <summary>
      /// …
      /// </summary>
      /// <param name="args">…</param>
      public Png2Bmp32(string[] args)
      {
         _args = args;
      }

      /// <summary>
      /// …
      /// </summary>
      internal void Run()
      {
         try
         {
            ArgumentParser parser = new ArgumentParser(_args);

            parser.InputPathParsed += Parser_InputPathParsed;
            parser.FinishedArgumentParsing += Parser_FinishedArgumentParsing;

            parser.Parse();
         }
         catch (Exception exc)
         {
            Console.Error.WriteLine(Properties.Resource.strErr, exc.Message);
            Environment.ExitCode = -1;
         }
      }

      /// <summary>
      /// …
      /// </summary>
      /// <param name="sender">…</param>
      /// <param name="e">…</param>
      void Parser_FinishedArgumentParsing(object sender, EventArgs e)
      {
         Convert();
      }

      /// <summary>
      /// …
      /// </summary>
      private void Convert()
      {
         if (!string.IsNullOrEmpty(_inputDir)) ConvertDir();
         else ConvertPath();
      }

      /// <summary>
      /// …
      /// </summary>
      private void ConvertPath()
      {
         ImageConverter.Convert(_inputPath);
      }

      /// <summary>
      /// …
      /// </summary>
      private void ConvertDir()
      {
         ConvertDir(_inputDir);
      }

      /// <summary>
      /// …
      /// </summary>
      /// <param name="dir">…</param>
      private void ConvertDir(string dir)
      {
         foreach (string d in Directory.GetDirectories(dir))
         {
            ConvertDir(d);
         }

         string[] files = Directory.GetFiles(dir, "*.png");
         Parallel.ForEach(files, path => ImageConverter.Convert(path));
      }

      /// <summary>
      /// …
      /// </summary>
      /// <param name="sender">…</param>
      /// <param name="e">…</param>
      void Parser_InputPathParsed(object sender, PathParsedEventArgs e)
      {
         FileAttributes fa = File.GetAttributes(e.Path);
         if ((fa & FileAttributes.Directory) != 0) _inputDir = e.Path;
         else _inputPath = e.Path;
      }
   }
}
