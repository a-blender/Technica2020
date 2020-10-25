using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickhandler : MonoBehaviour
{
    public GameObject myUI, mystuff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clickhandler()
    {
        myUI.SetActive(true);
        mystuff.SetActive(false);
    }
}
