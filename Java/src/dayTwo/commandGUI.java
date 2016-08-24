package dayTwo;

import com.sun.javafx.tk.Toolkit;

import javax.sound.sampled.Line;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import static  dayTwo.generatePeople.people;

/**
 * Created by student on 23-Aug-16.
 */
public class commandGUI {//To recieve input and to output information. This is the role of the commandGUI.
    static Scanner input = new Scanner((System.in));//is a class we create with an object to take userinput.

    static void display (){//All these are output on the console. Giving user these options
        int choice;//User choice will be in numbers
        do{
            System.out.println("Welcome to Employee Database");
            System.out.println("1.Add an Employee");
            System.out.println("2.Edit an Employee");
            System.out.println("3.Remove an Employee");
            System.out.println("4.List an Employee");
            System.out.println("5.Search by First Name");
            System.out.println("6.Terminate");
            System.out.println();
            System.out.println("Enter between (1-6): ");

            //read input from user
            choice = input.nextInt();//choice from the user is in numbers(int).NextInt is a method for the input.

        }while (choice < 1 || choice > 6);
        int index;

        List<String> tempData = new ArrayList<>();//temporary data to collect data.


        switch (choice){//compare the choices.
            case 1:
                tempData = inputScreen();//gives user input screen to collect data.
                TaskProcessing.createEmployee(tempData);//to create new employee on a different screen.
                display();//displays the switch statement again. To keep the program running. recusive - to re run the method.
                break;
            case 2:
                index = findFirstName();
                tempData = inputScreen();
                display();
                //edit
                TaskProcessing.editDetails(index, tempData);
                display();
                break;
            case 3:
                TaskProcessing.removeEmployee(requestIndex());
                display();
                break;
            case 4:
                TaskProcessing.printAll();
                display();
                break;
            case 5:
                index = findFirstName();
                System.out.println(people.get(index));
                display();
                break;
            case 6:
                break;
        }
    }
    static List<String> inputScreen(){
        List<String>employeeData = new ArrayList<>();//create a temporary collection data to collect data from the inputscreen
        input.nextLine();
        System.out.print("Enter First Name: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Last Name: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Height: ");
        employeeData.add(input.nextLine());

        System.out.print("Weight: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter DOB (YYYY/MM/DD: ");
        String dob = input.nextLine();
        String [] dobData = dob.split("/");//splits the dob to format it
        //then we have to loop them to assign them one by one

        for(int i = 0; i<= dobData.length-1; i++ ){
            employeeData.add(dobData[i]);
        }

        System.out.print("Enter Sex:M/F ");
        employeeData.add(input.nextLine());


        System.out.print("Enter Position: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Hire Date: ");

        String hireData = input.nextLine();
        String [] hireDate = dob.split("/");//splits the hireDate to format it
        //then we have to loop them to assign them one by one

        for(int i = 0; i<= dobData.length-1; i++ ){
            employeeData.add(hireDate[i]);
        }
        return  employeeData;
    }

    static  int findFirstName(){
        System.out.println("Enter First Name: ");
        String firstname = input.next();
        return TaskProcessing.searchFirstname(firstname);
    }
    static int requestIndex(){
        System.out.print("Enter Employee index to remove: ");
        return input.nextInt();
    }
}
