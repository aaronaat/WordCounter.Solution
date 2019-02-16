using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void SentenceConstructor_CreateSentence_Sentence()
    {
      string sent = "This is a sentence";
      RepeatCounter newSentence = new RepeatCounter(sent);
      string sent2 = newSentence.GetSentence();
      Assert.AreEqual(sent, sent2);
    }
  }


}
