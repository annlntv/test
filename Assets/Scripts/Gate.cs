using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int value;

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier modifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (modifier != null)
        {
            modifier.AddMoney(value);
            Destroy(gameObject);
        }
    }
}
