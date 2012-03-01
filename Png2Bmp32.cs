using System;
using System.Collections.Generic;

namespace png2bmp32
{
   /// <summary>
   /// …
   /// </summary>
   class Png2Bmp32
   {
      private string[] _args;
      private string _inputPath;
      private string _outputPath;

      /// <summary>
      /// …
      /// </summary>
      /// <param name="args">…</param>
      public Png2Bmp32(string[] args)
      {
         _args = args;
         _inputPath = "";
         _outputPath = "";
      }

      /// <summary>
      /// …
      /// </summary>
      internal void Run()
      {
         try
         {
            ArgumentParser parser = new ArgumentParser(_args);

            parser.InputPathParsed += new PathParsedEventHandler(parser_InputPathParsed);
            parser.OutputPathParsed += new PathParsedEventHandler(parser_OutputPathParsed);
            parser.FinishedArgumentParsing += new EventHandler(parser_FinishedArgumentParsing);

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
      void parser_FinishedArgumentParsing(object sender, EventArgs e)
      {
         ImageConverter.Convert(_inputPath, _outputPath);
      }

      /// <summary>
      /// …
      /// </summary>
      /// <param name="sender">…</param>
      /// <param name="e">…</param>
      void parser_InputPathParsed(object sender, PathParsedEventArgs e)
      {
         _inputPath = e.Path;
      }

      /// <summary>
      /// …
      /// </summary>
      /// <param name="sender">…</param>
      /// <param name="e">…</param>
      void parser_OutputPathParsed(object sender, PathParsedEventArgs e)
      {
         _outputPath = e.Path;
      }
   }
}
