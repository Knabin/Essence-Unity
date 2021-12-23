using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    // property
    // int a = point;   GET
    // point = 100;     SET
    public int point {
        get {
            Debug.Log(m_point);
            return m_point;
        }

        set {
            if (value < 0)
            {
                m_point = 0;
            }
            else
            {
                m_point = value;
            }
        }
    }

    private int m_point = 0;


    //private int point = 0;
    //
    // public void SetPoint(int newPoint)
    // {
    //     // 함수의 필터링을 통해 들어가서는 안 되는 값을 걸러 준다.
    //     if (newPoint < 0)
    //     {
    //         point = 0;
    //     }
    //     else if (newPoint > 10000)
    //     {
    //         point = 10000;
    //     }
    //     else
    //     {
    //         point = newPoint;
    //     }
    // }

    // public int GetPoint()
    // {
    //     Debug.Log(point);
    //     return point;
    // }
}
