
def HasRL(queue):
    for i in range(len(queue)-1):
        if(queue[i]=='R' and queue[i+1]=='L'):
            return True
    return False


def solve(queue):
    res=0
    while(HasRL(queue)):
        i=0
        while(i<len(queue)-1):
            if(queue[i]=='R' and queue[i+1]=='L'):
                queue=queue[:i]+"LR"+queue[i+2:]
                i=i+1
            i=i+1
        res=res+1
    return res