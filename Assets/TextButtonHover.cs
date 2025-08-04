using UnityEngine;
using TMPro; // Penting! Kita perlu ini untuk mengakses komponen TextMeshPro
using UnityEngine.EventSystems; // Perlu ini untuk event hover dan click

// Script ini akan kita pasang di setiap objek teks yang ingin jadi tombol
public class TextButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI textMesh;
    public Color normalColor = Color.white;
    public Color hoverColor = Color.yellow;

    void Awake()
    {
        // Ambil komponen TextMeshPro dari objek ini saat game dimulai
        textMesh = GetComponent<TextMeshProUGUI>();
        // Atur warna awal
        textMesh.color = normalColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Fungsi ini dipanggil saat kursor mouse masuk ke area teks
        textMesh.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Fungsi ini dipanggil saat kursor mouse keluar dari area teks
        textMesh.color = normalColor;
    }
}