using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyrpMovement : MonoBehaviour
{
    
    float smooth = 5f;
    float tiltAngle = 60f;
    [SerializeField] BoxCollider box;

    // Start is called before the first frame update
    private void Awake()
    {
        this.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            win();
        }
    }

    void win()
    {
        Debug.Log("win!"); 
    }
}
