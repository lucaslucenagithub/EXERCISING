#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the birthday function below.
def birthday(s, d, m):

    result = 0

    counter = 1
    for x in s:
        chocoSum = x

        for y in s[counter:counter+(m-1)]:
            chocoSum += y    

        if(chocoSum == d):
            result += 1

        counter += 1

    return result


if __name__ == '__main__':
    fptr = open("TESTE", 'w')

    n = int(input().strip())

    s = list(map(int, input().rstrip().split()))

    dm = input().rstrip().split()

    d = int(dm[0])

    m = int(dm[1])

    result = birthday(s, d, m)
    print(result)

    fptr.write(str(result) + '\n')

    fptr.close()
