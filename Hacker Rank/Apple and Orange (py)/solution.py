#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the countApplesAndOranges function below.
def countApplesAndOranges(s, t, a, b, apples, oranges):
    applesCount, orangesCount = 0, 0;

    for apple in apples:
        dist = a + apple;
        if(dist >= s and dist <= t):
            applesCount += 1;

    for orange in oranges:
        dist = b + orange;
        if(dist >= s and dist <= t):
            orangesCount += 1;

    print(applesCount);
    print(orangesCount);

if __name__ == '__main__':
    st = input().split()

    s = int(st[0])

    t = int(st[1])

    ab = input().split()

    a = int(ab[0])

    b = int(ab[1])

    mn = input().split()

    m = int(mn[0])

    n = int(mn[1])

    apples = list(map(int, input().rstrip().split()))

    oranges = list(map(int, input().rstrip().split()))

    countApplesAndOranges(s, t, a, b, apples, oranges)
