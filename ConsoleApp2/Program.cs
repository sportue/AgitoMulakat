using System;

namespace ConsoleApp2
{
  class Program
  {

    // Soru 1 
    public static void UniqeRandomList()
    {
      Console.WriteLine("How long do you want to produce a list?");
      int lenght = int.Parse(Console.ReadLine());
      int[] array = new int[lenght];

      Random rnd = new Random();

      int countRandom = 0;
      int arrayIndex = 0;

      while (array[array.Length-1] == 0)
      {
        int temp = rnd.Next(1, array.Length+1);
        countRandom++;

        if (!Array.Exists(array, element => element == temp))
        {
          array[arrayIndex] = temp;
          arrayIndex++;
        }
      }
      for (int i = 0; i < array.Length-1; i++)
      {
        Console.Write(array[i]+",");
      }
      Console.Write(array[array.Length - 1] );
      Console.Write(" count of using random method" + countRandom);
    }

    //Soru 2
    public static string RecursiveTree(string tree, int count)
    {
      if (tree.Length == 0)
      {
        return "";
      }
      int treeLenght = tree.Length;
      string tempTree = tree;

      var mainChainIndex = 0;

      var subChain = tempTree.Substring(1, tempTree.Length - 1);
      var subChainIndex = subChain.IndexOf(tempTree[0]);
      mainChainIndex += subChainIndex + 1;
   
      tempTree = tree.Substring(1, subChainIndex);
      var tempTree2 = tree.Substring(mainChainIndex + 1,treeLenght- mainChainIndex - 1 );
     
      for (int i = 0; i < count; i++)
      {
        Console.Write("-");
      }
      Console.Write(tree[mainChainIndex]);
      Console.WriteLine();
   
      count = count + 1;
    
      return RecursiveTree(tempTree,count) + RecursiveTree(tempTree2, count-1 );
    }

    static void Main(string[] args)
    {
      //UniqeRandomList()
      Console.WriteLine("Input text for tree");
      string tree = Console.ReadLine();
      RecursiveTree(tree,0);
    }
  }
}
