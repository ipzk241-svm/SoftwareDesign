using Builder.classes;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

HeroBuilder heroBuilder = new HeroBuilder();
EnemyBuilder enemyBuilder = new EnemyBuilder();
CharacterDirector director = new CharacterDirector(heroBuilder);

Character basicHero = (Character)director.NoobHero();
Character proHero = (Character)director.ProHero();
director.ChangeBuilder(enemyBuilder);
Character mobEnemy = (Character)director.MobEnemy();
Character bossEnemy = (Character)director.BossEnemy();

basicHero.DisplayInfo();
proHero.DisplayInfo();
mobEnemy.DisplayInfo();
bossEnemy.DisplayInfo();

Console.WriteLine("\n");

basicHero.Attack(mobEnemy);
bossEnemy.Attack(proHero);
