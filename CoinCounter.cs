using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class CoinCounter : MonoBehaviour
{
    public static int coinCount = 0;
    public TextMeshProUGUI counterText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (counterText == null)
            counterText = GetComponent<TextMeshProUGUI>();

        if (counterText == null)
        {
            Debug.LogWarning("CoinCounter: no TextMeshProUGUI assigned or found on GameObject.", this);
            return;
        }

        counterText.text = coinCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (counterText == null) return;

        string value = coinCount.ToString();
        if (counterText.text != value)
        {
            counterText.text = value;
        }
    }
}
