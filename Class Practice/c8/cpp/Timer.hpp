#include<time.h>
#include <iostream>
#include <cstdio>
#include <ctime>
using namespace std;
class Timer{
    public:
    static int tab;
      clock_t start;
      string Label;
      static string st;
        Timer(string label){
            Label=label;
            start=clock();
            tab++;
            st=maketabs(tab);
            cout<<st<<"started"<<label<<endl;
}
string maketabs(int tab){
    string st="";
    for(int i=0;i<tab;i++){
        st+="   ";
    }
    return st;
}

~Timer(){
     double duration;
     duration = ( clock() - start ) / (double) CLOCKS_PER_SEC;
    
    st=maketabs(tab);
    cout<<st<<"ended"<<Label<<" "<<duration<<endl;
    tab--;
     
}
};

int Timer::tab;
string Timer::st;