# No.10818 - 최소, 최대
Q Path - https://www.acmicpc.net/problem/10818

comment - min, max 최댓값을 넣는 것보다 값 중 하나를 넣는 것이 빠르다.
C# s => int.parse(s) 보다 int.parse만 하는것이 더 빠르다.
java의 경우 배열을 미리 int형으로 변환 후 처리하는 것이 빨랐지만
Kotlin의 경우 반대로 List화 시켜서 넣으면 느려진다.

Language | Memory(KB) | RunTime(ms)
------------ | ------------- | ------
C# | 101764 | 852
Kotlin | 116860 | 428
Java | 122464 | 432 