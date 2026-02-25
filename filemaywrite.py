import time
import random
import os
while True:
    print("code or txt")
    time.sleep(0.2)
    fullcode = []
    while True:
        time.sleep(0.5)
        code = input(" -  ")
        if code == "save":
            break
        else:
            fullcode.append(code)
    time.sleep(0.2)
    filename = input("file name -  ")
    with open(filename, "a") as file:
        for item in fullcode:
            file.write(str(item) + "\n")
    print("file sussecfullly saved!")