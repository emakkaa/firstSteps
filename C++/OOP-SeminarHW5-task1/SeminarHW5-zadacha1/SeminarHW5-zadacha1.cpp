// SeminarHW5-zadacha1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include <iostream>
#include <cstring>
#include <cmath>

using namespace std;

const double PI = 3.14159265;

class Figure
{
public:
	virtual double area() const = 0;
	virtual double perimeter() const = 0;
};

class Circle : public Figure
{
private:
	double radius;

public:
	Circle(double r) : radius(r) {}

	double area() const {
		return PI*radius*radius;
	}

	double perimeter() const {
		return 2 * PI*radius;
	}
};

class Point
{
public:
	Point() : x(0), y(0) {}

	Point(double _x, double _y) : x(_x), y(_y) {}

	double distanceTo(const Point& point) const {
		return sqrt((x - point.x)*(x - point.x) + (y - point.y)*(y - point.y));
	}

	double x, y;
};

class ListOfPoints
{
protected:
	int size;
	Point *points;
	void copy(const ListOfPoints&);

public:
	ListOfPoints(int);
	ListOfPoints(const ListOfPoints&);
	ListOfPoints& operator=(const ListOfPoints&);
	~ListOfPoints();
	Point& operator[](int);
};

ListOfPoints::ListOfPoints(int numPoints) : size(numPoints) {
	points = new Point[size];
}

ListOfPoints::ListOfPoints(const ListOfPoints& list) : points(NULL) {
	copy(list);
}

ListOfPoints& ListOfPoints::operator=(const ListOfPoints& list) {
	if (this != &list)
		copy(list);
	return *this;
}

ListOfPoints::~ListOfPoints() {
	delete points;
}

Point& ListOfPoints::operator[](int i) {
	if (i < 0 || i >= size) exit(1);
	return points[i];
}

void ListOfPoints::copy(const ListOfPoints& list) {
	if (points != NULL)
		delete points;
	points = new Point[list.size];
	for (int i = 0; i < list.size; i++) {
		points[i].x = list.points[i].x;
		points[i].y = list.points[i].y;
	}
}

class Polygon : public Figure, public ListOfPoints
{
public:
	Polygon(int);
	double area() const;
	double perimeter() const;
};

Polygon::Polygon(int verteces) : ListOfPoints(verteces) {}

double Polygon::area() const {
	double a = 0;
	for (int i = 0; i < size - 1; i++) {
		a += (points[i].x - points[i + 1].x) * (points[i].y + points[i + 1].y);
	}
	if (size > 1) {
		a += (points[size - 1].x - points[0].x) * (points[size - 1].y + points[0].y);
	}
	return fabs(a / 2);
}

double Polygon::perimeter() const {
	double p = 0;
	for (int i = 0; i < size - 1; i++) {
		p += points[i].distanceTo(points[i + 1]);
	}
	if (size > 1) {
		p += points[size - 1].distanceTo(points[0]);
	}
	return p;
}

int main()
{
	Circle circle(3.14);
	Polygon square(4);
	square[0].x = 3;
	square[0].y = 3;
	square[1].x = -3;
	square[1].y = 3;
	square[2].x = -3;
	square[2].y = -3;
	square[3].x = 3;
	square[3].y = -3;


	cout << "Circle's perimeter: " << circle.perimeter() << endl;
	cout << "Circle's area: " << circle.area() << endl;
	cout << "Square's perimeter: " << square.perimeter() << endl;
	cout << "Square's area: " << square.area() << endl;

	system("pause");
	return 0;
}

