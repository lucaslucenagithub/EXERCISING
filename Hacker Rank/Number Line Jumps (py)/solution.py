#!/bin/python3

import math
import os
import random
import re
import sys

#GREATE EXPLANATION IN A MORE SOFISTICATED WAY TO RESOLVE THE KANGAROO FUNCTION:
# ->Product (x2-x1)*(v2-v1) would be >0 when one kangaroo starts ahead of another kangaroo and with greater velocity then another kangaroo. In that case another kangaroo will never be able to catch up.
# ->Product (x2-x1)*(v2-v1) would be =0 when,
# 1)Both start with same location but different speed.
# 2)Both start with different location but same speed.
# in either case they will never meet.
# eg. 0 5 3 10
# (x2-x1)*(v2-v1)>0 First kangaroo will never be able to catch up.
# So what we require is (x2-x1)*(v2-v1)<0.

# Complete the kangaroo function below.
def kangaroo(x1, v1, x2, v2):
    if((x2 >= x1 and v2 > v1) or (x1 >= x2 and v1 > v2)):
        return "NO"

    jumps = 0
    while jumps < 10000:
        jumps += 1
        if((v1 * jumps) + x1) == ((v2 * jumps) + x2):
            return "YES"

    return "NO"


if __name__ == '__main__':
    fptr = open("teste", 'w')

    x1V1X2V2 = input().split()

    x1 = int(x1V1X2V2[0])

    v1 = int(x1V1X2V2[1])

    x2 = int(x1V1X2V2[2])

    v2 = int(x1V1X2V2[3])

    result = kangaroo(x1, v1, x2, v2)

    fptr.write(result + '\n')

    fptr.close()
