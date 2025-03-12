using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public GameObject button;
    public GameObject huongdan;
    public GameObject content;
    public GameObject credit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                button.SetActive(true);
                huongdan.SetActive(false);
                content.SetActive(false);
                credit.SetActive(false);
                if(button.activeInHierarchy == true)
                    Application.Quit();
 
            }
        }
    }
    public void GamePLay()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void HuongDan()
    {
        button.SetActive(false);
        huongdan.SetActive(true);
        content.SetActive(true); 
    }
    public void back()
    {
        button.SetActive(true);
        huongdan.SetActive(false);
        content.SetActive(false);
        credit.SetActive(false);

    }
    public void Credit()
    {
        button.SetActive(false);
        credit.SetActive(true);
    }
}
