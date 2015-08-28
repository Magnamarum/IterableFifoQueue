using NUnit.Framework;
using IterableFifoQueue;


namespace IterableFifoQueueTest
{
    [TestFixture]
    public class Tests
    {
        [TestCase]
        public void testQueueAddAValue()
        {
            CustomQueue<Element> customQueue = new CustomQueue<Element>();
            Element e = new Element(1, "A");
            customQueue.Enqueue(e);

            Assert.AreEqual(e.getText(), customQueue.Dequeue().getText());
        }
        [TestCase]
        public void testQueueAddMaxValue()
        {

            CustomQueue<Element> customQueue = new CustomQueue<Element>();
        }

        [TestCase]
        public void testQueueAddMinValue()
        {

        }

        [TestCase]
        public void testQueueAddMediumValue()
        {

        }

        [TestCase]
        public void testQueueSecuenceInOrder()
        {

        }
    }
}
