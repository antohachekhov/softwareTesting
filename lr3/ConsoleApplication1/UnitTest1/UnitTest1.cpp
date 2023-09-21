#include "pch.h"
#include "CppUnitTest.h"
#include "../ConsoleApplication1/Class.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(getOddRankAndReverseAIsZero_Test_C2)
		{
			//arrange
			int a = 0;
			int expected = 0;

			// act
			int result = Class::getOddRankAndReverse(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getOddRankAndReverseAIsNotZero_Test_C2)
		{
			//arrange
			int a = 1;
			int expected = 1;

			// act
			int result = Class::getOddRankAndReverse(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsZero_Test_C2)
		{
			//arrange
			int a = 0;
			int expected = 0;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsNotZeroWithoutEvenValues_Test_C2)
		{
			//arrange
			int a = 10;
			int expected = 0;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(getEvenRankWithMaxEvenValueAIsNotZeroWithEvenValue_Test_C2)
		{
			//arrange
			int a = 20;
			int expected = 2;

			// act
			int result = Class::getEvenRankWithMaxEvenValue(a);

			// assert
			Assert::AreEqual(expected, result);
		}
	};
}
