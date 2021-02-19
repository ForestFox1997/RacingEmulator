using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestTask.RacingLogic.Racing;

namespace TestTask.RacingLogic
{
    static class Statistics
    {
        public static void RacingIsStarted()
        {
            stats = new List<Stats>(vehicles.Count);
            finishers = new Dictionary<Vehicle, int>();
        }

        

        private static int CountOfFinishers { get; set; }

        private static Dictionary<Vehicle, int> finishers;



        public static string GetResult(RaceCondition raceCondition)
        {
            if (raceCondition == RaceCondition.start)
            {
                CountOfFinishers = 0;
                string _vehicles = "";
                for(int i = 0; i < vehicles.Count; i++)
                    _vehicles += vehicles[i].ToString() + ", под номером" + i++ + ";\n";
                return "В гонке учавствуют " + stats.Count + "транспортных средств(а):" + _vehicles;
            }
            else if (raceCondition == RaceCondition.continues)
            {
                string _stats = "";

                for (int j = 0; j < vehicles.Count; j++)
                    if (vehicles[j].RemainingDistanceToFinish == 0)
                        stats[j].IsFinished = true;

                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].RemainingDistanceToFinish == 0)
                        _stats += "Участник с номером " + i++ + " финишировал;";
                    else
                        _stats += "Участник с номером " + i++ + " проехал "
                            + (100 - (vehicles[i].RemainingDistanceToFinish / 10000 * 100)) + "% пути;";
                    if (vehicles[i].GetDowntime() > 0)
                        _stats += " У него проколото колесо;";
                }

            }
            else if (raceCondition == RaceCondition.finish)
            {


            }
        }

        private static List<Stats> stats;

        private class Stats
        {
            public int ParticipantNumber;
            public bool WheelIsPunctured;
            public int CountOfWheelPunctures;
            public bool IsFinished;
            public int FinishedWithNumber;
        }

        public enum RaceCondition { start, continues, finish }





    }
}
