using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Animator animator;
    [SerializeField] Camera _mainCamera;

    void Start()
    {
        player.enabled = false;
    }

    public void Play()
    {
        player.enabled = true;
    }

    public void StartFinishBehaviour()
    {
        player.enabled = false;
        animator.SetTrigger("dance");
    }
}
