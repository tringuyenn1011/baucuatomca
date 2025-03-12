using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fb : MonoBehaviour
{
    public string UrlBao;
    public string UrlTri;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenBaro()
    {
        Application.OpenURL(UrlBao);
    }
    public void OpenTris()
    {
        Application.OpenURL(UrlTri);
    }
}
