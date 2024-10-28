using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Invaders_Game
{
    public class EnemySpawn
    {
        public EnemySpawn() { }

        public void GeneratedEnemies()
        {
            var dir = Directory.GetCurrentDirectory()+"\\TestFolder";

            int x = 0;
            int y = 0;

            foreach (var file in Directory.GetFiles(dir)) 
            {
                var fileInfo = new FileInfo(file);

                Enemy enemy = new Enemy() 
                {
                    Name = fileInfo.Name,
                    StartPosition = FormStartPosition.Manual, 
                    Location = new Point(x,y)

                };

                if (enemy.Location.X > 3000)
                {
                    y += 300;
                    x = 0;
                    enemy.Location = new Point(x,0);
                }

                enemy.Show();

                x += 300;
            }

        }
    }
}
