def isEven(num):
    return num % 2 == 0

def evenCount(collection):
    count = 0
    for x in collection:
        if isEven(x):
            count += 1
    return count


def getCount(value, collection):
    count = 0
    for item in collection:
        if value == item:
            count += 1
    return count


integers = [1,2,3,4,5,6]
print(evenCount(integers))
print(getCount("a", "asdaadsa"))

