with open("text.txt","r") as f,open("odd.txt","w") as odd,open("even.txt","w") as even:
    i=0
    for line in f:
        if(i%2==0):
           even.write(line+"\n")
           i=i+1
        else:
            odd.write(line+"\n")
            i= i+1

