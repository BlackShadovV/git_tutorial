 // Написать программу, которая вычисляет, сколько раз введенное с клавиатуры
  // число встречается в массиве.

#include <iostream>
#include <iomanip>
#include <math.h>
#include <conio.h>
#include <windows.h>
using namespace std;
int ARRSIZE,i,ch=0;//ch-совпадения num-число дляпроверки

void stars();
void intro();
float num,arr[256];
int arrlen();
int checkn();
float check();
void output();
main(){
	intro();
	check();
	checkn();
	arrlen();
	output();
	return 1;
}

float check(){//контроль ввода

while(true)
{
	cout<< "Enter a number to search in array\t-\t";
    cin >> num;                          
    if (cin.peek() == '\n') 
	{  
		cin.get();                    
        break;
	}
	else
	{
		cout <<"Expected number\n"<<endl;
        cin.clear(); 
        while (cin.get() != '\n'){}   
    }
}

/*	while(true)
{
	cout<<"Enter a number to search in array\t-\t";
    cin >> num;
    if(!cin) 
    {
       cout << "Expected number\n";
       cin.clear();
       while (cin.get() != '\n');
    }
    else break;
 }*/
 return num;
}

int arrlen(){
bool fail = false;
for (unsigned int i = 0; i < ARRSIZE; i++) 
{
	
while(true)
{
	cout<< "Enter value for array element " << i << ": \n";
    cin >> arr[i];                          
    if (cin.peek() == '\n') 
	{  
		
		if(arr[i]==num){
			ch++;
		}
		cin.get();                    
        break;
	}
	else
	{
		cout <<"\n*** Entered uncorrect value. Repeat enter"<<endl;
        cin.clear(); 
        while (cin.get() != '\n'){}   
    }
}
	

}
	return ARRSIZE;
}

void output(){
	cout<<"Matches of number ( "<<num;cout<<" )\t=\t";cout<<ch;cout<<'\n';
	for (i=0;i<=ARRSIZE-1;i++){
		cout<<arr[i];cout<<"\t";
		
	}
	getch();
return;
	}
	
int checkn(){//контроль ввода целочисленного

while(true)
{
	cout<<"Enter length of array\t-\t";
    cin >> ARRSIZE;                          
    if ((cin.peek() == '\n') && (ARRSIZE>0))
	{        
		cin.get();                    
        break;
	}
	else
	{
		cout <<"Repeat enter (wait for integer):"<<endl;
        cin.clear();                  
        while (cin.get() != '\n'){}   
    }
}
return ARRSIZE;
}

void intro(){
	stars();
	cout<<"*\t\t\tProgramm was written by Badin V.V.\t\t      *\n";
	cout<<"*\t\t\t\t\tLab No 4\t\t\t      *\n";
	stars();
	getch();
	system("cls");
	return; 
}

void stars(){
char s='*';
	for (int i=0;i<80;i++){
		cout<<s;
	}
return;
	}
