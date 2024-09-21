using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModelSwitcher : MonoBehaviour
{
    public GameObject casualModel;
    public GameObject middleModel;
    public GameObject blingModel;
    public GameObject poorModel;
    public void SetModel(Skins skin)
    {
        // про это мы пока что говорить не будем........
        if (skin == Skins.casual) 
        {
            casualModel.SetActive(true);
            middleModel.SetActive(false);
            blingModel.SetActive(false);
            poorModel.SetActive(false);
        }
        else if(skin == Skins.middle)
        {
            casualModel.SetActive(false);
            middleModel.SetActive(true);
            blingModel.SetActive(false);
            poorModel.SetActive(false);
        }
        else if (skin == Skins.bling)
        {
            casualModel.SetActive(false);
            middleModel.SetActive(false);
            blingModel.SetActive(true);
            poorModel.SetActive(false);
        }
        else if(skin == Skins.poor)
        {
            casualModel.SetActive(false);
            middleModel.SetActive(false);
            blingModel.SetActive(false);
            poorModel.SetActive(true);
        }
    }
}
