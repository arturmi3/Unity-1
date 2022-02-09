using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    MeshRenderer renderer;
    [SerializeField] float time = 5f;// Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time)
        {
            renderer.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
