int a1 = 3;
int b1 = 26;
int c1 = 5;
int a2 = 56456;
int b2 = 7;
int c2 = 6;
int a3 = 39;
int b3 = 8;
int c3 = 9;

int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}

Console.WriteLine(Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)));