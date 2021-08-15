#include<iostream>
#include<vector>
using namespace std;

   /* int maxofarray(vector<int> nums){
        max=nums[0];
     for(i=1;i<=nums.size;i++)
       if(nums[i]>max)
       max=nums[i];
 }*/
    

int maxofarray(int nums[],int n){
       int max=nums[0];
     for(int i=0;i<n;i++){
         if(nums[i]>max)
         max=nums[i];
     }
      
       return max;
       }


int main(){
    int nums[]={41,7,45,-2,123};
    int size=(sizeof(nums)/sizeof(int));
   cout<< maxofarray(nums,size);
   getchar();
}

 
