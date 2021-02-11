#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the plusMinus function below.
def plusMinus(arr):
    arrTotal = len(arr)
    pos, neg, zero = 0, 0, 0
    for index in arr:
        if(index > 0):
            pos += 1
        if(index < 0):
            neg += 1
        if(index == 0):
            zero += 1
    print("{:.6f}".format(pos / arrTotal))
    print("{:.6f}".format(neg / arrTotal))
    print("{:.6f}".format(zero / arrTotal))
    
if __name__ == '__main__':
    
    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)
