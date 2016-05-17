// Polymorphysm.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
class Rectangle {
protected:
	double a;
	double b;
public:
	Rectangle(double _a, double _b) : a(_a), b(_b) {};
	double perimeter() const{
		return 2 * (a + b);
	}
	double area() const {
		return a*b;
	}
	virtual void print() const {
		cout << "Rectangle(" << a << "," << b << ")" << endl;
		cout << "area: " << area() << endl;
		cout << "perimeter: " << perimeter() << endl;
	}
};

class Square : public Rectangle {
public:
	Square(double _a) : Rectangle(_a, _a) {};
	void print() const {
		cout << "Square(" << a << "," << a << ")" << endl;
		cout << "area: " << area() << endl;
		cout << "perimeter: " << perimeter() << endl;
	}

};

int main()
{
    return 0;
}

