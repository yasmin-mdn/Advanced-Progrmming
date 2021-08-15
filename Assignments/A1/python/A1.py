def MaximumValue(*arguments):
    max=arguments[0]
    for i in arguments:
        if i>max:
            max=i
    return max


def bubbleSort(arr):
    n = len(arr)
    for i in range(n):
        for j in range(0, n-i-1):
            if arr[j] > arr[j+1] :
                tmp=arr[j+1] 
                arr[j+1]=arr[j]
                arr[j]=tmp


  

def CommonIntegerElements(a,b):
    c=[]
    for i in a:
        for j in b:
            if(i==j):
             c.append(i)
    
    bubbleSort(c)
    return c

def CommonStringElements(st1,st2):
    c=[]
    for i in st1:
        for j in st2:
            if(i==j):
             c.append(i)
    bubbleSort(c)
    return c


def CommonElements(a,b):
    c=[]
    for i in a:
        for j in b:
            if(i==j):
             c.append(i)

    return c
