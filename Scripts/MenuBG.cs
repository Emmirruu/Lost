using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBG : MonoBehaviour
{
    public float speed = 4f;
    Vector3 MenuBg;

    void Start()
    {
        MenuBg = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed*Time.deltaTime);
    }
}
