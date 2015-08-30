using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace IterableFifoQueue
{
    public class CustomQueue<T> : List<Element>
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
                    int higher = Count - 1;
                    int middle = higher / 2;
                    int lower = 0;
                    bool found = false;
                    while (lower <= higher && !found)
                    {
                        middle = (lower + higher) / 2;
                        if (this[middle].getPriority() > e.getPriority())
                        {
                            lower = middle + 1;
                        }
                        else if (this[middle].getPriority() < e.getPriority())
                        {
                            higher = middle - 1;
                        }
                        else if (this[middle].getPriority() == e.getPriority())
                        {
                            while (this[middle].getPriority() == e.getPriority())
                            {
                                middle++;
                            }
                            found = true;
                        }

                    }
                    if (!found)
                    {
                        middle = 0;
                        foreach (Element x in this)
                        {
                            if (x.getPriority() >= e.getPriority()) middle++;
                            else break;
                        }
                    }
                    this.Insert(middle, e);
                }

            }
        }

        public Element Dequeue()
        {
            Element e = new Element(this.First().getPriority(), this.First().getText());
            this.RemoveAt(0);
            return e;
        }

        public Element Peek() {
            return this.First();
        }

        public Element LowerPriority() {
            return this.Last();
        }
    }
}
