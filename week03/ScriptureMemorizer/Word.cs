class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Reveal()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenText = "";
            foreach (char c in _text) //This places an underscore "_" for each letter of the text
            {
                hiddenText += "_";
            }
            return hiddenText;
        }
        else
        {
            return _text;
        }
    }
}


