using UnityEngine;

public class PinToPlayer : MonoBehaviour
{
    public GameObject obj;
    void Update()
    {
        transform.position = obj.transform.position;
    }
}
