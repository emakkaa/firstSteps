#include <iostream>
using namespace std;

class DynamicArray{
    int* elements;
    int size;
    int capacity;

private:
    void resize(){
        capacity *=2;
        int* newElements=new int[capacity];
        for(int i=0;i<size;i++){
            newElements[i]=elements[i];
        }
        delete[] elements;
        elements=newElements;
    }

public:
    DynamicArray(): size(0), capacity(8) {
        elements=new int[capacity];
    }

    DynamicArray(const DynamicArray& other){

    }

    int getSize() const{
        return size;
    }

    int getAt(int index) const{
        return elements[index];
    }

    void addAtEnd(int element){
        if(size==capacity){
           resize();
        }
        elements[size]=element;
        size++;
    }
    void removeLast(){
        size--;
    }

    void addAt(int element, int index){
        if(size==capacity){
            resize();
        }
        for(int i=size;i>index;--i){
            elements[i]=elements[i-1];
        }
        elements[index]=element;
        size++;

    }

    void removeAt(int index){
        for(int i=index;i<size-1;i++){
            elements[i]=elements[i+1];
        }
        size--;
    }


};


int main()
{
    DynamicArray d1;
    d1.addAtEnd(1);
    d1.addAtEnd(2);
    d1.addAtEnd(3);
    DynamicArray d2=d1;
    return 0;
}
