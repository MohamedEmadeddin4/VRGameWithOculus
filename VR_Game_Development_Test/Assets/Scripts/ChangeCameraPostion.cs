using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPostion : MonoBehaviour
{
   
    public GameObject oldpostion;
    
     
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Camera Postion :" + oldpostion.transform.position);
        StartCoroutine(CoroutineChangePostion());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePotionCamera()
    {
        
        oldpostion.transform.position = new Vector3(3484.0f, 121.0f, 574.0f);

    }
    IEnumerator CoroutineChangePostion()
    {
        yield return new WaitForSeconds(3.0f);
        ChangePotionCamera();
        Debug.Log("Camera Changed Postion" + oldpostion.transform.position);
    }
}
