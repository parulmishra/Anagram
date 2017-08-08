using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class AnagramClass
  {
    private string _word1;
    private string _word2;

    private static List<string> _wordList = new List<string>();
    public AnagramClass(string word1, string word2)
    {
      _word1 = word1;
      _word2 = word2;
      string [] _word2Arr = _word2.Split(' ');
      _wordList.AddRange(_word2Arr);
    }
    public string GetWord1()
    {
      return _word1;
    }
    public string GetWord2()
    {
      return _word2;
    }
    public List<string> GetWordList()
    {
      return _wordList;
    }
    public bool IsAnagram(char [] arr1, char [] arr2)
    {
      bool isAnagram = true;
      for (int i = 0; i< arr1.Length; i++)
      {
        if (arr1[i] != arr2[i])
        {
            isAnagram = false;
        }
      }
      return isAnagram;
    }
    public List<string> FindAnagram()
    {
      List<string> anagramList =  new List<string>();

      foreach (string word in _wordList)
      {
        char [] word1CharArr = _word1.ToCharArray();
        Array.Sort(word1CharArr);
        char [] temp = word.ToCharArray();
        Array.Sort(temp);

        if (temp.Length != _word1.Length)
        {
          continue;
        }
        else
        {
          bool isAnagram = IsAnagram(temp, word1CharArr);
          if (isAnagram == true)
          {
            Console.WriteLine("Message: " + word + " and " + _word1 + " are anagrams");
            anagramList.Add(word);
          }
        }
      }
      return anagramList;
    }
  }
}
