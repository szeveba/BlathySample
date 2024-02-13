import os

def main():
    print(os.getcwd())
    filename = r"C:\Users\szegedi.barnabas\Documents\BlathySample\Documents\Programozási alapok\Érettségi feladatok\2310_cbradio\cb.txt"
    datas = read_cb_data(filename)
    for item in datas:
        print(item)

def read_cb_data(filename):
    op = []
    with open(filename, 'r', encoding='utf-8') as file:
        next(file)
        for line in file:
            splits = line.strip().split(';')
            op.append(Statisztika(splits[0],splits[1],splits[2],splits[3]))
    return op



class Statisztika:
    def __init__(self, óra, perc, db, név):
        self.óra = int(óra)
        self.perc = int(perc)
        self.db = int(db)
        self.név = név
    
    def __str__(self) -> str:
        return f"{self.név} {self.db}db ({self.óra}:{self.perc})"

main()