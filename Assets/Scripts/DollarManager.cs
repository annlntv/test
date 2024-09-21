using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data.SqlTypes;

public class DollarManager : MonoBehaviour
{
    public int numberOfDollars;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI dollarUIText;

    private void Start()
    {
        numberOfDollars = Progress.Instance.Dollars;
        dollarUIText.text = numberOfDollars.ToString();
    }

    public void UpdateUI(int money)
    {
        text.text = money.ToString();
        SaveToProgress();
    }
    public void AddTwo()
    {
        numberOfDollars+=2;
        text.text = numberOfDollars.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.Dollars = numberOfDollars;
    }

    public void SpendMoney(int value)
    {
        numberOfDollars -= value;
        text.text = numberOfDollars.ToString();
    }
}
