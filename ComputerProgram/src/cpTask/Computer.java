package cpTask;

/**
 * Created by student on 26-Aug-16.
 */
public class Computer {//super class

    String cpu;
    String ram;
    String hdd;
    String graphicsCard;

    public Computer(String cpu, String ram, String hdd, String graphicsCard) {
        this.cpu = cpu;
        this.ram = ram;
        this.hdd = hdd;
        this.graphicsCard = graphicsCard;
    }

    public String getCpu() {
        return cpu;
    }

    public void setCpu(String cpu) {
        this.cpu = cpu;
    }

    public String getRam() {
        return ram;
    }

    public void setRam(String ram) {
        this.ram = ram;
    }

    public String getHdd() {
        return hdd;
    }

    public void setHdd(String hdd) {
        this.hdd = hdd;
    }

    public String getGraphicsCard() {
        return graphicsCard;
    }

    public void setGraphicsCard(String graphicsCard) {
        this.graphicsCard = graphicsCard;
    }
}
