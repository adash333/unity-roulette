﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{   
    float rotSpeed = 0; // 回転速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // マウスが押されたら回転速度を設定する
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        // ルーレットを減速させる（1フレームごとに、スピードを0.96倍にする。）
        this.rotSpeed *= 0.96f;
    }
}
