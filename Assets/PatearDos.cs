using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatearDos : MonoBehaviour
{
    private Rigidbody2D cuerpoPlat; 
    private float posicionInicialX; 
    private float movimientoFuerza = 0.01f; 
    private float movimientoX = 1f; 
    public float rangoMov; 
    
    void Start()
    {
        cuerpoPlat = GetComponent<Rigidbody2D>();
        posicionInicialX = transform.position.x; 
    }

    void Update()
    {
        movimientoHorizontal();
    }
    public void movimientoHorizontal(){
        Vector2 posicionX = transform.position; 
        posicionX = posicionX + new Vector2(movimientoX, 0f) * movimientoFuerza; 
        Debug.Log(posicionInicialX - posicionX.x);
        if (Mathf.Abs(posicionInicialX - posicionX.x) > rangoMov){
            movimientoFuerza *=-1; 
        }
        
        transform.position = posicionX; 
    }
}
