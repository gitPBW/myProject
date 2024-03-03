using UnityEngine;

public class Sample : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    //int num = 0;

    private void Awake()
    {
        //Debug.Log("Awake : Sample ������Ʈ ");

        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start : Sample ������Ʈ ");
        //num = 5;
        //print(num);
    }

    private void OnEnable()
    {
        //Debug.Log("Enable : Sample ������Ʈ ");
        //spriteRenderer.color = Color.blue;
        //print(num);
    }

    private void OnDisable()
    {
        //Debug.Log("Disable : Sample ������Ʈ ");
        spriteRenderer.color = Color.white;
        //num = 10;
        //print(num);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update : Sample ������Ʈ ");
        //print(num);
    }

    private void OnDestroy()
    {
        //Debug.Log("OnDestroy : Sample ������Ʈ ");
    }
}
