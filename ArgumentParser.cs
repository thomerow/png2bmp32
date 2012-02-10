using System;
using System.Collections.Generic;

namespace png2bmp32
{
  class PathParsedEventArgs : EventArgs
   {
      public string Path { get; private set; }

      public PathParsedEventArgs(string path)
      {
         Path = path;
      }
   }

   delegate void PathParsedEventHandler(object sender, PathParsedEventArgs e);

   class ArgumentParser
   {
      public string[] Args { get; private set; }

      public ArgumentParser(string[] args)
      {
         Args = args;
      }

      public event PathParsedEventHandler InputPathParsed;
      public event PathParsedEventHandler OutputPathParsed;
      public event EventHandler FinishedArgumentParsing;

      protected virtual void OnInputPathParsed(PathParsedEventArgs e)
      {
         if (InputPathParsed == null) return;
         InputPathParsed(this, e);
      }

      protected virtual void OnOutputPathParsed(PathParsedEventArgs e)
      {
         if (OutputPathParsed == null) return;
         OutputPathParsed(this, e);
      }

      protected virtual void OnFinishedArgumentParsing(EventArgs e)
      {
         if (FinishedArgumentParsing == null) return;
         FinishedArgumentParsing(this, e);
      }

      internal void Parse()
      {
         if (Args.Length != 2) throw new Exception(Properties.Resource.strCmdLnParamCount);

         OnInputPathParsed(new PathParsedEventArgs(Args[0]));
         OnOutputPathParsed(new PathParsedEventArgs(Args[1]));
         OnFinishedArgumentParsing(new EventArgs());
      }
   }
}
