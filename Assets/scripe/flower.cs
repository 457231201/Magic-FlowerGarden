using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower : MonoBehaviour
{
    public GameObject flower1;
    public GameObject flower2;
    public GameObject bazhang;
    int timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void OnMouseDown()
    {
        
        if (timer % 2==0)
        {
            Instantiate(flower1,bazhang. transform.position, bazhang.transform.rotation);
            timer+=1;
        }
        else
        {
            Instantiate(flower2, bazhang.transform.position, bazhang.transform.rotation);
            timer+=1;
        }
        {
            
        }
    }
}
