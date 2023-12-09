using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public Text Pun;
    public int Puntuacion =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void PuntosP(int score)
    {
        Puntuacion = Puntuacion + score;
        
            Pun.text = "Puntuacion:" + Puntuacion;
        
    }
}
