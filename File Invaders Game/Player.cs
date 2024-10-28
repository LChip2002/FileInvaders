
namespace File_Invaders_Game
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler
                (Player_KeyDown);            
        }

    }
}


