using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumperPower = 100f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb = other.GetComponent<Rigidbody>();
        if (playerRb != null)
        {
            playerRb.AddForce(Vector3.up * jumperPower, ForceMode.Impulse);
        }
    }
}
