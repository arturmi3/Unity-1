using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeback : MonoBehaviour
{
        void Update()
    {
        if (gameObject.tag =="Hit")
        {
           var obj = gameObject.GetComponent<Hitchanger>();
            if(obj.hittime +3 < Time.time)
            {
                 GetComponent<MeshRenderer>().material.color = Color.red;
                 gameObject.tag = "Untagged";
            }
        }   
    }
}
