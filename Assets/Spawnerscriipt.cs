using UnityEngine;

public class Spawnerscriipt : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float Timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer<spawnRate){
            Timer+= Time.deltaTime;        }
            else{
                Instantiate(Pipe, transform.position,transform.rotation);
                Timer = 0;
            }
    }
}
