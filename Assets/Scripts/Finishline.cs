using UnityEngine;

public class Finishline : MonoBehaviour
{
    public int leveltoUnlock;
    int numberOfUnlockedLevels;

    

   





    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked");
            
            if(numberOfUnlockedLevels <= leveltoUnlock)
            {
                PlayerPrefs.SetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
            }
        }
    }
}
