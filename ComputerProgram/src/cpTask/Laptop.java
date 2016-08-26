package cpTask;

/**
 * Created by student on 26-Aug-16.
 */
public class Laptop extends Computer {
    String battery;
    String screensize;

    //constructor
    public Laptop(String cpu, String ram, String hdd, String graphicsCard, String screensize, String battery) {
        super(cpu, ram, hdd, graphicsCard);
        this.screensize = screensize;
        this.battery = battery;
    }
    //geeter and setter
    public String getBattery() {
        return battery;
    }

    public void setBattery(String battery) {
        this.battery = battery;
    }

    public String getScreensize() {
        return screensize;
    }

    public void setScreensize(String screensize) {
        this.screensize = screensize;
    }
}
