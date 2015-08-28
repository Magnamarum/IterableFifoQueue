using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IterableFifoQueue
{
    class CustomQueue<T> : List<Element>
    {
        public void Enqueue(Element e)
        {
            if (this.Count == 0) this.Add(e);
            else
            {
                if (e.getPriority() <= this.Last().getPriority())
                {
                    this.Insert(this.Count, e);
                }
                else if (e.getPriority() > this.First().getPriority())
                {
                    this.Insert(0, e);
                }
                else
                {
                    int index = 0;
                    foreach (Element x in this) {
                        if (x.getPriority() >= e.getPriority()) index++;
                        else break;
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
