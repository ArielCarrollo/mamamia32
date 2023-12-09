using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREa : MonoBehaviour
{
    public GameObject CerdoP;
    public Puntos GameManager;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Crear", 3);
    }

    // Update is called once per frame
 

    void Crear()
    {
        GameObject Cerdos= Instantiate(CerdoP, new Vector3(Random.Range(-9, 9), 3.37f, 0), transform.rotation);
        Cerdos.GetComponent<Cerdo>().GameManager = GameManager;
        Invoke("Crear", 3);
    }
}
