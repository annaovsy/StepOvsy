#include "FinancialManagementSystem.h"
#include <iostream>
#include <fstream>
using namespace std;

//int ChoiceCards()
//{
//	Card* ptrCard;
//	DebitCard cardD;
//	CreditCard cardC;
//	cout << "\n\t����������, �������� �����\n\t1 - ��������� | 2 - ���������\n\t";
//	int choiceCard;
//	cin >> choiceCard;
//	while (true)
//	{
//		if (choiceCard == 1)
//			ptrCard = &cardD;
//		
//		else if(choiceCard == 2)
//			ptrCard = &cardC;
//
//		ptrCard->Menu();
//		int choice;
//		cin >> choice;
//		if (choice == 1)
//		{
//			cout << "����� ����� �� ����� : " << ptrCard->sumTotal << endl;
//		}
//		else if (choice == 2)
//		{
//			ptrCard->SetRefill();
//		}
//		else if (choice == 3)
//		{
//			ptrCard->SetExpenses();
//		}
//		else if (choice == 4)
//		{
//			ptrCard->ExpenseReportFile("Top.txt");
//		}
//		else if (choice == 5)
//		{
//			cout << "**********************************************************" << endl;
//			cout << "\t���������� �� ����������� ��������!\n\t�� ��������!" << endl;
//			return false;
//		}
//	}
//}

void Menu()
{
	cout << "\n*****************************************" << endl;
	cout << "*\t�������� ��������:\t\t*" << endl;
	cout << "*  ����� ����� �� �����		   - 1\t*" << endl;
	cout << "*  ���������� �������		   - 2\t*" << endl;
	cout << "*  �������� ������		   - 3\t*" << endl;
	cout << "*  �������� ��������/������ � ���� - 4\t*" << endl;
	cout << "*  �����			   - 5\t*" << endl;
	cout << "*****************************************" << endl << endl;
}

int Debit()
{
	DebitCard card;
	Menu();
	while (true)
	{	
		int choice;
		cin >> choice;
		if (choice == 1)
		{
			cout << "����� ����� �� ����� : " << card.sumTotal << endl;
		}
		else if (choice == 2)
		{
			card.SetRefill();
		}
		else if (choice == 3)
		{
			card.SetExpenses();
		}
		else if (choice == 4)
		{
			card.ExpenseReportFile("Top.txt");
		}
		else if (choice == 5)
		{
			cout << "**********************************************************" << endl;
			cout << "\t���������� �� ����������� ��������!\n\t�� ��������!" << endl;
			return false;
		}
		cout << " ------------------------------" << endl;
		cout << " * �������� ������ �������� : *" << endl;
	}
}

int Credit()
{
	CreditCard card;
	Menu();
	while (true)
	{
		int choice;
		cin >> choice;
		if (choice == 1)
		{
			cout << "����� ����� �� ����� : " << card.sumTotal << endl;
		}
		else if (choice == 2)
		{
			card.SetRefill();
		}
		else if (choice == 3)
		{
			card.SetExpenses();
		}
		else if (choice == 4)
		{
			card.ExpenseReportFile("Top.txt");
		}
		else if (choice == 5)
		{
			cout << "**********************************************************" << endl;
			cout << "\t���������� �� ����������� ��������!\n\t�� ��������!" << endl;
			return false;
		}
		cout << " ------------------------------" << endl;
		cout << " * �������� ������ �������� : *" << endl;
	}
}

void ChoiceCard()
{
	cout << "\n\t����������, �������� �����\n\t1 - ��������� | 2 - ���������\n\t";
	int choiceCard;
	cin >> choiceCard;
	switch (choiceCard)
	{
	case 1:
		Debit();
		break;
	case 2:
		Credit();
		break;
	}
}

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

//void DebitCard::Menu()
//{
//	cout << "\n*****************************************" << endl;
//	cout << "*\t�������� ��������:\t\t*" << endl;
//	cout << "*  ����� ����� �� �����		   - 1\t*" << endl;
//	cout << "*  ���������� �������		   - 2\t*" << endl;
//	cout << "*  �������� ������		   - 3\t*" << endl;
//	cout << "*  �������� ��������/������ � ���� - 4\t*" << endl;
//	cout << "*  �����			   - 5\t*" << endl;
//	cout << "*****************************************" << endl << endl;
//}

CreditCard::CreditCard(int _sumTotal, int _interestRate) :
	DebitCard(_sumTotal), 
	interestRate(_interestRate)
{}

//void CreditCard::Menu()
//{
//	cout << "\n\t��� ��������� ����� ���������� " << sumTotal << endl;
//	cout << "\n*****************************************" << endl;
//	cout << "*\t�������� ��������:\t\t*" << endl;
//	cout << "*  ����� ����� �� �����		   - 1\t*" << endl;
//	cout << "*  ���������� �������		   - 2\t*" << endl;
//	cout << "*  �������� ������		   - 3\t*" << endl;
//	cout << "*  �������� ��������/������ � ���� - 4\t*" << endl;
//	cout << "*  �����			   - 5\t*" << endl;
//	cout << "*****************************************" << endl << endl;
//}
