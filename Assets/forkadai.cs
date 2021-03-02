using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//Array.Reverseを使用するためのもの


public class forkadai : MonoBehaviour
{
    // 配列を初期化する
    int[] points = new int[] { 10, 20, 30, 40, 50 };
    // Start is called before the first frame update
    void Start()
    {
        // for文を使って配列の要素を順に表示する
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);

        }
        // for文を使って配列の要素を逆順に表示する
        Array.Reverse(points);// 配列の要素を逆順にする
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
