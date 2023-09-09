using Map.Spaces;
using Players;

namespace Map;

public class Map {
    public Space[] Spaces;
    public Player[] Players;

    public Map() {
        Spaces = GenerateMap();
        Players = GeneratePlayers();
    }

    private Space[] GenerateMap() {
        Space[] spaces = new Space[16];
        for (int x = 0; x < spaces.Length; x++) {
            switch (x) {
                case 0:
                    spaces[x] = new Space("Home");
                    break;
                case 1:
                case 2:
                case 5:
                case 7:
                case 9:
                case 13:
                case 15:
                    spaces[x] = new Road("Road");
                    break;
                case 3:
                    spaces[x] = new Property(
                        "Old Kent Road",
                        60,
                        2
                    );
                    break;
                case 4:
                    spaces[x] = new Property(
                        "Pall Mall",
                        140,
                        10
                    );
                    break;
                case 8:
                    spaces[x] = new Property(
                        "The Strand",
                        220,
                        18
                    );
                    break;
                case 12:
                    spaces[x] = new Property(
                        "Leicester Square",
                        260,
                        22
                    );
                    break;
                case 14:
                    spaces[x] = new Property(
                        "Park Lane",
                        350,
                        35
                    );
                    break;
                case 6:
                    spaces[x] = new Station("Paddington");
                    break;
                case 11:
                    spaces[x] = new Station("Waterloo");
                    break;
                case 10:
                    spaces[x] = new TaxOffice("Tax Office");
                    break;
            }
        }

        return spaces;
    }

    private Player[] GeneratePlayers() {
        Console.WriteLine("Enter number of players:");
        int requiredPlayerNum = Convert.ToInt32(Console.ReadLine());
        while (requiredPlayerNum > 10 ^ requiredPlayerNum < 2) {
            Console.WriteLine("Error, number of players must be between 2 and 10:");
            requiredPlayerNum = Convert.ToInt32(Console.ReadLine());
        }
        Player[] players = new Player[requiredPlayerNum];
        Console.WriteLine();

        for (int x = 0; x < players.Length; x++) {
            Console.WriteLine("Player " + (x + 1) + " name:");
            var playerName = Console.ReadLine();
            while (string.IsNullOrEmpty(playerName)) {
                Console.WriteLine("Error, entered value was empty. Re-enter name:");
                playerName = Console.ReadLine();
            }
            players[x] = new Player(
                playerName,
                x
            );
            Console.WriteLine();
        }

        return players;
    }
}