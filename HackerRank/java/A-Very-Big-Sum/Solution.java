import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        long acc = 0;
        for(int arr_i=0; arr_i < n; arr_i++){
            acc += in.nextLong();
        }
        System.out.println(acc);
		in.close();
    }
}