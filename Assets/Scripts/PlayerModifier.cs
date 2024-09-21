using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] public int moneyState;
    [SerializeField] GameObject player;
    [SerializeField] AudioSource increaseSound;
    [SerializeField] Animator animator;

    private bool startGame;
    private void Start()
    {
        startGame = true;
        SetMoneyState(Progress.Instance.Dollars);
    }

    public void AddMoney(int value)
    {
        moneyState += value;
        UpdateMoneyStateModel();
    }

    public void SetMoneyState(int value)
    {
        moneyState = value;
        UpdateMoneyStateModel();
    }

    public void HitBadDollar()
    {
        if (moneyState >= 0)
        {
            moneyState -= 20;
            UpdateMoneyStateModel();
        }
        else
        {
            Die();
        }
    }
    void UpdateMoneyStateModel()
    {
        FindObjectOfType<DollarManager>().UpdateUI(moneyState);
        PlayerModelSwitcher modelSwitcher = FindObjectOfType<PlayerModelSwitcher>();
        if ((modelSwitcher != null) && (!startGame))
        {
            if((moneyState >= 0) && (moneyState < 70)) { 
                modelSwitcher.SetModel(Skins.casual); 
                increaseSound.Play();
            }
            if ((moneyState >= 70) && (moneyState < 100))
            { 
                modelSwitcher.SetModel(Skins.middle); 
                increaseSound.Play();
                //animator.SetBool("isWalking", false);
                animator.SetBool("catwalk", true);
            }
            else if ((moneyState >= 100) && (moneyState < 200))
            { 
                modelSwitcher.SetModel(Skins.bling); 
                increaseSound.Play();
                animator.SetBool("catwalk", true);
            }
            else if ((moneyState >= 200) && (moneyState < 400))
            { 
                modelSwitcher.SetModel(Skins.bussiness); 
                increaseSound.Play();
                animator.SetBool("catwalk", true);
            }
            else if ((moneyState >= 400) && (moneyState < 1000))
            { 
                modelSwitcher.SetModel(Skins.cocktail); 
                increaseSound.Play();
                animator.SetBool("catwalk", true);
            }
            else if (moneyState < 0)
            {
                modelSwitcher.SetModel(Skins.poor);
                animator.SetBool("isWalking", false);
            }
                
        }
        startGame = false;
    }

    void Die()
    {
        FindObjectOfType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }
}
