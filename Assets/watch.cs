using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

using UnityEngine.UI;

public class watch : MonoBehaviour
{
    public TMP_Text WatchText;
    public float WatchValue;
    public UnityAction action;
    void Start()
    {
        WatchText = GetComponent<TMP_Text>();
        WatchValue = 0;
        action += run;
    }

    void Update()
    {
        action?.Invoke();
    }
    private void run()
    {
        WatchValue = WatchValue + Time.deltaTime;
        WatchText.text = WatchValue.ToString("F2");
    }
}
