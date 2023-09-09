namespace Players;

public class Player {
    public string? Name;
    public int Number;
    public int Balance;
    public int Position;

    public Player(string? playerName, int arrayPosition) {
        Name = playerName;
        Number = arrayPosition + 1;
        Balance = 1000;
        Position = 0;
    }
}