def computepay(h,r):
	if h<40 :
	 value=h*r
	else:
	 value=(h-40)*1.5*r
	 value=value+40*r
	return value

hrs = input("Enter Hours:")
h = float(hrs)
rate= input("Enter Hours:")
r=float(rate)
p = computepay(h,r)
print("Pay",str(p))