using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICriptDerrota : MonoBehaviour
{
    public static UICriptDerrota instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
         this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void perdio(){
        this.gameObject.SetActive(true); 
    }
}
