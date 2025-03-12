using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public static bool isMuted = true;
    public static AudioSource off;
    public Sprite onSound;
    public Sprite offSound;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        off = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isMuted == false)
            off.mute = true;
        else
            off.mute = false;
    }
    public void changeImage()
    {
        if(button.image.sprite == onSound)
        {
            isMuted = false;
            button.image.sprite = offSound;
        }
        else
        {
            isMuted = true;
            button.image.sprite = onSound;
        } 
            
    }
}
