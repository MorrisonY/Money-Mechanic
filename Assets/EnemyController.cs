using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int rewardAmount = 10;
    public CurrencyTracker currencyTracker;

    // Start is called before the first frame update
    void Start()
    {
        currencyTracker = GameObject.FindObjectOfType<CurrencyTracker>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            if (currencyTracker != null)
            {
                currencyTracker.EnemyDestroyed(rewardAmount);
            }
        }
    }

    private void OnDestroy()
    {
        currencyTracker.EnemyDestroyed(rewardAmount);
    }
}
