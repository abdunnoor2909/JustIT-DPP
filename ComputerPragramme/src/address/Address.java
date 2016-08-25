package address;

/**
 * Created by student on 23-Aug-16.
 */
public class Address {
    //fields
   private String firstLineAddress;
   private String secondLineAddress;
   private String postCode;

    //properties


    public String getFirstLineAddress() {
        return firstLineAddress;
    }

    public void setFirstLineAddress(String firstLineAddress) {
        this.firstLineAddress = firstLineAddress;
    }

    public String getSecondLineAddress() {
        return secondLineAddress;
    }

    public void setSecondLineAddress(String secondLineAddress) {
        this.secondLineAddress = secondLineAddress;
    }

    public String getPostCode() {
        return postCode;
    }

    public void setPostCode(String postCode) {
        this.postCode = postCode;
    }



    //constructors overloading
    Address() {}

    public Address(String firstLineAddress, String secondLineAddress, String postCode) {
        this.firstLineAddress = firstLineAddress;
        this.secondLineAddress = secondLineAddress;
        this.postCode = postCode;

    }

    @Override
    public String toString() {
        return String.format("Address: %s %s %s", this.firstLineAddress, this.secondLineAddress, this.postCode);
    }
}

