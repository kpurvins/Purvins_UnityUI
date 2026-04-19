using UnityEngine;
using TMPro;

public class AgeCalculator : MonoBehaviour
{
  public TMP_InputField nameInput;
  public TMP_InputField yearInput;
  public TextMeshProUGUI resultText;

  public void CalculateAge()
  {
    int birthYear = int.Parse(yearInput.text);
    int currentAge = 2026 - birthYear;
    resultText.text = "Character " + nameInput.text + " is " + currentAge + " years old!";
  }
}