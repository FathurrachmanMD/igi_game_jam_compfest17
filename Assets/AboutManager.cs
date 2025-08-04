using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutSceneManager : MonoBehaviour
{
    // Fungsi ini akan dipanggil oleh tombol "Kembali"
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}