using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleUI : MonoBehaviour
{
    public TextMeshProUGUI DdayText;
    public TextMeshProUGUI DdayTextValue;
    public TextMeshProUGUI ItemInfoText;
    public TextMeshProUGUI ItemInfoTextValue;
    public TextMeshProUGUI ResultText;
    public TextMeshProUGUI ResultTextValue;


    int currentDday = 1;
    string currentItem = "·Õ¼Òµå";
    int result = 1000;

    // Start is called before the first frame update
    void Start()
    {
        NextDday(9);
        DdayText.text = "D-day " + currentDday;
        DdayTextValue.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
       // currentItem = currentItem;
    }
}
