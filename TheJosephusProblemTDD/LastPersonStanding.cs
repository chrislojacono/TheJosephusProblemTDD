using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheJosephusProblemTDD
{
    public class LastPersonStanding
    {
        public int JosephusCalculator(int numberOfPeople, int killingInterval)
        {
            var peopleToLoopOver = Enumerable.Range(1, numberOfPeople).ToList();

            var originalKillingInterval = killingInterval - 1;
            
            while (peopleToLoopOver.Count > 1)
            {
                for (int i = killingInterval - 1; peopleToLoopOver.Count > 1; i += originalKillingInterval)
                {
                    if(i > peopleToLoopOver.Count - 1)
                    {
                        killingInterval = i - peopleToLoopOver.Count + 1;
                        break;
                    }
                    peopleToLoopOver.RemoveAt(i);

                }

            }
            var lastGuyStanding = peopleToLoopOver[0];


            return lastGuyStanding;
        }
    }
}
