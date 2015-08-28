using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<Element> elementos = new CustomQueue<Element>();
            elementos.Enqueue(new Element(5, "D"));
            elementos.Enqueue(new Element(6, "A"));
            elementos.Enqueue(new Element(5, "E"));
            elementos.Enqueue(new Element(6, "B"));
            elementos.Enqueue(new Element(5, "F"));
            elementos.Enqueue(new Element(6, "C"));

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
    class CustomQueue<T> : List<Element>
    {
        public void Enqueue(Element e) {
            if (this.Count==0) this.Add(e);
            else
            {
                if (e.getPriority() <= this.Last().getPriority())
                {
                    this.Insert(this.Count,e);
                }
                else if (e.getPriority() > this.First().getPriority())
                {
                    this.Insert(0, e);
                }
                else {
                    int index = 0;
                    foreach (Element x in this) {
                        if (x.getPriority() >= e.getPriority()) index++;
                    }
                    this.Insert(index, e);
                }

            }
        }

        public Element Dequeue()
        {
            Element e = this.First();
            this.Remove(e);
            return e;
        }
    }
    
}
