using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //movementSpeed er en variabel, der bestemmer bev�gelseshastigheden.
    //Vi skriver "public" fordi vi gerne vil kunne tilg� den i Unity Inspector
    //Vi skriver "float" fordi det er et decimaltal
    //"movementSpeed" er det navn, vi har givet vores variabel. Vi kunne ogs� kalde den "speed", "x" eller "Fortnite4Ever"
   

    public float movementSpeed;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int horizontalInput = (Input.GetKey(KeyCode.RightArrow) ? 1 : 0) - (Input.GetKey(KeyCode.LeftArrow) ? 1 : 0);
        int verticalInput = (Input.GetKey(KeyCode.UpArrow) ? 1 : 0) - (Input.GetKey(KeyCode.DownArrow) ? 1 : 0);
        
        var movement = Vector3.Normalize(new(horizontalInput, verticalInput));
        
        transform.Translate(movementSpeed * Time.deltaTime * movement);
    }
}
