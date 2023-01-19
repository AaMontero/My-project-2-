using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVictoria : MonoBehaviour
{
    public int id; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(id == 1){
            if(other.tag == "Player"){ 
            Debug.Log("Felicidades Gano"); 
            Impulso.instance.gameObject.SetActive(false); 
            UIScript.instance.gameObject.SetActive(true); 
        }
        }else{
             if(other.tag == "Player"){ 
            Debug.Log("Perdiste"); 
            Impulso.instance.gameObject.SetActive(false);
            UICriptDerrota.instance.gameObject.SetActive(true); 
        }
        }
        
    }
}
