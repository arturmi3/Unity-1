using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFinish : MonoBehaviour
{ 
    float score = 50 ;
   private void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.tag == "Player")
       {
      var Player = other.gameObject.GetComponent<scorecounter>();
      score = score - Player.hits;
      Debug.Log("Congratulations you have won " + score);
       }
   }
}
