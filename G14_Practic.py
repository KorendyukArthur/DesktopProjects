print("Задание 1")
list1 = []
class Square:
    def __init__(self,s):
        self.square_list = s
        list1.append(self.square_list)
        

obj1 = Square(3)
obj2 = Square(4)
obj3 = Square(5)
print(list1)

print("Задание 2")

list2 = []
class Square1:
    def __init__(self,s1):
        self.square_list1 = s1
        list2.append(self.square_list1)
        print("{} на {} на {} на {}".format(s1,s1,s1,s1))
        
obj11 = Square1(5)
print(list2)


class NewClass1:
    def __init__(self,a,b):
        self.alfa = a
        self.bta = b  

