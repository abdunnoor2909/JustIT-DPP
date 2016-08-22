package dayOne.primitives;

import java.io.IOException;
import java.util.Scanner;

/**
 * Created by student on 22-Aug-16.
 */
public class controlStatement {

    public static void main(String[] args) {
        binaryLoop();

    }

    static void numberComparison() {

        System.out.print("Enter number between 0 - 2000: ");
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();
        String yourNumber;

        if (number <100 || number == 100)
            yourNumber = "Your number is is less than and equal 100";

        else if (number < 500 || number == 500)
            yourNumber = "Your number is less than and equal to 500";

        else if (number < 100 || number == 2000)
            yourNumber = "Your number is less than 100 and equal to 2000";

        else
            yourNumber = "Your number is more than 2000, your number is beyond our scope";

        System.out.println(yourNumber);


    }
        static void Menu(){
            try{
                char choice;
                do{
                    System.out.println("Hellper Menu:");
                    System.out.println("1. if");
                    System.out.println("2. Switch");
                    System.out.println("3. while");
                    System.out.println("4. do-while");
                    choice = (char) System.in.read();//converts choice into a 'char'

                }
                while(choice < '1' || choice >'4');

                switch (choice){
                    case '1'://choice is a 'char'
                        System.out.println("If statement uses boolean condition");
                        break;
                    case '2':
                        System.out.println("Switch uses constant expressions to compare");
                        break;
                    case '3':
                        System.out.println("'While' is a simple loop, boolean condition");
                        break;
                    case '4':
                        System.out.println("Just keep doing it BOOM!");
                        break;



                }
            } catch (IOException e){
                System.out.println(e.getMessage());
                //System.out.println("This is not a character we needed! BOOM!");
            }
        }

    static void iceCream() {
        try {
            char selection;
            do{
                System.out.println("Ice - Cream Menu:");
                System.out.println("Please choose:");
                System.out.println("'1' for Small ice cream");
                System.out.println("'2' for Medium Ice cream");
                System.out.println("'3' for Large Ice cream");
                System.out.println("'4' for Huge Ice cream");

                selection = (char) System.in.read();//converts choice into a 'char'

            }
            while(selection < '1' || selection >'4');

            switch (selection) {
                case '1'://choice is a 'char'
                    System.out.println("That's £1.25");
                    break;
                case '2':
                    System.out.println("That's £2.25");
                    break;
                case '3':
                    System.out.println("That's £3.25");
                    break;
                case '4':
                    System.out.println("That's £4.00");
                    break;
            }


        } catch (IOException e){
            System.out.println(e.getMessage());
        }
    }

    static  void calculate(){
        String value1, value2, op;
        Scanner input = new Scanner(System.in);
        System.out.println("Enter first number:");
        value1 = input.nextLine();


    }

    static void WhileInfinite() {
        int index = 0;

        outer:
        while (true) {
            int value = ++index;
            System.out.println(value);

            if (value == 5) {
                System.out.println("Found it");
                break outer;
            }
            if (value == 10) {
                break;
            }
        }
    }

        static void ForLoopTest () {
            String[] data = {"This", "is", "a", "String"};
        for(int i = 0; i <=data.length -1; i++){
            System.out.println(data[i]);
        }

            String result = "";
            for(String s :data){//for each loop
                result += String.format(s + " ");
            }
            System.out.println(result);
        }

    static void binaryLoop(){

        int result = 0, mult  = 1;

        Scanner input = new Scanner(System.in);
        String binary = input.nextLine();



        for(int i = binary.length()-1; i >=0; i--){//starts from the last value
            if(binary.charAt(i) == '1')
                result += mult;
            mult = mult *2;

        }

        System.out.println("Decimal value: " + result);


    }



    }







