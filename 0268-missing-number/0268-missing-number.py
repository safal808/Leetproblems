class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        n = len(nums)
        tsum= n*(n+1)//2
        asum=sum(nums)
        return tsum-asum
            
                
        