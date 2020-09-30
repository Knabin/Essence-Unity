using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{
	public Transform targetTransform;

    void Start()
    {
		Quaternion newRotation = Quaternion.Euler(new Vector3(45, 0, 0));
		transform.rotation = newRotation;

		// 현재 각도에서 회전하는 법 
		// 1. Rotate 함수 이용
		transform.Rotate(new Vector3(30, 0, 0));

		// 2. 쿼터니언 -> Vector3, Vector3끼리 연산 후 쿼터니언 변환
		Quaternion originalRotation = transform.rotation;

		Vector3 originalRotationInVector3 = originalRotation.eulerAngles;
		Vector3 targetRotationVec = originalRotationInVector3 + new Vector3(30, 0, 0);

		Quaternion targetRotation = Quaternion.Euler(targetRotationVec);

		transform.rotation = targetRotation;

		// 3. 쿼터니언끼리 연산
		Quaternion oriRotation = Quaternion.Euler(new Vector3(45, 0, 0));
		Quaternion plusRotation = Quaternion.Euler(new Vector3(30, 0, 0));
		Quaternion tarRotation = oriRotation * plusRotation;

		transform.rotation = tarRotation;

		// Look Rotation
		Vector3 direction = targetTransform.position - transform.position;
		Quaternion.LookRotation(direction);


		// Lerp
		Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
		Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));
		Quaternion.Lerp(aRotation, bRotation, 0.5f);

	}
}
