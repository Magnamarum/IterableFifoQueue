using System;

namespace IterableFifoQueue
{
    public class Element : Object
    {
        int priority;
        string text;
        public void setPriority(int priority)
        {
            this.priority = priority;
        }
        public int getPriority()
        {
            return priority;
        }

        public void setText(string text)
        {
            this.text = text;
        }
        public string getText()
        {
            return this.text;
        }
        public Element(int priority, string text)
        {
            this.priority = priority;
            this.text = text;
        }

    }
}
