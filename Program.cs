namespace Program {
    class Application {
        static void Main(string[] args) {
            MainMenu menu = new MainMenu();
            string klasa = menu.CharacterClass();
            string ime = menu.CharacterName();


            Character player = new Character (klasa, ime);

        }
    }
}