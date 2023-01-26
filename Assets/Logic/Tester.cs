using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private CoinStorage coinStorage;
    private CoinService coinService;
    // Start is called before the first frame update
    void Start()
    {
        this.coinStorage = new CoinStorage();
        this.coinStorage.Init();
        this.coinService = new CoinService(this.coinStorage);
        this.coinService.Init();

        Debug.Log("Coin Service Initialized. Coins: " + this.coinService.coins);
        Debug.Log("Data Path: " + Application.persistentDataPath + "/data.json");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.coinService.AddCoins(this, 10);
            Debug.Log("10 coins added. Total: " + this.coinService.coins + " sent by: " + this);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            this.coinService.RemoveCoins(this, 20);
            Debug.Log("20 coins removed. Total: " + this.coinService.coins + " sent by: " + this);
        }
    }
}
