using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubtractor : MonoBehaviour
{
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
		{
			ScoreManagerEx.GetInstance().AddScore(-2);
			Debug.Log(ScoreManagerEx.GetInstance().GetScore());
		}
    }
}
