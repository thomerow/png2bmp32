using System;
using System.Collections.Generic;

namespace png2bmp32
{
   class Png2Bmp32
   {
      private string[] _args;
      private string _inputPath;
      private string _outputPath;

      public Png2Bmp32(string[] args)
      {
         _args = args;
         _inputPath = "";
         _outputPath = "";
      }

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
            Console.WriteLine(Properties.Resource.strErr, exc.Message);
         }
      }

      void parser_FinishedArgumentParsing(object sender, EventArgs e)
      {
         ImageConverter.Convert(_inputPath, _outputPath);
      }

      void parser_InputPathParsed(object sender, PathParsedEventArgs e)
      {
         _inputPath = e.Path;
      }

      void parser_OutputPathParsed(object sender, PathParsedEventArgs e)
      {
         _outputPath = e.Path;
      }
   }
}
