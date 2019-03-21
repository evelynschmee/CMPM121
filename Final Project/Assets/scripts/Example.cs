using UnityEngine;

public class Example : MonoBehaviour
{
    // Destroy everything that enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Circle")
        {
            Debug.Log("touvh");
            Destroy(other.gameObject);
        }
    }
}



//*using UnityEngine;
/*
public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hi");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("uhhhh");
        if (other.gameObject.tag == "Player" )
        {
            Debug.Log("touvh");
        }
        //ello?
    }


}

*/