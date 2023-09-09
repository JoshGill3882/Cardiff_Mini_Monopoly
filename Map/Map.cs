using Map.Spaces;

namespace Map;

public class Map {
    public Space[] Spaces;

    public Map() {
        Spaces = GenerateMap();
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
}