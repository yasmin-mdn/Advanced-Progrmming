/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package aw2;

public class App {
    public int getnums(int[] nums) {
        int max=nums[0];
        for (int i : nums) {
            if(i>max)
              max=i;
        }

        return max;
    }

    public static void main(String[] args) {
        int[] nums ={12,152,0,-3};
        System.out.println(new App().getnums(nums));
    }
}
