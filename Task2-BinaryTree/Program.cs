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
            var n3 = new Node<TestResult>(tr1);
            var n4 = new Node<TestResult>(tr2);
            var n5 = new Node<TestResult>(tr3);
            var n6 = new Node<TestResult>(tr);
            Node<TestResult> n7 = null;

            //var t1 = new BinaryTree<int>();
            //t1.Insert(n1, 4);
            //t1.Insert(n1, 5);

            var t2 = new BinaryTree<TestResult>();
            
            //t2.Add(n3);
            //t2.Add(n7, tr4);
            //t2.Add(n4);
            //t2.Add(n5);
            //t2.Add(n6);
        }
    }
}
