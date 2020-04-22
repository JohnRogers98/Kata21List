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
        public void NodeTwoConnectCreateTest()
        {
            String contentFirstNode = "This is first link";
            String contentSecondNode = "This is second link";
            String contentThirdNode = "This is third link";

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

            ZNode nodeThree = new ZNode()
            {
                Index = 3,
                Content = contentThirdNode
            };

            nodeOne.NextNode = nodeTwo;
            nodeTwo.NextNode = nodeThree;

            nodeTwo.PreviousNode = nodeOne;
            nodeThree.PreviousNode = nodeTwo;

            Assert.AreEqual(nodeOne, nodeThree.PreviousNode.PreviousNode);
        }

        [TestMethod]
        public void ZListAddNodeTest()
        {
            ZList list = new ZList();
            list.Add("1");
            list.Add("2");

            Assert.AreEqual("1", list.GetContentOfIndex(0));
            Assert.AreEqual("2", list.GetContentOfIndex(1));
        }


        [TestMethod]
        public void ZListTwoConnectDeleteNodeTest()
        {
            ZListTwoConnect list = new ZListTwoConnect();
            list.Add("1");
            list.Add("2");

            Boolean status = list.Delete(1);

            Assert.AreEqual(true, status);
        }

        [TestMethod]
        public void ZListTwoConnectDeleteNotExistNodeTest()
        {
            ZListTwoConnect list = new ZListTwoConnect();
            list.Add("1");
            list.Add("2");

            list.Delete(1);
            Boolean status = list.Delete(1);

            Assert.AreEqual(false, status);
        }
    }
}
