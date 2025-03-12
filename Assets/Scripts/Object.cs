using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    public Sprite[] Pic;
    public static int gioihan;
    public Button openButton;
    public Button buttonx10;
    public Button buttonx3;
    public Button buttonx5;
    public Button buttonx1;
    public GameObject napdong;
    public AudioSource xoc;
    public ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        Sound.isMuted = true;
        napdong.transform.position = new Vector3(-1.376127e-09f, 4.5f, -2);
        buttonx10 = GameObject.Find("x10").GetComponent<Button>();
        buttonx3 = GameObject.Find("x3").GetComponent<Button>();
        buttonx5 = GameObject.Find("x5").GetComponent<Button>();
        buttonx1 = GameObject.Find("x1").GetComponent<Button>();
        RandomAnimal();
    }

    // Update is called once per frame
    void Update()
    {
        if(Sound.isMuted == false)
            xoc.mute = true;
        else
            xoc.mute = false;
    }
    public void RandomAnimal()
    {
        GetComponent<SpriteRenderer>().sprite = Pic[UnityEngine.Random.Range(0, Pic.Length)];
    }
    public void Randomx3Animal()
    {
        
        xoc.Play();
        napdong.transform.position = new Vector3(-1.376127e-09f, 0.4f, -2);
        StartCoroutine(Time(3));
        buttonx10.interactable = false;
        buttonx3.interactable = false;
        buttonx5.interactable = false;
        buttonx1.interactable = false;
        ps.Stop();
        
    } 
    public void Randomx5Animal()
    {
        xoc.Play();
        napdong.transform.position = new Vector3(-1.376127e-09f, 0.4f, -2);
        StartCoroutine(Time(5));
        buttonx10.interactable = false;
        buttonx3.interactable = false;
        buttonx5.interactable = false;
        buttonx1.interactable = false;
        ps.Stop();
        
    }  
    public void Randomx10Animal()
    {  
        xoc.Play();
        napdong.transform.position = new Vector3(-1.376127e-09f, 0.4f, -2);
        StartCoroutine(Time(10));
        buttonx10.interactable = false;
        buttonx3.interactable = false;
        buttonx5.interactable = false;
        buttonx1.interactable = false;
        ps.Stop();
        
    } 
    
    IEnumerator Time(int gioihan)
    {
        yield return new WaitForSeconds(2);
        
        for(int dem = 1; dem <= gioihan; dem++)
        {
            RandomAnimal();
            yield return new WaitForSeconds(0.2f);
        }
        openButton.gameObject.SetActive(true); 
        xoc.Stop();
    }
    public void Mo()
    {
        buttonx10.interactable = true;
        buttonx3.interactable = true;
        buttonx5.interactable = true;
        buttonx1.interactable = true;
    }
}
