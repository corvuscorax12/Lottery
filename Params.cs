using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Settings
    {
        int maxNumber;
        static int amountOfDrawings;
        double costPerTicket;

        public int MaxNumber
        {
            get { return maxNumber; }
            set { maxNumber = value; }
        }
        public  int AmountOfDrawing
        {
            get { return amountOfDrawings; }
            set { amountOfDrawings = value; }
        }
        public double  CostPerTicket
        {
            get { return costPerTicket; } 
            set { costPerTicket = value; }
        }
        


    }
}
