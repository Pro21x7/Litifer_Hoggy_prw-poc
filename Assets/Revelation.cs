using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Revelation : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        Thread.Sleep(5000);
        Destroy(GameObject.FindWithTag("kill"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
