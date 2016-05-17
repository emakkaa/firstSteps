#include "stdafx.h"
#include <iostream>
using namespace std;


class Student {
private:
	char firstName[32];
	char secondName[32];
	char lastName[32];
	int age;
	int schoolNumber;
public:
	char* getFirstName() { return firstName; }
	char* getSecondName() { return secondName; }
	char* getLastName() { return lastName; }
	int getAge() { return age; }
	int getSchoolNumber() { return schoolNumber; }


	Student() {
		strcpy_s(firstName, "Unnamed");
		strcpy_s(secondName, "Unnamed");
		strcpy_s(lastName, "Unnamed");
		age = -1;
		schoolNumber = -1;
	}
	Student(char* _firstName, char* _secondName, char* _lastName,int _age, int _schoolNumber) {
		strcpy_s(firstName, _firstName);
		strcpy_s(secondName, _secondName);
		strcpy_s(lastName, _lastName);
		age = _age;
		schoolNumber = _schoolNumber;
	}

	Student(Student const &other) {
		strcpy_s(this->firstName,other.firstName);
		strcpy_s(this->secondName, other.secondName);
		strcpy_s(this->lastName, other.lastName);
		this->schoolNumber = schoolNumber;
		this->age = age;
	}
	
	Student& operator=(Student const& other)
	{
		strcpy_s(firstName, other.firstName);
		strcpy_s(secondName, other.secondName);
		strcpy_s(lastName, other.lastName);
		age = other.age;
		schoolNumber = other.schoolNumber;
		return *this;
	}
	void printStudentsInfo() {
		cout << firstName << " " << secondName << " " << lastName << endl;
		cout << "Age: " << age << endl;
		cout << "ID: " << schoolNumber << endl;
		cout << "------------------------" << endl;

	}

};

class Teacher {
private:
	char firstName[32];
	char secondName[32];
	char lastName[32];
	char subject[32];

public:
	char* getFirstName() { return firstName;}
	char* getSecondName() { return secondName;}
	char* getLastName() { return lastName; }
	char* getSubject() { return subject;}
	Teacher() {
		strcpy_s(firstName, "Unnamed");
		strcpy_s(secondName, "Unnamed");
		strcpy_s(lastName, "Unnamed");
		strcpy_s(subject, "NoSubject");
	}

	Teacher(char* _firstName, char* _secondName, char* _lastName, char* _subject) {
		strcpy_s(firstName, _firstName);
		strcpy_s(secondName, _secondName);
		strcpy_s(lastName, _lastName);
		strcpy_s(subject, _subject);
	}

	Teacher(Teacher const &other) {
		strcpy_s(this->firstName, other.firstName);
		strcpy_s(this->secondName, other.secondName);
		strcpy_s(this->lastName, other.lastName);
		strcpy_s(this->subject, other.subject);
	}
	


	Teacher& operator=(Teacher const& other)
	{
		strcpy_s(firstName, other.firstName);
		strcpy_s(secondName, other.secondName);
		strcpy_s(lastName, other.lastName);
		strcpy_s(subject, other.subject);
		return *this;
	}
	void printTeacherInfo() {
		cout << firstName << " " << secondName << " " << lastName << endl;
		cout << "------------------------" << endl;

	}
	
};

class School
{
private:
	Student *students;
	Teacher *teachers;
	int sizeStudents;
	int sizeTeachers;
public:
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

		
public:
	void findStudentBySchoolNumber(int _schoolNumber) 
	{
		for (int i = 0; i<sizeStudents; i++)
		{
			if (students[i].getSchoolNumber() == _schoolNumber) {
				cout << students[i].getFirstName() << " " << students[i].getLastName() << endl;
			}
		}
	}

	void getStudentInfo(char* _firstName, char* _lastName)
	{
		for (int i = 0; i < sizeStudents; i++)
		{
			
			if (!(strcmp(_firstName, students[i].getFirstName())) &&
			    !(strcmp(_lastName, students[i].getLastName()))) 
			{
				students[i].printStudentsInfo();
			}
		}
	}

	void getTeacherBySubject(char *_subject) 
	{
		for (int i = 0; i < sizeTeachers; i++)
		{
			if (!strcmp(_subject, teachers[i].getSubject())) {
				teachers[i].printTeacherInfo();
			}
		}
	}
	
};
int main()
{

	Teacher *teachers = new Teacher[2];
	teachers[0] = Teacher("Emil", "Dimitrov","Todorov", "History");
	teachers[1] = Teacher("Emil", "Dimitrov", "Todorov", "Geometry");
	Student *students = new Student[5];
	students[0] = Student("Emil", "Dimitrov", "Todorov",20, 0);
	students[1] = Student("Emil", "Dimitrov", "Todorov", 20, 1);
	School school = School(students, 2,teachers,2);
	school.findStudentBySchoolNumber(1);
	school.getStudentInfo("Emil", "Todorov");
	school.getTeacherBySubject("Geometry");
	return 0;
}


