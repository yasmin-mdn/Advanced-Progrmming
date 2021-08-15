
// template<typename T>
class SaveVariableRef
{public:
   
   // SaveVariableRef(int &n){}
   // SaveVariableRef(T &n){}
~SaveVariableRef(){}

};


 //template<typename T>
class SaveVariablePtr
{public:
    int *pTemp;
    SaveVariablePtr(int *pN){
        pTemp=pN;
}

// SaveVariablePtr(T *pN){}
~SaveVariablePtr(){}
};

