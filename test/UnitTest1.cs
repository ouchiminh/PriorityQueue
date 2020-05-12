using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriorityQueueEmptyTest()
        {
            PriorityQueue.PriorityQueue<int> queue = new PriorityQueue.PriorityQueue<int>();
            Assert.IsTrue(queue.Empty);
        }
        [TestMethod]
        public void PriorityQueueTest()
        {
            PriorityQueue.PriorityQueue<int> queue = new PriorityQueue.PriorityQueue<int>();
            var ans = new int[] { 1, 2, 3, 4, 6, 8, 9 };
            queue.Enqueue(new int[] { 1, 4, 2, 3, 9, 8, 6 });

            var i = 0;
            while (!queue.Empty)
            {
                Assert.AreEqual(ans[i++], queue.Dequeue());
            }
        }
    }
}
