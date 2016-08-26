package dayTwo;

import java.sql.SQLException;
import java.time.LocalDate;
import java.util.InputMismatchException;
import java.util.List;
import java.util.Locale;
import java.util.concurrent.atomic.DoubleAccumulator;

import static dayTwo.generatePeople.people;

/**
 * Created by student on 23-Aug-16.
 */
public class TaskProcessing {
    static EmployeeDb db;

    static  void prepareDb() throws Exception{
        db = new EmployeeDb();
        db.queryAll();
    }

    static void loadData() throws SQLException{
        people.clear();
        db.queryAll();
    }

    static void newEmployee(List<String> data) throws SQLException {
        db.addEmployee(data);
        loadData();
    }


   static void createEmployee(List<String>data){

       String[] dob = data.get(4).split("-");
       String[] hireDate = data.get(7).split("-");

        Employee temp = new Employee(
                        data.get (0),
                        data.get(1),
                        Short.parseShort(data.get(2)),
                        Double.parseDouble(data.get(3)),
                        LocalDate.of(Integer.parseInt(dob[0]), Integer.parseInt(dob[1]), Integer.parseInt(dob[2])),
                        checkSex(data.get(5)),
                        data.get(6),
                        LocalDate.of(Integer.parseInt(hireDate[0]), Integer.parseInt(hireDate[1]), Integer.parseInt(hireDate[2])));


            people.add(temp);//create a new employee to the people collection.
    }

    static  void printAll() {
        for (Person e : people)//for each Person in people
            System.out.println(String.format("%s " + e, people.indexOf(e)));
    }

        static int searchFirstname(String firstName) {//to search for the firstname by the foreach loop.
        for (Person p : people) {
            if (p.getFirstName().contains(firstName))
                return people.indexOf(p);//returns the index of people in the list.

        }
            return -1;
        }

    static void editDetails(int index, List<String> data){//will edit the details based on the index found by searching the firstname.
        people.get(index).setFirstName(data.get(0));
        people.get(index).setLastName(data.get(1));
        people.get(index).setHeight(Short.parseShort(data.get(2)));
        people.get(index).setWeight(Double.parseDouble(data.get(3)));
        people.get(index).setBirthDate(LocalDate.of(
                Integer.parseInt(data.get(4)),
                Integer.parseInt(data.get(5)),
                Integer.parseInt(data.get(6))));
        people.get(index).setSex(checkSex(data.get(7)));
        people.get(index).setPosition(data.get(8));
        people.get(index).setHireDate(LocalDate.of(
                Integer.parseInt(data.get(9)),
                Integer.parseInt(data.get(10)),
                Integer.parseInt(data.get(11))));
        ;
    }
        static  SexType checkSex(String data){// METHOD to check the sex of the employee
            if(data.contains("M"))
                return SexType.MALE;
            else
                return SexType.FEMALE;
        }
    static void removeEmployee(int index){
        people.remove(index);
    }//METHOD retrieve the index of the object and remove it
}

