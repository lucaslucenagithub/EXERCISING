#!/bin/python3

import math
import os
import random
import re
import sys
from typing import Counter

#
# Complete the 'getTotalX' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER_ARRAY a
#  2. INTEGER_ARRAY b
#


def getTotalX(a, b):
    result = 0
    numbers = a + b

    integerValue = max(a)
    while (integerValue <= max(numbers)):
        firstArrayMatches = 0
        for x in a:
            if(integerValue % x == 0):
                firstArrayMatches += 1

        secondArrayMatches = 0
        for x in b:
            if(x % integerValue == 0):
                secondArrayMatches += 1

        if(firstArrayMatches == len(a) and secondArrayMatches == len(b)):
            result += 1
            
        integerValue += 1

    return result


if __name__ == '__main__':
    fptr = open("TESTE", 'w')

    first_multiple_input = input().rstrip().split()

    n = int(first_multiple_input[0])

    m = int(first_multiple_input[1])

    arr = list(map(int, input().rstrip().split()))

    brr = list(map(int, input().rstrip().split()))

    total = getTotalX(arr, brr)
    print(total)

    fptr.write(str(total) + '\n')

    fptr.close()
