using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _enterButton;
    [SerializeField] private Button _mapButton;
    [SerializeField] private TMP_InputField _startNumberEnter;
    [SerializeField] private TMP_InputField _finishNumberEnter;
    [SerializeField] private GameObject _enterPanel;

    [SerializeField] private Move _move;

    private string _startPoint;
    private string _finishPoint;
    private bool _mapIsOpen = false;

    void Start()
    {
        _enterButton.onClick.AddListener(StartMoving);
        _enterButton.onClick.AddListener(ActivatePanel);
        _mapButton.onClick.AddListener(ActivatePanel);
    }

    private void StartMoving()
    {
        _startPoint = _startNumberEnter.text;
        _finishPoint = _finishNumberEnter.text;

        _move.GoingToFinishPoint(_startPoint, _finishPoint);
    }

    private void ActivatePanel()
    {
        _mapIsOpen = !_mapIsOpen;

        _enterPanel.SetActive(_mapIsOpen);

        _startNumberEnter.text = "";
        _finishNumberEnter.text = "";
    }
}
