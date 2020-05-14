using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    public class GeneticAlgorithm
    {
        public class TerminationCriteria
        {
            public int MaxNumberOfGenerations { set; get; }
            public int MaxUselessIterations { set; get; }
            public float UselessIterationFactor { set; get; }
            public bool AreUselessIterations(Chromosome bestOfOldPopulation, Chromosome bestOfNewPopulation)
            {
                // if Euclidean distance of "bestOfOldPopulation" and "bestOfNewPopulation" is lower than "UselessIterationFactor"
                // then this method will return true, otherwise will return false

                double distance = 0;
                double tmp;

                for (int i = 0; i < bestOfOldPopulation.Genomes.Length; i++)
                {
                    tmp = bestOfOldPopulation.Genomes[i] - bestOfNewPopulation.Genomes[i];
                    distance += (tmp * tmp); 
                }
                distance = Math.Sqrt(distance);

                //
                return (distance < UselessIterationFactor) ? true : false; 
            }
        }

        public class ExecutionResult
        {
            public int NumberOfGenerations { set; get; }
            public System.Collections.Generic.List<Chromosome> BestChromosomes;

            public ExecutionResult()
            {
                BestChromosomes = new List<Chromosome>(20);
            }
        }

        public GeneticAlgorithm()
        {
            Termination = new TerminationCriteria();
        }

        public void Reset()
        {

        }

        public ExecutionResult Run()
        {
            ExecutionResult result = new ExecutionResult();
            Chromosome oldBest = new Chromosome(ProblemParameters.Dimension);
            bool Continue = true;
            int uselessIterations = 0 ;

            CreateInitialPopulation();
            result.NumberOfGenerations = 1;
            result.BestChromosomes.Add(_bestOfCurrentPopulation.Clone());

            while (Continue)
            {
                _bestOfCurrentPopulation.CopyTo(oldBest);
                GenerateNextPopulation();
                result.NumberOfGenerations++;

                result.BestChromosomes.Add(_bestOfCurrentPopulation.Clone());


                // Check Termination Criteria
                if (result.NumberOfGenerations == Termination.MaxNumberOfGenerations)
                    Continue = false;
                if (Termination.AreUselessIterations(oldBest, _bestOfCurrentPopulation))
                {
                    uselessIterations++;
                    if (uselessIterations == Termination.MaxUselessIterations)
                        Continue = false;
                }
                else
                {
                    uselessIterations = 0;
                }

            }
            return result;
        }

        private void CreateInitialPopulation()
        {
            // Allocate space for current and intermediate population
            _currentPopulation = new Chromosome[PopulationSize];
            _intermediatePopulation = new Chromosome[PopulationSize];

            for (int i = 0; i < PopulationSize; i++)
            {
                _currentPopulation[i] = new Chromosome(ProblemParameters.Dimension);
                _intermediatePopulation[i] = new Chromosome(ProblemParameters.Dimension);
            }

            // Randomly initialize chromosomes (and find best of them)
            Random rnd = new Random();
            double bestFitness = double.NegativeInfinity;

            for (int i = 0; i < PopulationSize; i++)
            {
                for (int j = 0; j < ProblemParameters.Dimension; j++)
                {
                    _currentPopulation[i].Genomes[j] = Math.Round(
                        rnd.NextDouble() * (ProblemParameters.Boundaries[j].Upper - ProblemParameters.Boundaries[j].Lower) +
                        ProblemParameters.Boundaries[j].Lower
                        , SpaceQuantizationDecimalPlaces);
                }
                _currentPopulation[i].CalculateFitnessValue();

                // Find best chromosome
                if (_currentPopulation[i].FitnessValue > bestFitness)
                {
                    bestFitness = _currentPopulation[i].FitnessValue;
                    _bestOfCurrentPopulation = _currentPopulation[i];
                }
            }

        }

        private void GenerateNextPopulation()
        {
            Random rnd = new Random();
            Chromosome oldBestSolution = new Chromosome(ProblemParameters.Dimension);
            Chromosome newBestSolution, newWrostSolution;

            // Store best found solution
            _bestOfCurrentPopulation.CopyTo(oldBestSolution);
            //

            #region Selection (Algorithm: Tournament)
            int tourSize;  // Tournament size
            int bestChromosomeIndex = 0;
            double bestFitness;

            if (PopulationSize < 32)
                tourSize = 3;
            else
                tourSize = (int)Math.Log(PopulationSize, 2) - 1;


            for (int i = 0; i < PopulationSize; i++)
            {
                bestFitness = Double.NegativeInfinity;
                for (int j = 0; j < tourSize; j++)
                {
                    int rndIndex;
                    rndIndex = rnd.Next(PopulationSize);
                    if (_currentPopulation[rndIndex].FitnessValue > bestFitness)
                    {
                        bestFitness = _currentPopulation[rndIndex].FitnessValue;
                        bestChromosomeIndex = rndIndex;
                    }
                }

                // Copy the "winner of tournament" to Intermediate Population
                _currentPopulation[bestChromosomeIndex].CopyTo(_intermediatePopulation[i]);
            }
            #endregion

            #region Crossover (Algorithm: Arithmetic Crossover)
            for (int i = 0; i < PopulationSize / 2; i++)
            {
                if (rnd.NextDouble() < ProbabilityOfCrossover)
                {
                    // Do Crossover
                    Chromosome.DoCrossover(_intermediatePopulation[i], _intermediatePopulation[i + 1],
                                            _currentPopulation[i], _currentPopulation[i + 1]);
                }
                else
                {
                    // Do NOT Crossover (Copy parents to the new population without any change)
                    _intermediatePopulation[i].CopyTo(_currentPopulation[i]);
                    _intermediatePopulation[i + 1].CopyTo(_currentPopulation[i + 1]);
                }
            }
            #endregion

            #region Mutation
            newBestSolution = newWrostSolution = _currentPopulation[0];

            for (int i = 0; i < PopulationSize; i++)
            {
                if (rnd.NextDouble() < ProbabilityOfMutation)
                    _currentPopulation[i].DoMutation();

                // Find wrost of this (new) population
                if (_currentPopulation[i].FitnessValue < newWrostSolution.FitnessValue)
                    newWrostSolution = _currentPopulation[i];

                // Find best of this (new) population
                if (_currentPopulation[i].FitnessValue > newBestSolution.FitnessValue)
                    newBestSolution = _currentPopulation[i];
            }

            #region Elitism
            oldBestSolution.CopyTo(newWrostSolution); // After this statement, "newWrostSolution" will point to "Old Best Solution"!
            // Now we must find best of current and old populations
            _bestOfCurrentPopulation = (oldBestSolution.FitnessValue<newBestSolution.FitnessValue)
                ? newBestSolution : newWrostSolution;
            #endregion
            #endregion
        }

        public int PopulationSize { set; get; } // Population size MUST BE EVEN
        public float ProbabilityOfMutation { set; get; }
        public float ProbabilityOfCrossover { set; get; }
        public static int SpaceQuantizationDecimalPlaces { set; get; }
        public TerminationCriteria Termination { set; get; }
        private Chromosome[] _currentPopulation;
        private Chromosome[] _intermediatePopulation;
        private Chromosome _bestOfCurrentPopulation;
    }
}
