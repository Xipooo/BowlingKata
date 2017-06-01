using System;
using System.Collections.Generic;

namespace BowlingKata.Features.CalculateBowlingGame
{
    public class BowlingGame : IBowlingGame
    {
        private IList<int> rolls = new List<int>();
        public int GetTotalScore()
        {
            int totalScore = 0;
            int rollNumber = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[rollNumber] == 10)
                {
                    totalScore += GetRoll(rollNumber) + GetRoll(rollNumber + 1) + GetRoll(rollNumber + 2);
                }
                else if (GetRoll(rollNumber) + GetRoll(rollNumber + 1) == 10)
                {
                    totalScore += GetRoll(rollNumber) + GetRoll(rollNumber + 1) + GetRoll(rollNumber + 2);
                    rollNumber++;
                }
                else
                {
                    totalScore += GetRoll(rollNumber) + GetRoll(rollNumber + 1);
                    rollNumber++;
                }
                rollNumber++;
            }
            return totalScore;
        }

        public void AddRoll(int pins)
        {
            rolls.Add(pins);
        }

        private int GetRoll(int index)
        {
            try
            {
                return rolls[index];
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
