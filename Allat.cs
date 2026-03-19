namespace WFA26031901;

internal class Allat
{
    public int Id { get; set; }
    public string? Nev { get; set; }
    public string Faj { get; set; }
    public float Eletkor { get; set; }
    public Reszleg Reszleg { get; set; }
    public Gondozo Gondozo { get; set; }

    public object[] GetDgvRow() => [Faj, Nev, Eletkor, Reszleg.Nev, Gondozo.Nev];

    public Allat(string sor)
    {
        var v = sor.Split(';');
        Id = int.Parse(v[0]);
        Nev = v[1] == "NULL" ? null : v[1];
        Faj = v[2];
        Eletkor = float.Parse(v[3].Replace('.', ','));
        Reszleg = new()
        {
            Id = int.Parse(v[4]),
            Nev = v[5],
            Meret = int.Parse(v[6]),
        };
        Gondozo = new()
        {
            Id = int.Parse(v[7]),
            Nev = v[8],
            Szakterulet = v[9],
        };
    }
}
