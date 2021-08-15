import math
class Dot:
    def __init__(self, X,Y):  
        self.X = X
        self.Y=Y

    def Distance(self,other):
        dx=pow(self.X-other.X,2)
        dy=pow(self.Y-other.Y,2)
        return math.sqrt(dx+dy)
    
    def __eq__(self, value):
        return self.X==value.X and self.Y==value.Y