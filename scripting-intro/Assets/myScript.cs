using UnityEngine;

public class myScript : MonoBehaviour
{
    int myInt = 15;
    float myfloat = 3.2f;
    char mychar = 'e';
    string mystring = "gubernatorial";
    Vector2 myvec2 = new Vector2(-3, 45);
    Vector3 myvec3 = new Vector3(1.2f, 55.0f, 8.1f);
    int[] myarr = { 1, 4, 7, 9, 12 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("variables: ");
        Debug.Log(myInt);
        Debug.Log(myfloat);
        Debug.Log(mychar);
        Debug.Log(mystring);
        Debug.Log(myvec2);
        Debug.Log(myvec3);
        Debug.Log(myarr[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
