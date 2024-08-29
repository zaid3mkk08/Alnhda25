using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WoodCollection : MonoBehaviour
{
  
    
    public int Wood = 0;
    
    public TextMeshProUGUI woodtext;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Wood") 
        {
            Wood++;
            woodtext.text =  Wood.ToString() + " /25";
            
            Destroy(other.gameObject);
        }
    }
   
}
