using System;

namespace WordCounter {

  public class RepeatCounter
  {
    private string _sentence;

    public RepeatCounter (string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

  }

}
