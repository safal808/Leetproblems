import math
class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        if n<=0:
            return False
        power = math.log2(n)
        return power == int(power)
        
        