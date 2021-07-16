using TMPro;
using UnityEngine;

public class TowerSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _sizeView;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.SizeUpdate += OnSizeUpdated;
    }

    private void OnDisable()
    {
        _tower.SizeUpdate -= OnSizeUpdated;
    }

    private void OnSizeUpdated(int size)
    {
        _sizeView.text = size.ToString();
    }
}