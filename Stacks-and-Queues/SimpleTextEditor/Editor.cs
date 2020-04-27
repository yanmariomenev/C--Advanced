
using System.ComponentModel.Design;
using System.Text;

namespace SimpleTextEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Editor
    {
        static void Main(string[] args)
        {
           var textList = new Stack<string>();
           var text = new StringBuilder();

           var count = int.Parse(Console.ReadLine());

           for (int i = 0; i < count; i++)
           {
               var input = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
               var currentCommand = input[0];
               if (currentCommand == "1")
               {
                   textList.Push(text.ToString());
                   text.Append(input[1]);
               }
               else if (currentCommand == "2")
               {
                   var index = int.Parse(input[1]);
                   textList.Push(text.ToString());
                   text.Remove(text.Length - index, index);

               }
               else if (currentCommand == "3")
               {
                   var index = int.Parse(input[1]);
                   Console.WriteLine(text[index - 1]);
               }
               else if (currentCommand == "4")
               {
                   if (textList.Count > 0)
                   {
                       text.Clear();
                       text.Append(textList.Pop());
                   }
               }
               
           }
        }
    }
}
