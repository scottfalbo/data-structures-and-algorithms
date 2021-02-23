using System;
using System.Collections.Generic;
using System.Text;
using Challenges;
using Xunit;

namespace CodeChallengeTests
{
    public class RepeatedWordTests
    {

        [Fact]
        public void Successfully_Strip_A_String_Of_Punctuation()
        {
            string testString = "Here is a string, it has some words, and some puncuation.";
            string actual = RepeatedWord.StripPunctuation(testString);
            string expected = "Here is a string it has some words and some puncuation";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Successfully_Split_A_String_Into_An_Array()
        {
            string testString = "Here is a string, it has some words, and some puncuation.";
            string[] actual = RepeatedWord.SplitString(testString);
            string[] expected = new string[]
            {
                "Here", "is", "a", "string", "it", "has", "some", "words", "and", "some", "puncuation"
            };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Successfully_Return_The_First_Repeated_Word()
        {
            string input = "Once upon a time, there was a brave princess who";
            string actual = RepeatedWord.RepeatWord(input);
            string expected = "a";
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Reutrn_Null_If_There_Are_No_Repeats()
        {
            string input = "There are no repeats in this sentence.";
            Assert.Null(RepeatedWord.RepeatWord(input));
        }

        [Fact]
        public void Return_Null_If_Input_String_Is_Empty()
        {
            string input = "";
            Assert.Null(RepeatedWord.RepeatWord(input));
        }

        [Fact]
        public void Find_A_Repeating_Word_Despite_Case()
        {
            string testString = "Here is a string.  It has the word here twice.";
            string actual = RepeatedWord.RepeatWord(testString);
            string expected = "here";
            Assert.Equal(expected, actual);
        }
    }
}
