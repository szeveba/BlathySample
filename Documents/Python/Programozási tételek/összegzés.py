def sumIntegers(collection):
    temp = 0
    for x in collection:
        temp += x
    return temp


def multipleIntegers(collection):
    temp = 1
    for x in collection:
        temp *= x
    return temp

def sumStrings(collection):
    temp = ""
    for x in collection:
        temp += x
    return temp

integers = [1,2,3,4,5]
strings = ["a", "b", "c"]
result = sumIntegers(integers)
print(result)
result = multipleIntegers(integers)
print(result)
result = sumStrings(strings)
print(result)

def f15V1(collection):
    op = 0
    for i in range(0,len(collection)):
        if i % 2 != 0:
            op += collection[i]
    return op

def f15V2(collection):
    op = 0
    i = 0
    for item in collection:
        if(i % 2 != 0):
            op += item
        i += 1
    return op