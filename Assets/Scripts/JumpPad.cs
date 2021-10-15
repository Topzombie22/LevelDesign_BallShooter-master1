using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 1000f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * bounce, ForceMode.Impulse);
        }
    }

}
