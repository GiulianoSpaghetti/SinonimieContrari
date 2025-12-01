// See https://aka.ms/new-console-template for more information
using Cruciverba;
using SQLite;
using System.Reflection;


public class Diziozionario
{
    private static string cs = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sinonimi.db");
    private static SQLiteConnection con;
    private static string s;
    private static int id;
    private static SQLite.TableQuery<Parola> query;
    private static List<Parola> elementi;


    public static void SetParola()
    {
        s = Console.ReadLine();
        Parola p = new Parola();
        p.parola = s;
        con.Insert(p);
        Console.WriteLine("Parola inserita con id: " + p.Id);

    }


    public static void addSinonimo()
    {
        Console.WriteLine("Inserisci l'id della parola a cui vuoi aggiungere un sinonimo:");
        id = int.Parse(Console.ReadLine());
        query = con.Table<Parola>().Where(x => x.Id == id);
        elementi = query.ToList();
        if (elementi.Count == 0)
        {
            Console.WriteLine("Parola non trovata.");
            return;
        }
        Parola p = elementi[0];
        if (p.sinonimi==null)
        {
            p.sinonimi = new List<int>();
        }
        if (p.sinonimo0>0) p.sinonimi.Add(p.sinonimo0);
        if (p.sinonimo1>0) p.sinonimi.Add(p.sinonimo1);
        if (p.sinonimo2>0) p.sinonimi.Add(p.sinonimo2);
        if (p.sinonimo3>0) p.sinonimi.Add(p.sinonimo3);
        if (p.sinonimo4>0) p.sinonimi.Add(p.sinonimo4);
        if (p.sinonimo5>0) p.sinonimi.Add(p.sinonimo5);
        if (p.sinonimo6>0) p.sinonimi.Add(p.sinonimo6);
        if (p.sinonimo7>0) p.sinonimi.Add(p.sinonimo7);
        if (p.sinonimo8>0) p.sinonimi.Add(p.sinonimo8);
        if (p.sinonimo9>0) p.sinonimi.Add(p.sinonimo9);
        Console.WriteLine("Inserisci l'id del sinonimo da aggiungere:");
        int idSinonimo = int.Parse(Console.ReadLine());
        if (p.sinonimi.Contains(idSinonimo))
        {
            Console.WriteLine("Sinonimo già presente.");
            return;
        }
        p.sinonimi.Add(idSinonimo);
        if ((p.sinonimi.Count > 0)) p.sinonimo0 = p.sinonimi[0];
        if ((p.sinonimi.Count > 1)) p.sinonimo1 = p.sinonimi[1];
        if ((p.sinonimi.Count > 2)) p.sinonimo2 = p.sinonimi[2];
        if ((p.sinonimi.Count > 3)) p.sinonimo3 = p.sinonimi[3];
        if ((p.sinonimi.Count > 4)) p.sinonimo4 = p.sinonimi[4];
        if ((p.sinonimi.Count > 5)) p.sinonimo5 = p.sinonimi[5];
        if ((p.sinonimi.Count > 6)) p.sinonimo6 = p.sinonimi[6];
        if ((p.sinonimi.Count > 7)) p.sinonimo7 = p.sinonimi[7];
        if ((p.sinonimi.Count > 8)) p.sinonimo8 = p.sinonimi[8];
        if ((p.sinonimi.Count > 9)) p.sinonimo9 = p.sinonimi[9];
        p.sinonimi = null;
        con.Update(p);
        Console.WriteLine("Sinonimo aggiunto.");
    }

    public static void addContrario()
    {
        Console.WriteLine("Inserisci l'id della parola a cui vuoi aggiungere un contrario:");
        id = int.Parse(Console.ReadLine());
        query = con.Table<Parola>().Where(x => x.Id == id);
        elementi = query.ToList();
        if (elementi.Count == 0)
        {
            Console.WriteLine("Parola non trovata.");
            return;
        }
        Parola p = elementi[0];
        if (p.contrari==null)
        {
            p.contrari = new List<int>();
        }
        if (p.contrario0>0)
            p.contrari.Add(p.contrario0);
        if (p.contrario1>0)
            p.contrari.Add(p.contrario1);
        if (p.contrario2>0)
            p.contrari.Add(p.contrario2);
        if (p.contrario3>0)
            p.contrari.Add(p.contrario3);
        if (p.contrario4>0)
            p.contrari.Add(p.contrario4);
        if (p.contrario5>0)
            p.contrari.Add(p.contrario5);
        if (p.contrario6>0)
            p.contrari.Add(p.contrario6);
        if (p.contrario7>0)
            p.contrari.Add(p.contrario7);
        if (p.contrario8>0)
            p.contrari.Add(p.contrario8);
        if (p.contrario9>0)
            p.contrari.Add(p.contrario9);
        Console.WriteLine("Inserisci l'id del contrario da aggiungere:");
        int idContrario = int.Parse(Console.ReadLine());
        if (p.contrari.Contains(idContrario))
        {
            Console.WriteLine("Contrario già presente.");
            return;
        }
        p.contrari.Add(idContrario);
        if (p.contrari.Count> 0) p.contrario0 = p.contrari[0];
        if (p.contrari.Count> 1) p.contrario1 = p.contrari[1];
        if (p.contrari.Count> 2) p.contrario2 = p.contrari[2];
        if (p.contrari.Count> 3) p.contrario3 = p.contrari[3];
        if (p.contrari.Count> 4)  p.contrario4 = p.contrari[4];
        if (p.contrari.Count> 5)  p.contrario5 = p.contrari[5];
        if (p.contrari.Count> 6)  p.contrario6 = p.contrari[6];
        if (p.contrari.Count> 7)   p.contrario7 = p.contrari[7];
        if (p.contrari.Count> 8)   p.contrario8 = p.contrari[8];
        if (p.contrari.Count > 9) p.contrario9 = p.contrari[9];
        p.contrari = null;
        con.Update(p);
        Console.WriteLine("Contrario aggiunto.");
    }


    public static void Main(string[] args)
    {
        con = new SQLiteConnection(cs);
        con.CreateTable<Parola>();
        VisualizzaMenu();
        con.Close();
    }

    public static void VisualizzaParole()
    {
        query = con.Table<Parola>();
        elementi = query.ToList();
       if (elementi.Count == 0)
        {
            Console.WriteLine("Nessuna parola trovata.");
            return;
        }
        foreach (Parola p in elementi)
        {
            Console.WriteLine("Id: " + p.Id + " Parola: " + p.parola);
            if (p.sinonimi == null)
            {
                p.sinonimi = new List<int>();
            }
            if (p.sinonimo0 > 0) p.sinonimi.Add(p.sinonimo0);
            if (p.sinonimo1 > 0) p.sinonimi.Add(p.sinonimo1);
            if (p.sinonimo2 > 0) p.sinonimi.Add(p.sinonimo2);
            if (p.sinonimo3 > 0) p.sinonimi.Add(p.sinonimo3);
            if (p.sinonimo4 > 0) p.sinonimi.Add(p.sinonimo4);
            if (p.sinonimo5 > 0) p.sinonimi.Add(p.sinonimo5);
            if (p.sinonimo6 > 0) p.sinonimi.Add(p.sinonimo6);
            if (p.sinonimo7 > 0) p.sinonimi.Add(p.sinonimo7);
            if (p.sinonimo8 > 0) p.sinonimi.Add(p.sinonimo8);
            if (p.sinonimo9 > 0) p.sinonimi.Add(p.sinonimo9);
            if (p.sinonimi==null || p.sinonimi.Count == 0)
            {
                Console.WriteLine("Nessun sinonimo.");
            }
            else
            {
                Console.Write("Sinonimi: ");
                foreach (int idSinonimo in p.sinonimi)
                {
                    Console.Write(idSinonimo + " ");
                }
                Console.WriteLine();
            }
            if (p.contrari == null)
            {
                p.contrari = new List<int>();
            }
            if (p.contrario0 > 0)
                p.contrari.Add(p.contrario0);
            if (p.contrario1 > 0)
                p.contrari.Add(p.contrario1);
            if (p.contrario2 > 0)
                p.contrari.Add(p.contrario2);
            if (p.contrario3 > 0)
                p.contrari.Add(p.contrario3);
            if (p.contrario4 > 0)
                p.contrari.Add(p.contrario4);
            if (p.contrario5 > 0)
                p.contrari.Add(p.contrario5);
            if (p.contrario6 > 0)
                p.contrari.Add(p.contrario6);
            if (p.contrario7 > 0)
                p.contrari.Add(p.contrario7);
            if (p.contrario8 > 0)
                p.contrari.Add(p.contrario8);
            if (p.contrario9 > 0)
                p.contrari.Add(p.contrario9);
            if (p.contrari==null || p.contrari.Count == 0)
            {
                Console.WriteLine("Nessun contrario.");
            }
            else
            {
                Console.Write("Contrari: ");
                foreach (int idContrario in p.contrari)
                {
                    Console.Write(idContrario + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public static void VisualizzaMenu()
    {
        int s;
        string scelta;
        do
        {
            Console.WriteLine("1: Inserisci parola");
            Console.WriteLine("2: Aggiungi sinonimo");
            Console.WriteLine("3: Aggiungi contrario");
            Console.WriteLine("4: Visualizza parole");
            Console.WriteLine("0: Esci");
            Console.Write("Scegli un'opzione: ");
            scelta = Console.ReadLine();
            try
            {
                s = int.Parse(scelta);
            }
            catch (Exception)
            {
                Console.WriteLine("Valore non valido");
                s = 5;
            }
            switch(s)
            {
                case 1:
                    SetParola();
                    break;
                case 2:
                    addSinonimo();
                    break;
                case 3:
                    addContrario();
                    break;
                case 4:
                    VisualizzaParole();
                    break;
                case 0:
                    Console.WriteLine("Uscita in corso...");
                    break;
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
                }
            } while (s >0 && s <5);
    } 
}