package CoffeeProgramme;

/**
 * Created by student on 26-Aug-16.
 */
public class Coffee {
    private final CoffeeType type;
    private final int beans;
    private final int milk;

    //constructor

    public Coffee(CoffeeType type, int beans, int milk) {
        this.type = type;
        this.beans = beans;
        this.milk = milk;
    }
    //getter
    public CoffeeType getType() {
        return type;
    }

    public int getBeans() {
        return beans;
    }

    public int getMilk() {
        return milk;
    }
}
