namespace Map.Spaces; 

public class TaxOffice : Space {
    public TaxOffice(string spaceName) : base(spaceName) { }

    public static int CostCalc(int currentBal, bool doubleRoll) { return doubleRoll ? currentBal / 20 : currentBal / 10; }
}