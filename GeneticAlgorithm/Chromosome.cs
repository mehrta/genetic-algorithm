using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    public class Chromosome
    {
        public Chromosome(int genomes)
        {
            Genomes = new double[genomes];
        }

        public static void DoCrossover(Chromosome parent1, Chromosome parent2, Chromosome offspring1, Chromosome offspring2)
        {
            Random rnd = new Random();

            for (int i = 0; i < parent1.Genomes.Length; i++)
            {
                double d = rnd.NextDouble();
                offspring1.Genomes[i] = Math.Round( d * parent1.Genomes[i] + (1 - d) * parent2.Genomes[i], GeneticAlgorithm.SpaceQuantizationDecimalPlaces);
                offspring2.Genomes[i] = Math.Round((1 - d) * parent1.Genomes[i] + d * parent2.Genomes[i], GeneticAlgorithm.SpaceQuantizationDecimalPlaces);
            }

            // Calculate FitnessValue of offsprings
            offspring1.CalculateFitnessValue();
            offspring2.CalculateFitnessValue();
        }

        public void DoMutation()
        {
            Random rnd = new Random();

            // Select a random genome
            int genomeIndex;
            genomeIndex = rnd.Next(Genomes.Length);

            // Assign a VALID randome value to the selected genome 
            double genomeValue;
            genomeValue = Math.Round(
                rnd.NextDouble() * (ProblemParameters.Boundaries[genomeIndex].Upper - ProblemParameters.Boundaries[genomeIndex].Lower) +
                ProblemParameters.Boundaries[genomeIndex].Lower
                ,  GeneticAlgorithm.SpaceQuantizationDecimalPlaces);

            // Change genome
            Genomes[genomeIndex] = genomeValue;
            CalculateFitnessValue();
        }

        public bool IsValid()
        {
            bool valid = true;

            for (int i = 0; (i < Genomes.Length) && (valid); i++)
                if ((Genomes[i] < ProblemParameters.Boundaries[i].Lower) || (Genomes[i] > ProblemParameters.Boundaries[i].Upper))
                    valid = false;

            return valid;
        }

        public void CalculateFitnessValue()
        {
            double totalDistance = 0;

            for (int i = 0; i < ProblemParameters.FixedPoints.Length; i++)
            {
                // Calculate Distance of this chromosome from i'th 'fixed point'
                double distance = 0;
                for (int j = 0; j < ProblemParameters.Dimension; j++)
                {
                    double tmp= Genomes[j] - ProblemParameters.FixedPoints[i].Entries[j];
                    distance +=(tmp * tmp);
                }
                distance = Math.Sqrt(distance);

                totalDistance += distance;
            }

            FitnessValue = -1 * totalDistance;
        }

        public void CopyTo(Chromosome destination)
        {
            for (int i = 0; i < Genomes.Length; i++)
                destination.Genomes[i] = this.Genomes[i];

            destination.CalculateFitnessValue();
        }

        public Chromosome Clone()
        {
            Chromosome c = new Chromosome(this.Genomes.Length);
            this.CopyTo(c);
            return c;
        }


        public double[] Genomes { set; get; }
        public double FitnessValue { set; get; }
    }
}
