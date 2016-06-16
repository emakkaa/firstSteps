// SeminarHW4-zadacha2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstring>
using namespace std;


class DoubleVect {
protected:
	double* vector;
	int size;
	int lower;
	int upper;
public:
	DoubleVect(int s = 1) {
		lower = 0;
		upper = s - 1;
		size = s;
		vector = new double[s];
	}

	~DoubleVect() {
		delete[] vector;
	}

	DoubleVect(const DoubleVect& other) {
		size = other.size;
		vector = new double[size];

		for (int i = 0; i < size; i++)
		{
			vector[i] = other.vector[i];
		}
		lower = other.lower;
		upper = other.upper;
	}

	DoubleVect& operator=(const DoubleVect& other) {
		if (this != &other)
		{
			delete[] vector;
			size = other.size;
			vector = new double[size];

			for (int i = 0; i < size; i++)
			{
				vector[i] = other.vector[i];
			}
			lower = other.lower;
			upper = other.upper;
		}
		return *this;
	}

	double& operator[](int i) {
		return vector[i];
	}

	int lowerBound() const {
		return lower;
	}

	int upperBound() const {
		return upper;
	}
};

class DoubleVector : public DoubleVect
{
public:
	DoubleVector(int low, int upp) : DoubleVect(upp - low + 1) {
		lower = low;
		upper = upp;
	}

	double& operator[] (int i) {
		return DoubleVect::operator[] (i - lower);
	}
};
int main() {
	DoubleVect a(4);
	

	for (int i = a.lowerBound(); i < a.upperBound(); i++)
	{
		cout << "> ";
		cin >> a[i];
	}

	for (int i = a.lowerBound(); i < a.upperBound(); i++)
	{
		cout << a[i] << " " << endl;
	}

	DoubleVector b(16, 25);

	for (int i = b.lowerBound(); i < b.upperBound(); i++)
	{
		cout << "> ";
		cin >> b[i];
	}

	for (int i = b.lowerBound(); i < b.upperBound(); i++)
	{
		cout << b[i] << " " << endl;
	}

	system("pause");
	return 0;
}
