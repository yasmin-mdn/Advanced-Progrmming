#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

namespace A1
{
    
int MaximumValue(int a ,int b){
    int x=a;
    if(b>x)
        x=b;
    return x;
}
template<typename T, typename... Ts>
auto MaximumValue( T a,Ts...args){
T max=MaximumValue(args...);
if (a>max)
  max =a;
return max;
}

void swap(int &xp, int &yp)  
{  
    int temp = xp;  
    xp = yp;  
    yp = temp;  
}  
void swap(string &xp, string &yp)  
{  
    string temp = xp;  
    xp = yp;  
    yp = temp;  
}  
  
vector<int> selectionSort(vector <int> arr)  
{ int n=arr.size();
    int i, j, min_idx;  
    for (i = 0; i < n-1; i++)  
    { min_idx = i;  
        for (j = i+1; j < n; j++)  
        if (arr[j] < arr[min_idx])  
            min_idx = j;    
        swap(arr[min_idx], arr[i]);  
    }  
     return arr;
} 
void Sort(vector <string>& s){
    for(int i=0; i<s.size();i++){
    string st_min=s[i];
 for(int j=i+1; j<s.size();j++){
     if(s[i].size()>s[j].size){
         st_min=s[j];
     }
     for(int k=0; k<s.size();k++){
         if((int)s[j][k]<(int)s[i][k]){
         swap(s[i],s[j]);
        break;}
         else if((int)s[j][k]>(int)s[i][0])
     break;
     }
    
 }

    }
    
}

       
 vector<int>  CommonIntegerElements(int a[],int b[],int na,int nb){
    vector<int> commons;
for(int i =0;i<na;i++){
    for(int j=0;j<nb;j++){
        if(a[i]==b[j])
          commons.push_back(a[i]);
    }
}
  commons= selectionSort(commons);
       
        return commons; 


}

vector<string> CommonStringElements(string a[],string b[],int na,int nb){
     vector<string> commons;
    for(int i =0;i<na;i++){
    for(int j=0;j<nb;j++){
        if(a[i]==b[j])
          commons.push_back(a[i]);
    }
}
    Sort(commons);
    //sort(commons.begin(),commons.end());
    return commons;
}

template< class type>

vector<type> CommonElements(type a[],type b[],int na,int nb){
    vector<type> commons;
    for(int i =0;i<na;i++){
    for(int j=0;j<nb;j++){
        if(a[i]==b[j])
          commons.push_back(a[i]);
    }
}
return commons;
}

} // namespace A1;

