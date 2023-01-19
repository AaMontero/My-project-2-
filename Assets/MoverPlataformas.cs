using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlataformas : MonoBehaviour
{
    public int velocidadRotacion ; 
    // Start is called before the first frame update
    void Start()
    {
    }    // Update is called once per frame
    void Update()
    {
        girar();
    }
    public void girar(){
        transform.Rotate(Vector3.forward* velocidadRotacion );   
    }

}
