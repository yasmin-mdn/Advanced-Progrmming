import queue
import copy
from enum import Enum

parent = {}

class ECell(Enum):
    Empty = 0
    Wall = 1

class Graph:
    """
    maze size and wall positions. walls is a list of position like [(2, 3), (1,3), (4,5)]
    """
    """
    Constructs a grid of nodes using the provided x and y size.
    """
    def __init__(self, n, m, walls):
        self.board = [[0 for _ in range(n)] for _ in range(m)]
        for i in range(m):
            for j in range(n):
                if (i, j) in walls:
                    self.AddNode((i, j), ECell.Wall)
                else:
                    self.AddNode((i, j), ECell.Empty)

    def AddNode(self, pos, cellType):
        newNode = Node(pos, cellType)
        self.board[newNode.x][newNode.y] = newNode 

    
    def GetNode(self, x, y):
        try:
            self.board[int(x)][int(y)]
        except (ValueError, IndexError):
            return None
        else:
            return self.board[int(x)][int(y)]
    """
    find adjacent nodes
    """
    def GetNeighbours(self, node):
        list=[]
        if  GetNode(self,node.x-1,node.y).type==ECell.Empty:
            list.append(GetNode(self,node.x-1,node.y))
        if  GetNode(self,node.x,node.y-1).type==ECell.Empty:
             list.append(GetNode(self,node.x,node.y-1))
        if  GetNode(self,node.x+1,node.y).type==ECell.Empty:
             list.append(GetNode(self,node.x+1,node.y))
        if  GetNode(self,node.x,node.y+1).type==ECell.Empty:
             list.append(GetNode(self,node.x,node.y+1))
        return list
        
class Node:
    def __init__(self, pos, cellType):
        self.x = pos[0]
        self.y = pos[1]
        self.type = cellType
        parent=None
    
    def __eq__(self, other):
        return (self.x == other.x and self.y == other.y)

    def __hash__(self):
        return hash((self.x, self.y))

def TracePath(start, current):
    path = []
    while current!=start :
      list=Graph.GetNeighbours(self,current)
      if current.parent in list:
            path.append(current.parent)
            current=current.parent


    return path

def DrawMaze(n, m, path, start, goal, walls):
    b = [[0 for _ in range(n)] for _ in range(m)]
    for i in range(0,n):
        for j in range(0,m):
            b[i][j]="-"
            if(i,j) in walls:
                b[i][j]="W"
            if (i,j) in path:
                 b[i][j]="P"
            if (i,j) == start:
                 b[i][j]="S"
            if (i,j) == goal:
                 b[i][j]="G"
    for i in range(0,n):
        for j in range(0,m):
            print(b[i][j] ,end="")
        print("\n")


def BreadthFirstSearch(maze, start, goal):
    frontier = queue.Queue()
    frontier.put(start)
    visited = [start]
    Found = False

    while not frontier.empty():
        current = frontier.get()
        if current == goal:
            path = TracePath(start, current)
            Found = True
            path.append((start.x, start.y))
            return path[::-1]
        else:
            ## 4
            pass
            ##
    if (not Found):
        return "Not Found"

def FindPath(s, e, n, m, walls):
    maze = Graph(n, m, walls)
    start = maze.board[s[0]][s[1]]
    end = maze.board[e[0]][e[1]]
    path = BreadthFirstSearch(copy.deepcopy(maze), start, end)
    DrawMaze(n, m, path, start, end, walls)
    print(path)
    return path


walls = [(4,4), (5,5), (4,5), (5,4)]
path = [(1, 2), (2, 2), (3, 2), (3, 3), (3, 4), (3, 5), (3, 6), (4, 6), (4, 7)]
DrawMaze(10, 10, path, (1,2), (4,7), walls)