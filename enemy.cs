namespace Program {
    abstract class Enemy {
        public abstract string name { get; }
        public abstract int health { get; set; }
        public abstract int damage { get;}

        public virtual bool calculateDamage(int userDamage) {
               int currentHealth = health - userDamage;

            if (currentHealth > 0) {
                health = currentHealth;
                Console.WriteLine("You did " + userDamage + " damage. Current enemy health: " + this.health);
                return false; 
            }
            if (currentHealth <= 0) {
                Console.WriteLine("You are victorious!");
                return true;
            }
            return false;
        }
    }

    class Ogre : Enemy {
        public override string name { get; } = "Ogre";
        public override int health { get; set; } = 110;
        public override int damage { get; } = 20;
    }

    class OgreMage : Enemy {  
        public override string name { get; } = "Ogre";
        public override int health { get; set; } = 110;
        public override int damage { get; } = 20;
        int magicResistance = 5;

        public override bool calculateDamage(int userDamage) {
            int currentHealth = health - (userDamage - magicResistance);

            if (currentHealth > 0) {
                health = currentHealth;
                Console.WriteLine("You did " + userDamage + " damage. Current enemy health: " + this.health);
                return false; 
            }
            if (currentHealth <= 0) {
                Console.WriteLine("You are victorious!");
                return true;
            }
            return false;
        }
    }
}
 
