using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFonksiyonları : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        Destroy(gameObject);//objeyi siler
        Destroy(gameObject,20f);//objeyi 20 süre sonra siler
        */
        //  Destroy(this,5f);// 5f saniye sonra scrip dosyası objeden cıkar
        Destroy(GetComponent<Rigidbody>(), 5f);//bileşsen silme
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
