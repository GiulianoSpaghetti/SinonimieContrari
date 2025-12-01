
using Cruciverba;
using ReactiveUI;
using SQLite;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
namespace SinonimieContrari.ViewModels;

public class MainViewModel : ViewModelBase
{
    private Parola p;
    private int _id;
    private string _testo;
    private int _sinonimo0;
    private int _sinonimo1;
    private int _sinonimo2;
    private int _sinonimo3;
    private int _sinonimo4;
    private int _sinonimo5;
    private int _sinonimo6;
    private int _sinonimo7;
    private int _sinonimo8;
    private int _sinonimo9;
    private int _contrario0;
    private int _contrario1;
    private int _contrario2;
    private int _contrario3;
    private int _contrario4;
    private int _contrario5;
    private int _contrario6;
    private int _contrario7;
    private int _contrario8;
    private int _contrario9;
    private int _numero;
    private static string cs = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sinonimi.db");
    private static SQLiteConnection con;
    private static string s;
    private static int id;
    private static SQLite.TableQuery<Parola> query;
    private string _errore;
    public int Numero
    {
        get => _numero;
        set
        {
            this.RaiseAndSetIfChanged(ref _numero, value);
        }
    }
    public string Errore
    {
        get => _errore;
        set
        {
            this.RaiseAndSetIfChanged(ref _errore, value);
        }
    }
    public int Id
    {
        get => _id;
        set
        {
            this.RaiseAndSetIfChanged(ref _id, value);
        }
    }
    public string Testo
    {
        get => _testo; 
        set
        {
            this.RaiseAndSetIfChanged(ref _testo, value);
        }
    }

    public int Sinonimo0
    {
        get => _sinonimo0;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo0, value);
        }
    }
    public int Sinonimo1 {         
        get => _sinonimo1;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo1, value);
        }
    }

    public int Sinonimo2 {         
        get => _sinonimo2;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo2, value);
        }
    }
    public int Sinonimo3 {         
        get => _sinonimo3;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo3, value);
        }
    }
    public int Sinonimo4 {         
        get => _sinonimo4;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo4, value);
        }
    }
    public int Sinonimo5 {         
        get => _sinonimo5;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo5, value);
        }
    }
    public int Sinonimo6 {         
        get => _sinonimo6;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo6, value);
        }
    }
    public int Sinonimo7 {         
        get => _sinonimo7;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo7, value);
        }
    }
    public int Sinonimo8 {         
        get => _sinonimo8;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo8, value);
        }
    }
    public int Sinonimo9 {         
        get => _sinonimo9;
        set
        {
            this.RaiseAndSetIfChanged(ref _sinonimo9, value);
        }
    }
    public int Contrario0 {         
        get => _contrario0;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario0, value);
        }
    }
    public int Contrario1 {         
        get => _contrario1;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario1, value);
        }
    }
    public int Contrario2 {         
        get => _contrario2;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario2, value);
        }
    }
    public int Contrario3 {         
        get => _contrario3;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario3, value);
        }
    }
    public int Contrario4 {         
        get => _contrario4;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario4, value);
        }
    }
    public int Contrario5 {         
        get => _contrario5;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario5, value);
        }
    }
    public int Contrario6 {         
        get => _contrario6;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario6, value);
        }
    }
    public int Contrario7 {         
        get => _contrario7;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario7, value);
        }
    }
    public int Contrario8 {         
        get => _contrario8;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario8, value);
        }
    }
    public int Contrario9 {         
        get => _contrario9;
        set
        {
            this.RaiseAndSetIfChanged(ref _contrario9, value);
        }
    }

    public MainViewModel()
    {
        con = new SQLiteConnection(cs);
        con.CreateTable<Parola>();
        Numero=con.Table<Parola>().Count();
    }
    public void InserisciParola()
    {
        Parola p = new Parola();
        p.parola = Testo;
        p.contrario0 = Contrario0;
        p.contrario1 = Contrario1;
        p.contrario2 = Contrario2;
        p.contrario3 = Contrario3;
        p.contrario4 = Contrario4;
        p.contrario5 = Contrario5;
        p.contrario6 = Contrario6;
        p.contrario7 = Contrario7;
        p.contrario8 = Contrario8;
        p.contrario9 = Contrario9;
        p.sinonimo0 = Sinonimo0;
        p.sinonimo1 = Sinonimo1;
        p.sinonimo2 = Sinonimo2;
        p.sinonimo3 = Sinonimo3;
        p.sinonimo4 = Sinonimo4;
        p.sinonimo5 = Sinonimo5;
        p.sinonimo6 = Sinonimo6;
        p.sinonimo7 = Sinonimo7;
        p.sinonimo8 = Sinonimo8;
        p.sinonimo9 = Sinonimo9;
        con.Insert(p);
        Numero = con.Table<Parola>().Count();
    }

    public void GetParola()
    {
        query = con.Table<Parola>().Where(x => x.Id == _id);
        p = query.FirstOrDefault();
        try
        {
            Testo = p.parola;
            Contrario0 = p.contrario0;
            Contrario1 = p.contrario1;
            Contrario2 = p.contrario2;
            Contrario3 = p.contrario3;
            Contrario4 = p.contrario4;
            Contrario5 = p.contrario5;
            Contrario6 = p.contrario6;
            Contrario7 = p.contrario7;
            Contrario8 = p.contrario8;
            Contrario9 = p.contrario9;
            Sinonimo0 = p.sinonimo0;
            Sinonimo1 = p.sinonimo1;
            Sinonimo2 = p.sinonimo2;
            Sinonimo3 = p.sinonimo3;
            Sinonimo4 = p.sinonimo4;
            Sinonimo5 = p.sinonimo5;
            Sinonimo6 = p.sinonimo6;
            Sinonimo7 = p.sinonimo7;
            Sinonimo8 = p.sinonimo8;
            Sinonimo9 = p.sinonimo9;
        }
        catch (NullReferenceException ex)
        {
            Errore = ex.Message;
        }
    }

    public void ModificaParola()
    {
        Parola p = new Parola();
        p.Id = _id;
        p.parola = Testo;
        p.contrario0 = Contrario0;
        p.contrario1 = Contrario1;
        p.contrario2 = Contrario2;
        p.contrario3 = Contrario3;
        p.contrario4 = Contrario4;
        p.contrario5 = Contrario5;
        p.contrario6 = Contrario6;
        p.contrario7 = Contrario7;
        p.contrario8 = Contrario8;
        p.contrario9 = Contrario9;
        p.sinonimo0 = Sinonimo0;
        p.sinonimo1 = Sinonimo1;
        p.sinonimo2 = Sinonimo2;
        p.sinonimo3 = Sinonimo3;
        p.sinonimo4 = Sinonimo4;
        p.sinonimo5 = Sinonimo5;
        p.sinonimo6 = Sinonimo6;
        p.sinonimo7 = Sinonimo7;
        p.sinonimo8 = Sinonimo8;
        p.sinonimo9 = Sinonimo9;
        con.Update(p);
    }

    public void EliminaParola()
    {
        Parola p = new Parola();
        p.Id = _id;
        con.Delete<Parola>(p.Id);
        Numero = con.Table<Parola>().Count();
    }
}
