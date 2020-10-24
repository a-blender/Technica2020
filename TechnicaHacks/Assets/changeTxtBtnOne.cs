using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class changeTxtBtnOne : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] TextMeshProGUI m_Object;
   // private TextMeshProUGUI button;
    public TextMeshProUGUI txt;
    void Start()
    {
        //  GetComponent<changeTxtBtnOne>().Text = "Scan using AR.";
        // GameObject.Find("changeTxtBtnOne").GetComponentInChildren<Text>().text = "Scan using AR.";
        //changeTxtBtnOne button = GetComponentInChildren<changeTxtBtnOne>();
        // changeTxtBtnOne button = GetComponentInChildren<TextMeshProUGUI>();
        // button.Text = "Scan using AR";
        //  m_Object = GetComponent<TextMeshProUGUI>().text = "Scan using AR.";

        //button = GetComponent<TextMeshProUGUI>();

       txt.text = "Scan using AR.";



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
