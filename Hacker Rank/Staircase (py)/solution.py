#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the staircase function below.
def staircase(n):
    stairCase = "";

    step = 1;
    spaces = n - 1;
    while step <= n:
        stairCase += (spaces * " ") + (step * "#") + "\n"
        step+=1
        spaces-=1

    print(stairCase)

    

if __name__ == '__main__':
    n = int(input())

    staircase(n)
