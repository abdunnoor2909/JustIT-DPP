package dayOne.primitives;

import java.util.Scanner;

/**
 * Created by student on 22-Aug-16.
 */
public class Light {
    static int lightSpeed = 186000;

    public static void main(String[] args){
        //calculate light speed
        //Evenson et all - calculated light speed 299,792,458 metres / second

        System.out.print("Enter number of days: ");
        Scanner input = new Scanner(System.in);
        long days = input.nextLong();



        //java uses streams
        System.out.println("In " + days);
        System.out.println("Days light will travel about " + lightCalculator(days) + " miles.");
    }

    static long lightCalculator(long days){//creating a method
        long seconds = days * 24 * 60 * 60;
        return lightSpeed * seconds;
    }
}
