package cpTask;

import jdk.internal.util.xml.impl.Input;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 26-Aug-16.
 */
public class Shop {
    static Scanner input = new Scanner((System.in));


    public static void display() {
        char userInput;

        do {

            System.out.println("Welcome to XDComputers!");
            System.out.println("Please select an option...");
            System.out.println("C, Create a computer");
            System.out.println("N, Create customer");
            System.out.println("S, Search for computers");
            System.out.println("O, Display all computers");
            System.out.println("Q, Quit");

            userInput = input.nextLine().charAt(0);



        } while (userInput != 'C' && userInput != 'N' && userInput != 'S' && userInput != 'O' && userInput !='Q' );

        List<String> tempData = new ArrayList<>();//temporary data to collect data.


        switch (userInput) {
            case 'C':
                System.out.println("Desktop or Laptop");
                String data = input.next();
                 if(data.contains("Desktop")){
                    tempData = inputScreen();
                    Processing.desktopBuild(tempData);
                } else if (data.contains("Laptop")){
                    tempData = inputScreen2();
                    Processing.laptopBuild(tempData);
                     display();
                     break;
                }

        }


    }

    private static List<String> inputScreen() {
        List<String>desktopData = new ArrayList<>();

        input.nextLine();
        System.out.print("Enter CPU: ");
        desktopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter RAM: ");
        desktopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter HDD: ");
        desktopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter Graphics Card: ");
        desktopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter Monitor Size: ");
        desktopData.add(input.nextLine());



        return desktopData;
    }

    private static List<String> inputScreen2() {
        List<String>laptopData = new ArrayList<>();

        input.nextLine();
        System.out.print("Enter CPU: ");
        laptopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter RAM: ");
        laptopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter HDD: ");
        laptopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter Graphics Card: ");
        laptopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter Screen size: ");
        laptopData.add(input.nextLine());

        input.nextLine();
        System.out.print("Enter battery: ");
        laptopData.add(input.nextLine());



        return laptopData;
    }



}








