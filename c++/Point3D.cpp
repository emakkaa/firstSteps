#include <iostream>
#include <cmath>
using namespace std;
class Point3D {
    private:
        double x;
        double y;
        double z;
    public:
        void setX(double otherX){
            x=otherX;
        }
        double getX()
        {
            return x;
        }
        void setY(double otherY){
            y=otherY;
        }
        double getY()
        {
            return y;
        }
        void setZ(double otherZ){
            z=otherZ;
        }
        double getZ()
        {
            return z;
        }
        void translate(double a,double b,double c)
        {
            setX(getX()+a);
            setY(getY()+b);
            setZ(getZ()+c);
            cout<<"New X:"<<getX()<<endl;
            cout<<"New Y:"<<getY()<<endl;
            cout<<"New Z:"<<getZ()<<endl;
        }
        double distanceAB (Point3D C,Point3D D)
        {
            return sqrt(abs(pow(C.getX()-D.getX(),2)+pow(C.getY()-D.getY(),2)+pow(C.getZ()-D.getZ(),2)));
        }
        double P (Point3D A,Point3D B,Point3D C)
        {
            if(A.distanceAB(A,B)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            if(A.distanceAB(C,A)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            if(A.distanceAB(B,C)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            return A.distanceAB(B,C)+B.distanceAB(B,C)+A.distanceAB(C,A); // Perimetur
        }

        double S (Point3D A,Point3D B,Point3D C)
        {
            if(A.distanceAB(A,B)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            if(A.distanceAB(C,A)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            if(A.distanceAB(B,C)==0)
            {
                cout<<"Nqma takuv triugulnik";
            }
            return sqrt(P(A,B,C)/2+(P(A,B,C)/2-A.distanceAB(A,C))+(P(A,B,C)/2-B.distanceAB(B,C))+(P(A,B,C)/2-A.distanceAB(A,B))); //Liceto po Heoronova formula
        }
        void translateByVector(Point3D A,Point3D B)
        {
            A.x+=B.x;
            A.y+=B.y;
            A.z+=B.z;
            cout<<"Nov X prenesen po vektor:"<<A.getX()<<endl;
            cout<<"Nov Y prenesen po vektor:"<<A.getY()<<endl;
            cout<<"Nov Z prenesen po vektor:"<<A.getZ()<<endl;
        }
};

int main()
{
    //ZADACHA 1
    Point3D H;
    H.setX(5);
    H.setY(5);
    H.setZ(5);
    Point3D F=H;
    cout<<"Transponiranata tochka e s koordinati: "<<endl;
    H.translate(1,2,3);
    cout<<endl;
    cout<<"Razstoqnieto mejdu dvete tochki e:"<<H.distanceAB(F,H)<<endl;
    cout<<endl;
    //ZADACHA 2
    Point3D A,B,C;
    A.setX(0);
    A.setY(0);
    A.setZ(0);
    B.setX(0);
    B.setY(0);
    B.setZ(0);
    C.setX(3);
    C.setY(5);
    C.setZ(8);
    cout<<"Perimetura na triugulnika e: "<<A.P(A,B,C)<<endl;
    cout<<endl;
    cout<<"Liceto na triugulnika e: "<<A.S(A,B,C)<<endl;
    cout<<endl;
    Point3D D;
    D.setX(1);
    D.setY(1);
    D.setZ(1);
    D.translateByVector(A,D);
    cout<<endl;
    D.translateByVector(B,D);
    cout<<endl;
    D.translateByVector(C,D);
    return 0;
}

