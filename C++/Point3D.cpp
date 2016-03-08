#include <iostream>
#include <cmath>

using namespace std;

class Point3D{
		double x;
		double y;
		double z;
	public:

	Point3D (double _x = 0 , double _y= 0 , double _z= 0){
		setX(_x);
		setY(_y);
		setZ(_z);
	}

		double getX(){
			return x;
		}
		double getY(){
			return y;
		}
		double getZ(){
			return z;
		}
		void setX(double newX){
			x = newX;
		}
		void setY(double newY){
			y = newY;
		}
		void setZ(double newZ){
			z = newZ;
		}

		void translate(Point3D translationVector) {
			setX(getX() + translationVector.getX());
			setY(getY() + translationVector.getY());
			setZ(getZ() + translationVector.getZ());
		}

		double distanceTo(Point3D other){
			return sqrt(pow(getX() - other.getX(), 2) +
						pow(getY() - other.getY(), 2) +
						pow(getZ() - other.getZ(), 2));
		}

};
class Triangle {
	Point3D aVertex;
	Point3D bVertex;
	Point3D cVertex;

public:
	Triangle(Point3D a, Point3D b, Point3D c) {
		aVertex = a;
		bVertex = b;
		cVertex = c;
	}

	double getASide(){
		return bVertex.distanceTo(cVertex);
	}
	double getBSide(){
		return aVertex.distanceTo(cVertex);
	}
	double getCSide(){
		return bVertex.distanceTo(aVertex);
	}

	double perimeter() {
		return getASide() + getBSide() + getCSide();
	}
	double area() {
		double semiperimeter = perimeter() / 2;

		return sqrt(semiperimeter
			*(semiperimeter - getASide())
			*(semiperimeter - getBSide())
			*(semiperimeter - getCSide()));
	}
	void translate(Point3D translationVector){
		aVertex.translate(translationVector);
		bVertex.translate(translationVector);
		cVertex.translate(translationVector);
	}
};


int main() {
	Triangle triangle(Point3D(1, 1, 1), Point3D(1, 1, 2), Point3D(1, 2, 1));
	cout << triangle.area() << endl;

	system("pause");
	return 0;
}
