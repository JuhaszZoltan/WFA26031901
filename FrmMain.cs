using System.Text;

namespace WFA26031901;

public partial class FrmMain : Form
{
    const string AllatokTxt = "..\\..\\..\\data\\allatok.txt";

    List<Allat> allatok = [];

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
    }

    private void BtnSzuresClick(object? sender, EventArgs e)
    {
        if (cbxGondozok.Text == "összes...")
        {
            DgvFeltoltese(allatok);
            return;
        }

        var szurtAllatok = allatok.Where(a => a.Gondozo.Nev == cbxGondozok.SelectedItem!.ToString());
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
