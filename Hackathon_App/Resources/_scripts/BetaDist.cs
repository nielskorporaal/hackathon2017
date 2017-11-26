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

namespace Hackathon_App.Resources._scripts {
    class BetaDist {

        private int alpha, beta = 1000;
        private int total;
        private double p;

        public BetaDist() {
            updateP();
        }

        public BetaDist(int alpha, int beta) {
            this.alpha = alpha;
            this.beta = beta;
            updateP();
        }
        
        public void updateTotal() {
            total = alpha + beta;
        }

        public void updateP() {
            updateTotal();
            p = alpha / total;
        }

        public void updateDist(bool success) {
            if (success) { alpha = +1; }
            else { beta = +1; }
            updateP();
        }
        
        public int getTotal() {
            return total;
        }

        public double getP() {
            return p;
        }
    }
}