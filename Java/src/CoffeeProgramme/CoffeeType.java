package CoffeeProgramme;

/**
 * Created by student on 26-Aug-16.
 */
public enum CoffeeType {//act like a class. you cannot create anymore objects. The way you define is the way it will be.something you collect and values are set
    Espresso(7,0),//first int refers to how many beans we need/second int means milk
    Latte(7,230),
    FilterCoffee(10,0);

    private final int requiredBeans;
    private final int requiredMilk;

    //enum supports constructors

    CoffeeType(int requiredBeans, int requiredMilk) {
        this.requiredBeans = requiredBeans;
        this.requiredMilk = requiredMilk;
    }

    public int getRequiredBeans() {
        return requiredBeans;
    }

    public int getRequiredMilk() {
        return requiredMilk;
    }
}
