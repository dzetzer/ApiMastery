using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiMastery.Models;

namespace ApiMastery
{
    public class DataContext : DbContext
    {
        public DbSet<Series> Series { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ApiMastery;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Series>().HasData(
                new Series()
                {
                    SeriesId = 1,
                    Name = "Halo"
                },
                new Series()
                {
                    SeriesId = 2,
                    Name = "BioShock"
                },
                new Series()
                {
                    SeriesId = 3,
                    Name = "Kingdom Hearts"
                },
                new Series()
                {
                    SeriesId = 4,
                    Name = "Batman: Arkham"
                });
            modelBuilder.Entity<Game>().HasData(
                new Game()
                {
                    GameId = 1,
                    Name = "Halo: Combat Evolved",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 2,
                    Name = "Halo 2",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 3,
                    Name = "Halo 3",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 4,
                    Name = "Halo Wars",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 5,
                    Name = "Halo 3: ODST",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 6,
                    Name = "Halo: Reach",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 7,
                    Name = "Halo: Combat Evolved Anniversary",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 8,
                    Name = "Halo 4",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 9,
                    Name = "Halo: Spartan Assault",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 10,
                    Name = "Halo: The Master Chief Collection",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 11,
                    Name = "Halo: Spartan Strike",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 12,
                    Name = "Halo 5: Guardians",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 13,
                    Name = "Halo Wars 2",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 14,
                    Name = "Halo: Fireteam Raven",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 15,
                    Name = "Halo Infinite",
                    SeriesId = 1
                },
                new Game()
                {
                    GameId = 16,
                    Name = "BioShock",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 17,
                    Name = "BioShock: Challenge Rooms",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 18,
                    Name = "BioShock 2",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 19,
                    Name = "BioShock 2: Minerva's Den",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 20,
                    Name = "BioShock: Industrial Revolution",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 21,
                    Name = "BioShock Infinite",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 22,
                    Name = "BioShock Infinite: Burial at Sea Part I",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 23,
                    Name = "BioShock Infinite: Burial at Sea Part II",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 24,
                    Name = "BioShock: The Collection",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 25,
                    Name = "Parkside (TBD)",
                    SeriesId = 2
                },
                new Game()
                {
                    GameId = 26,
                    Name = "Kingdom Hearts",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 27,
                    Name = "Chain of Memories",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 28,
                    Name = "Kingdom Hearts II",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 29,
                    Name = "Re:Chain of Memories",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 30,
                    Name = "KH: Coded",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 31,
                    Name = "358/2 Days",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 32,
                    Name = "Birth by Sleep",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 33,
                    Name = "Re:coded",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 34,
                    Name = "Dream Drop Distance",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 35,
                    Name = "1.5 Remix",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 36,
                    Name = "KH: X",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 37,
                    Name = "2.5 Remix",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 38,
                    Name = "Unchained χ",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 39,
                    Name = "2.8 Final Chapter Prologue",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 40,
                    Name = "Kingdom Hearts III",
                    SeriesId = 3
                },
                new Game()
                {
                    GameId = 41,
                    Name = "Arkham Asylum",
                    SeriesId = 4
                },
                new Game()
                {
                    GameId = 42,
                    Name = "Arkham City",
                    SeriesId = 4
                },
                new Game()
                {
                    GameId = 43,
                    Name = "Arkham City Lockdown",
                    SeriesId = 4
                },
                new Game()
                {
                    GameId = 44,
                    Name = "Arkham Origins",
                    SeriesId = 4
                },
                new Game()
                {
                    GameId = 45,
                    Name = "Arkham Origins Blackgate",
                    SeriesId = 4
                },
                new Game()
                {
                    GameId = 46,
                    Name = "Arkham Knight",
                    SeriesId = 4
                });
            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    CommentId = 1,
                    Title = "Combat Evolved",
                    Body = "This immersive sci-fi epic delivers both an expansive story and electrifying first-person combat, making it one of 2001's best games.",
                    GameId = 1
                },
                new Comment()
                {
                    CommentId = 2,
                    Title = "Awesome Game",
                    Body = "The original Halo is definitely something to play on Xbox! Learn how the franchise began and see the coolest hero in gaming history: Spartan 117-The Master Chief! Yes, Halo Combat Evolved is a true original.",
                    GameId = 1
                },
                new Comment()
                {
                    CommentId = 3,
                    Title = "Awesome Game",
                    Body = "Probably my favorite war shooter multiplayer game. Had so much fun with this one. One of the best multiplayers ever.",
                    GameId = 2
                },
                new Comment()
                {
                    CommentId = 4,
                    Title = "Awesome Game",
                    Body = "A fantastic example of pure artistic vision coupled with serious technological know-how.",
                    GameId = 2
                },
                new Comment()
                {
                    CommentId = 5,
                    Title = "Cool Game",
                    Body = "It's solid gameplay, immense replayability, online functionality and incredible production values will ensure its place in video game history, and it is, without a doubt, a satisfying and fulfilling close to the beloved trilogy.",
                    GameId = 3
                },
                new Comment()
                {
                    CommentId = 6,
                    Title = "Awesome Game",
                    Body = "In substance it's nothing new, merely a magnificent, beautiful monster of an FPS sequel. In concept and execution, though, Halo 3 is the future",
                    GameId = 3
                },
                new Comment()
                {
                    CommentId = 7,
                    Title = "Cool Game",
                    Body = "Purists and veterans will probably dismiss Halo Wars due to its lack of depth, but Halo fans and the uninitiated should jump right in. It's probably the strongest RTS game that's ever been released for a console, and as an entry point into the genre, it's pretty much unbeatable.",
                    GameId = 4
                },
                new Comment()
                {
                    CommentId = 8,
                    Title = "Awesome Game",
                    Body = "This is a fun game..LIGHT RTS but fun in action. I wonder if it would have gotten better critic scores had it not been part of the Halo Franchise? More Multiplayer Options would have bumped my score. Bottom line is that the game is fun.",
                    GameId = 4
                },
                new Comment()
                {
                    CommentId = 9,
                    Title = "Cool Game",
                    Body = "Halo expands focusing on the smallest things, with new gameplay and the same excellence we are used to.",
                    GameId = 5
                },
                new Comment()
                {
                    CommentId = 10,
                    Title = "Awesome Game",
                    Body = "Whether you're looking to go it alone, check out Halo 3's full suite of multiplayer options, or just see how long you and your buddies can keep the Grim Reaper at bay in Firefight, ODST has something for everyone.",
                    GameId = 5
                },
                new Comment()
                {
                    CommentId = 11,
                    Title = "Cool Game",
                    Body = "Halo: Reach is without doubt Bungie's finest Halo game, and best of all it has the story and structure to the campaign to finally deliver the Halo experience that some of us have been waiting for since the original Halo: Combat Evolved launched on Xbox back in 2002.",
                    GameId = 6
                },
                new Comment()
                {
                    CommentId = 12,
                    Title = "Awesome Game",
                    Body = "ODST could have been a clever little shimmy, but it came out a misstep. Reach brings us right back into the dance that hooked us nine years ago, introduces some cool new steps, and leaves us twirling in enchantment as Bungie graciously bows out. Just keep twirling, Spartan.",
                    GameId = 6
                },
                new Comment()
                {
                    CommentId = 13,
                    Title = "Cool Game",
                    Body = "They could have easily just threw on a fresh coat of paint on it and called it an HD remake like a lot of other titles, but 343 has more respect for Bungie, Halo and the fans than that. They have added a ton of new features well worth the $40 price tag.",
                    GameId = 7
                },
                new Comment()
                {
                    CommentId = 14,
                    Title = "Awesome Game",
                    Body = "Halo: Combat Evolved Anniversary is more than just a simple high defintion remake. The game is running on two engines, the original CE one and a new one. It's a great way to show the progress that has been made in ten years. In spite of some technical errors and the absence of many original multiplayer maps, 343 shows that it has the power to create next year's Halo 4.",
                    GameId = 7
                },
                new Comment()
                {
                    CommentId = 15,
                    Title = "Cool Game",
                    Body = "If you're a Halo fan, you've probably already pre-ordered and purchased this game and thankfully the game more than lived up to its hype. Even if you have never played a Halo game before, it's still one of the best first person shooters on any console.",
                    GameId = 8
                },
                new Comment()
                {
                    CommentId = 16,
                    Title = "Awesome Game",
                    Body = "This is THE best Halo game yet, and although the campaign in short, there's an abundance of content to keep Halo 4 in your disc tray.",
                    GameId = 8
                },
                new Comment()
                {
                    CommentId = 17,
                    Title = "Cool Game",
                    Body = "Halo: Spartan Assault brings the Halo universe once again back on the Xbox 360, but in a different way as you are used to see the franchise. This top-down shooter is an enjoyable journey through the world of the Spartans. However, it is a very short adventure. Too short in our opinion.",
                    GameId = 9
                },
                new Comment()
                {
                    CommentId = 18,
                    Title = "Awesome Game",
                    Body = "Much like Halo Wars before it, this game fills in some of the gaps in the Halo story while experimenting with a new gameplay style. While Halo Wars was a RTS, this is a twin-stick shooter, and a darn good one at that. It feels like a steal for just $9.99",
                    GameId = 9
                },
                new Comment()
                {
                    CommentId = 19,
                    Title = "Cool Game",
                    Body = "There's more love and care lavished on The Master Chief Collection than you see in countless other big-money, brand new blockbuster releases. The fact that the games themselves are fantastic fun online and off is the cherry on the icing.",
                    GameId = 10
                },
                new Comment()
                {
                    CommentId = 20,
                    Title = "Awesome Game",
                    Body = "Halo: The Master Chief Collection really sets the standard for all future re-release game collections.",
                    GameId = 10
                },
                new Comment()
                {
                    CommentId = 21,
                    Title = "Cool Game",
                    Body = "A gorgeous, surprisingly deep shooter that sucks you back into Halo's universe. Fun and flashy in all the right ways.",
                    GameId = 11
                },
                new Comment()
                {
                    CommentId = 22,
                    Title = "Awesome Game",
                    Body = "Halo: Spartan Strike combines the look and feel of a classic Halo game with the mechanics of a solid dual stick shooter.",
                    GameId = 11
                },
                new Comment()
                {
                    CommentId = 23,
                    Title = "Cool Game",
                    Body = "Developers from 343 Industries have finally caught the right way and with the fifth part they fixed the mistakes which they made in the previous installment. So they provide the players with an absolutely perfect and catchy campaign",
                    GameId = 12
                },
                new Comment()
                {
                    CommentId = 24,
                    Title = "Awesome Game",
                    Body = "Although the story feels less of an event, Halo 4's campaign is a thoroughly satisfying spectacle. ",
                    GameId = 12
                },
                new Comment()
                {
                    CommentId = 25,
                    Title = "Cool Game",
                    Body = "At the end of the day, however, it’s the multiplayer and gameplay that make or break an RTS game, and Halo Wars 2 checks those boxes. If you’ve ever had the itch to command an army of UNSC soldiers, Halo Wars 2 will easily scratch it.",
                    GameId = 13
                },
                new Comment()
                {
                    CommentId = 26,
                    Title = "Awesome Game",
                    Body = "Halo Wars 2 is still a highly recommendable title — in fact, likely one of the best RTS games that can be found on the current generation. However, accessibility on consoles came with a price to both controls and gameplay in both campaign and multiplayer modes.",
                    GameId = 13
                },
                new Comment()
                {
                    CommentId = 27,
                    Title = "Cool Game",
                    Body = "This game is crazy fun! Played it at an arcade with friends and we had a blast. Every time we saw Iron chef we would all scream CHIEF SIR, I recommend this game for anyone who wants to have fun with friends.",
                    GameId = 14
                },
                new Comment()
                {
                    CommentId = 28,
                    Title = "Awesome Game",
                    Body = "A quality game to play with friends!",
                    GameId = 14
                },
                new Comment()
                {
                    CommentId = 29,
                    Title = "Cool Game",
                    Body = "Can't Wait!!!",
                    GameId = 15
                },
                new Comment()
                {
                    CommentId = 30,
                    Title = "Awesome Game",
                    Body = "Looks Promising",
                    GameId = 15
                },
                new Comment()
                {
                    CommentId = 31,
                    Title = "Cool Game",
                    Body = "BioShock is on the same par as those great classic films that have won awards for years and this one will for the video game industry. The combination of a great story and fantastic gameplay with wonderful scenery has been so well created into an all around well crafted game that it would be a shame to miss out on playing it.",
                    GameId = 16
                },
                new Comment()
                {
                    CommentId = 32,
                    Title = "Awesome Game",
                    Body = "The first-person shooter is, simply, one of the best games ever made. ",
                    GameId = 16
                },
                new Comment()
                {
                    CommentId = 33,
                    Title = "Cool Game",
                    Body = "The Challenge rooms are quite enjoyable, but are almost over too quickly.",
                    GameId = 17
                },
                new Comment()
                {
                    CommentId = 34,
                    Title = "Awesome Game",
                    Body = "Fun to play",
                    GameId = 17
                },
                new Comment()
                {
                    CommentId = 35,
                    Title = "Cool Game",
                    Body = "The weapons are better. The plasmids are better. The enemies are better. At some points, even the storytelling is better. What’s most amazing and surprising about BioShock 2, however, is that by diving deeper into Rapture’s tortured history and exploring more of Rapture’s haunted world, it actually manages to make the original BioShock better, too.",
                    GameId = 18
                },
                new Comment()
                {
                    CommentId = 36,
                    Title = "Awesome Game",
                    Body = "Maybe Bioshock 2 is not as emotionally engaging as its first iteration, but at same time retains the main virtues of its predecessor. A game that shows the maturity that the First Person Shooter has achieved in this generation.",
                    GameId = 18
                },
                new Comment()
                {
                    CommentId = 37,
                    Title = "Cool Game",
                    Body = "A satisfying self-contained chapter, driven by an engrossing story, with exploration encouraged. Plus flying laser robots.",
                    GameId = 19
                },
                new Comment()
                {
                    CommentId = 38,
                    Title = "Awesome Game",
                    Body = "Some refreshing of the game's major mechanics or pacing could have spliced this DLC to the next level, but unfortunately its repetitive nature holds it back. If you are a sucker for Rapture lore, then Minerva's Den may yet be worth the $10.",
                    GameId = 19
                },
                new Comment()
                {
                    CommentId = 39,
                    Title = "Cool Game",
                    Body = "I had an amazing time with this game. I absolutely loved the game despite not playing any other game in the bio shock series",
                    GameId = 20
                },
                new Comment()
                {
                    CommentId = 40,
                    Title = "Awesome Game",
                    Body = "It's a masterpiece in story telling You have to play it to experience it",
                    GameId = 20
                },
                new Comment()
                {
                    CommentId = 41,
                    Title = "Cool Game",
                    Body = "Great music. Great Game. Great story. Great plot. Great DLC. Great atmosphere. Great connection to the first Bioshock.",
                    GameId = 21
                },
                new Comment()
                {
                    CommentId = 42,
                    Title = "Awesome Game",
                    Body = "With the release of BioShock Infinite, developer Irrational has delivered a bigger story, more polished experience, and created two similar-yet-separate games that can co-exist and remain equal in quality. When the history of videogames is written, not one, but two BioShocks will be remembered for pushing gameplay, story, and subject matter to new levels.",
                    GameId = 21
                },
                new Comment()
                {
                    CommentId = 43,
                    Title = "Cool Game",
                    Body = "BURIAL AT SEA TIES THE INFINITE WORLD OF BIOSHOCK TOGETHER IN INTERESTING WAYS",
                    GameId = 22
                },
                new Comment()
                {
                    CommentId = 44,
                    Title = "Awesome Game",
                    Body = "STEALTH IS A SURPRISINGLY ENJOYABLE COUNTERPOINT TO THE LARGE-SCALE MASSACRES OF INFINITE",
                    GameId = 22
                },
                new Comment()
                {
                    CommentId = 45,
                    Title = "Cool Game",
                    Body = "Burial at Sea Episode Two too often feels like well-made fan fiction",
                    GameId = 23
                },
                new Comment()
                {
                    CommentId = 46,
                    Title = "Awesome Game",
                    Body = "Burial At Sea's second episode is lovely to look at and sports some surprisingly enjoyable sneaky combat, but both are used to tell a story that, without flowcharts and some seriously generous apologetics, is convoluted to migraine-inducing degrees.",
                    GameId = 23
                },
                new Comment()
                {
                    CommentId = 47,
                    Title = "Cool Game",
                    Body = "The story telling, unique environments, gameplay and amount of content included makes Bioshock The Collection a must buy.",
                    GameId = 24
                },
                new Comment()
                {
                    CommentId = 48,
                    Title = "Awesome Game",
                    Body = "The Bioshock Collection is the perfect way to revisit this amazing franchise in glorious FULL HD graphics.",
                    GameId = 24
                },
                new Comment()
                {
                    CommentId = 49,
                    Title = "Cool Game",
                    Body = "Can't Wait!!!",
                    GameId = 25
                },
                new Comment()
                {
                    CommentId = 50,
                    Title = "Awesome Game",
                    Body = "Looks Promising",
                    GameId = 25
                },
                new Comment()
                {
                    CommentId = 51,
                    Title = "Cool Game",
                    Body = "You’ll be hard pressed to find another game that even comes close to matching the quality found in Kingdom Hearts. Games just don’t come as beautiful and well thought out as this, it’s a virtual masterpiece that excels in every way possible.",
                    GameId = 26
                },
                new Comment()
                {
                    CommentId = 52,
                    Title = "Awesome Game",
                    Body = "I really don’t think anyone else could have woven as complex and enthralling a story into such enjoyable gameplay and kept it as true to both Square and especially Disney fans.",
                    GameId = 26
                },
                new Comment()
                {
                    CommentId = 53,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts Re: Chain of Memories for the PS2 is definitely worth checking out, especially if you haven't yet played the GBA original.",
                    GameId = 27
                },
                new Comment()
                {
                    CommentId = 54,
                    Title = "Awesome Game",
                    Body = "An impressive remake that improves the presentation of the original GBA version by leaps and bounds while simultaneously streamlining the battle system.",
                    GameId = 27
                },
                new Comment()
                {
                    CommentId = 55,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts II, I am relieved to say, delivers on everything the series' potential hinted at.",
                    GameId = 28
                },
                new Comment()
                {
                    CommentId = 56,
                    Title = "Awesome Game",
                    Body = "A game well worth playing. It lasts much longer than any game should have to, squeezing out new experiences wherever possible.",
                    GameId = 28
                },
                new Comment()
                {
                    CommentId = 57,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts Re: Chain of Memories for the PS2 is definitely worth checking out, especially if you haven't yet played the GBA original.",
                    GameId = 29
                },
                new Comment()
                {
                    CommentId = 58,
                    Title = "Awesome Game",
                    Body = "An impressive remake that improves the presentation of the original GBA version by leaps and bounds while simultaneously streamlining the battle system.",
                    GameId = 29
                },
                new Comment()
                {
                    CommentId = 59,
                    Title = "Cool Game",
                    Body = "If you're looking for a game that's filled with breezy fun, excellent graphics, solid characters, and all the worlds of Disney in the palm of your hand with a lot of The Matrix thrown in for good measure, then Kingdom Hearts: Coded should absolutely be in your collection.",
                    GameId = 30
                },
                new Comment()
                {
                    CommentId = 60,
                    Title = "Awesome Game",
                    Body = "When it comes to action, variety, and the sheer fun of obliterating Heartless with a Keyblade, coded is a more-than-worthwhile entry in the beloved Kingdom Hearts saga. ",
                    GameId = 30
                },
                new Comment()
                {
                    CommentId = 61,
                    Title = "Cool Game",
                    Body = "For all its intricate plot threads, the game is at its best during these little character moments.",
                    GameId = 31
                },
                new Comment()
                {
                    CommentId = 62,
                    Title = "Awesome Game",
                    Body = "A great continuation to the Kingdom Hearts saga, 358/2 Days offers great customization options, fluid gameplay and awesome visuals, but suffers from recycled material.",
                    GameId = 31
                },
                new Comment()
                {
                    CommentId = 63,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts: Birth By Sleep is a beautiful Square Enix's RPG, which includes the Disney's magic in the style of Final Fantasy.",
                    GameId = 32
                },
                new Comment()
                {
                    CommentId = 64,
                    Title = "Awesome Game",
                    Body = "With its deeply satisfying series of campaigns, solid battle and progression systems, and a worthwhile multiplayer component, you'd be foolish to pass this one up.",
                    GameId = 32
                },
                new Comment()
                {
                    CommentId = 65,
                    Title = "Cool Game",
                    Body = "It's a funny sequel, allthough the all times fans should be asking for something more (or new) from the developers. Despite the lack of innovation, Re: Coded is literallly filled with content, and still worth its price if you love the brand.",
                    GameId = 33
                },
                new Comment()
                {
                    CommentId = 66,
                    Title = "Awesome Game",
                    Body = "Kingdom Hearts: Re:Coded is one of the low points of the franchise's history. The game has some great ideas buried within, but the execution leaves much to be desired.",
                    GameId = 33
                },
                new Comment()
                {
                    CommentId = 67,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts 3D is the pinnacle of the Kingdom Hearts portable formula, unifying everything that the series did right in the format and many new, smart ideas.",
                    GameId = 34
                },
                new Comment()
                {
                    CommentId = 68,
                    Title = "Awesome Game",
                    Body = "Whether or not you're a fan of Nintendo's latest handheld console, if you love Kingdom Hearts, this is a must-have title that's filled with fantastic gameplay, an intriguing story, and beautiful visuals.",
                    GameId = 34
                },
                new Comment()
                {
                    CommentId = 69,
                    Title = "Cool Game",
                    Body = "There is a certain magic present here that a decade has only made stronger. Newcomers and fans alike will find enjoyment in this collection and you won’t able to help smiling at plenty of moments, even if you’ve seen them play out before.",
                    GameId = 35
                },
                new Comment()
                {
                    CommentId = 70,
                    Title = "Awesome Game",
                    Body = "Just like in the first go around, there’s a lot to do in this game.",
                    GameId = 35
                },
                new Comment()
                {
                    CommentId = 71,
                    Title = "Cool Game",
                    Body = "Fun to play!!!",
                    GameId = 36
                },
                new Comment()
                {
                    CommentId = 72,
                    Title = "Awesome Game",
                    Body = "In my top 5 easy",
                    GameId = 36
                },
                new Comment()
                {
                    CommentId = 73,
                    Title = "Cool Game",
                    Body = "Kingdom Hearts II Final Mix and Birth by Sleep improved with new combats and extra content: an unmissable collection for every fan to keep up with the saga.",
                    GameId = 37
                },
                new Comment()
                {
                    CommentId = 74,
                    Title = "Awesome Game",
                    Body = "A great collection, though the lack of any real gameplay in Kingdom Hearts Re: Coded is a weak point.",
                    GameId = 37
                },
                new Comment()
                {
                    CommentId = 75,
                    Title = "Cool Game",
                    Body = "I’ve spent a bit of time with the game since I downloaded it earlier this week, and even though I’m still early on, I’m enjoying every minute of it. Sure, it may not be a main Kingdom Hearts game, but it is definitely something to help satisfy my Kingdom Hearts fix until KH3 comes out.",
                    GameId = 38
                },
                new Comment()
                {
                    CommentId = 76,
                    Title = "Awesome Game",
                    Body = "It certainly doesn’t hold a candle to the console games, but it carries itself surprisingly well as a handheld side story.",
                    GameId = 38
                },
                new Comment()
                {
                    CommentId = 77,
                    Title = "Cool Game",
                    Body = "While it’s not the new Kingdom Hearts game that many may have wanted, it’s much more than just a simple collection of old titles or some cheap cash-in. It’s a bridge to what awaits, and I can’t help but feel excited after watching the credits roll for the umpteenth time.",
                    GameId = 39
                },
                new Comment()
                {
                    CommentId = 78,
                    Title = "Awesome Game",
                    Body = "Kingdom Hearts fans - particularly those who can justify the game's astronomical price point of $60 for about five hours of new content - will definitely enjoy their brief time with Kingdom Hearts HD 2.8 Final Chapter Prologue.",
                    GameId = 39
                },
                new Comment()
                {
                    CommentId = 79,
                    Title = "Cool Game",
                    Body = "The developer has refined and perfected the combat. It kept its silliness in tact. It kept in the darker themes and deep moments of self-reflection that we all need every once in awhile. It’s, quite frankly, the best Kingdom Hearts game Square Enix has ever created.",
                    GameId = 40
                },
                new Comment()
                {
                    CommentId = 80,
                    Title = "Awesome Game",
                    Body = "There is no doubt that Kingdom Hearts III will make long term fans moved or even cry. As for those new to the franchise, I believe they also can be satisfied because of tons of classic Disney elements and solid combat system, even though they could barely understand the main story.",
                    GameId = 40
                },
                new Comment()
                {
                    CommentId = 81,
                    Title = "Cool Game",
                    Body = "Yes, this is the Batman you've been waiting for...It's a wonderful experience, beginning to end, never taking the easy or familiar route, and infusing each shift of the story with original ideas that cut no corners. ",
                    GameId = 41
                },
                new Comment()
                {
                    CommentId = 82,
                    Title = "Awesome Game",
                    Body = "I can’t recommend Arkam Asylum enough.",
                    GameId = 41
                },
                new Comment()
                {
                    CommentId = 83,
                    Title = "Cool Game",
                    Body = "Arkham City should be celebrated as a shining achievement for the action-adventure genre for its masterful execution",
                    GameId = 42
                },
                new Comment()
                {
                    CommentId = 84,
                    Title = "Awesome Game",
                    Body = "If there is one game you buy this year, make it Batman: Arkham City. Few other games released this year will reach this level of polish, variety, story quality, action, scale, and length.",
                    GameId = 42
                },
                new Comment()
                {
                    CommentId = 85,
                    Title = "Cool Game",
                    Body = "The gadgets make for a good change in pace and the boss battles mean Lockdown stands out from being an Infinity Blade clone.",
                    GameId = 43
                },
                new Comment()
                {
                    CommentId = 86,
                    Title = "Awesome Game",
                    Body = "This game looks nothing short of gorgeous, and it really shows off how pretty an iOS game can be.",
                    GameId = 43
                },
                new Comment()
                {
                    CommentId = 87,
                    Title = "Cool Game",
                    Body = "Simply put, Batman: Arkham Origins is the definitive example of a console tie-in game done right",
                    GameId = 44
                },
                new Comment()
                {
                    CommentId = 88,
                    Title = "Awesome Game",
                    Body = "The mobile version of Arkham Origins delivers just enough Bat-action to keep fans happy, but falls short overall due to a restricted fighting system.",
                    GameId = 44
                },
                new Comment()
                {
                    CommentId = 89,
                    Title = "Cool Game",
                    Body = "Yes, most of the game seems like a copy of Arkham City, but that doesn't take away the overall high quality that comes from the lush world, the superb fighting system and the great characters WB Montreal created.",
                    GameId = 45
                },
                new Comment()
                {
                    CommentId = 90,
                    Title = "Awesome Game",
                    Body = "Next to Arkham City, Arkham Origins is a bit of a disappointment in its lack of new ideas and use of win buttons, making it the least interesting of the trilogy.",
                    GameId = 45
                },
                new Comment()
                {
                    CommentId = 91,
                    Title = "Cool Game",
                    Body = "A great release for those who enjoy the Arkham games but haven't played Blackgate for whatever reason.",
                    GameId = 46
                },
                new Comment()
                {
                    CommentId = 92,
                    Title = "Awesome Game",
                    Body = "It feels quite far from the main episodes, but if you looking for a metroidvania game, with good exploring sections and puzzles, this is an interesting choice.",
                    GameId = 46
                });
        }
    }
}
