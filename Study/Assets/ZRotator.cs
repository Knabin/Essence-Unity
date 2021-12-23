using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZRotator : BaseRotator
{
    protected override void Rotate()
    {
        //base.Rotate();    // 부모의 기능을 그대로 사용하고, 덧붙이고 싶은 거라면 이렇게
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
