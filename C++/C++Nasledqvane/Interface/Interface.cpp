// Interface.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>
#include <iomanip>

using namespace std;

class Shape {
public:
	virtual double perimeter() const = 0;
	virtual double area() const = 0;
	virtual void print() const = 0;
	
};
class Rectangle : public Shape {
protected:
	double a;
	double b;
public:
	Rectangle(double _a, double _b) : a(_a), b(_b) {};
	double perimeter() const {
		return 2 * (a + b);
	}
	double area() const {
		return a*b;
	}
	void print() const {
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

class Circle : public Shape {
protected:
	double r;
public:
	Circle(double _r) : r(_r) {};
	double perimeter() const {
		return 2 * 3.14159 * r ;
	}
	double area() const {
		return 3.14 * pow(r, 2);
	}void print() const {
		cout << "Circle("<< r << ")" << endl;
		cout << "area: " << area() << endl;
		cout << "perimeter: "<< setprecision(5) << perimeter() << endl;
	}
};


int main()
{
	cout << "Press r for rectangle , s for square,c for circle):";
	char option;
	cin >> option;
	Shape* ptr = nullptr;
	if (option == 'r') {
		double a, b;
		cin >> a >> b;
		ptr = new Rectangle(a, b); 
	}
	else if (option == 's') {
		double a;
		cin >> a;
		ptr = new Square(a);
	}
	else if (option == 'c') {
		double r;
		cin >> r;
		ptr = new Circle(r);
	}
	ptr->print();


    return 0;
}

