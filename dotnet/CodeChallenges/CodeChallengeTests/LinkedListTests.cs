using System;
using Xunit;
using static LinkedLists.Program;

namespace CodeChallengeTests
{
    public class LinkedListTests
    {
      /// <summary>
      /// Activity test, return true or false that it did something
      /// </summary>
      [Fact]
      public void Linked_List_Activity_Test()
        {
            bool itWorks = LinkListActivity();
            Assert.True(itWorks);
        }
    }
}
