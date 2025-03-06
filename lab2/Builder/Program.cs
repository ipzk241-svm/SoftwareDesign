using Builder.classes;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

CharacterDirector director = new CharacterDirector();
HeroBuilder heroBuilder = new HeroBuilder();
EnemyBuilder enemyBuilder = new EnemyBuilder();

Character basicHero = (Character)director.NoobHero(heroBuilder);
Character proHero = (Character)director.ProHero(heroBuilder);
Character mobEnemy = (Character)director.MobEnemy(enemyBuilder);
Character bossEnemy = (Character)director.BossEnemy(enemyBuilder);

basicHero.DisplayInfo();
proHero.DisplayInfo();
mobEnemy.DisplayInfo();
bossEnemy.DisplayInfo();

Console.WriteLine("\n");

basicHero.Attack(mobEnemy);
bossEnemy.Attack(proHero);
