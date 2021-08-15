import math as m

class Triangle:
    #Dots=[]
    def __init__(self,dots):  
        self.Dots=dots

    def Surroundings(self):
        
        sides=[]
        sides.append(self.Dots[0].Distance(self.Dots[1]))
        sides.append(self.Dots[1].Distance(self.Dots[2]))
        sides.append(self.Dots[2].Distance(self.Dots[0]))
        return sum(sides)

    def Area(self):
        sides=[]
        sides.append(self.Dots[0].Distance(self.Dots[1]))
        sides.append(self.Dots[1].Distance(self.Dots[2]))
        sides.append(self.Dots[2].Distance(self.Dots[0]))
        p=sum(sides)/2
        return m.sqrt((p-sides[0])*(p-sides[1])*(p-sides[2])*p)

        
    def __eq__(self, value):
        return self.Dots==value.Dots
    