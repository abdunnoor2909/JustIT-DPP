package address;

/**
 * Created by student on 23-Aug-16.
 */
public class Contact {
    //fields

    private Person person;
    private Address address;

    public Contact(Person person, Address address) {

    }


    //properties


    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }

    public Person getPerson() {
        return person;
    }

    public void setPerson(Person person) {
        this.person = person;
    }

    //constructors overloading
    Contact() {}
    public Contact(String phoneNumber, String email, Address address, Person person) {

        this.address = address;
        this.person = person;
    }

    @Override
    public String toString() {
        return String.format("Contact:  %s %s",  this.address, this.person);
    }
}
