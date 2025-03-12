using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject nap;
    public GameObject Ob1;
    public GameObject Ob2;
    public GameObject Ob3;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Active()
    {
        
        nap.transform.position = new Vector3(-1.376127e-09f, 5.0f, -2);
        gameObject.SetActive(false);
        if(Ob1.GetComponent<SpriteRenderer>().sprite == Ob2.GetComponent<SpriteRenderer>().sprite || Ob2.GetComponent<SpriteRenderer>().sprite == Ob3.GetComponent<SpriteRenderer>().sprite ||Ob1.GetComponent<SpriteRenderer>().sprite == Ob3.GetComponent<SpriteRenderer>().sprite   /*== Ob3.GetComponent<SpriteRenderer>().sprite*/)
        {
            ps.Play();
        }
    }
}
