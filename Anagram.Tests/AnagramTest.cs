using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest : IDisposable
  {
    public void Dispose()
    {
      AnagramClass.ClearAll();
    }
    [TestMethod]
    public void FindAnagram_MatchOccursOneOutOfOne_ListOfString()
    {
      //Arrange
      List<string> expected = new List<string>(){"beard"};
      //Act
      AnagramClass anagram = new AnagramClass("bread", "beard");
      List<string> actual = anagram.FindAnagram();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FindAnagram_MatchOccursOneOutOfMultiple_ListOfString()
    {
      //Arrange
      List<string> expected = new List<string>(){"bread"};
      //Act
      AnagramClass anagram = new AnagramClass("beard", "bread");
      List<string> actual = anagram.FindAnagram();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FindAnagram_MatchDoesNotOccursEmptyOutOfMultiple_ListOfString()
    {
      //Arrange
      List<string> expected = new List<string>(){"Error Message : Please enter the word to match."};
      //Act
      AnagramClass anagram = new AnagramClass("", "bread bottom");
      List<string> actual = anagram.FindAnagram();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FindAnagram_MatchDoesNotOccursWordOutOfEmptyList_ListOfString()
    {
      //Arrange
      List<string> expected = new List<string>(){"Error Message : Please enter the list of words to match."};
      //Act
      AnagramClass anagram = new AnagramClass("bread", "");
      List<string> actual = anagram.FindAnagram();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FindAnagram_MatchDoesNotOccurs_ListOfString()
    {
      //Arrange
      List<string> expected = new List<string>(){"Message: No anagrams found."};
      //Act
      AnagramClass anagram = new AnagramClass("bread", "bottom program top");
      List<string> actual = anagram.FindAnagram();
      if (actual.Count == 0)
      {
        Console.WriteLine("No elemtnt in the list.");
      }else
      {
        foreach(string s in actual)
        {
          Console.WriteLine("Actual result : " + s);

        }

      }
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
