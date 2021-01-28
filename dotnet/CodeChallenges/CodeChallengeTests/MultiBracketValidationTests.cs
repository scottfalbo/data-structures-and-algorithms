using System;
using Xunit;
using Challenges;
using DataStructures;

namespace CodeChallengeTests
{
    public class MultiBracketValidationTests
    {
        [Theory]
        [InlineData("()[]")]
        [InlineData("(){}[]")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(({}))[[{}]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void Happy_Paths_True(string testString)
        {
            bool result = MultiBracketValidation.Validate(testString);
            Assert.True(result);
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("{(})")]
        public void Expected_False_Returns(string testString)
        {
            bool result = MultiBracketValidation.Validate(testString);
            Assert.False(result);
        }

        [Fact]
        public void ArugmentException_Error_If_Empty_String()
        {
            Assert.Throws<ArgumentException>(() => 
                MultiBracketValidation.Validate(""));
        }

        [Fact]
        public void ArgumentException_If_There_Are_No_Brackets()
        {
            Assert.Throws<ArgumentException>(() =>
                MultiBracketValidation.Validate("I have no brackets"));
        }

    }
}
