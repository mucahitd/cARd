using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MultipleVB : MonoBehaviour
{   
    public GameObject directorGO, producerGO, awardsGO;
    
    VirtualButtonBehaviour[] vrb;
    void Start()
    {
        directorGO.SetActive(false);
	    producerGO.SetActive(false);
	    awardsGO.SetActive(false);

        vrb = GetComponentsInChildren<VirtualButtonBehaviour>();

        for(int i = 0; i<vrb.Length; i++)
        {
            vrb[i].RegisterOnButtonPressed(onButtonPressed);
            vrb[i].RegisterOnButtonReleased(onButtonReleased);
        }
    void onButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "DirectorVB")

        {
            directorGO.SetActive(true);
            producerGO.SetActive(false);
            awardsGO.SetActive(false);
        }

        else if(vb.VirtualButtonName == "ProducerVB")

        {
            directorGO.SetActive(false);
            producerGO.SetActive(true);
            awardsGO.SetActive(false);
        }

        else if(vb.VirtualButtonName == "AwardsVB")
        {
            directorGO.SetActive(false);
            producerGO.SetActive(false);
            awardsGO.SetActive(true);
        }
            
        else
        {
            throw new UnityException(vb.VirtualButtonName + "Virtual button not supported");
        }
    }
    void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }
}

}