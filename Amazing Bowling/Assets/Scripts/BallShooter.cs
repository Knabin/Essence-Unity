using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
	public CamFollow cam;

	public Rigidbody ball;
	public Transform firePos;
	public Slider powerSlider;
	public AudioSource shootingAudio;
	public AudioClip fireClip;
	public AudioClip chargingClip;
	public float minForce = 15f;
	public float maxForce = 30f;
	public float chargingTime = 0.75f;

	float currentForce;
	float chargeSpeed;
	bool fired;

	// component가 꺼져 있다가 켜질 때 매번 실행됨
	private void OnEnable()
	{
		currentForce = minForce;
		powerSlider.value = minForce;
		fired = false;
	}

	private void Start()
	{
		chargeSpeed = (maxForce - minForce) / chargingTime;
	}

	private void Update()
	{
		if (fired)
			return;

		powerSlider.value = minForce;

		if (currentForce >= maxForce && !fired)
		{
			currentForce = maxForce;
			Fire();
		}
		else if (Input.GetButtonDown("Fire1"))
		{
			//fired = false;		// 연사 가능
			currentForce = minForce;

			shootingAudio.clip = chargingClip;
			shootingAudio.Play();
		}
		else if (Input.GetButton("Fire1") && !fired)
		{
			currentForce += chargeSpeed * Time.deltaTime;
			powerSlider.value = currentForce;
		}
		else if (Input.GetButtonUp("Fire1") && !fired)
		{
			Fire();
		}
	}

	void Fire()
	{
		fired = true;
		Rigidbody ballInstance = Instantiate(ball, firePos.position, firePos.rotation);
		ballInstance.velocity = currentForce * firePos.forward;

		shootingAudio.clip = fireClip;
		shootingAudio.Play();

		currentForce = minForce;
		cam.SetTarget(ballInstance.transform, CamFollow.State.Tracking);
	}
}
