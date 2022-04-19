using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dısarıdanOBjeAtamaIslmi : MonoBehaviour
{
    public GameObject yeniObje;
    void Start()
    {
        yeniObje.GetComponent<BoxCollider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
