using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_BinaryTree
{
    public class TestResult : IComparable<TestResult>
    {
        //private float mark;
        public string StudentName { get; set; }
        public string TestName { get; set; }
        private float mark;
        public DateTime TestDate { get; set; }
        public float Mark
        {
            get { return mark; }
            set
            {
                if (value >= 0 && value <= 100)
                    mark = value;
            }
        }

        public int CompareTo(TestResult other)
        {
            if (this.Mark > other.Mark) return 1;
            else if (this.Mark < other.Mark) return -1;
            else return 0;
        }

        public static bool operator >(TestResult a, TestResult b)
        {
            return a.Mark > b.Mark;
        }

        public static bool operator <(TestResult a, TestResult b)
        {
            return a.Mark < b.Mark;
        }
    }
}
