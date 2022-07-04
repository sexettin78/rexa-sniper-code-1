using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class atesetmetest4 : MonoBehaviour
{
    public Text uyaritext;
     public float hiz = 0.1f;
    public Text mermisayitext;
    public float mermi, sarjor, sarjorsayi, menzil, hasar1, hasar2;
    public bool ates;
    RaycastHit hit;
    int dusmancani = 100;
    float floatzaman;
    int sayac;
    public Text zamantext;
      
    void Start()
    {
        
    }
    

   private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
    
         }
        

    }

    void Update()
    {
        mermisayitext.text = "Kalan Mermi:"+mermi.ToString();


          zamanyazdir();
      //  zamantext.text = "Zaman:" + sayac.ToString() + "sn";
        
        zamantext.text = "Zaman:" + sayac.ToString() + "sn";
        if (sayac == 3)
        {
            uyaritext.gameObject.SetActive(false);
           
        }
        else if (sayac == 10)
        {
            SceneManager.LoadScene(44);
        }
    }

    public void atesevent(){
        if (mermi > 0)
        {
        mermi--;
        ates = true; 
        }
        else
        {
            uyaritext.text = "Merminiz bitti";
        }

    }
       void zamanyazdir()
    {
        floatzaman += Time.deltaTime;
        if (floatzaman > 1)
        {
            sayac++;
            floatzaman = 0;
        }
    }
int ace = 0;
public GameObject skopk;
public void skop(){
           if (ace < 6)
           {
        var pos = skopk.transform.position;
        pos.z += hiz;
        skopk.transform.position = pos;


        var pos3 = skopk.transform.position;
        pos3.y -= 2f;
        skopk.transform.position = pos3;

        ace += 1;
           }

}
//int bsrvurus = 0;
    void FixedUpdate(){
        if (ates)
        {
            ates = false;
            if (Physics.Raycast(Camera.main.transform.position,Camera.main.transform.forward, out hit , menzil))
            {
                if (hit.transform.tag == "dusman")
                {
                   
                   
                        Destroy(hit.transform.gameObject);
                                    PlayerPrefs.SetInt("level", 22);
                        SceneManager.LoadScene(49);
                       
                
                   
                }
            }
        }  
    }




}
