using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
	public enum State
	{
		Idle,
		Ready,
		Tracking,
	}

	State state
	{
		set
		{
			switch(value)
			{
				case State.Idle:
					targetZoomSize = roundReadyZoomSize;
				break;
				case State.Ready:
					targetZoomSize = readyReadyZoomSize;
				break;
				case State.Tracking:
					targetZoomSize = trackingZoomSize;
				break;
			}
		}
	}

	Transform target;
	
	public float smoothTime = 0.2f;
	Vector3 lastMovingVelocity;
	Vector3 targetPosition;

	Camera cam;
	float targetZoomSize = 5f;
	const float roundReadyZoomSize = 14.5f;
	const float readyReadyZoomSize = 5f;
	const float trackingZoomSize = 10f;

	float lastZoomSpeed;


	private void Awake()
	{
		cam = GetComponentInChildren<Camera>();
		state = State.Idle;
	}

	private void Move()
	{
		targetPosition = target.transform.position;

		// ref: 함수 안에서 변경된 값을 챙겨서 나옴
		Vector3 SmoothPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref lastMovingVelocity, smoothTime);
		transform.position = SmoothPosition;
	}

	private void Zoom()
	{
		float smoothZoomSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoomSize, ref lastZoomSpeed, smoothTime);
		cam.orthographicSize = smoothZoomSize;
	}
	
	// 시간 간격이 일정함
	private void FixedUpdate()
	{
		if (target != null)
		{
			Move();
			Zoom();
		}
	}

	public void Reset()
	{
		state = State.Idle;
	}

	public void SetTarget(Transform newTarget, State newState)
	{
		target = newTarget;
		state = newState;
	}
}
