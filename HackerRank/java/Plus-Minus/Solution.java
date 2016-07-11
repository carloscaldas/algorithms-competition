import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        int less = 0;
        int more = 0;
        int same = 0;
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        for(int arr_i=0; arr_i < n; arr_i++){
            int tmp = in.nextInt();
            if (tmp == 0) {
                same++;
            }
            else if (tmp >0) {
                more++;     
            }
            else {
                less++;
            }
        }
        System.out.printf("%.6f\n", (double)more/(double)n);
        System.out.printf("%.6f\n", (double)less/(double)n);
        System.out.printf("%.6f\n", (double)same/(double)n);
    }
}
