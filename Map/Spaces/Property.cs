namespace Map.Spaces; 

public class Property : Space {
    public int Cost;
    public int Rent;
    public int MortgageValue;
    public bool Owned;

    public Property(string spaceName, int cost, int rent) : base(spaceName) {
        Cost = cost;
        Rent = rent;
        MortgageValue = cost % 2;
        Owned = false;
    }
}