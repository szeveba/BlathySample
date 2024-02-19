def isEven(num):
    return num % 2 == 0

def hasEven(collection):
    i = 0
    while(i < len(collection) and not isEven(collection[i])):
        i+=1
    return i < len(collection)

def hasEven2(collection):
    for x in collection:
        if isEven(x):
            return True
    return False

integers1 = [1,3,5]
integers2 = [2,4,6]
integers = [1,2,3,4,5,6]

print(hasEven(integers2))
print(hasEven(integers1))
print(hasEven(integers) == hasEven2(integers))
