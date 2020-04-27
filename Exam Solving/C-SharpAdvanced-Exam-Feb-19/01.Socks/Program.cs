using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _01.Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var leftSocksCollection = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var rightSocksCollection = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var sockPairs = new List<int>();
            Stack<int> leftSocks = new Stack<int>(leftSocksCollection);

            while (rightSocksCollection.Count != 0 && leftSocks.Count != 0)
            {
                var rightSock = rightSocksCollection[0];
                var leftSock = leftSocks.Peek();

                if (leftSock > rightSock)
                {
                    var pairNum = rightSock + leftSock;
                    sockPairs.Add(pairNum);
                    rightSocksCollection.RemoveAt(0);
                    leftSocks.Pop();
                }
                else if (leftSock == rightSock)
                {
                    rightSocksCollection.RemoveAt(0);
                    var leftSockValue = leftSocks.Pop() + 1;
                    leftSocks.Push(leftSockValue);
                }
                else if (leftSock < rightSock)
                {
                    leftSocks.Pop();
                   
                }

            }

            var biggestPair = sockPairs.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine(biggestPair);
            Console.WriteLine(string.Join(" ", sockPairs));
        }
    }
}
