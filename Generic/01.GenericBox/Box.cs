using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBox
{
   public class Box<T>
   where T : IComparable<T>
   {
       private List<T> boxCollection;
       public int countGreater { get;private set; }
       public Box()
       {
           this.boxCollection = new List<T>();
       }
       public void Add(T item)
       {
           this.boxCollection.Add(item);
       }

       public void Compare(T item)
       {
           foreach (var currentItem in this.boxCollection)
           {
               if (currentItem.CompareTo(item) > 0)
               {
                   this.countGreater++;
               }

           }
       }
       public void Swap(int x, int y)
       {
           T tempValue = this.boxCollection[x];
           this.boxCollection[x] = this.boxCollection[y];
           this.boxCollection[y] = tempValue;
       }
       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();
           foreach (var box in boxCollection)
           {
               sb.AppendLine($"{box.GetType().FullName}: {box}");
           }

           return sb.ToString().TrimEnd();
       }

       
   }
}
