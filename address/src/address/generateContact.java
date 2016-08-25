package address;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class generateContact {

    public static Contact con1 = new Contact("0789456123", "Fokhrul@gmail.com",
            new Address("101 Bishops way", "Bethnal Green", "E2 9HL"),
            new Person("Fokhrul", "Islam", LocalDate.of(1990, 9, 29)));

    public static List<Contact> people = new ArrayList<>();

    static void addPeople() {
        people.add(con1);
    }
}

