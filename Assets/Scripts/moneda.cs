using UnityEngine;

public class moneda : MonoBehaviour
{
    public menus menusScript;

    private float speed = 80f;

    private void OnTriggerEnter(Collider other)
    {
        menusScript.Victoria();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
