package dayTwo;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

/**
 * Created by student on 23-Aug-16.
 */
public abstract class Person {//instance of an object should not be created now. - meaning of abstract here.

    //fields
    private String firstName;
    private String lastName;
    private  short height;
    private double weight;
    private LocalDate birthDate;
    private SexType sex;
    private BloodType bloodType;
    private boolean isSleeping = false;

    //properties

    public BloodType getBloodType() {
        return bloodType;
    }

    public void setBloodType(BloodType bloodType) {
        this.bloodType = bloodType;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public short getHeight() {
        return height;
    }

    public void setHeight(short height) {
        this.height = height;
    }

    public LocalDate getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(LocalDate birthDate) {
        this.birthDate = birthDate;
    }

    public SexType getSex() {
        return sex;
    }

    public void setSex(SexType sex) {
        this.sex = sex;
    }


    //constructors overloading
    Person() {}

    public Person(String firstName, String lastName, LocalDate birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public Person(String firstName, String lastName, short height, double weight, LocalDate birthDate, SexType sex) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.height = height;
        this.weight = weight;
        this.birthDate = birthDate;
        this.sex = sex;
        //this.bloodType = bloodType;
    }

    //methods
    public long getAge(){
        if(birthDate == null){
            return 0;
        }
        long years = ChronoUnit.YEARS.between(birthDate, LocalDate.now());//this uses encapsulation to find out birthdate.
        return years;
    }

    public  String talk()throws Exception {

        if(isSleeping)
            throw new Exception("Cannot talk while sleeping");

        return String.format("%s %s says hello! Im awake!", this.firstName , this.lastName);

    }

    public  void sleep(){
        isSleeping = true;
    }

    @Override
    public String toString(){
        return String.format("Person: %s %s %s %s %s  %s", this.firstName , this.lastName, this.getAge(),
                this.height , this.weight, this.getSex().toString());
    }


}
