using System;

namespace WordCounter.Models {

  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _count;

    public RepeatCounter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }
    public string GetWord()
    {
      return _word;
    }

    public int Count()
    {
      int count = 0;
      string[] sentArray = _sentence.Split(' ');
      foreach (string i in sentArray)
      {
        if (i == _word)
        {
          count++;
        }
      }
      _count = count;
      return _count;

     }

  }

}
