using UnityEngine;

public class GrapMoney : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MoneyCounter.money += 1000;
            Destroy(gameObject);
        }
    }
}
