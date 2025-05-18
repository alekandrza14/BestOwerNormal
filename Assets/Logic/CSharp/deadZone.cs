using UnityEngine;

public class deadZone : MonoBehaviour
{
    public GameObject deadwindow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(deadwindow);
            Destroy(other.gameObject);
        }
    }
}
