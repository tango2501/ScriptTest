using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 変数aを3で初期化する
        int a = 3;
        if( a == 3 )
        {
            //変数aが3の場合、変数bを5で初期化する
            int b = 5;
        }
        Debug.Log(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
