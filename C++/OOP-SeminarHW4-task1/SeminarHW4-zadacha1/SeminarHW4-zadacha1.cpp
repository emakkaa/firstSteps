// SeminarHW4-zadacha1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

class Bag {
protected:
	int *arr;
	int size;
	int count;

public:
	Bag() {
		arr = NULL;
		count = 0;
		size = 0;
	}

	~Bag() {
		delete arr;
	}

	void create() {
		if (arr != NULL) delete arr;
		count = 0;
		size = 8;
		arr = new int[size];
	}

	void resize() {
		size *= 2;
		int* copy = arr;
		arr = new int[size];
		for (int i = 0; i < count; i++) {
			arr[i] = copy[i];
		}
		delete copy;
	}

	virtual void add(int element) {
		if (size == 0) {
			create();
		}
		else if (count == size) {
			resize();
		}
		arr[count] = element;
		count++;
	}

	bool remove(int element) {
		int* copy = arr;
		arr = new int[size];
		for (int i = 0; i < count; i++) {
			if (copy[i] != element) arr[i] = copy[i];
			else {
				for (int j = i + 1; j < count; j++) {
					arr[j - 1] = copy[j];
				}
				count--;
				return true;
			}
		}
		return false;
	}

	int getCount() {
		return count;
	}

	void intersect(Bag other) {
		cout << "intersection: " << endl;
		for (int i = 0; i < count; i++) {
			if (other.remove(arr[i])) {
				cout << arr[i] << " ";
			}
		}
		cout << endl;
	}

	void addition(Bag other) {
		cout << "addition: " << endl;
		for (int i = 0; i < count; i++) {
			cout << arr[i] << " ";
		}

		for (int i = 0; i < other.count; i++) {
			cout << other.arr[i] << " ";
		}

		cout << endl;
	}

	void substraction(Bag other) {
		cout << "substraction: " << endl;
		for (int i = 0; i < count; i++) {
			if (!other.remove(arr[i])) {
				cout << arr[i] << " ";
			}
		}
		other.print();
	}

	void print() {
		for (int i = 0; i < count; i++) {
			cout << arr[i] << " ";
		}
		cout << endl;
	}
};

class Set : public Bag {
public:
	void add(int element) {
		if (!isContained(element)) {
			Bag::add(element);
		}
	}

	bool isContained(int element) {
		for (int i = 0; i < count; i++) {
			if (arr[i] == element) {
				return true;
			}
		}
		return false;
	}

	void addition(Set other) {
		cout << "addition: " << endl;
		for (int i = 0; i < count; i++) {
			cout << arr[i] << " ";
			other.remove(arr[i]);
		}
		other.print();
	}
};

int main() {
	cout << "Bag: " << endl;
	Bag bag1, bag2;
	for (int i = 0; i < 10; i++) {
		bag1.add(i);
	}
	bag2.add(1);
	bag2.add(2);
	bag2.add(3);
	bag2.add(4);
	bag2.add(5);
	bag1.print();
	bag2.print();
	bag1.intersect(bag2);
	bag1.addition(bag2);
	bag1.substraction(bag2);
	cout << endl;
	cout << "Set: " << endl;
	Set set1, set2;
	set1.add(1);
	set1.add(2);
	set1.add(3);
	set1.add(4);
	set2.add(5);
	set2.add(6);
	set2.add(7);
	set2.add(8);
	set1.print();
	set2.print();
	set1.intersect(set2);
	set1.addition(set2);
	set1.substraction(set2);
	cout << endl;
}

