using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogText : MonoBehaviour
{
    Text logText;

    void Start()
    {
        logText = GetComponent<Text>();

#if UNITY_EDITOR
        logText.text = $"����Ƽ ������!";
#elif UNITY_ANDROID
        logText.text = $"�ȵ���̵�!";
#endif
    }
}
