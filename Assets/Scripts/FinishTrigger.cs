using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class FinishTrigger : MonoBehaviour
{
    //[SerializeField] GameManager gameManager;
    [SerializeField] AudioSource source;
    public void OnTriggerEnter(Collider other)
    {
        PlayerBehavior playerBehavior = other.attachedRigidbody.GetComponent<PlayerBehavior>();
        if (playerBehavior != null)
        {
            source.Play();
            playerBehavior.StartFinishBehaviour();
            FindObjectOfType<GameManager>().ShowFinishWindow();

        }
    }
}
