package dayTwo;
import java.sql.SQLException;

import static dayTwo.generatePeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class MainProgram {
    public  static void main (String [] args)throws Exception{


       // generatePeople.addPeople();
        TaskProcessing.prepareDb();
        new WelcomeWindow();



    }
}
