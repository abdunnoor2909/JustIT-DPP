package address;

/**
 * Created by student on 23-Aug-16.
 */
public class Contact {
    //fields
    private String phoneNumber;
    private String email;
    private Person person;
    private Address address;



    //properties
    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

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
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.address = address;
        this.person = person;
    }

    @Override
    public String toString() {
        return String.format("Contact: %s %s %s %s", this.phoneNumber, this.email, this.address, this.person);
    }
}
