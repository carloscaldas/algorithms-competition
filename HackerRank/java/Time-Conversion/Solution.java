import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static String convert(String time) {
	   int hour = new Integer(time.substring(0, 2));
	   String middle = time.substring(2, 8);
	   String period = time.substring(8, 10);

	   if (hour == 12) {
    		if (period.equals("AM")) {
    			hour = 0;
    		}
    	} else {
    		if (period.equals("PM")) {
    			hour += 12;
    		}
    	}

		return ((hour < 10) ? ("0" + hour) : Integer.toString(hour)) + middle;
	}
    
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String time = in.next();
        System.out.println(convert(time));
		in.close();
    }
}