using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestTask.RacingLogic.Racing;
using static TestTask.RacingLogic.Service;

namespace TestTask.RacingLogic
{
    static class Statistics
    {
        private static List<Vehicle> finishers;

        public static string GetResult(RaceCondition raceCondition)
        {
            if (raceCondition == RaceCondition.start)
            {
                //CountOfFinishers = 0;
                finishers = new List<Vehicle>();
                string _vehicles = "";
                for(int i = 0; i < vehicles.Count; i++)
                    _vehicles += vehicles[i].ToString() + ", под номером" + (i + 1) + ";" + Environment.NewLine;
                return "В гонке учавствуют " + vehicles.Count + " транспортных средств(а):" 
                    + Environment.NewLine + _vehicles + Environment.NewLine;
            }
            else if (raceCondition == RaceCondition.continues)
            {
                UpdateFinishersList();
                string _stats = "";
                //for (int j = 0; j < vehicles.Count; j++)
                //    if (vehicles[j].RemainingDistanceToFinish == 0)
                //        stats[j].IsFinished = true;
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].RemainingDistanceToFinish == 0)
                        _stats += "Участник с номером " + (i + 1) + " финишировал;";
                    else
                        _stats += "Участник с номером " + (i + 1) + " проехал "
                            + (100 - (vehicles[i].RemainingDistanceToFinish / Parameters.DistanceUnits * 100)) + "% пути;";
                    if (vehicles[i].GetDowntime() > 0)
                        _stats += " У него проколото колесо;";
                    _stats += Environment.NewLine;
                }
                return _stats;
            }
            else if (raceCondition == RaceCondition.finish)
            {
                string _stats = "";
                for (int i = 0; i < vehicles.Count; i++)
                {
                    _stats += "Участник с номером " + (i + 1) + ", " + vehicles.ToString()
                        + " финишировал на позиции " + (finishers.IndexOf(vehicles[i]) + 1) + ", зататив "
                        + vehicles[i].CountOfTimeUnits + " едениц времени;";
                }
                return _stats;
            }
            return "";
        }

        /// <summary> Обновить список финишировавших </summary>
        private static void UpdateFinishersList()
        {
            foreach (Vehicle vehicle in vehicles)
                if (vehicle.RemainingDistanceToFinish == 0 && !finishers.Contains(vehicle))
                    finishers.Add(vehicle);
        }

        //private static List<Stats> stats;

        //private class Stats
        //{
        //    public int ParticipantNumber;
        //    public bool WheelIsPunctured;
        //    public int CountOfWheelPunctures;
        //    public bool IsFinished;
        //    public int FinishedWithNumber;
        //}

        public enum RaceCondition { start, continues, finish }

    }
}
