// Homework3Seminar.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstring>
#include <algorithm>
using namespace std;



class Human {
protected:
	char* firstName;
	char* lastName;
public:
	char* getFirstName() const { return firstName; }
	char* getLastName() const { return lastName; }
	virtual void print() {
		cout << "Name: " << firstName << " " << lastName << endl;
	}

	Human(char* _firstName = " ", char* _lastName = " ") {
		firstName = new char[strlen(_firstName) + 1];
		strcpy(firstName, _firstName);
		lastName = new char[strlen(_lastName) + 1];
		strcpy(lastName, _lastName);
	}

	Human(const Human& other) {
		firstName = new char[strlen(other.getFirstName()) + 1];
		strcpy(firstName, other.getFirstName());
		lastName = new char[strlen(other.getLastName()) + 1];
		strcpy(lastName, other.getLastName());
	}

	Human operator=(const Human& other) {
		if (this != &other) {
			delete[] firstName;
			firstName = new char[strlen(other.getFirstName()) + 1];
			strcpy(firstName, other.getFirstName());
			delete[] lastName;
			lastName = new char[strlen(other.getLastName()) + 1];
			strcpy(lastName, other.getLastName());
		}

		return *this;
	}



};


class Student : public Human {
protected:
	double grade;
public:
	Student() : Human(), grade(0) {}

	Student(double _grade, char* _firstName, char* _lastName) : Human(_firstName, _lastName) {
		grade = _grade;
	}

	Student(const Student& other) {
		firstName = new char[strlen(other.getFirstName()) + 1];
		strcpy(firstName, other.getFirstName());
		lastName = new char[strlen(other.getLastName()) + 1];
		strcpy(lastName, other.getLastName());
		grade = other.grade;
	}


	bool operator<(Student const & b)
	{
		return this->getGrade() < b.getGrade();
	}

	Student operator=(const Student& other) {
		if (this != &other) {
			delete[] firstName;
			firstName = new char[strlen(other.getFirstName()) + 1];
			strcpy(firstName, other.getFirstName());
			delete[] lastName;
			lastName = new char[strlen(other.getLastName()) + 1];
			strcpy(lastName, other.getLastName());
			grade = other.grade;
		}

		return *this;
	}


	double getGrade() const {
		return this->grade;
	}

	void print() {
		cout << "Name: " << firstName << " " << lastName << endl;
		cout << "Grade: " << grade << endl;

	}
};

class Worker : public Human {
protected:
	double weekSalary;
	double workHoursPerDay;
public:
	Worker(char* _firstName, char* _lastName, double _weekSalary, double _workHoursPerDay) : Human(_firstName, _lastName) {
		weekSalary = _weekSalary;
		workHoursPerDay = _workHoursPerDay;
	}
	double getWeekSalary() const { return weekSalary; }
	double getWorkHoursPerDay() const { return workHoursPerDay; }

	Worker(const Worker& other) {
		firstName = new char[strlen(other.getFirstName()) + 1];
		strcpy(firstName, other.getFirstName());
		lastName = new char[strlen(other.getLastName()) + 1];
		strcpy(lastName, other.getLastName());
		weekSalary = other.getWeekSalary();
		workHoursPerDay = other.getWorkHoursPerDay();
	}
	Worker operator=(const Worker& other) {
		if (this != &other) {
			delete[] firstName;
			firstName = new char[strlen(other.getFirstName()) + 1];
			strcpy(firstName, other.getFirstName());
			delete[] lastName;
			lastName = new char[strlen(other.getLastName()) + 1];
			strcpy(lastName, other.getLastName());
			weekSalary = other.getWeekSalary();
			workHoursPerDay = other.getWorkHoursPerDay();
		}
		return *this;
	}
	double MoneyPerHour() {
		return weekSalary / (7 * workHoursPerDay);
	}
	void print() {
		cout << "Name: " << firstName << " " << lastName << endl;
		cout << "Week salary: " << weekSalary << endl;
		cout << "Worked hours per day: " << workHoursPerDay << endl;
		cout << "Money per hour earned: " << MoneyPerHour() << endl;
	}
};




int main()
{
	Student students[10] = { Student(11 , "BEmil" , "Todorovv"),
							Student(2 , "EDmil" , "Todorovv"),
							Student(73 , "HEmil" , "Todorovv"),
							Student(44 , "JEmil" , "Todorovv"),
							Student(5 , "IEmil" , "Todorovv"),
							Student(62 , "OEmil" , "Todorovv"),
							Student(71 , "FEmil" , "Todorovv"),
							Student(80 , "AEmil" , "Todorovv"),
							Student(9 , "HEmil" , "Todorovv"),
							Student(115 , "HHEmil" , "Todorovv")
	};
	sort(begin(students), end(students)); // probvah go ot liubopitstvo


	for (int i = 0; i < 10; i++)
	{
		students[i].print();
		cout << endl;
	}

	Worker workers[10] = { Worker("QEmil" , "Todorovv",200,4),
						Worker("REmil" , "Todorovv",200,5),
						Worker("CEmil" , "Todorovv",300,6),
						Worker("BEmil" , "Todorovv",400,7),
						Worker("REmil" , "Todorovv",500,8),
						Worker("FEmil" , "Todorovv",600,9),
						Worker("NEmil" , "Todorovv",700,8),
						Worker("GEmil" , "Todorovv",800,8),
						Worker("HEmil" , "Todorovv",900,8),
						Worker("AEmil" , "Todorovv",1000,8)
	};
	int minimalPosition; //normalna sortirovka
	for (int i = 0; i < 10; i++)
	{
		minimalPosition = i;
		for (int j = i + 1; j < 10; j++)
		{
			if (workers[j].MoneyPerHour() > workers[minimalPosition].MoneyPerHour())
			{
				minimalPosition = j;
			}
		}
		if (minimalPosition != i)
		{
			Worker flag = workers[i];
			workers[i] = workers[minimalPosition];
			workers[minimalPosition] = flag;
		}
	}
	for (int i = 0; i < 10; i++)
	{
		workers[i].print();
		cout << endl;
	}


	cout << "------------------------------------------------------------" << endl;
	cout << endl;
	Human** doubleArray = new Human*[20];
	for (int i = 0; i < 10; i++)
	{
		doubleArray[i] = new Worker(workers[i]);
	}
	for (int i = 10; i < 20; i++)
	{
		doubleArray[i] = new Student(students[i - 10]);
	}
	// normalna sortirovka
	short k;
	Human* max;

	for (int i = 0; i < 19; i++) {
		max = doubleArray[i];
		k = i;
		for (int j = i + 1; j < 20; j++)
			if (strcmp(doubleArray[j]->getFirstName(), max->getFirstName()) == 0) {
				if (strcmp(doubleArray[j]->getLastName(), max->getLastName()) < 0) {
					max = doubleArray[j];
					k = j;
				}
			}
			else {
				if (strcmp(doubleArray[j]->getFirstName(), max->getFirstName()) < 0) {
					max = doubleArray[j];
					k = j;
				}
			}
			Human* swap;
			swap = doubleArray[k];
			doubleArray[k] = doubleArray[i];
			doubleArray[i] = swap;
	}
	for (int i = 0; i < 20; i++)
	{
		doubleArray[i]->print();
		cout << endl;
	}
	return 0;
}










