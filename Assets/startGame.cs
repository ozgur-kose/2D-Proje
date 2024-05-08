using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] characters;
    private int selectedCharacterIndex;

    public void Start()
    {
        // Se�ilen karakterin indeksini al�n
        selectedCharacterIndex = PlayerPrefs.GetInt("selectedCharacterIndex", 0);

        // Se�ilen karakterin �rne�ini olu�turun veya etkinle�tirin
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == selectedCharacterIndex)
            {
                characters[i].SetActive(true);
            }
            else
            {
                characters[i].SetActive(false);
            }
        }
    }
}
