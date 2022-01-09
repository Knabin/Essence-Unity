using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("Jump");
        }

        // 아무것도 누르지 않을 때는 0, 방향키 위쪽 누르면 1이 들어옴
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", verticalInput);
        anim.SetFloat("Horizontal", horizontalInput);
    }

    private void OnAnimatorIK(int layerIndex) 
    {
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f); // 우선순위 결정
        anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);

        anim.SetIKPosition(AvatarIKGoal.LeftHand, target.position);
        anim.SetIKRotation(AvatarIKGoal.LeftHand, target.rotation);

        anim.SetLookAtWeight(1.0f);
        anim.SetLookAtPosition(target.position);

    }
}
