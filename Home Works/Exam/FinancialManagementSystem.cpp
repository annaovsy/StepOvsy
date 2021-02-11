#include "FinancialManagementSystem.h"
#include <iostream>
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
	int first, second, third;
	if (productCategory > entertainmentCategory && productCategory > travelCategory)
	{
		first = productCategory;
		if (entertainmentCategory > travelCategory)
		{
			second = entertainmentCategory;
			third = travelCategory;
		}
		else
		{
			second = travelCategory;
			third = entertainmentCategory;
		}			
	}
	else if(productCategory > entertainmentCategory && productCategory > travelCategory  )

	if (productCategory > entertainmentCategory)
		productCategory = first;
	FILE* file = fopen(filename, "w"); //��������� ����
	if (!file)
		return false;
	fprintf(file, "����� ������ �� ����������:"); 
	fprintf(file, "%s\t%d\t%.2lf\n", name.c_str(), age, averMark);

	fclose(file); //��������� ����

	return true;
}

void DebitCard::Show()
{
	cout << "����� ����� �� ����� : " << sumTotal << endl;
	cout << "�������� : " << productCategory << endl;
	cout << "����������� : " << entertainmentCategory << endl;
	cout << "����������� : " << travelCategory << endl;
}
