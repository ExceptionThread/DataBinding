using System.ComponentModel;

public class Artikel : INotifyPropertyChanged
{
    private int artikelNr;
    private string bezeichner;
    private double preis;

    public int ArtikelNr
    {
        get => artikelNr;
        set
        {
            artikelNr = value;
            OnPropertyChanged(nameof(ArtikelNr));
        }
    }

    public string Bezeichner
    {
        get => bezeichner;
        set
        {
            bezeichner = value;
            OnPropertyChanged(nameof(Bezeichner));
        }
    }

    public double Preis
    {
        get => preis;
        set
        {
            preis = value;
            OnPropertyChanged(nameof(Preis));
        }
    }

    public Artikel(int artikelNr, string bezeichner, double preis)
    {
        ArtikelNr = artikelNr;
        Bezeichner = bezeichner;
        Preis = preis;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
