Console.OutputEncoding = System.Text.Encoding.UTF8;

string [] tvrtka = new string [] {"Rockstar", "Micrsoft Studios", "Ubisoft"};

Game user = new Game("Red Dead Redemption", "Western", 2018,false, tvrtka [0]);
Game user2 = new Game("Sea of Thieves", "Adventure", 2018, true, tvrtka [1]);
Game user3 = new Game("God of War Ragnarok", "Adventure", 2022, false, tvrtka [2]);

Console.WriteLine("ime i žanr: {0} {1}", user.ime, user.žanr );
Console.WriteLine("Godina: {0}", user.godina);
Console.WriteLine("Platforma : {0}", user.platforma ? "Xbox" : "PS");
Console.WriteLine("Tvrtka: {0}", user.tvrtka);

Console.WriteLine("ime i žanr: {0} {1}", user2.ime, user2.žanr );
Console.WriteLine("Godina: {0}", user2.godina);
Console.WriteLine("Platforma : {0}", user2.platforma ? "Xbox" : "PS");
Console.WriteLine("Tvrtka: {0}", user2.tvrtka);

Console.WriteLine("ime i žanr: {0} {1}", user3.ime, user3.žanr );
Console.WriteLine("Godina: {0}", user3.godina);
Console.WriteLine("Platforma : {0}", user3.platforma ? "Xbox" : "PS");
Console.WriteLine("Tvrtka: {0}", user3.tvrtka);

class Game {
    public string ime;
    public string žanr;
    public int godina;
    public bool platforma;
    public string tvrtka;

    public Game(string ime, string žanr, int godina, bool platforma, string tvrtka) {
        this.ime = ime;
        this.žanr = žanr;
        this.godina = godina;
        this.platforma = platforma;
        this.tvrtka = tvrtka;
    }
}