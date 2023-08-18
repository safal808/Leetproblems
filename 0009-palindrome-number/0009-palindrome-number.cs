
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false; 
        }
        int rev=x;
        int sum = 0;
        
        while (x != 0) {
            int r = x % 10;
            sum = sum * 10 + r;
            x = x / 10;
        }
        
        return rev == sum;
    }
}
