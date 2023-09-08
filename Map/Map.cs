using Map.Spaces;

namespace Map;

public class Map {
    public Space[] Spaces = new Space[16];

    public Map() {
        for (int x = 0; x < Spaces.Length; x++) {
            switch (x) {
                case 0:
                    Spaces[x] = new Space("Home");
                    break;
                case 1:
                case 2:
                case 5:
                case 7:
                case 9:
                case 13:
                case 15:
                    Spaces[x] = new Road("Road");
                    break;
                case 3:
                    Spaces[x] = new Property(
                        "Old Kent Road",
                        60,
                        2
                    );
                    break;
                case 4:
                    Spaces[x] = new Property(
                        "Pall Mall",
                        140,
                        10
                    );
                    break;
                case 8:
                    Spaces[x] = new Property(
                        "The Strand",
                        220,
                        18
                    );
                    break;
                case 12:
                    Spaces[x] = new Property(
                        "Leicester Square",
                        260,
                        22
                    );
                    break;
                case 14:
                    Spaces[x] = new Property(
                        "Park Lane",
                        350,
                        35
                    );
                    break;
                case 6:
                    Spaces[x] = new Station("Paddington");
                    break;
                case 11:
                    Spaces[x] = new Station("Waterloo");
                    break;
                case 10:
                    Spaces[x] = new TaxOffice("Tax Office");
                    break;
            }
        }
    }
}