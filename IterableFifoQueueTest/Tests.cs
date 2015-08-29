using NUnit.Framework;
using IterableFifoQueue;
using System;


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
            Element maxElement = new Element(10, "This is max");
            customQueue.Enqueue(new Element(1, "This is not max"));
            customQueue.Enqueue(new Element(5, "This is not max"));
            customQueue.Enqueue(new Element(4, "This is not max"));
            customQueue.Enqueue(maxElement);
            customQueue.Enqueue(new Element(1, "This is not max"));
            customQueue.Enqueue(new Element(7, "This is not max"));
            customQueue.Enqueue(new Element(9, "This is not max"));

            Assert.AreEqual(maxElement.getText(), customQueue.Dequeue().getText());
        }

        [TestCase]
        public void testQueueAddMinValue()
        {
            CustomQueue<Element> customQueue = new CustomQueue<Element>();
            Element minElement = new Element(1, "This is min");

            customQueue.Enqueue(new Element(14, "This is not max"));
            customQueue.Enqueue(new Element(5, "This is not max"));
            customQueue.Enqueue(new Element(4, "This is not max"));
            customQueue.Enqueue(minElement);
            customQueue.Enqueue(new Element(2, "This is not max"));
            customQueue.Enqueue(new Element(7, "This is not max"));
            customQueue.Enqueue(new Element(9, "This is not max"));
            Assert.AreEqual(minElement.getText(), customQueue.LowerPriority().getText());
        }

        [TestCase]
        public void testQueueSecuenceInOrder()
        {

            CustomQueue<Element> customQueue = new CustomQueue<Element>();
            customQueue.Enqueue(new Element(5, "B"));
            customQueue.Enqueue(new Element(3, "D"));
            customQueue.Enqueue(new Element(4, "C"));
            customQueue.Enqueue(new Element(2, "E"));
            customQueue.Enqueue(new Element(1, "F"));
            customQueue.Enqueue(new Element(6, "A"));

            Assert.AreEqual("A", customQueue.Dequeue().getText());
            Assert.AreEqual("B", customQueue.Dequeue().getText());
            Assert.AreEqual("C", customQueue.Dequeue().getText());
            Assert.AreEqual("D", customQueue.Dequeue().getText());
            Assert.AreEqual("E", customQueue.Dequeue().getText());
            Assert.AreEqual("F", customQueue.Dequeue().getText());
        }
    }
}
