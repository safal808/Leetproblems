public class Solution {
    public int Reverse(int x) {
    
        long rev=x;
        int sum = 0;
        
        while (x != 0) {            
            if (sum > int.MaxValue / 10 || sum < int.MinValue / 10) {
                return 0;
            }
            
            sum = sum * 10 +  x % 10;;
            x = x / 10;
        } 
        return sum;
    }
}