using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void FindAnagram_MatchOccurs_String()
    {
      //Arrange
      List<string> expected = new List<string>(){"beard"};
      //Act
      AnagramClass anagram = new AnagramClass("bread", "beard");
      List<string> actual = anagram.FindAnagram();
      //Assert
      CollectionAssert.AreEqual(expected, actual);
    }
  }
}
