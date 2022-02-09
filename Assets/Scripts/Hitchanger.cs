using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitchanger : MonoBehaviour
{
    public float hittime = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.black ;
        gameObject.tag = "Hit";
        hittime = Time.time;
        }
    }

}
