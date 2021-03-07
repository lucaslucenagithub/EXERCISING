#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the breakingRecords function below.
def breakingRecords(n, scores):
    highest, lowest, mostPointsRecords, leastPointsRecords = [], [], 0, 0

    currentGame = 0
    while currentGame < n:
        highest.append(scores[currentGame])
        lowest.append(scores[currentGame])

        if(currentGame == 0):
            currentGame += 1
            continue

        if(highest[currentGame - 1] >= highest[currentGame]):
            highest[currentGame] = highest[currentGame - 1]

        if(lowest[currentGame] >= lowest[currentGame - 1]):
            lowest[currentGame] = lowest[currentGame - 1]

        if(highest[currentGame - 1] < highest[currentGame]):
            mostPointsRecords += 1

        if(lowest[currentGame - 1] > lowest[currentGame]):
            leastPointsRecords += 1

        currentGame += 1

    return [mostPointsRecords, leastPointsRecords]


if __name__ == '__main__':
    fptr = open("TESTE", 'w')

    n = int(input())

    scores = list(map(int, input().rstrip().split()))

    result = breakingRecords(n, scores)
    print(' '.join(map(str, result)))

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()
