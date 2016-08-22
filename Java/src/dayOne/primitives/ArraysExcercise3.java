package dayOne.primitives;

/**
 * Created by student on 22-Aug-16.
 */
public class ArraysExcercise3 {

    public static void main(String[] args) {
        int[] test = {1,2,3};
        int[] test2 = {1,2,3};


        System.out.println(commonEnd(test,test2));

    }

    static boolean commonEnd(int[] nums, int[] nums2){
        return (nums[0] == nums2[0] || nums[2]==nums2[2]);


    }




}

