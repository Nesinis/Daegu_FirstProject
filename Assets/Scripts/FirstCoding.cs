using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // ������ ���� �����ϱ�
    public int numberInt1;
    public int numberInt2;
    int numberSum;
    int numberRemainder;
    int numberSubtract;
    int numberMultiply;
    float numberDivide;


    // �Ǽ��� ���� �����ϱ�
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;


    // ���ڿ� ���� �����ϱ�
    public string name = "�ڿ���";
    string job = "���λ����";

    // ���� ���� �����ϱ�
    public bool isMan;


    // Start is called before the first frame update
    // ��ŸƮ�� �����Ͱ� �۵� �� ���Ŀ� ����ȴ�
    // Void Start �� �ڷᰪ�� ��ȯ���� �ʰڴ� ��� ��
    void Start()
    {
        // ������ ����
        // ���� �̸� = ��;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        // = 1���� ���� ������ == 2���� ����
        // "/" �� "%" ������

        //number = 50;
        //number2 = 3.141592f;
        // name = "������";
        //isMan = false;

        //numberResult = (float)numberInt1 / (float)numberInt2;
        // ��Ģ ������:  +   -   *  /  %

        // ���ڿ� + ���ڿ� -> �� ���ڿ��� ����ȴ�.
        // ���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ� ���� ��: ������.ToString()

        //string result = name + numberInt1.ToString();

        //print(result);
        //print(numberRemainder);

        // numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�.
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
    // void Update �� ȣ�� �غ� �� �Լ�
    void Update()
    {

    }

    // �Լ� ����
    // ��ȯ �ڷ��� �Լ� �̸� (�Ű�����1, �Ű�����2, ...)
    // {
    //      ����
    // }

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
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


    // �� ������ ���� �Է����� �޾Ƽ�, �� ������ ������ ����� �Ǽ� ���·� ��ȯ�Ѵ�.
    // �Է¹��� ������ �Ǽ��� �ӽ� ����ȯ�� �Ѵ�.

    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }

}






