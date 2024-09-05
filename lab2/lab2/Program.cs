using System;

    public class Set
    {
        private HashSet<int> _elements;

        public Set()
        {
            _elements = new HashSet<int>();
        }
        public void AddElement(int element)
        {
            _elements.Add(element);
        }
        public void RemoveElement(int element)
        {
            _elements.Remove(element);
        }
        public int HashSetSize()
        {
            return _elements.Count;
        }
        public int GetSum()
        {
            int sum = 0;
            foreach (int elem in _elements)
            {
                sum += elem;
            }
            return sum;
        }
        public bool HasNegativeElem()
        {
            foreach (int elem in _elements)
            {
                if(elem <0)
                {
                    return true;
                }
            }
            return false;
        }
    public void PrintElements()
    {
        foreach (int elem in _elements)
        {
            Console.Write($"{elem} ");
        }
        Console.WriteLine();
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Set[] sets = new Set[3];
            sets[0] = new Set();
            sets[0].AddElement(1);
            sets[0].AddElement(21);
            sets[0].AddElement(4);

            sets[1] = new Set();
            sets[1].AddElement(-5);
            sets[1].AddElement(4);
            sets[1].AddElement(11);

            sets[2] = new Set();
            sets[2].AddElement(4);
            sets[2].AddElement(-2);
            sets[2].AddElement(9);

            Set minSet = sets[0];
            Set maxSet = sets[0];
            int minSum = minSet.GetSum();
            int maxSun = maxSet.GetSum();

            foreach(var set in sets)
            {
                int elemSum = set.GetSum();
                if(elemSum <minSum)
                {
                    minSet = set;
                    minSum = elemSum;
                }
                if(elemSum>maxSun)
                {
                    maxSet = set;
                    maxSun = elemSum;
                }
            }
            Console.WriteLine($"множество с минимальной суммой: ");
        minSet.PrintElements();
            Console.WriteLine($"множество с макс. суммой:");
        maxSet.PrintElements();

        Console.WriteLine("множества содержащие отрицательные элементы: ");

        foreach( var set in sets)
        {
            if(set.HasNegativeElem())
            {
                set.PrintElements();
            }
        }

        } 
        
    }
    