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
        JSONSave.Start(new JSONSaveConfig
        {
            SaveFileName = "data.json",
            AutoSaveData = true,
            ScrambleSaveData = false,
            EncryptionSecret = "123",
        });
        this.coinStorage = new CoinStorage();
        this.coinStorage.Init();
        this.coinService = new CoinService(this.coinStorage);
        this.coinService.Init();

        Debug.Log("Coin Service Initialized. Coins: " + this.coinService.coins);
        Debug.Log("Data Path: " + Application.persistentDataPath + "/data.json");
        Vector3 v2 = new Vector3(7, 7, 7);
        v2 = JSONSave.GetVector3("test2", v2);
        Debug.Log("Vector3: " + v2.x + ", " + v2.y + ", " + v2.z);
        Debug.Log("Vector3.x: " + JSONSave.GetVector3x("test2", 1));
        JSONSave.SetVector2("test2", new Vector2(6, 5));
        Debug.Log("Vector2: " + JSONSave.GetVector2("test2", new Vector2(1, 1)).x + ", " + JSONSave.GetVector2("test2", new Vector2(1, 1)).y);


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
