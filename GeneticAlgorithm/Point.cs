using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    class Point
    {
        public Point(int dimension)
        {
            Entries = new double[dimension];
        }

        public double[] Entries { set; get; }
    }
}
