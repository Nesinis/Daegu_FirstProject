using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // 정수형 변수 선언하기
    public int numberInt1;
    public int numberInt2;
    int numberSum;
    int numberRemainder;
    int numberSubtract;
    int numberMultiply;
    float numberDivide;


    // 실수형 변수 선언하기
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;


    // 문자열 변수 선언하기
    public string name = "박원석";
    string job = "개인사업자";

    // 논리형 변수 선언하기
    public bool isMan;


    // Start is called before the first frame update
    // 스타트는 에디터가 작동 된 이후에 적용된다
    // Void Start 는 자료값을 반환하지 않겠다 라는 뜻
    void Start()
    {
        // 변수의 사용법
        // 변수 이름 = 값;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        // = 1개는 대입 연산자 == 2개는 같다
        // "/" 몫 "%" 나머지

        //number = 50;
        //number2 = 3.141592f;
        // name = "강동규";
        //isMan = false;

        //numberResult = (float)numberInt1 / (float)numberInt2;
        // 사칙 연산자:  +   -   *  /  %

        // 문자열 + 문자열 -> 두 문자열이 연결된다.
        // 정수 또는 실수를 문자열로 형변환하고 싶을 때: 변수명.ToString()

        //string result = name + numberInt1.ToString();

        //print(result);
        //print(numberRemainder);

        // numberInt1과 numberInt2 변수의 합계 값을 출력한다.
        //numberSum = Sum(10, 20);
        int numberSum = Sum(numberInt1, numberInt2);
        int numSubtract = Subtract(numberInt1, numberInt2);
        int numMultiply = Multiply(numberInt1, numberInt2);
        float numDivide = Divide(numberInt1, numberInt2);
        print(numberSum);
        print(numSubtract);
        print(numMultiply);
        print(numDivide);

        
    }

    // Update is called once per frame
    // void Update 는 호출 준비가 된 함수
    void Update()
    {

    }

    // 함수 선언
    // 반환 자료형 함수 이름 (매개변수1, 매개변수2, ...)
    // {
    //      할일
    // }

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고 싶다!
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
    // Subtract, Multiply, Divide

    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }


    // 두 정수의 값을 입력으로 받아서, 두 정수의 나눗셈 결과를 실수 형태로 반환한다.
    // 입력받은 정수를 실수로 임시 형변환을 한다.

    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }

}






