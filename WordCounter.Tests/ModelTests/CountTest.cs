using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void Constructor_CreateSetWordSentence_WordSentence()
    {
      string wrd = "word";
      string sent = "This is a sentence";
      RepeatCounter newSentence = new RepeatCounter(wrd, sent);
      string sent2 = newSentence.GetSentence();
      string wrd2 = newSentence.GetWord();
      Assert.AreEqual(sent, sent2);
      Assert.AreEqual(wrd, wrd2);
    }

  }


}
