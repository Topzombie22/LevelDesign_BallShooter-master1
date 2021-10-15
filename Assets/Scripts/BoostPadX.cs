using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPadX : MonoBehaviour
{
    // Start is called before the first frame update
    public float bounce = 1000f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * bounce, ForceMode.Impulse);
        }
    }
}
