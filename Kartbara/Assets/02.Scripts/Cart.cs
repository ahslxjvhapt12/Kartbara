using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{

    private float speed;      // ĳ���� ������ ���ǵ�.
    private float jumpSpeed;  // ĳ���� ���� ��.
    private float gravity;    // ĳ���Ϳ��� �ۿ��ϴ� �߷�.
    private float rotateSpeed = 50;

    public LayerMask checkRay;
    [SerializeField] private GameObject rayPos;

    private CharacterController controller; // ���� ĳ���Ͱ� �������ִ� ĳ���� ��Ʈ�ѷ� �ݶ��̴�.
    private Vector3 MoveDir;                // ĳ������ �����̴� ����.

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

        Physics.Raycast(rayPos.transform.position, -transform.up, out hit, 1);

        float h = Input.GetAxisRaw("Horizontal");
        transform.rotation = Quaternion.Euler(0, h * Time.deltaTime * rotateSpeed, 0) * transform.rotation;
        // ���� ĳ���Ͱ� ���� �ִ°�?
        if (controller.isGrounded)
        {
            MoveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            MoveDir = transform.TransformDirection(MoveDir);
            MoveDir *= speed;
            // ĳ���� ����
            if (Input.GetButton("Jump"))
                MoveDir.y = jumpSpeed;
        }

        MoveDir.y -= gravity * Time.deltaTime; //�߷� ����

        // ĳ���� ������.
        controller.Move(MoveDir * Time.deltaTime);
    }
}