#include <bits/stdc++.h>
using namespace std;

int n = 25;
int di[] = {+1 ,0 ,-1 ,0};
int dj[] = {0 ,+1 ,0 ,-1};

void flood(int i ,int j ,int m ,vector <string>&g ,vector <vector <int>>&b)
{
    if(i < 0 || j < 0 || i >= n || j >= n)
        return;
    if(b[i][j] || g[i][j] != '1')
        return;
    b[i][j] = m;
    for(int d = 0; d < 4; d++)
        flood(i+di[d] ,j+dj[d] ,m ,g ,b);
}

int main()
{
//    freopen("spiral_connected.in" ,"r" ,stdin);
//    cin >> n;
    vector <string> g(n ,string(n ,'0'));
//    for(auto&r : g)
//        cin >> r;
    for(int i = 0; i < n; i++)
    for(int j = 0; j < n; j++)
        g[i][j] = '0' + (rand()&1);
//    for(int d = 0; d <= n/2; d += 2){
//        for(int i = d; i < n-d; i++)
//            g[i][d] = '1' ,g[i][n-d-1] = '1',
//            g[d][i] = '1' ,g[n-d-1][i] = '1';
//    }

    for(auto&r : g)
        printf("%s\n",r.c_str());

    auto comp = [&](vector <int>&v){
        vector <int> r;
        map <int ,int> mp;
        mp[0] = 0;
        mp[1] = 1;
        int nxt = 1;
        for(auto&i : v){
            if(!mp.count(i))
                mp[i] = ++nxt;
            r.push_back(mp[i]);
        }
        return r;
    };

    for(int d = 0; d < n; d++){
        auto cg = g;
        for(int i = 0; i < n; i++)
        for(int j = 0; j < n; j++)
            if((n-i-1)+j <= d)
                continue;
            else
                cg[i][j] = '0';

        int vm = 2;
        vector <vector <int>> vis(n ,vector <int>(n));
        for(int i = 0; i < n; i++)
        for(int j = 0; j < n; j++) if(!vis[i][j] && cg[i][j] == '1')
            flood(i ,j ,vm++ ,cg ,vis);

        vector <int> ss;
        for(int j = 0; j <= d; j++)
            if(vis[n-d+j-1][j]
            && (n-d+j == n || cg[n-d+j][j] == '0')
            && (j == 0 || cg[n-d+j-1][j-1] == '0'))
                ss.push_back(1);
            else
                ss.push_back(vis[n-d+j-1][j]);

        auto c = comp(ss);
        for(auto&x : c){
            if(x == 1)
                printf("+");
            else if(x == 0)
                printf("_");
            else
                printf("%d",x-2);
        }
        printf("\n");
    }
}
