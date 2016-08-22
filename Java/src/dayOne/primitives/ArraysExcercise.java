package dayOne.primitives;

/**
 * Created by student on 22-Aug-16.
 */
public class ArraysExcercise {

    public static void main(String[] args) {
        int[] test = {1,2,3,1};

        System.out.println(sameFirstLast(test));

    }

        static boolean sameFirstLast(int[] nums){
        return (nums.length >=1 && nums[0]== nums[nums.length -1]);


        }




}

