using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class hit2 : MonoBehaviour
{
    public Animator hitAnim;
    public VirtualButtonBehaviour vb;
    // Start is called before the first frame update
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        hitAnim.Play("hammer1_hit");
    }
    
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("OnButtonRelease: " + vb.VirtualButtonName);
    }
}
