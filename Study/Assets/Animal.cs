using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    // 부모 클래스 - 모든 친구들의 원형, 공유하는 기능

    public string name;
    public float weight;
    public int year;

    public void Print() {
        Debug.Log(name + "| 몸무게: " + weight + "| 나이: " + year);
    }

    protected float GetSpeed()
    {
        return CalcSpeed();
    }

    private float CalcSpeed()
    {
        return 100f / (weight * year);
    }
}

public class Dog2 : Animal
{
    // Animal의 코드를 가진 상태에서 덧붙여서 코드를 짤 수 있게 됨

    // 1. 코드의 재사용 - 디자인 패턴, sandbox 패턴 찾아보기
    //

    public void Hunt()
    {
        //CalcSpeed();
        float speed = GetSpeed();
        Debug.Log(speed + "의 속도로 달려가서 사냥했다");

        weight = weight + 10f;
    }
}

public class Cat : Animal
{
    public void Stealth()
    {
        Debug.Log("숨었다");
    }
}