class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False
        else:
            original = x
            reversed_num = 0
            while x != 0:
                digit = x % 10
                reversed_num = reversed_num * 10 + digit
                x = x // 10
            return reversed_num == original