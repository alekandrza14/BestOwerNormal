using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
    public Text MoneyCounterLable;
    public static int money = 1000;
    void Update()
    {
        MoneyCounterLable.text = "p." + money;
    }
}
