using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour
{
    public float damage = 100f;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    
    // interface는 내부에 멤버변수나 구현문이 있는 함수가 들어가지 못한다.
    // 껍데기만 존재하고, 어느 정도는 구현해 놓되 자식들이 직접 구현하는 걸 원한다면 abstract!
    public abstract void Attack();
}
