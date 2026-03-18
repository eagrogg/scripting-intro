using UnityEngine;

public class controlflow : MonoBehaviour
{
    public float num1 = 8;
    public float num2 = 9;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(num1 + num2);
        Debug.Log(num1 - num2);
        Debug.Log(num1 * num2);
        Debug.Log(num1 / num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
