using UnityEngine;

public class myScript : MonoBehaviour
{
    public int myInt = 403;
    public float myfloat = 3.2f;
    public char mychar = 'e';
    public string mystring = "gubernatorial";
    private Vector2 myvec2 = new Vector2(-3, 45);
    public Vector3 myvec3 = new Vector3(1.2f, 55.0f, 8.1f);
    public int[] myarr = { 1, 4, 7, 9, 12 };


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Add(myInt, 63));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
