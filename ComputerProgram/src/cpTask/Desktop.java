package cpTask;

/**
 * Created by student on 26-Aug-16.
 */
public class Desktop extends Computer{
    String monitor;


    //constructor
    public Desktop(String cpu, String ram, String hdd, String graphicsCard, String monitor) {
        super(cpu, ram, hdd, graphicsCard);
        this.monitor = monitor;

    }
    //getter and setter

    public String getMonitor() {
        return monitor;
    }

    public void setMonitor(String monitor) {
        this.monitor = monitor;
    }




}
