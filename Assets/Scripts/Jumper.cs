using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumperPower = 300f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody playerRb = other.GetComponent<Rigidbody>();
        if (playerRb != null)
        {
            playerRb.AddForce(Vector3.up * jumperPower, ForceMode.Impulse);
        }
    }
}
