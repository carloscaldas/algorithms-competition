import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for(int a0 = 0; a0 < t; a0++){
            int n = in.nextInt(); //test cases
            int k = in.nextInt(); //cancelation threshold
            //int a[] = new int[n];
            int inTime = 0;
            for(int a_i=0; a_i < n; a_i++){
                int tmp = in.nextInt();
                if (tmp<=0) {
                    inTime++;
                }
            }
            System.out.println( (inTime < k) ? "YES" : "NO" );
        }
    }
}
