#1
hrs = input("Enter Hours:")
h = float(hrs)
rate= input("Enter Hours:")
r=float(rate)
if h<40 :
    print(h*r)
else:
    value=(h-40)*1.5*r
    value=value+40*r
    print(value)


#2
score = input("Enter Score: ")
s=float(score)
if s>1.0 or s<0.0:
    print("Error")
elif  s<0.6:
    print("F")
elif  s>=0.6 and s<0.7:
    print("D")
elif   s>=0.7 and s<0.8:
    print("C")
elif   s>=0.8 and s<0.9:
    print("B")  
elif   s>=0.9:
    print("A")