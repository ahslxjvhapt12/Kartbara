using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{

    private float speed;      // 캐릭터 움직임 스피드.
    private float jumpSpeed;  // 캐릭터 점프 힘.
    private float gravity;    // 캐릭터에게 작용하는 중력.
    private float rotateSpeed = 50;

    public LayerMask checkRay;
    [SerializeField] private GameObject rayPos;

    private CharacterController controller; // 현재 캐릭터가 가지고있는 캐릭터 컨트롤러 콜라이더.
    private Vector3 MoveDir;                // 캐릭터의 움직이는 방향.

    void Start()
    {
        speed = 6.0f;
        jumpSpeed = 8.0f;
        gravity = 20.0f;

        MoveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        RaycastHit hit;

        Physics.Raycast(rayPos.transform.position, -transform.up, out hit, 1f);
        Debug.DrawRay(rayPos.transform.position, -transform.up * 0.4f, Color.red);

        Transform hitObj = hit.transform;

        float h = Input.GetAxisRaw("Horizontal");
        Debug.Log(hitObj);
        
        // 아 거지같네 진짜
        //transform.rotation = hit.transform.rotation;


        //if (hitObj != null) transform.rotation = Quaternion.Euler(hitObj.rotation.x, h * Time.deltaTime * rotateSpeed, hitObj.rotation.z) * transform.rotation;
        //else transform.rotation = Quaternion.Euler(0, h * Time.deltaTime * rotateSpeed, 0) * transform.rotation;
        transform.rotation = Quaternion.Euler(0, h * Time.deltaTime * rotateSpeed, 0) * transform.rotation;
        // 현재 캐릭터가 땅에 있는가?
        if (controller.isGrounded)
        {
            MoveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            MoveDir = transform.TransformDirection(MoveDir);
            MoveDir *= speed;
            // 캐릭터 점프
            if (Input.GetButton("Jump"))
                MoveDir.y = jumpSpeed;
        }

        MoveDir.y -= gravity * Time.deltaTime; //중력 연산

        // 캐릭터 움직임.
        controller.Move(MoveDir * Time.deltaTime);
    }
}