using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void OnPlayerDead()
    {
        // 지연 시간 후 Restart라는 이름의 함수 실행
        Invoke("Restart", 5f);
    }
    private void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
