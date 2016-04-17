#include <iostream>
#include <cstring>
using namespace std;

class Student{
private:
    int facultyNumber;
    char studentName[32];
    double grades[5];
public:
    Student()
    {
        facultyNumber=0;
        strcpy(studentName,"");
        for(int i=0;i<5;i++)
        {
            grades[i]=0;
        }


    }
    Student(int _facultyNumber,char* _studentName,double* _grades){
        facultyNumber=_facultyNumber;
        strcpy(studentName,_studentName);
        for(int i=0;i<5;i++)
        {
            grades[i]=_grades[i];
        }
    }

    int getFacultyNumber(){
        return facultyNumber;
    }
    char* getStudentName(){
        return studentName;
    }
    double* getGrades(){
        return grades;
    }
    void inputData(Student* a,int size){
        for(int i=0;i<size;i++){
            cout<<"Vuvedi FN na studenta: ";
            cin>>a[i].facultyNumber;
            cout<<"Vuvedi ime na studenta: ";
            cin>>a[i].studentName;
            cout<<"Vuvedi ocenki na studenta:";
            cout<<endl;
            for(int j=0;j<5;j++)
            {
                cout<<"Ocenka po "<<j+1<<" predmet: ";
                do{
                    cin>>a[i].grades[j];
                }while(a[i].grades[j]>6 || a[i].grades[j]<2);
            }
            cout<<endl;
        }
    }

    void outputData(Student* arr,int size){
        cout<<"Danni za studentite v sistemata:"<<endl;
        cout<<endl;
        for(int i=0;i<size;i++)
        {
            cout<<"FN na studenta: "<<arr[i].facultyNumber<<endl;
            cout<<"Ime na studenta: "<<arr[i].studentName<<endl;
            for(int j=0;j<5;j++){
                cout<<"Ocenka po "<<j+1<<" predmet: ";
                cout<<arr[i].grades[j]<<endl;
            }
            cout<<"Sreden uspeh na studenta: "<<arr[i].approxGrade()<<endl;
            cout<<endl;
        }
    }
    double approxGrade(){
        double approx=0;
        for(int i=0;i<5;i++){
            approx+=grades[i];
        }
        return approx/5;
    }
};


int main(){
    int n=5;
    Student s[n];
    s[0].inputData(s,n);
    s[0].outputData(s,n);

    return 0;
}
