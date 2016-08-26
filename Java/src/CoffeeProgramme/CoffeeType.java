package CoffeeProgramme;

/**
 * Created by student on 26-Aug-16.
 */
public enum CoffeeType {//act like a class. you cannot create anymore objects. The way you define is the way it will be.something you collect and values are set
    Espresso(7,0),//first int refers to how many beans we need/second int means milk
    Latte(7,230),
    FilterCoffee(10,0);

    private final int requiresBeans;
    private final int requiredMilk;

    //enum supports constructors

    CoffeeType(int requiresBeans, int requiredMilk) {
        this.requiresBeans = requiresBeans;
        this.requiredMilk = requiredMilk;
    }

    public int getRequiresBeans() {
        return requiresBeans;
    }

    public int getRequiredMilk() {
        return requiredMilk;
    }
}
