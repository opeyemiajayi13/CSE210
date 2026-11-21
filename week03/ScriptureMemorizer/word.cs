public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Display the word or underscores
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        string hiddenText = "";

        foreach (char character in _text)
        {
            if (char.IsLetter(character))
            {
                hiddenText += "_";
            }
            else
            {
                hiddenText += character;
            }
        }

        return hiddenText;
    }
}