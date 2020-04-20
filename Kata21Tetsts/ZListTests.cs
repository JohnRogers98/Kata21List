using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kata21;

namespace Kata21Tetsts
{
    [TestClass]
    public class ZListTests
    {
        [TestMethod]
        public void NodeCreateTest()
        {
            String contentFirstNode = "This is first link";
            String contentSecondNode = "This is second link";

            ZNode nodeOne = new ZNode()
            {
                Index = 1,
                Content = contentFirstNode 
            };

            ZNode nodeTwo = new ZNode()
            {
                Index = 2,
                Content = contentSecondNode
            };
            nodeOne.NextNode = nodeTwo;

            Assert.AreEqual(contentSecondNode, nodeOne.NextNode.Content);
        }

        [TestMethod]
        public void ZListAddNodeTest()
        {
            ZList list = new ZList();
            list.Add("1");
            list.Add("2");

            Assert.AreEqual("1", list.GetElementOfIndex(0));
            Assert.AreEqual("2", list.GetElementOfIndex(1));
        }

    }
}
