#include<iostream>
#include "Timer.hpp"
void method2(){
    Timer t2("method2");
    _sleep(2000);
}
void method(){
    Timer t("method");
    method2();
    _sleep(1500);
}

int main(){
    Timer::tab=0;
    Timer tmain("main");
    method();
}
