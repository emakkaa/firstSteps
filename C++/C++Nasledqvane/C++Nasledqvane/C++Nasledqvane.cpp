// C++Nasledqvane.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstring>
using namespace std;

class Person {
	char firstName[32];
	char lastName[32];
	int age;
public:
	Person(char* _firstName, char* _lastName, int _age) {
		strcpy_s(firstName, _firstName);
		strcpy_s(lastName, _lastName);
		age = _age;
	}
	void print() {
		cout << firstName << " " << lastName << " " << age << endl;
	}
};
class Student :public Person {
	char mark;
	char specialty[32];
public:
	Student(char* _firstName, char* _lastName, int _age, char _mark, char* _specialty) :
		Person(_firstName, _lastName, _age)
	{
		mark = _mark;
		strcpy_s(specialty, _specialty);

	}
	void printStudentData() {
		print();
		cout << "Mark:" << mark << " Specialty:" << specialty << endl;
	}
};

class Worker :public Person {
	int moneyPerHour;
	int hoursWorked;
public:
	Worker(char* _firstName, char* _lastName, int _age, int _moneyPerHour, int _hoursWorked) :
		Person(_firstName, _lastName, _age) {
		moneyPerHour = _moneyPerHour;
		hoursWorked = _hoursWorked;
	}
	void printWorkerData() {
		print();
		cout << "Money per hour:" << moneyPerHour << " Hours Worked:" << hoursWorked << endl;

	}
	int calculateSalary(Worker worker) {
		int salary;
		salary = worker.hoursWorked*worker.moneyPerHour;
		return salary;
	}


};

int main()
{
	Person _1("Emil", "Todorov", 20);
	_1.print();
	Student _2("Emil", "Todorov", 20, 'A', "Math");
	_2.printStudentData();
	Worker _3("Emil", "Todorov", 20, 50, 50);
	_3.printWorkerData();
	cout << _3.calculateSalary(_3) << endl;
	return 0;
}


