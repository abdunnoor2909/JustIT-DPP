package address;

import java.time.LocalDate;
import java.util.List;
import static address.generateContact.people;

/**
 * Created by student on 23-Aug-16.
 */
public class TaskProcessing {
    static void createContact(List<String> data) {

        Contact temp = new Contact(

                (new Person(data.get(2), data.get(3), LocalDate.of(Integer.parseInt(data.get(4)), Integer.parseInt(data.get(5)), Integer.parseInt(data.get(6))))),
                (new Address(data.get(5), data.get(6), data.get(7))));


        people.add(temp);
    }
    static void printAll() {
        for (Contact c : people)//for each Person in people
            System.out.println(String.format("%s " + c, people.indexOf(c)));
    }


}




