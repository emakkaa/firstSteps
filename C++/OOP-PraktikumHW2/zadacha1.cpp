#include <iostream>
#include <cstring>
using namespace std;

class Card{
private:
    char bookHeading[32];
    char authorName[32];
    int bookBalance;
public:
    Card(char* _bookHeading,char* _authorName,int _bookBalance){
        strcpy(bookHeading,_bookHeading);
        strcpy(authorName,_authorName);
        bookBalance=_bookBalance;
    }
    char* getBookHeading(){
        return bookHeading;
    }
    void setBookHeading(char* _bookHeading){
        strcpy(bookHeading,_bookHeading);
    }
    char* getAuthorName(){
        return authorName;
    }
    void setAuthorName(char* _authorName){
        strcpy(authorName,_authorName);
    }
    int getBookBalance(){
        return bookBalance;
    }
    void setBookBalance(int n){
        bookBalance=n;
    }
    void print(int size);
};

void Card :: print(int size){
    for(int i=0;i<size;i++)
    {
        cout<<"Imeto na knigata: "<<getBookHeading()<<endl;
        cout<<"Avtora na knigata e: "<<getAuthorName()<<endl;
        cout<<"Nalichni vmomenta: "<<getBookBalance()<<endl;
        cout<<endl;
    }
}
int main()
{
    Card a("afa","fadsf",4);
    Card s[5]= {{"Emaka","Apokalipsis",4},
                {"Emaka","Apokalipsis",4},
                {"Emaka","Apokalipsis",4},
                {"Emaka","Apokalipsis",4},
                {"Emaka","Apokalipsis",4}};
    a.print(5);
    return 0;
}
