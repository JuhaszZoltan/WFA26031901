using System.Text;

namespace WFA26031901;

public partial class FrmMain : Form
{
    const string AllatokTxt = "..\\..\\..\\data\\allatok.txt";

    List<Allat> allatok = [];

    IEnumerable<Allat> szurtAllatok = null;

    public FrmMain()
    {
        InitializeComponent();
        this.Load += FrmMainLoad;
    }

    private void FrmMainLoad(object? sender, EventArgs e)
    {
        Beolvas();
        DgvFeltoltese(allatok);
        CbxFeltoltes();
        btnSzures.Click += BtnSzuresClick;
        btnOsszes.Click += BtnOsszesClick;
        btnStatisztika.Click += BtnStatisztikaClick;
    }

    private void BtnStatisztikaClick(object? sender, EventArgs e)
    {
        float avgEletkor = 0F;
        if (szurtAllatok is null)
        {
            avgEletkor = allatok.Average(a => a.Eletkor);
        }
        else avgEletkor = szurtAllatok.Average(a => a.Eletkor);

        lblSatisztika.Text = 
            $"állatok száma: {(szurtAllatok is null ? allatok.Count : szurtAllatok.Count())}\n" +
            $"a kijelölt állatok átlagos életkora: {avgEletkor: 0.00} év";
    }

    private void BtnOsszesClick(object? sender, EventArgs e)
    {
        DgvFeltoltese(allatok);
        szurtAllatok = null;
    }

    private void BtnSzuresClick(object? sender, EventArgs e)
    {
        bool minValid = int.TryParse(txtMinKor.Text, out int minKor);
        bool maxValid = int.TryParse(txtMaxKor.Text, out int maxKor);

        if (!minValid || !maxValid)
        {
            _ = MessageBox.Show(
                text: "Az életkor-határérték csak egész szám lehet!",
                icon: MessageBoxIcon.Error,
                buttons: MessageBoxButtons.OK,
                caption: "Hibás bevitel!");
            return;
        }

        szurtAllatok = allatok.Where(
            a => a.Gondozo.Nev == cbxGondozok.SelectedItem!.ToString()
            && a.Eletkor >= minKor && a.Eletkor <= maxKor);

        DgvFeltoltese(szurtAllatok);
    }

    private void CbxFeltoltes()
    {
        cbxGondozok.Items.Add("összes...");

        var gondozok = allatok
            .DistinctBy(a => a.Gondozo.Nev)
            .Select(a => a.Gondozo.Nev);
        foreach (var nev in gondozok) cbxGondozok.Items.Add(nev);
    }

    private void DgvFeltoltese(IEnumerable<Allat> altk)
    {
        dgvAllatok.Rows.Clear();
        foreach (var a in altk)
            dgvAllatok.Rows.Add(a.GetDgvRow());
    }

    private void Beolvas()
    {
        using StreamReader sr = new(AllatokTxt, Encoding.UTF8);
        _ = sr.ReadLine();
        while (!sr.EndOfStream) allatok.Add(new(sr.ReadLine()!));
    }


}
