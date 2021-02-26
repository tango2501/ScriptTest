using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // moneyを50で初期化する
        int money = 200;

        if (money >= 100)
        {
            // moneyが100以上だった場合
            Debug.Log("ポーションを買う");
        }
        else
        {
            // moneyが100未満だった場合
            Debug.Log("武器を売る");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
