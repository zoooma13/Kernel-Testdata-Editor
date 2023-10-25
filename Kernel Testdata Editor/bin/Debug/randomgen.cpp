#include <bits/stdc++.h>
using namespace std;

mt19937 rng(chrono::steady_clock::now().time_since_epoch().count());
#define rnd(s ,e) uniform_int_distribution<int>(s, e)(rng)

int main()
{
    freopen("input.in" ,"w" ,stdout);

    int n = 100;
    //scanf("%d",&n);
    printf("%d\n",n);
    for(int i = 0; i < n; i++)
    {
        string row(n ,'0');
        for(int j = 0; j < n; j++) if(rnd(0,1))
            row[j]++;
        printf("%s\n",row.c_str());
    }
}
