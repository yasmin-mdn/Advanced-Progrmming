#second assignment
fname = input("Enter file name: ")
fh = open(fname)
lst = list()
for line in fh:
   words=line.rstrip().split()
   for word in words:
       if word not in lst:
           lst.append(word)
lst.sort()
print(lst)

#second assignment
fname = input("Enter file name: ")
if len(fname) < 1 : fname = "mbox-short.txt"
fh = open(fname)
count = 0
for line in fh:
    if not line.rstrip().startswith("From") or line.rstrip().startswith("From:"):continue
    lst=line.rstrip().split(" ")
    print(lst[1])
    count+=1

print("There were", count, "lines in the file with From as the first word")
