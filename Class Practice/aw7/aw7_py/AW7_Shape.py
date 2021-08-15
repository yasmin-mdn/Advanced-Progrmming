import AW7_Triangle
class Shape:
    def __init__(self,dots):  
        self.Dots=dots
    
    def __eq__(self, value):
        return self.Dots==value.Dots

    def __iadd__(self,other):
        for i in other.Dots:
            if (i not in self.Dots):
                self.Dots.append(i)
        return self
    def Surroundings(self) :
        s=0
        for i in range(-1,len(self.Dots)-1):
            s+=self.Dots[i].Distance(self.Dots[i+1])
        return s
    def Area(self):
        a=0
        if len(self.Dots)%2==0:
        
         for i in range(-2,len(self.Dots)-2,2):
            triangle1 = AW7_Triangle.Triangle([self.Dots[i],self.Dots[i+1],self.Dots[i+2]])
            a+=int(triangle1.Area())
        else:
            for i in range(-2,len(self.Dots)-3,2):
                triangle1 = AW7_Triangle.Triangle([self.Dots[i],self.Dots[i+1],self.Dots[i+2]])
                a+=int(triangle1.Area())
            triangle1 = AW7_Triangle.Triangle([self.Dots[0],self.Dots[-2],self.Dots[-3]])
            a+=triangle1.Area()
        return a

    