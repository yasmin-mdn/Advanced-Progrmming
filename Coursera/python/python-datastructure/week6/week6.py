name = input("Enter file:")
if len(name) < 1 : name = "mbox-short.txt"
handle = open(name)
d=dict()
for line in handle:
    if not line.startswith("From") or line.startswith("From:") :continue
    words=line.split(":")
    subwords=words[0].split()
    h=subwords[5]
    d[h]=d.get(h,0)+1
ls=sorted(d.items())
for (k,v) in ls:
 print(k,v)