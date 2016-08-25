package address;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 23-Aug-16.
 */
public class commandGUI {
    static Scanner input = new Scanner((System.in));

    static void display() {
        int choice;
        do {
            System.out.println("Welcome to Contacts Database");
            System.out.println("1.Add a Contact");
            System.out.println("2.Edit a Contact");
            System.out.println("3.Remove an Contact");
            System.out.println("4.List all Contacts");
            System.out.println("5.Search by First Name");
            System.out.println("6.Terminate");
            System.out.println();
            System.out.println("Enter between (1-6): ");

            //read input from user
            choice = input.nextInt();

        } while (choice < 1 || choice > 6);

        List<String> tempData = new ArrayList<>();

        switch (choice) {
            case 1:
                tempData = inputScreen();
                TaskProcessing.createContact(tempData);//to create new contact on a different screen.
                display();//displays the switcch statement again. To keep the program running.
            case 2:
            case 3:
            case 4:
                TaskProcessing.printAll();
                display();
            case 5:
            case 6:
                break;
        }

    }

    static List<String> inputScreen() {
        return null;
    }
}
