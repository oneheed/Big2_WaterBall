﻿// See https://aka.ms/new-console-template for more information
using Big2.Models;

var commeand = @"S[8] S[9] S[3] D[J] S[7] H[3] C[2] C[9] H[2] D[7] S[K] C[6] C[3] D[4] H[7] C[A] D[A] D[K] H[4] D[8] C[4] H[10] H[A] S[10] H[Q] H[5] S[4] D[5] H[9] H[8] C[10] S[6] S[A] D[3] S[5] D[9] D[Q] H[K] C[Q] H[J] D[10] S[2] H[6] C[K] S[J] C[7] S[Q] D[6] D[2] C[J] C[8] C[5]
水球
火球
保齡球
地瓜球
0
0
3
4
4
10
10
11
-1
-1
-1
0 1
5 6
-1
7 8
7 8
5 6
-1
-1
-1
5 6
-1
-1
-1
0
0
3
2
0
3
5
4
2
8
-1
-1
-1
0
3
-1
0
-1
-1
-1
0";

var big2Game = new Big2Game(commeand);
big2Game.Start();