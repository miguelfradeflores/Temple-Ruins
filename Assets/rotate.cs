using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public Transform player;
    Animator anim;
    public int distancia = 30;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (  Mathf.Sqrt( Mathf.Pow((player.position.x - transform.localPosition.x),2)  + Mathf.Pow(player.position.z - transform.localPosition.z ,2) )< distancia)
        {

            //atacar()


            anim.SetBool("rotar", true );
        }
        else
        {
            //patrullar

            anim.SetBool("rotar", false);
        }

    }
}
