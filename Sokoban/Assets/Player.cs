using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public GameManager gameManager;

	public float speed = 10f;
	Rigidbody playerRigidbody;

	// 게임이 처음 시작되었을 떄 한 번
    void Start()
    {
		playerRigidbody = GetComponent<Rigidbody>();
    }

	// 화면이 한 번 깜빡일 때 한 번 실행
	// 1초에 대략 60번(사양에 따라 다름) => 몇 번 실행되는지는 정해져 있지 않음
    void Update()
    {
		if (gameManager.isGameOver) return;

		// -1 ~ +1
		// 직접 연결돼 있는 게 아니라, 이름을 찾아가서 해당 키를 찾아감 
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis("Vertical");

		float fallSpeed = playerRigidbody.velocity.y;

		//playerRigidbody.AddForce(inputX * speed, 0, inputZ * speed);
		playerRigidbody.velocity = new Vector3(inputX * speed, fallSpeed, inputZ * speed);

	}
}
