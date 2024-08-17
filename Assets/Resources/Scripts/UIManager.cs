using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private GameObject car;
    [SerializeField] private GameObject flg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = flg.transform.position.x - car.transform.position.x;
        if (distance < 0) {
            text.color = Color.red;
            text.text = "게임 오버";
        } else {
            text.text = "깃발까지의 거리 : " + (flg.transform.position.x - car.transform.position.x).ToString("F2") + "M 입니다";
        }
    }
}
