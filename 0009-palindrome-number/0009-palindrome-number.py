class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False

        original, reversed_num = x, 0
        while x:
            reversed_num = reversed_num * 10 + x % 10
            x //= 10

        return original == reversed_num
