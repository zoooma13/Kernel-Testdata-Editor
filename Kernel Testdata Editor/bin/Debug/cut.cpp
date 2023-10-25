#include <bits/stdc++.h>
using namespace std;

int main()
{
    freopen("apio.in" ,"r" ,stdin);
    freopen("apio2.in" ,"w" ,stdout);
    int n;
    cin >> n;
    vector <string> b(n);
    for(string&r : b)
        cin >> r;
    vector <string> nb;
    for(int i = 21; i <= 67; i++)
        nb.push_back(b[i].substr(11 ,85-11+1));
    while(nb.size() < nb[0].size()){
        nb.insert(nb.begin() ,string(nb[0].size() ,'0'));
        nb.push_back(string(nb[0].size() ,'0'));
    }
    cout << nb.size() << endl;
    for(auto&r : nb)
        cout << r << endl;
}
