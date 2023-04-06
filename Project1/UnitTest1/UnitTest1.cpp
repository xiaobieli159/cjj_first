#include "pch.h"
#include "CppUnitTest.h"
#include"../Project1/БъЭЗ.h"
#include"../Project1/pro.cpp"
using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		experiment expl;
		/*TEST_METHOD(TestMethod1)
		{	
			expl.input(1, 1, 1);
		}*/
		TEST_METHOD(TestMethod2)
		{	
			expl.input(0, 15, 1);
		}
		/*TEST_METHOD(TestMethod3)
		{	
			expl.input(1, 1, 2);
		}
		TEST_METHOD(TestMethod4)
		{	
			expl.input(3, 1, 3);
		}
		TEST_METHOD(TestMethod5)
		{
			expl.input(2, 1, 4);
		}
		TEST_METHOD(TestMethod6)
		{
			expl.input(2, 0, 4);
		}*/
	};
}
