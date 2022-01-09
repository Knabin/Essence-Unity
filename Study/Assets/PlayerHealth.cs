using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    // 바깥에서 들어와서 등록만 해 놓고 떠난다. 명단.
    public UnityEvent onPlayerDead;

    private void Dead() 
    {
        // 어떤 기능들이 들어와 있는지는 관심이 없고, 발동시킨다.
        // 엮인 코드가 없기 때문에 구조적으로 매우 깔끔하다.
        onPlayerDead.Invoke();
        Debug.Log("죽었다!");
        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("죽었다!");
        Destroy(gameObject);
    }
}
