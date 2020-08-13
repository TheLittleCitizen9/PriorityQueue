using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PriorityQueue.Abstract;

namespace PriorityQueue
{
    public class PriorityQueue<T> : IPriorityQueue<T>
    {
        public List<Tuple<uint, T>> PriorityList = new List<Tuple<uint, T>>();
        public int Count => PriorityList.Count;

        public T Dequeue()
        {
            var min = PriorityList.Min(r => r.Item1);
            var newPriorityList = PriorityList.Where(l => l.Item1 == min).ToList();
            PriorityList.Remove(newPriorityList[0]);
            return newPriorityList[0].Item2;
        }

        public void Enqueue(uint priority, T item)
        {
            

            PriorityList.Add(new Tuple<uint, T>(priority, item));
        }
    }
}
