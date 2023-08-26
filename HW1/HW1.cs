using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{
    public int playerAge = 10;
    public float guess = 1.0f;
    public string playerMessage = "Hello";
    // Start is called before the first frame update
    void Start()
    {
        FuncOne(playerAge);
        FuncTwo(guess);
        FuncThree(playerMessage);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FuncOne(int age)
    {
        if (age <= 80)
        {
            Debug.Log("msg1");
        }
        else
        {
            Debug.Log("msg2");
        }
    }

    void FuncTwo(float guess)
    {
        switch (guess)
        {
            case 3.14f:
                Debug.Log("You found my pie :)");
                break;
            case 2.72f:
                Debug.Log("You found my Eclair :)");
                break;
            default:
                Debug.Log("You can NOT anything :(");
                break;
        }
    }

    void FuncThree(string msg)
    {
        int i = 0;
        int len = msg.Length;
        while (i < len)
        {
            Debug.Log(msg[i] + msg[len - 1 - i]);
        }
    }
}
