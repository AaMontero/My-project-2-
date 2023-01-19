using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour


{
    public static Impulso instance; 
    private Rigidbody2D micuerpo; 
    private float movimientoFuerza = 0.01f;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        micuerpo = GetComponent<Rigidbody2D>(); 
        micuerpo.bodyType = RigidbodyType2D.Static; 
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoX = Input.GetAxisRaw("Horizontal"); 
        Vector2 posicionX = transform.position; 
        posicionX = posicionX + new Vector2(movimientoX, 0f) * movimientoFuerza; 
        transform.position = posicionX; 
        if(Input.GetKeyDown(KeyCode.Space)){
         empezarJuego();
        }
    }
    private void empezarJuego() {
        micuerpo.bodyType = RigidbodyType2D.Dynamic;
    }



}
