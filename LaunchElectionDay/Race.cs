using System;
namespace LaunchElectionDay
{
	public class Race
	{
		public string Office;
		public bool raceAvablity;
		public List<Candidate> Candidates;

		public Race(string office)
		{
			Office = office;
            raceAvablity = true;
			Candidates = new List<Candidate> { };
		}

		public void RegisterCandidate(Candidate candidateToAdd)
		{
			Candidates.Add(candidateToAdd);
		}

		public bool IsOpen()
		{
			return raceAvablity;
		}

		public void Close()
		{
			raceAvablity = false;
			Console.WriteLine("Race is now closed");
		}

		public Candidate GetWinner()
		{
			var tempCandidate = new Candidate("", "");
			

			foreach (var canidate in Candidates)
			{
				if(canidate.Votes > tempCandidate.Votes)
				{
                    tempCandidate.Name = canidate.Name;
                    tempCandidate.Votes = canidate.Votes;
					tempCandidate.Party = canidate.Party;
                }
			}

			if(tempCandidate.Name == "" && tempCandidate.Votes == 0)
			{
                tempCandidate.Name = "No Valid Candidates found";
            }

			return tempCandidate;
        }

		public bool IsTie()
		{
			bool tieDectected = false;

            var tempCandidate = new Candidate("", "");

            foreach (var canidate in Candidates)
            {
                if (canidate.Votes > tempCandidate.Votes)
                {
                    tempCandidate.Name = canidate.Name;
                    tempCandidate.Votes = canidate.Votes;
                    tempCandidate.Party = canidate.Party;
                }

                if (canidate.Votes == tempCandidate.Votes && tempCandidate.Name != canidate.Name)
				{
                    tieDectected = true;
				}
            }

			return tieDectected; 
        }
    }
}

