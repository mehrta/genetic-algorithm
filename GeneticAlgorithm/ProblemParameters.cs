using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    static class ProblemParameters
    {
        public struct Boundary
        {
            public double Lower { set; get; }
            public double Upper { set; get; }
        }

        public static int Dimension { set; get; }
        public static Point[] FixedPoints { set; get; }
        public static Boundary[] Boundaries { set; get; }

        public static bool Load(string path)
        {
            bool errorFlag = false;
            System.IO.StreamReader sr= new System.IO.StreamReader(path);

            try
            {
                // Read Dimension
                Dimension = System.Convert.ToInt32(sr.ReadLine());

                // Read boundary of each dimension
                Boundaries = new Boundary[Dimension];
                string[] tokens;
                for (int i = 0; i < Dimension; i++)
                {
                    tokens = sr.ReadLine().Split(',');
                    Boundaries[i].Lower = (double)System.Convert.ToDouble(tokens[0]);
                    Boundaries[i].Upper = (double)System.Convert.ToDouble(tokens[1]);
                }

                // Read 'Number of fixed points' and alocate space for Points
                int numberOfFixedPoints;
                numberOfFixedPoints = System.Convert.ToInt32(sr.ReadLine());
                FixedPoints = new Point[numberOfFixedPoints];
                for (int i = 0; i < numberOfFixedPoints; i++)
                    FixedPoints[i] = new Point(Dimension);

                // Read fixed points
                for (int i = 0; i < numberOfFixedPoints; i++)
                {
                    tokens = sr.ReadLine().Split(',');

                    for (int j = 0; j < Dimension; j++)
                        FixedPoints[i].Entries[j] = (double)System.Convert.ToDouble(tokens[j]);
                }
            }
            catch
            {
                errorFlag = true;
            }
            finally
            {
                // Close the file
                sr.Close();
            }

            return errorFlag;
        }
    }
}
