#include <iostream>
#include <cstring>
using namespace std;
const int MAX_ARRAY=20;
const int MAX_NAME_SIZE=20;
class Student{
    char firstName[MAX_NAME_SIZE];
    char lastName[MAX_NAME_SIZE];
public:
    Student(char* _firstName="",char* _lastName=""){
        strcpy(firstName,_firstName);
        strcpy(lastName,_lastName);
    }
    void printStudentsInfo(){
        cout<<"Student's name: "<<firstName<<" "<<lastName<<endl;
    }
};

class Group{
    char groupName[MAX_NAME_SIZE];
    Student students[MAX_ARRAY];
    int studentsLength=0;
public:
    Group(char* _groupName=""){
        strcpy(groupName,_groupName);
    }

    void printGroupsInfo(){
        cout<<groupName<<endl;
        cout<<studentsLength<<endl;
        for(int i=0;i<studentsLength;i++)
        {
            students[i].printStudentsInfo();
        }
    }
public:
    void addStudent(Student& student){
        students[studentsLength]=student;
        studentsLength++;
    }

};

class Teacher {
    char teacherFirstName[MAX_NAME_SIZE];
    char teacherLastName[MAX_NAME_SIZE];
    Group groups[MAX_ARRAY];
    int groupsLength=0;
public:
    Teacher(char* _teacherFirstName="",char* _teacherLastName=""){
        strcpy(teacherFirstName,_teacherFirstName);
        strcpy(teacherLastName,_teacherLastName);
    }
    void addGroup(Group& group){
        groups[groupsLength]=group;
        groupsLength++;
    }
    void printTeachersInfo(){
        cout<<"Teacher's name: "<<teacherFirstName<<" "<<teacherLastName<<endl;
        for(int i=0;i<groupsLength;i++)
        {
            groups[i].printGroupsInfo();
        }
    }
};

class School{
    char schoolName[MAX_NAME_SIZE];
    Teacher listOfTeachers[MAX_ARRAY];
    int teachersLength;
    Group listOfGroups[MAX_ARRAY];
    int groupsLength;
    Student listOfStudents[MAX_ARRAY];
    int studentsLength;
public:
    School(char* _schoolName){
        strcpy(schoolName,_schoolName);
        teachersLength=0;
        groupsLength=0;
        studentsLength=0;
    }
    void getSchoolName(){
        cout<<schoolName<<endl;
    }

    void addStudent(Student& student,Group& group){
        listOfStudents[studentsLength]=student;
        studentsLength++;
        group.addStudent(student);
    }
    void addTeacher(Teacher& teacher){
        listOfTeachers[teachersLength]=teacher;
        teachersLength++;
    }
     void addGroup(Group& group,Teacher& teacher){
        listOfGroups[groupsLength]=group;
        groupsLength++;
        teacher.addGroup(group);
    }
};

int main()
{
    School school("Machilishte");
    school.getSchoolName();
    Student s1("Emil Todorov");
    Student s2("s 2");
    Student s3("s 3");
    Student s4("s 4");
    Student s5("s 5");
    Student s6("s 6");
    Student s7("s 7");
    Student s8("s 8");
    Student s9("s 9");
    Student s10("s 10");
    Student s11("s 11");
    Student s12("s 12");
    Teacher teacher1("Emil Todorov");
    school.addTeacher(teacher1);
    Group english("English");
    school.addGroup(english,teacher1);
    school.addStudent(s1,english);
    school.addStudent(s2,english);
    school.addStudent(s3,english);
    school.addStudent(s4,english);

    teacher1.printTeachersInfo();
    return 0;
}
