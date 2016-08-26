package CoffeeProgramme;

/**
 * Created by student on 26-Aug-16.
 */
public class Cafe {
    private int beansInStock = 0;
    private int milkInStock = 0;

    //methods
    public Coffee brew(CoffeeType coffeeType) {
        return brew(coffeeType, 1);
    }

    public Coffee brew(CoffeeType coffeeType, int quantity) {
        requirePositive(quantity);
        int requiredBeans = coffeeType.getRequiredBeans() * quantity;
        int requiredMilk = coffeeType.getRequiredMilk() * quantity;

        if (requiredBeans > beansInStock || requiredMilk > milkInStock)
            throw new IllegalStateException("Insufficient beans or milk");

        beansInStock -= requiredBeans;
        milkInStock -= requiredMilk;
        return new Coffee(coffeeType, requiredBeans, requiredMilk);
    }

    public void requirePositive(int value) {//if the quantity requested is less than 1 we show error.
        if (value < 1)
            throw new IllegalArgumentException();
    }

    public void restockBeans(int weightinGrams) {
        requirePositive(weightinGrams);
        beansInStock += weightinGrams;
    }

    public void restockMilk(int weightinGrams) {
        requirePositive(weightinGrams);
        milkInStock += weightinGrams;
    }

}
