using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Penting untuk mengelola scene!

public class MainMenuManager : MonoBehaviour
{
    // Fungsi ini akan dipanggil oleh tombol "Mulai"
    public void StartGame()
    {
        // Memuat scene dengan nama "Level01"
        // Pastikan nama ini sama persis dengan nama file scene game Anda.
        SceneManager.LoadScene("Level01");
    }

    // Fungsi ini akan dipanggil oleh tombol "Keluar"
    public void QuitGame()
    {
        // Debug.Log untuk memastikan tombol berfungsi di Editor
        Debug.Log("Keluar dari game!");

        // Perintah untuk keluar dari aplikasi
        // Ini hanya akan bekerja di versi game yang sudah di-build, bukan di Editor Unity.
        Application.Quit();
    }
}