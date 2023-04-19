using System;
using System.Collections.Generic;

namespace LaunchElectionDay
{
	public class Election
	{
		public List<Race> Races;

		private string Year;

		public Election(string year)
		{
			Year = year;
            Races = new List<Race> { };
        }
		
		public string GetYear()
		{
			return Year;
		}

		public List<Race> GetRaces()
		{
			return Races;
        }

		public void AddRace(Race raceToAdd)
		{
			Races.Add(raceToAdd);
		}

		public List<Candidate> GetAllCandidates()
		{
			List<Candidate> allCanidatesList = new List<Candidate> { };

            foreach (var race in this.Races)
			{
				foreach (var canidate in race.Candidates)
				{
					allCanidatesList.Add(canidate);
                }
			}

			return allCanidatesList;
		}

		public Dictionary<string, int> GetVoteCount()
		{
			Dictionary<string, int> allVotesCanidates = new Dictionary<string, int> { };

			// name as key and votes as int
			foreach (var canidate in this.GetAllCandidates())
			{
				allVotesCanidates.Add(canidate.Name, canidate.Votes);
            }

			return allVotesCanidates;
        }
    }
}

