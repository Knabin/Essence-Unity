using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject WinUI;
	public ItemBox[] itemBoxes;
	public bool isGameOver = false;

    void Start()
    {
        
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("SampleScene");
		}

		if (isGameOver) return;

		int count = 0;

        for(int i = 0; i < itemBoxes.Length; ++i)
		{
			if (itemBoxes[i].isOverlapped)
			{
				++count;
			}
		}

		if (count >= 3)
		{
			isGameOver = true;
			Debug.Log("게임 승리!");
			WinUI.SetActive(true);
		}
    }
}
