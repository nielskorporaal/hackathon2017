using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hackathon_App.Resources._scripts
{
    class TaskSelector {

        private int totalSuccesses = 0;     // Total number of successes
        private int[] successes;            // Distributions for each task

        /// <summary>
        /// Creates a Task Selector
        /// </summary>
        /// <param name="inputs"></param>
        public TaskSelector (int inputs) {
            successes = new int[inputs];    // Make array for successes per task
            Array.Clear(successes, 1, successes.Length);    // Set successes to 1 for all tasks
            updateTotal();
        }

        /// <summary>
        /// Selects a Task
        /// </summary>
        /// <returns>Task index</returns>
        public int selectTask() {
            Random random = new Random();
            double sample = random.NextDouble();
            double subTotal = 0;
            int index = -1;
            do {
                index++;
                subTotal =+ successes[index] / totalSuccesses;
            }
            while (sample > subTotal || index > successes.Length - 1);
            return index;
        }

        public void updateTotal() {
            totalSuccesses = successes.Sum();
        }

        public void updateDistribution(int task, bool success) {
            if (success) {
                successes[task]++;
                updateTotal();
            }
        }
    }
}