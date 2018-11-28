cases = int(input())

for i in range(cases):
    day = int(input())
    month = int(input())
    
    if (day % 2 == month % 2) or (day == 25 and month == 12):
        print("FESTIVO");
    else:
        print("LABORABLE");
