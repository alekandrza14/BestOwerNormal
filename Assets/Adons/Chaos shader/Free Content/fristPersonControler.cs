using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fristPersonControler : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject[] g;
    bool inverse;
    static private fristPersonControler find;
    public static fristPersonControler main()
    {
        if (!find)
        {
            find = FindAnyObjectByType<fristPersonControler>();
        }
        return find;
    }
    void Update()
    {
        Ray r = new Ray(transform.position,Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(r,out hit))
        {
            if (hit.distance <= 1.5f && Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up*(50 * Time.deltaTime)*(VarSave.GetInt("Bonus_Jump")==1?3:1), ForceMode.Impulse);
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            inverse = !inverse;
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (!inverse)
            {


                g[0].transform.Rotate(0, Input.GetAxisRaw("Mouse X") * (150f * Time.fixedDeltaTime), 0);
                g[1].transform.Rotate(-Input.GetAxisRaw("Mouse Y") * (150f * Time.fixedDeltaTime), 0, 0);
            }
            else
            {

                g[0].transform.Rotate(0, -Input.GetAxisRaw("Mouse X") * (150f * Time.fixedDeltaTime), 0);
                g[1].transform.Rotate(Input.GetAxisRaw("Mouse Y") * (150f * Time.fixedDeltaTime), 0, 0);
            }
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Cursor.lockState = CursorLockMode.None;
        }
       if((rb.linearVelocity.x+ rb.linearVelocity.z) <= 1) rb.MovePosition( (((transform.right * Input.GetAxisRaw("Horizontal")+ transform.forward * Input.GetAxisRaw("Vertical"))/6) * (VarSave.GetInt("Bonus_Speed") == 1 ? 3 : 1)) +transform.position);
      
    }
}
