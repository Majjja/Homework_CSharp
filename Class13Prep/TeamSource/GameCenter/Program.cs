using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();


            // 1.   Find all TEAMS with name starting with 'LA' 
            var teamsStartingWithLA = teams
                                        .Where(team => team.Name.StartsWith("LA"))
                                        .ToList();
            teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));
            Console.WriteLine("-----------------------------");

            // 2.   Find all team NAMES which are playing in "Staples Center"
            var teamsPlayingInSC = teams
                                        .Where(team => team.Arena.Equals("Staples Center"))
                                        .Select(team => team.Name)
                                        .ToList();
            teamsPlayingInSC.ForEach(name => Console.WriteLine(name));
            Console.WriteLine("-----------------------------");

            // 3.   Find all teams coaches
            var allCoaches = teams
                                .Select(team => team.Coach)
                                .ToList();
            allCoaches.ForEach(coachName => Console.WriteLine(coachName.FullName));
            Console.WriteLine("-----------------------------");

            // 4.   Find 3 oldest coaches NAMES
            var threeOldestCoaches = allCoaches
                                        .OrderByDescending(team => team.Age)
                                        .Take(3)
                                        .Select(coach => coach.FullName)
                                        .ToList();
            threeOldestCoaches.ForEach(coach => Console.WriteLine(coach));
            Console.WriteLine("-----------------------------");

            // 5.   Group all teams by their Arenas
            var groupTeamsByArenas = teams
                                        .GroupBy(team => team.Arena)
                                        .ToList();
            foreach (var arena in groupTeamsByArenas)
            {
                Console.WriteLine(arena.Key);
                foreach (var team in arena)
                {
                    Console.WriteLine($"***{team.Name}");
                }
            }
            Console.WriteLine("-----------------------------");

            // 6.   Find all players in one LIST
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            allPlayers.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("-----------------------------");

            // 7.   Find player with best avgPtsPerGame
            var playeraWithMaxRangPoints = allPlayers
                                                    .OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                    .Select(player => player.FullName)
                                                    .FirstOrDefault();

            Console.WriteLine(playeraWithMaxRangPoints);
            Console.WriteLine("-----------------------------");


            // HOMEWORK
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HOMEWORK:");
            Console.ResetColor();

            // 8.   Find all coaches NAMES with Age > 50
            var coachesOver50 = allCoaches
                                    .Where(coach => coach.Age > 50)
                                    .Select(coach => coach.FullName)
                                    .ToList();
            coachesOver50.ForEach(name => Console.WriteLine(name));
            Console.WriteLine("-----------------------------");

            // 9.   Order players by AGE - DESC
            var playersByAge = allPlayers
                                    .OrderByDescending(player => player.Age)
                                    .ToList();
            playersByAge.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("-----------------------------");

            // 10.  Find player with highest RebPerGame
            var playerWithHigherRebPerGame = allPlayers
                                                    .OrderByDescending(team => team.PlayerStatistic["RebPerGame"])
                                                    .FirstOrDefault();
            Console.WriteLine(playerWithHigherRebPerGame.FullName);
            Console.WriteLine("-----------------------------");

            // 11.  Find all players with PtsPerGame > 20
            var playersWithPtsPerGameOver20 = allPlayers
                                                    .Where(team => team.PlayerStatistic["PtsPerGame"] > 20)
                                                    .ToList();
            playersWithPtsPerGameOver20.ForEach(player => Console.WriteLine(player.FullName));
            Console.WriteLine("-----------------------------");

            // 12.  Find all players NAMES older then 30 years
            var playersOver30 = allPlayers
                                        .Where(player => player.Age > 30)
                                        .Select(player => player.FullName)
                                        .ToList();
            playersOver30.ForEach(player => Console.WriteLine(player));
            Console.WriteLine("-----------------------------");

            // 13.  Group players by age
            var groupedPlayersByAge = allPlayers
                                            .GroupBy(player => player.Age)
                                            .ToList();
            foreach (var age in groupedPlayersByAge)
            {
                Console.WriteLine($"Age: {age.Key}");
                foreach (var player in age)
                {
                    Console.WriteLine($"***Player: {player.FullName}");
                }
            }
            Console.WriteLine("-----------------------------");

            // 14.  Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            var playersWithRebPerGameOver7 = allPlayers
                                                    .Where(team => team.PlayerStatistic["RebPerGame"] > 7.0)
                                                    .Select(player => new { player.FullName, player.PlayerStatistic })
                                                    .ToList();
            playersWithRebPerGameOver7.ForEach(player => Console.WriteLine($"Name: {player.FullName}, PtsPerGame: {player.PlayerStatistic["PtsPerGame"]}"));
            Console.WriteLine("-----------------------------");

            // 15.  Find first 3 players with highest PtsPerGame
            var playersWithHighestPts = allPlayers
                                                .OrderByDescending(team => team.PlayerStatistic["PtsPerGame"])
                                                .Take(3)
                                                .ToList();
            playersWithHighestPts.ForEach(player => Console.WriteLine($"Name: {player.FullName}, PtsPerGame: {player.PlayerStatistic["PtsPerGame"]}"));
            Console.WriteLine("-----------------------------");

            // 16.  Find the team which has the player with highest PtsPerGame
            var playerWithHighestPtsPerGame = playersWithHighestPts.FirstOrDefault();
            var teamWithPlayerWithHighestPtsPerGame = teams.GroupBy(team => team.Name).ToList();
            foreach (var team in teamWithPlayerWithHighestPtsPerGame)
            {
                foreach (var player in team)
                {
                    if (player.Players.Contains(playerWithHighestPtsPerGame))
                        Console.WriteLine($"Team: {team.Key}, Player: {playerWithHighestPtsPerGame.FullName}");
                }
            }

            Console.WriteLine("-----------------------------");

            // 17.  Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC
            var playersWithHighestRebPerGame = allPlayers
                                                        .OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                                                        .Take(4)
                                                        .OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                                                        .ToList();
            playersWithHighestRebPerGame.ForEach(players => Console.WriteLine(players.FullName));
            Console.ReadLine();
        }
    }
}
