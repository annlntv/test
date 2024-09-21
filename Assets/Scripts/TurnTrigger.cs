using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTrigger : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Transform targetWaypoint;
    public float rotationSpeed = 20f;

    private bool isRotating = false;
    private void OnTriggerEnter(Collider other)
    {
        isRotating = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isRotating = false;
        Destroy(gameObject);
    }

    private void Update()
    {
        if (isRotating)
        {
            OnRotate();
        }
    }

    void OnRotate ()
    {
        Vector3 direction = (targetWaypoint.position - player.transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            isRotating=false;
        }

    }
}

