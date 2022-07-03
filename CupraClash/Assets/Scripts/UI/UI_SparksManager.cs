using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_SparksManager : MonoBehaviour
{
    [Header("Spark Variables")]
    [SerializeField] public TextMeshProUGUI totalSparks;
    [SerializeField] public TextMeshProUGUI currentSparks;
    [SerializeField] public TextMeshProUGUI sparksToDefeat;
    [SerializeField] private GameObject whiteSparks;
    [SerializeField] private GameObject orangeSparks;


    public void PlusButton()
    {
        int currentSparksValue;
        int.TryParse(currentSparks.text, out currentSparksValue);
        int allSparksValue;
        int.TryParse(totalSparks.text, out allSparksValue);
        if( allSparksValue > currentSparksValue)
        {
            int sum = currentSparksValue + 10;
            currentSparks.text = sum.ToString();
        }
        
    }

    public void SubstractButton()
    {
        int currentSparksValue;
        int.TryParse(currentSparks.text, out currentSparksValue);
        if(currentSparksValue >= 10 )
        {
            int resta = currentSparksValue - 10;
            currentSparks.text = resta.ToString();
        }
        
    }
    public void ExchangeButton()
    {
        int currentSparksValue;
        int.TryParse(currentSparks.text, out currentSparksValue);
        int allSparksValue;
        int.TryParse(totalSparks.text, out allSparksValue);
        int defeatValue;
        int.TryParse(sparksToDefeat.text, out defeatValue);

        if(currentSparksValue >= defeatValue)
        {
            //you win
            sparksToDefeat.text = currentSparksValue.ToString();

            int tmpTotalSparks = allSparksValue - currentSparksValue;
            totalSparks.text = tmpTotalSparks.ToString();

            currentSparks.text = "0";

            whiteSparks.SetActive(false);
            orangeSparks.SetActive(true);
        }
        else if(currentSparksValue < defeatValue)
        {
            int tmpSparksDefeat = defeatValue - currentSparksValue;
            sparksToDefeat.text = tmpSparksDefeat.ToString();

            int tmpTotalSparks = allSparksValue - currentSparksValue;
            totalSparks.text = tmpTotalSparks.ToString();

            currentSparks.text = "0";
        }
    }
}
