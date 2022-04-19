using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentFonksiyonu : MonoBehaviour
{
   BoxCollider Silgi;
    void Start()
    {
        /*
        Silgi = gameObject.GetComponent(typeof(BoxCollider)) as BoxCollider; // objedeki bilesen ile etkilesir
        Silgi.isTrigger = true;
  */
        /*
        Silgi = (BoxCollider)FindObjectOfType(typeof(BoxCollider));
        if(Silgi)
        {
            Silgi.isTrigger = true;   // bu bilesen varmý diye kontrol ettikten sonra 
                                      //verilen komutu yapar.. bilesen yoksa komutu yapmadan gecer
        }
        */
        /*
        gameObject.SetActive(false); //objeyi sahnede pasif hale getirir
        */
        /*
        if (gameObject.activeSelf)
        {
            Debug.Log("obje aktif");      //Objenin aktif olup olmadýgýný kontrol eder
        }
        else
        {
            Debug.Log("obje pasif");
        }
        */
        /*
        gameObject.tag = "dost";    //objeyi baska bir tagýn icine koyar
        */
        /*
        if (gameObject.CompareTag("dost"))
        {
            Debug.Log("taglar ayný");        //Objenin taglarýnýn ayný  olup olmadýgýný kontrol eder
        }
        else
        {
            Debug.Log("taglar farklý");
        }
        */
        /*
        Rigidbody bilesen1 = gameObject.AddComponent<Rigidbody>() as Rigidbody;  //objeye yeni bilesen ekleme
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
