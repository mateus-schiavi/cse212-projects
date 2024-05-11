using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        // Parsing the CSV file
        using (var reader = new TextFieldParser("basketball.csv"))
        {
            reader.TextFieldType = FieldType.Delimited;
            reader.SetDelimiters(",");
            reader.ReadFields(); // ignore header row

            while (!reader.EndOfData)
            {
                var fields = reader.ReadFields();
                var playerId = fields[0];
                var points = int.Parse(fields[8]);

                // Update career points for each player
                if (players.ContainsKey(playerId))
                {
                    players[playerId] += points;
                }
                else
                {
                    players[playerId] = points;
                }
            }
        }

        // Sort players by career points and get top 10
        var topPlayers = players.OrderByDescending(kv => kv.Value).Take(10).ToArray();

        // Display top 10 players
        Console.WriteLine("Top 10 Players:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player.Key}: {player.Value} points");
        }
    }
}
