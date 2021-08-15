largest = None
smallest = None
while True:
	num = input("Enter a number: ")
	try:
		n=int(num)
	except:
		if num == "done" :
           	 break
		else:
			print("Invalid input") 
        
        
	if  n>largest or largest==None:
			largest=n
	elif  n<smallest or smallest==None:
			smallest=n
   
    

print("Maximum is", largest)
print("Minimum is", smallest)