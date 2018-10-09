
using BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n1 = new Node<int>(5);
            //var n2 = new Node<int>(4);
            
            var tr = new TestResult() { StudentName = "Vlad", Mark = 99, TestDate = DateTime.Now, TestName = "1" };
            var tr1 = new TestResult() { StudentName = "Vlad", Mark = 96, TestDate = DateTime.Now, TestName = "1" };
            var tr2 = new TestResult() { StudentName = "Vlad", Mark = 88, TestDate = DateTime.Now, TestName = "1" };
            var tr3 = new TestResult() { StudentName = "Vlad", Mark = 79, TestDate = DateTime.Now, TestName = "1" };
            var tr4 = new TestResult() { StudentName = "Vlad", Mark = 40, TestDate = DateTime.Now, TestName = "1" };
            
            var t2 = new BinaryTree<TestResult>();

            t2.Add(tr);
            t2.Add(tr1);
            t2.Add(tr2);
            t2.Add(tr3);

            
            Console.WriteLine();
            foreach (var item in t2.InOrderTraversal())
            {
                Console.WriteLine(item.value.Mark);
            }
        }
    }
}
