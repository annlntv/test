using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Animator animator;
    private float oldMousePositionX;
    private float x;
    private bool start = true;
    void FixedUpdate()
    {
        if (start)
        {
            animator.SetBool("isWalking", true);
            start = false;
        }

        Vector3 newPos = transform.position + transform.forward * Time.deltaTime * speed;
        newPos.x = Mathf.Clamp(newPos.x, -2.5f, 2.5f);
        transform.position = newPos;

        float deltaX = Input.mousePosition.x - oldMousePositionX;
        oldMousePositionX = Input.mousePosition.x;

        if (Input.GetMouseButton(0))
        {
            x += deltaX / 70;
            x = Mathf.Clamp(x, -2.5f, 2.5f);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }

    }
}
