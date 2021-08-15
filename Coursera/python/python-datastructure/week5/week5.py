name = input("Enter file:")
if len(name) < 1 : name = "mbox-short.txt"
handle = open(name)
d=dict()
for line in handle:
    if not line.rstrip().startswith("From"):continue
    words=line.split(" ")
    d[words[1]]=d.get(words[1],0)+1
bigestkey=None
bigestvalue=None
for k in d:
    if bigestkey==None or bigestvalue<d[k]:
        bigestkey=k
        bigestvalue=d[k]

print(bigestkey,d[bigestkey])
