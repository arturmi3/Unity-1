using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Dzień Dobry");
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*MoveSpeed ;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
