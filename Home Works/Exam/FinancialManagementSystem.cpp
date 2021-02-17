#include "FinancialManagementSystem.h"
#include <iostream>
#include <fstream>
using namespace std;

DebitCard::DebitCard(int _sumTotal):
	sumTotal(_sumTotal),
	productCategory(0),
	entertainmentCategory(0),
	travelCategory(0)
{}

void DebitCard::SetRefill()
{
	int refill;
	cout << "������� �����: " << endl;
	cin >> refill;
	sumTotal += refill;
	cout << "�������� ��������� �������!" << endl;
	cout << "����� ����� �� ����� : " << sumTotal << endl;
}

void DebitCard::SetExpenses()
{
	int expenses, category;	
	cout << "������� �����: " << endl;
	cin >> expenses;
	if (expenses >= sumTotal)
	{
		cout << "\t�������� �� ����� ���� ���������!!!\n\t����� ������ ��������� ������� �� �����!\n";
	}
	else
	{
		int min = 1000;
		int max = 0;
		cout << "������� ���������: 1 - �������� | 2 - ����������� | 3 - �����������" << endl;
		cin >> category;
		switch (category)
		{
		case 1:
			productCategory += expenses;
			break;
		case 2:
			entertainmentCategory += expenses;
			break;
		case 3:
			travelCategory += expenses;
			break;
		default:
			break;
		}
		
		sumTotal -= expenses;
		cout << "�������� ��������� �������!" << endl;
		cout << "����� ����� �� ����� : " << sumTotal << endl;
	}	
}

bool DebitCard::ExpenseReportFile(const char* filename)
{
	string first, second, third;
	//int first, second, third;
	if (productCategory > entertainmentCategory && productCategory > travelCategory)
	{
		first = "��������";
		if (entertainmentCategory > travelCategory)
		{
			second = "�����������";
			third = "�����������";
		}
		else
		{
			second = "�����������";
			third = "�����������";
		}			
	}
	else if (entertainmentCategory > productCategory && entertainmentCategory > travelCategory)
	{
		first = "�����������";
		if (productCategory > travelCategory)
		{
			second = "��������";
			third = "�����������";
		}
		else
		{
			second = "�����������";
			third = "��������";
		}
	}
	else if (travelCategory > productCategory && travelCategory > entertainmentCategory)
	{
		first = "�����������";
		if (productCategory > entertainmentCategory)
		{
			second = "��������";
			third = "�����������";
		}
		else
		{
			second = "�����������";
			third = "��������";
		}
	}
	
	cout << "��� 3 ������ �� ���������:" << endl;
	cout << "1. " << first << endl;
	cout << "2. " << second << endl;
	cout << "3. " << third << endl;

	ofstream fileOut(filename, ios::out); //����� � ����
	if (!fileOut.is_open())
		return false;
	fileOut << "��� 3 ������ �� ���������:" << endl;
	fileOut << "1. " << first<< endl;
	fileOut << "2. " << second << endl;
	fileOut << "3. " << third << endl;
	fileOut.close();
	return true;
}

void Menu()
{
	cout << "\n*****************************************" << endl;
	cout << "*\t�������� ��������:\t\t*" << endl;
	cout << "*  ����� ����� �� �����		   - 1\t*" << endl;
	cout << "*  ���������� �������		   - 2\t*" << endl;
	cout << "*  �������� ������		   - 3\t*"<< endl;
	cout << "*  �������� ��������/������ � ���� - 4\t*" << endl;
	cout << "*  �����			   - 5\t*" << endl;
	cout << "*****************************************" << endl << endl;	
}

CreditCard::CreditCard(int _sumTotal, int _interestRate) :
	DebitCard(_sumTotal), 
	interestRate(_interestRate)
{}
