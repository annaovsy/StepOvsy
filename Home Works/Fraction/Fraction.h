#pragma once
#include <iostream>
using namespace std;

class Fraction
{
private:
    int intPart;       
    int numerator;      
    int denominator;   
    
    void GetMixedView();     //�������������� � ��������� ���
    void Cancellation();     //���������� �����
    void GetIntPart();       //��������� ����� ����� �����
public:
    Fraction() 
    {
        intPart = 0;
        numerator = 0;
        denominator = 1;
    };
    Fraction(int _intPart, int _numerator = 0, int _denominator = 1);
    void Print();
    
    Fraction operator + (Fraction);
    Fraction operator - (Fraction);  
    Fraction operator * (Fraction);
    Fraction operator / (Fraction);
};
