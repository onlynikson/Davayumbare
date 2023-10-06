using UnityEngine;
using UnityEngine.SceneManagement;

public class ResoawnScipt : MonoBehaviour
{
    
    
    // Storing Our Checkpoint Here;
    public static Vector2 lastCheckPointPos = new Vector2 (-6,0);

   public void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        
        
    }


}
