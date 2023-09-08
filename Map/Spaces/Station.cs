namespace Map.Spaces; 

public class Station : Space {
    public Station(string spaceName) : base(spaceName) { }

    public static int RentCalc(int previousSpace) { return 10 * previousSpace; }
}