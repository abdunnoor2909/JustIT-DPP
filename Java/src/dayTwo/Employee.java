package dayTwo;

import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */
//Employee is a Person(Person is a superClass of Employee.
public class Employee extends Person{//(extends) Employee is a 'Person'. All details from the Person needed.
    private String position;//including these information. position & hire date.
    private LocalDate hireDate;

    Employee () {}//its a requirement to have a defualt constructur

    Employee(String firstName , String lastName , short height , double weight, LocalDate birthDate, SexType sex, String pos, LocalDate hd){

        super(firstName, lastName, height, weight, birthDate, sex);//super is a way to invoke the Person method.
        this.position = pos;
        this.hireDate = hd;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public void setHireDate(LocalDate hireDate) {
        this.hireDate = hireDate;
    }

    @Override
    public String toString(){
        return String.format("Employee Name: %s %s %s", super.toString(),
                this.position, this.hireDate);
    }
}
