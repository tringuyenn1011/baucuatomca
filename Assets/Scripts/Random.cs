using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Random : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        StartCoroutine(haha());
    }
    IEnumerator haha()
        {
            
            
                button.interactable = false;
            yield return new WaitForSeconds(30.0f);
    
            button.interactable = true;
        }


    
}
