first assigment
fname = input("Enter file name: ")
fh = open(fname)
for line in fh:
    line=line.rstrip().upper()
    print(line)


#second 
fname = input("Enter file name: ")
fh = open(fname)
s=0
count=0
for line in fh:
    if not line.startswith("X-DSPAM-Confidence:") : continue
    pos=line.find(":")
    count+=1
    s+=float(line[pos+1:].strip())
avg=s/count
print("Average spam confidence:"+" "+str(avg))