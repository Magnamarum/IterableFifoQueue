using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IterableFifoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<Element> elements = new CustomQueue<Element>();
            Random rand = new Random();
            for (int i = 0; i < 150; i++)
            {
                elements.Enqueue(new Element(rand.Next(1, 10), " " + i));
            }
            Console.Out.WriteLine("Foreach Iterator");
            foreach (Element e in elements)
            {
                Console.Out.WriteLine(e.getText() + " " + e.getPriority());
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine("Real time Dequeueing");
            while (elements.Count > 0)
            {
                Element e = elements.Dequeue();
                Console.Out.WriteLine(e.getText() + " " + e.getPriority());
            }
            Console.Read();

        }
    }


}
