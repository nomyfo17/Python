import random
import time
number = random.randint (1,10)
while True:
    print("guess the number")
    ng = input()
    rng = int (ng)
    if rng == number:
        print("you found the num")
        break
    elif rng < number:
        print("higher")
    elif rng > number:
        print("lower")
print("Base of openRG by @nomyfo17ultra")
time.sleep(1.5)
