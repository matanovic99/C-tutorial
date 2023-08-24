namespace Program {
    class BattleManager {

        public void startBattle(Character player) {
            bool running = true;
            Ogre ogre = new Ogre();
            OgreMage ogreMage = new OgreMage();

            do {
                Console.WriteLine("Battle started!\n");
                Console.WriteLine("******************************\n");

                Console.WriteLine("Wild Ogre appears!");
                bool isDefeated = ogre.calculateDamage(player.strenght);

                running = !isDefeated;
            } while (running);

            running = true;
            do {
                Console.WriteLine("Battle started!\n");
                Console.WriteLine("******************************\n");

                Console.WriteLine("Wild Ogre Mage appears!");
                bool isDefeated = ogreMage.calculateDamage(player.strenght);

                running = !isDefeated;
            } while (running);
        }
    }
}