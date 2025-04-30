using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    [SerializeField] float speed = 5.0f;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        // Time.deltaTime
        // ������ �������� �Ϸ��ϴµ� ����� �ð��� �� ������ ��ȯ�ϴ� �ð��Դϴ�.
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
