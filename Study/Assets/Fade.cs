using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
	public Image fadeImage;

    void Start()
    {
		//StartCoroutine("FadeIn");
		StartCoroutine(FadeIn());		// 성능적으로 좋으나 임의적으로 멈출 수 없음
    }

	IEnumerator FadeIn()
	{
		Color startColor = fadeImage.color;

		for(int i = 0; i < 100; ++i)
		{
			startColor.a = startColor.a - 0.01f;
			fadeImage.color = startColor;
			yield return new WaitForSeconds(0.01f);
		}
	}
}
