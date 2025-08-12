using UnityEngine;

public class middlescript : MonoBehaviour
{
    public Logicscript Logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision){
        Logic.addScore();
    }
}
