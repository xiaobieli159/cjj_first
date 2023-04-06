
#include<iostream>
#include<cstdlib>
#include"标头.h"

using namespace std;

int experiment::input(int A, int B, int X) {
	if ((A > 1) && (B == 0))
	{
		X = X / A;
	}
	if ((A == 2) || (X > 1))
	{
		X = X + 1;
	}
	return X;
}
int main()
{
	experiment expl;
	//cout << "路径1457(1,1,1):X=" << expl.input(1, 1, 1) << endl;
	//cout << "路径14567(1,1,2):X=" << expl.input(1, 1, 2) << endl;
	//cout << "路径12457(3,1,3):X=" << expl.input(3, 1, 3) << endl;
	//cout << "路径12467(2,1,4):X=" << expl.input(2, 1, 4) << endl;
	//cout << "路径123467(2,0,4):X=" << expl.input(2, 0, 4) << endl;
	cout << "路径1457(0,15,1):X=" << expl.input(0, 15, 1) << endl;
	return 0;
}