using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyTracker : MonoBehaviour
{
    public int currentCurrency = 0;
    public Text currencyText;


    // Start is called before the first frame update
    void Start()    
    {
        currentCurrency = 100;
        currencyText.text = "$ " + currentCurrency.ToString();
        currencyText = GameObject.Find("Currency Display").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void UpdateCurrency(int amount) {
        currentCurrency += amount;
        if (currencyText != null) {
            currencyText.text = "$ " + currentCurrency.ToString();
        }
    }

    public void EnemyDestroyed(int rewardAmount) {
        UpdateCurrency(rewardAmount);
    }
}
