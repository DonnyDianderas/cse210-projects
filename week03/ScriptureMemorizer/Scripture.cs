class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');//Splits the text into words and converts them into Word objects
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public void RevealRandomWords(int numberToReveal)
    {
        Random random = new Random();
        int revealedCount = 0;

        // Desocultar palabras al azar
        while (revealedCount < numberToReveal)
        {
            int index = random.Next(0, _words.Count);
            if (_words[index].IsHidden())  // Solo desocultar si está oculta
            {
                _words[index].Reveal();
                revealedCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        // Construir el texto para mostrar sin usar métodos complejos
        string result = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            result = result + word.GetDisplayText() + " ";
        }

        // Eliminar el último espacio manualmente
        if (result.EndsWith(" "))
        {
            result = result.Substring(0, result.Length - 1);
        }

        return result;
    }

    public bool IsCompletelyHidden()
    {
        // Verificar si todas las palabras están ocultas
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}


