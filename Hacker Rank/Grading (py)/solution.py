#!/bin/python3

import math
import os
import random
import re
import sys
from typing import Counter

#
# Complete the 'gradingStudents' function below.
#
# The function is expected to return an INTEGER_ARRAY.
# The function accepts INTEGER_ARRAY grades as parameter.
#


def gradingStudents(grades):
    result = []

    index = 0
    while index < len(grades):
        nextMultipleOf5 = math.ceil(grades[index]/5) * 5
        if (grades[index] >= 38 and abs(grades[index] - nextMultipleOf5) < 3):
            result.append(nextMultipleOf5)
        else:
            result.append(grades[index])
        index += 1
    return result


if __name__ == '__main__':

    grades_count = int(input().strip())

    grades = []

    for _ in range(grades_count):
        grades_item = int(input().strip())
        grades.append(grades_item)

    result = gradingStudents(grades)

    print(result)
