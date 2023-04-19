using System.Diagnostics;
using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");
var joe = new Candidate("Joe C", "Democrat");
var fred = new Candidate("Fred J", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

joe.VoteFor();
joe.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);

var race = new Race("City Council District 10");

Console.WriteLine(race.Office);


foreach (var person in race.Candidates)
{
    Console.WriteLine(person.Name);
}

race.RegisterCandidate(diana);
race.RegisterCandidate(joe);

foreach (var person in race.Candidates)
{
    Console.WriteLine(person.Name);
}

Console.WriteLine(race.GetWinner().Name);
Console.WriteLine(race.IsTie());


