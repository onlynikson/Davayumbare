using UnityEngine;

public class Finish : MonoBehaviour
{
    public int LevelsToUnlock;
    int numberOfUnlockedLevels;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelsUnlocked", numberOfUnlockedLevels + 1);
        }
    }
}
