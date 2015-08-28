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
            CustomQueue<Element> elementos = new CustomQueue<Element>();
            Random rand = new Random();
            for (int i = 0; i < 150; i++) {
                elementos.Enqueue(new Element(rand.Next(1, 10), " "+i));
            }
            Console.Out.WriteLine("Foreach Iterator");
            foreach (Element e in elementos) {
                Console.Out.WriteLine(e.getText()+" "+e.getPriority());
            }
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine();
            Console.Out.WriteLine("Real time Dequeueing");
            while(elementos.Count>0) {
                Element e = elementos.Dequeue();
                Console.Out.WriteLine(e.getText() + " " + e.getPriority());
            }
            Console.Read();

        }
    }
    
    
}
