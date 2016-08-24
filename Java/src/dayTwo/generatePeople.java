package dayTwo;

import address.*;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class generatePeople {
    //create a bunch of people.
    //public static Person dana = new Person("Dana", "Scully", (short) 160, 52.5,
            //LocalDate.of(1983, 9, 9), SexType.FEMALE);

    //public static Person Fokhrul = new Person("Fokhrul", "Islam", (short) 170, 69.5,
            //LocalDate.of(1990, 9, 29), SexType.MALE);


//person cannot be created anymore because person is an abstract now. cannot create instance of an object


    public static Employee fokhrul = new Employee("Fokhrul", "Islam", (short) 185,78.90, LocalDate.of(1990,9,29), SexType.MALE,  "Java Developer",
            LocalDate.of(2017,3,16));

    public static List<Employee> people = new ArrayList<>();// collectin of employeess(people)

    static void addPeople() {
       // people.add(dana);
        //people.add(Fokhrul);
        people.add(fokhrul);
    }
}