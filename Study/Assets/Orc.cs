using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : BaseMonster
{
    public override void Attack()
    {
        Debug.Log("광역공격을 했다! 데미지: " + damage);
    }
}
