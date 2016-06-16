// SeminarHW5-zadacha2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class Stack
{
public:
	virtual bool push(int) = 0;
	virtual bool pop(int&) = 0;
	virtual int size() = 0;
	virtual ~Stack() {}
};

class ArrayStack : public Stack
{
public:
	ArrayStack() { count = 0; }

	int size() { return count; }

	bool push(int x) {
		if (!hasSpace())
			return false;
		getArray()[count] = x;
		count++;
		return true;
	}

	bool pop(int &x) {
		if (isEmpty())
			return false;
		x = getArray()[count - 1];
		count--;
		return true;
	}

protected:
	virtual int* getArray() = 0;
	virtual bool hasSpace() = 0;
	virtual bool isEmpty() = 0;
	int count;
};

class StaticArrayStack : public ArrayStack
{
public:
	StaticArrayStack() : ArrayStack() {}

private:
	int staticArray[10];

protected:
	bool hasSpace() {
		return count < 9;
	}
	bool isEmpty() {
		return count == 0;
	}
	int* getArray() {
		return staticArray;
	}
};

class DynamicArrayStack : public ArrayStack
{
public:
	DynamicArrayStack() : ArrayStack() {
		dynamicArray = new int[10];
		capacity = 10;
	}

	~DynamicArrayStack() {
		delete dynamicArray;
	}

private:
	int capacity;
	int *dynamicArray;

	bool resize() {
		int* newArray = new int[capacity * 2];

		if (newArray == NULL)
			return false;

		for (int i = 0; i < capacity; i++)
			newArray[i] = dynamicArray[i];

		int *save = dynamicArray;
		dynamicArray = newArray;
		capacity *= 2;
		delete save;
		return true;
	}

protected:
	bool hasSpace() {
		return count < capacity || resize();
	}

	bool isEmpty() {
		return count == 0;
	}

	int* getArray() {
		return dynamicArray;
	}
};

int main()
{
	StaticArrayStack staticStack;
	int input;
	cout << "Input the elements of the stack (press -1 to end adding elements!)" << endl;
	do 
	{
		cin >> input;
	}
	while (input != -1 && staticStack.push(input));

	while (staticStack.pop(input))
	{
		cout << input << endl;
	}
	DynamicArrayStack dynamicStack;

	cout << "Input the elements of the stack (press -1 to end adding elements!) " << endl;
	do
	{
		cin >> input;
	}
	while (input != -1 && dynamicStack.push(input));

	while (dynamicStack.pop(input))
	{
		cout << input << endl;
	}
	return 0;
}

