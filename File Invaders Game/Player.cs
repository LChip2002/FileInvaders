
using System.CodeDom.Compiler;

namespace File_Invaders_Game
{
    public partial class Player : Form
    {
        public Player()
        {
            EnemySpawn spawn = new EnemySpawn();
            spawn.GeneratedEnemies();

            InitializeComponent();
            this.KeyDown += new KeyEventHandler
                (Player_KeyDown);            
        }

    }
}


