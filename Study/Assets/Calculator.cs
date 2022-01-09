using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // 새로운 delegate 타입을 정의. 이러한 형태인 애들만 대행해 줄 수 있다.
    delegate float Calculate(float a, float b);

    Calculate onCalculate;

    private void Start() {
        //onCalculate = Sum(); == Sum을 호출하겠다는 것임;
        onCalculate = Sum;      // Sum을 대행해라!
        onCalculate += Subtract;   // Sum 다음에 Subtract
        onCalculate -= Subtract;
        onCalculate += Multiply;
    }

    public float Sum(float a, float b)
    {
        Debug.Log(a + b);
        return a + b;
    }

    public float Subtract(float a,  float b)
    {
        Debug.Log(a - b);
        return a - b;
    }

    public float Multiply(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // 계산하고 싶은 함수를 명시적으로 표시해야 함
            //Sum(1, 10);
            //Subtract(1, 10);
            //Multiply(1, 10);

            // 계산할 거라고 시작만 하면 추후 실시간으로 변경 가능
            // delegate: 유언 대리인(...), 죽기 전에 하고 싶은 일을 쭉 명시한다
            //           유언 리스트에 어떤 게 있는지 신경 안 쓰고, 일단 그냥 수행해 버린다
            //           내부에 함수 포인터를 가지고 있음 (A, B, C를 가리키는 변수를 가지고 있다)
            //           대행한 값의 "마지막" 결과값을 return 해 준다!
            Debug.Log("결과값 : " + onCalculate(1, 10));
        }
    }
}
