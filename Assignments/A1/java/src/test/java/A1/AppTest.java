package A1;

import org.junit.Test;
import static org.junit.Assert.*;

import java.util.ArrayList;

public class AppTest {
    @Test public void A1(){
        Program classUnderTest = new Program();
        assertEquals(Program.MaximumValue(2, 5, 3, 8, 1, 21, 34, 6, 0) , 34);

        Integer[] nums1 = {1, 54, 125, 23, 644, 31, 5, 61};
        Integer[] nums2 = { 125, 23, 2, 3, 1001, 22, 5, 234, 31, 94};
        Integer[] exp1 = Program.CommonIntegerElements(nums1,nums2);
        Integer[] act1 = {5, 23, 31, 125};
        assertEquals(exp1,act1);

        String[] str1 = {"Hello", "All", "Java", "Ap" };
        String[] str2 = { "Ap", "Programming", "First", "Language", "Microsoft", "All" , "Java"};
        String[] exp2 = A1.Program.CommonStringElements(str1,str2);
        String[] act2 = {"All", "Ap", "Java" };
        assertEquals(exp2,act2);

        ArrayList<String> exp3 = A1.Program.CommonElements(str1,str2);
        ArrayList<String> act3 = new ArrayList<String>();
        act3.add("All");act3.add("Java");act3.add("Ap");
        assertEquals(exp3,act3);
        ArrayList<Integer> exp4 = A1.Program.CommonElements(nums1,nums2);
        ArrayList<Integer> act4 = new ArrayList<Integer>();
        act4.add(125); act4.add(23); act4.add(31); act4.add(5);
        assertEquals(exp4,act4);

    }
}
