namespace Map.Spaces; 

public class Station : Space {
    public int Cost;
    public int MortgageValue;
    public bool Owned;

    public Station(string spaceName, int cost, int rent) : base(spaceName) {
        Cost = cost;
        MortgageValue = cost % 2;
        Owned = false;
    }

    public static int RentCalc(int previousSpace) { return 10 * previousSpace; }
}