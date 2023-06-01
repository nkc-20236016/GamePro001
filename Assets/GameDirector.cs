using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject Timegauge;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.Timegauge = GameObject.Find("Timegauge");
    }

    public void DecreaseHp()
    {
        this.Timegauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            this.Timegauge.GetComponent<Image>().fillAmount -= 0.01f;
        }
    }
}
