using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework;
using ВDailyTask;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// Этот файл содержит автоматически созданные тесты.
// Не изменяйте этот файл вручную.
// 
// Если содержимое файла устареет, его можно будет удалить.
// Например, если файл больше не компилируется.
// </auto-generated>
using System;

namespace ВDailyTask.Tests
{
    public partial class CityModelBuilderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException527()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(2, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException577()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(2, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(OutOfMemoryException))]
public void CreateCityModelTestThrowsOutOfMemoryException120()
{
    using (PexPConsoleInContext.Create())
    {
      OutOfMemoryException outOfMemoryException;
      CityModel cityModel;
      outOfMemoryException = new OutOfMemoryException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(1, "throw", (object)outOfMemoryException);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(IOException))]
public void CreateCityModelTestThrowsIOException998()
{
    using (PexPConsoleInContext.Create())
    {
      IOException iOException;
      CityModel cityModel;
      iOException = new IOException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(0, "peeked", (object)true)
          .At(2, "throw", (object)iOException)
          .At(1, "peek", (object)' ');
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void CreateCityModelTestThrowsArgumentOutOfRangeException911()
{
    using (PexPConsoleInContext.Create())
    {
      ArgumentOutOfRangeException argumentOutOfRangeException;
      CityModel cityModel;
      argumentOutOfRangeException = new ArgumentOutOfRangeException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(1, "throw", (object)argumentOutOfRangeException);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
public void CreateCityModelTest79601()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-0")
          .At(6, "line", "-0");
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
      Assert.IsNotNull((object)s0);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException857()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "")
          .At(6, "line", "0")
          .At(8, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "0");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(OutOfMemoryException))]
public void CreateCityModelTestThrowsOutOfMemoryException266()
{
    using (PexPConsoleInContext.Create())
    {
      OutOfMemoryException outOfMemoryException;
      CityModel cityModel;
      outOfMemoryException = new OutOfMemoryException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "e")
          .At(4, "throw", (object)outOfMemoryException);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "e");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException964()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "")
          .At(6, "line", "")
          .At(8, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(OutOfMemoryException))]
public void CreateCityModelTestThrowsOutOfMemoryException409()
{
    using (PexPConsoleInContext.Create())
    {
      OutOfMemoryException outOfMemoryException;
      CityModel cityModel;
      outOfMemoryException = new OutOfMemoryException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "")
          .At(6, "line", "")
          .At(7, "throw", (object)outOfMemoryException);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, "");
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException632()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", "e\0\0")
          .At(6, "line", "e\0\0")
          .At(8, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException666()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(0, "peeked", (object)true)
          .At(1, "peek", (object)' ')
          .At(3, "line", ".")
          .At(5, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(OutOfMemoryException))]
public void CreateCityModelTestThrowsOutOfMemoryException351()
{
    using (PexPConsoleInContext.Create())
    {
      OutOfMemoryException outOfMemoryException;
      CityModel cityModel;
      outOfMemoryException = new OutOfMemoryException();
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.NextSegment(1).DefaultSession
          .At(3, "line", "-0")
          .At(4, "throw", (object)outOfMemoryException);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}

[TestMethod]
[PexGeneratedBy(typeof(CityModelBuilderTest))]
[PexRaisedException(typeof(ObjectDisposedException))]
public void CreateCityModelTestThrowsObjectDisposedException339()
{
    using (PexPConsoleInContext.Create())
    {
      CityModel cityModel;
      IPexChoiceRecorder choices = PexChoose.Replay.Setup();
      choices.DefaultSession
          .At(3, "line", "-0")
          .At(6, "line", "-")
          .At(8, "close", (object)true);
      CityModelBuilder s0 = new CityModelBuilder();
      cityModel = this.CreateCityModelTest(s0, (string)null);
    }
}
    }
}
