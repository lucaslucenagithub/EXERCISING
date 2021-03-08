#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'rotateLeft' function below.
#
# The function is expected to return an INTEGER_ARRAY.
# The function accepts following parameters:
#  1. INTEGER d
#  2. INTEGER_ARRAY arr
#

def rotateLeft(d, arr):
    
    rotationIndex = []
    othersIndex = []  
    
    counterRotation = d
    while counterRotation < len(arr):
        rotationIndex.append(arr[counterRotation])
        counterRotation += 1
        
    counterOthers = 0
    while counterOthers < d:
        othersIndex.append(arr[counterOthers])
        counterOthers += 1

    return rotationIndex + othersIndex



if __name__ == '__main__':
    fptr = open("teste", 'w')

    first_multiple_input = input().rstrip().split()

    n = int(first_multiple_input[0])

    d = int(first_multiple_input[1])

    arr = list(map(int, input().rstrip().split()))

    result = rotateLeft(d, arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
