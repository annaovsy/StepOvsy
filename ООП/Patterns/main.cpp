#include<iostream>
#include"AircraftBuilder.h"
#include"AircraftConstructor.h"
#include"HangGliderBuilder.h"
#include"GliderBuilder.h"
using namespace std;

int main() 
{
	try 
	{
		AircraftBuilder* builder;
		//������� ������ ������ ���������
		AircraftConstructor* shop =	new AircraftConstructor();
		//������� ������ ������ ���������.
		//���� ������ ����� ��������� �����������
		builder = new HangGliderBuilder();
		//��������� ����������
		shop->Construct(builder);
		//���������� ���������� � �����������
		builder->GetAircraft()->Show();
		//������� ������ ������ ���������.
		//���� ������ ����� ��������� �������
		delete builder;
		builder = new GliderBuilder();
		//��������� ������
		shop->Construct(builder);
		//���������� ���������� � �������
		builder->GetAircraft()->Show();
		delete builder;
		delete shop;
	}
		catch (char* str) 
		{
			cout << endl << str << endl;
		}  
	return 0;
}