using png2bmp32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace png2bmp32.Test
{
    
    
    /// <summary>
    ///This is a test class for ImageConverterTest and is intended
    ///to contain all ImageConverterTest Unit Tests
    ///</summary>
   [TestClass()]
   public class ImageConverterTest
   {


      private TestContext testContextInstance;

      /// <summary>
      ///Gets or sets the test context which provides
      ///information about and functionality for the current test run.
      ///</summary>
      public TestContext TestContext
      {
         get
         {
            return testContextInstance;
         }
         set
         {
            testContextInstance = value;
         }
      }

      #region Additional test attributes
      // 
      //You can use the following additional attributes as you write your tests:
      //
      //Use ClassInitialize to run code before running the first test in the class
      //[ClassInitialize()]
      //public static void MyClassInitialize(TestContext testContext)
      //{
      //}
      //
      //Use ClassCleanup to run code after all tests in a class have run
      //[ClassCleanup()]
      //public static void MyClassCleanup()
      //{
      //}
      //
      //Use TestInitialize to run code before running each test
      //[TestInitialize()]
      //public void MyTestInitialize()
      //{
      //}
      //
      //Use TestCleanup to run code after each test has run
      //[TestCleanup()]
      //public void MyTestCleanup()
      //{
      //}
      //
      #endregion


      /// <summary>
      ///A test for Convert
      ///</summary>
      [TestMethod()]
      public void ConvertTest()
      {
         string path = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Test Files";
         string _inputPath = path + @"\is_png.bla"; // TODO: Initialize to an appropriate value
         string _outputPath = path + @"\test_output.bmp"; // TODO: Initialize to an appropriate value
         ImageConverter.Convert(_inputPath, _outputPath);
      }
   }
}
