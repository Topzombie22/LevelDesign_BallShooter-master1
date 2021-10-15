using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPad : MonoBehaviour
{
    public float bounce = 20f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * bounce, ForceMode.Impulse);
        }
    }
}
