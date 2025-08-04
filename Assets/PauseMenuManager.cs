using UnityEngine;
using UnityEngine.SceneManagement; // Sangat penting untuk berpindah scene!

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    private bool isPaused = false;

    void Start()
    {
        // Pastikan menu tidak aktif dan waktu berjalan normal saat mulai
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        // Deteksi tombol Escape untuk membuka/menutup menu jeda
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // Fungsi untuk menjeda permainan
    void PauseGame()
    {
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f; // Menghentikan waktu dalam game
        isPaused = true;
    }

    // Fungsi untuk melanjutkan permainan (dipanggil oleh tombol "Lanjutkan")
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f; // Mengembalikan kecepatan waktu ke normal
        isPaused = false;
    }

    // Fungsi untuk kembali ke Main Menu (dipanggil oleh tombol "Kembali ke Menu")
    public void BackToMainMenu()
    {
        // PENTING: Selalu kembalikan Time.timeScale ke 1 sebelum pindah scene!
        // Jika tidak, scene MainMenu juga akan ikut terjeda.
        Time.timeScale = 1f;
        
        // Memuat scene dengan nama "MainMenu"
        SceneManager.LoadScene("MainMenu");
    }
}