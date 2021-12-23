using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPoint : MonoBehaviour
{
    public PointManager pointManager;
    public MonsterManager monsterManager;

    private void Start() 
    {
        pointManager.point = 100;
        Debug.Log("현재 점수: " + pointManager.point);

        pointManager.point = -100;
        Debug.Log("현재 점수: " + pointManager.point);

    //     pointManager.SetPoint(100);

    //     int myPoint = pointManager.GetPoint();
    //     Debug.Log("현재 포인트: " + myPoint);

    //     pointManager.SetPoint(-1000);
    //     myPoint = pointManager.GetPoint();
    //     Debug.Log("현재 포인트: " + myPoint);

        Debug.Log(monsterManager.count);
    }
}
