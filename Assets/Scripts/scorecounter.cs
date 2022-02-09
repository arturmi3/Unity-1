using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorecounter : MonoBehaviour
{
   public int hits = 0;
        private void OnCollisionEnter(Collision other)
        {
            if  (other.gameObject.tag != "Hit")
            {
            hits ++;
            Debug.Log("youve hit wall this many times " + hits);
            }
        }
}
