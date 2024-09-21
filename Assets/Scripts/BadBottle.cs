using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBottle : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject effectPrefab;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<PlayerModifier>().HitBadDollar();
        Destroy(gameObject);
        Instantiate(effectPrefab, transform.position, transform.rotation);
    }
}
