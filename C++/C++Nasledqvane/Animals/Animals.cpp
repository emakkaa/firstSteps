// Animals.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstring>
using namespace std;
class Animal {
	virtual void sayHello() const = 0;
	virtual void sayAge() const = 0;
	virtual ~Animal() = 0;
	
};
class Dog : public Animal {
protected:
	char name[32];
	int age;
public:
	Dog(char* _name,int _age) :age(_age) {
		strcpy_s(name,_name);
	}
	void sayHello() {
		cout << "Woof!";
	}
	void sayAge() {
		cout<<"My name is"
	}
};

int main()
{
    return 0;
}

