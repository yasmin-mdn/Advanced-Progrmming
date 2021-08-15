def maxofarray(nums):
    max=nums[0]
    i=0
    for i in nums:
      if i>max:
        max=i
    return max

nums=[12,7,123,-3]
print(maxofarray(nums))