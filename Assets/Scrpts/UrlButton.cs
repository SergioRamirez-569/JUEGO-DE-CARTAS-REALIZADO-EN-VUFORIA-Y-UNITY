using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlButton : MonoBehaviour
{

    public string url;
    // Start is called before the first frame update
    public void Open()
    {
        Application.OpenURL(url);
    }
}
