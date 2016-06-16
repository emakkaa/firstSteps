// Kontrolno2-Garage.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstring>

using namespace std;

enum vehicleType {AIR , LAND};
enum carType {STANDARD,LUXURY,SPORTSCAR};
enum motorcycleType {SPORTSBIKE,SCOOTER,};

class Engine {
protected:
	char* engineType;
	int enginePower;
	int engineVolume;
public:
	int getEnginePower() const{
		return enginePower;
	}
	void setEnginePower(int _enginePower) {
		enginePower = _enginePower;
	}
	char* getEngineType() const {
		return engineType;
	}
	int getEngineVolume() const{
		return engineVolume;
	}


	Engine(char* _engineType=" ",int _enginePower=0,int _engineVolume=0) {
		engineType = new char[strlen(_engineType) + 1];
		strcpy(engineType,_engineType);
		enginePower = _enginePower;
		engineVolume = _engineVolume;
	}
	Engine(const Engine& other) {
		engineType = new char[strlen(other.getEngineType()) + 1];
		strcpy(engineType, other.getEngineType());
		enginePower = other.getEnginePower();
		engineVolume = other.getEngineVolume();
	}
	Engine operator=(const Engine& other) {
		if (this != &other) {
			delete[] engineType;
			engineType = new char[strlen(other.getEngineType()) + 1];
			strcpy(engineType, other.getEngineType());
			enginePower = other.getEnginePower();
			engineVolume = other.getEngineVolume();
		}

		return *this;
	}


};

class Vehicle {
protected:
	Engine engine;
	vehicleType type;
	char* brand;
	double price;
public:
	char* getBrand() const{
		return brand;
	}
	double getPrice() const{
		return price;
	}
	vehicleType getType() const {
		return type;
	}

	Vehicle(vehicleType _type = LAND, char* _brand = " ", double _price = 0) {
		type = _type;
		brand = new char[strlen(_brand) + 1];
		strcpy(brand, _brand);
		price = _price;
	}
	Vehicle(const Vehicle& other) {
		engine = other.engine;
		brand = new char[strlen(other.getBrand()) + 1];
		strcpy(brand,other.getBrand());
		type = other.getType();
		price = other.getPrice();
	}

	Vehicle operator=(const Vehicle& other) {
		if (this != &other) {
			delete[] brand;
			brand = new char[strlen(other.getBrand()) + 1];
			strcpy(brand, other.getBrand());
			engine = other.engine;
			type = other.getType();
			price = other.getPrice();
		}
	}

	void modify(int upgradeEnginePower, double priceUp) {
		this->engine.setEnginePower(engine.getEnginePower()+upgradeEnginePower);
		this->price = priceUp*getPrice();
	}
	void printInfo() {
		cout << "Brand: " << getBrand();
		cout << "\nPrice: " << getPrice() << endl;
	}
};

class Motorycycle : public Vehicle {
protected:
	motorcycleType motorType;
	int maxSpeed;
	int yearOfCreation;
	bool forRoad;
public:
	
	int getYearOfCreation() {
		return yearOfCreation;
	}
	bool getForRoad() {
		return forRoad;
	}
	Motorycycle(Engine engine, vehicleType _type, char* _brand, double _price,
		motorcycleType _motorType, int _maxSpeed, int _yearOfCreation, bool _forRoad)
		: Vehicle(_type, _brand, _price) {
		motorType = _motorType;
		maxSpeed = _maxSpeed;
		yearOfCreation = _yearOfCreation;
		forRoad = _forRoad;
	}

	bool isForRoad(Motorycycle motor) {
		return motor.getForRoad();
	}
};

class Car : public Vehicle {
	carType cType;
	int maxSpeed;
	int yearOfCreation;
	int capacity;
public:
	int getYearOfCreation() {
		return yearOfCreation;
	}

	Car(Engine engine, vehicleType _type, char* _brand, double _price,
		carType _cType, int _maxSpeed, int _yearOfCreation, int _capacity)
		: Vehicle(_type, _brand, _price) {
		cType = _cType;
		maxSpeed = _maxSpeed;
		yearOfCreation = _yearOfCreation;
		capacity = _capacity;
	}
};


class Garage {
protected:
	Car* carArray;
	Motorycycle *motoArray;
	int sizeOfCars;
	int sizeOfMotos;
public:
	Garage(Car* _carArray = nullptr, Motorycycle* _motoArray = nullptr, int _sizeOfCars = 0, int _sizeOfMotos = 0) : 
		motoArray(_motoArray), carArray(_carArray), sizeOfCars(_sizeOfCars), sizeOfMotos(_sizeOfMotos) {}
	Garage(Garage &other) : motoArray(other.motoArray), carArray(other.carArray), sizeOfCars(other.sizeOfCars),sizeOfMotos(other.sizeOfMotos) {}
	Garage& operator =(Garage &other) {
		Garage *temp = new Garage(other);
		*this = *temp;
		return *this;
	}
	~Garage() {
		delete[] carArray;
		delete[] motoArray;
	}

	void getVehiclesAfter(int yearAfter) {
		for  (int i = 0; i < sizeOfMotos;  i++)
		{
			
			if (motoArray[i].getYearOfCreation() > yearAfter) {
				motoArray[i].printInfo();
			}
		}
		for  (int i= 0; i < sizeOfCars;i++)
		{
			if (carArray[i].getYearOfCreation() > yearAfter) {
				carArray[i].printInfo();
			}
		}
	}

	void getVehiclesModel(char* searchingModel) {
		for (int i = 0; i < sizeOfMotos; i++)
		{
			
			if (!strcmp(motoArray[i].getBrand, searchingModel)) {
				motoArray[i].printInfo();
			}
		}
		for (int i = 0; i < sizeOfCars; i++)
		{
			if (!strcmp(carArray[i].getBrand, searchingModel)) {
				carArray[i].printInfo();
			}
		}
	}

	int getTotalPrice() {
		int totalSum;
		for (int i = 0; i < sizeOfMotos; i++)
		{
			totalSum += motoArray[i].getPrice();
		}
		for (int i = 0; i < sizeOfCars; i++)
		{
			totalSum += carArray[i].getPrice();
		}
		return totalSum;
	}

	void o(int threshold, int horsepower) {
		for (int i = 0; i < sizeOfMotos; i++)
		{
			if (motoArray[i].engine.getEnginePower() < threshold) {
				motoArray[i].modify(horsepower, 12 / 100);
				//cant reach engine and no time to do it
			}
		}
		for (int i = 0; i < sizeOfCars; i++)
		{
			if (carArray[i].engine.getEnginePower() < threshold) {
				carArray[i].modify(horsepower, 12 / 100);
				// cant reach engine and no time to do it
			}
		}
	}
};



int main()
{
    return 0;
}









/*public:
	School(Student *_students = nullptr, int _studentSize = 0, Teacher *_teachers = nullptr, int _teachersize = 0) :
		students(_students), teachers(_teachers), sizeStudents(_studentSize), sizeTeachers(_teachersize) {}
	School(School &other) :students(other.students), sizeStudents(other.sizeStudents),
		teachers(other.teachers), sizeTeachers(other.sizeTeachers) {}
	School& operator =(School &other)
	{
		School *temp = new School(other);
		*this = *temp;
		return *this;
	}

	~School()
	{
		delete[] students;
		delete[] teachers;
	}

	*/