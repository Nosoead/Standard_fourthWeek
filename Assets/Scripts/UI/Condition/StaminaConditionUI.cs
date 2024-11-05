using UnityEngine;
using UnityEngine.UI;

//�� ������� PlayerCoditionController���� �޾� �����ݴϴ�.
public class StaminaConditionUI : MonoBehaviour
{
    public Image uiBar;

    public void ApplyUI(float currentValue, float maxValue)
    {
        uiBar.fillAmount = currentValue / maxValue;
    }
}